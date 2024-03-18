using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;

namespace ISDP_Cosman_Dallas
{
    //Author: Dallas Cosman
    //Form: Add/Edit Employee
    //Desc: This form is opened when an admit selects add or edit on the employee screen.
    // This form is populated by the Employee that has been sent by the other form if edit was selected.
    // The form checks that all fields have valid entries, and any changes made are not saved unless the user
    // selects SAVE, otherwise the user can cancel to close the form.

    public partial class AddEditEmployeeForm : Form
    {
        string formType;

        public AddEditEmployeeForm()
        {
            InitializeComponent();
        }

        //on form load: populate drop down lists with locations/positions, and populate fields if editting an employee.
        private void AddEditEmployeeForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            List<Site> sites = new List<Site>();
            List<Position> positions = new List<Position>();

            //Get all sites/positions and populate corresponding dropdownlists.
            try
            {
                sites = SiteAccessor.GetAllSites();
                positions = PositionAccessor.GetAllPositions();
                foreach (Position posn in positions)
                {
                    cboEmpPosition.Items.Add(posn.PermissionLevel);
                }
                foreach (Site site in sites)
                {
                    cboEmpLocation.Items.Add(site.Name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //If the form has an employee sent, populate fields to be editted.
            if (this.Tag != null)
            {
                this.Text = "Edit Employee";
                lblAddEditEmp.Text = "Edit Employee";
                Employee editEmp = (Employee)this.Tag;
                Site empSite = sites.FirstOrDefault(Site => Site.SiteID == editEmp.SiteID);
                Position empPosn = positions.FirstOrDefault(posn => posn.PositionID == editEmp.PositionID);
                lblAddEditDetails.Text = "Edit " + lblAddEditDetails.Tag.ToString();

                txtEmpID.Text = editEmp.EmployeeID.ToString();

                txtEmpPassword.Text = editEmp.Password.ToString();
                txtEmpPassword.Tag = editEmp.Password.ToString();

                txtEmpLastName.Text = editEmp.LastName.ToString();
                txtEmpLastName.Tag = editEmp.LastName.ToString();

                txtEmpFirstName.Text = editEmp.FirstName.ToString();
                txtEmpFirstName.Tag = editEmp.FirstName.ToString();

                if (editEmp.Notes != null)
                {
                    txtEmpNotes.Text = editEmp.Notes.ToString();
                    txtEmpNotes.Tag = editEmp.Notes.ToString();
                }

                chkEmpActive.Checked = editEmp.Active;
                chkEmpActive.Tag = editEmp.Active;

                chkEmpLocked.Checked = editEmp.Locked;
                chkEmpLocked.Tag = editEmp.Locked;

                cboEmpLocation.Text = empSite.Name;
                cboEmpLocation.Tag = empSite.Name.ToString();

                cboEmpPosition.Text = empPosn.PermissionLevel;
                cboEmpPosition.Tag = empPosn.PermissionLevel.ToString();

                txtEmpUsername.Text = editEmp.Username.ToString();
                txtEmpUsername.Tag = editEmp.Username.ToString();

                txtEmpEmail.Text = editEmp.Email.ToString();
                txtEmpEmail.Tag = editEmp.Email.ToString();

                lblResetEmp.Visible = true;

                formType = "edit";
            }

            //If there was no employee sent to the form, change details accordingly.
            else
            {
                this.Text = "Add New Employee";
                lblAddEditEmp.Text = "Add Employee";
                lblAddEditDetails.Text = "Add " + lblAddEditDetails.Tag.ToString();
                formType = "add";
                txtEmpUsername.Enabled = false;
                txtEmpUsername.PlaceholderText = "Username Auto Generated";
                txtEmpEmail.Enabled = false;
                txtEmpEmail.PlaceholderText = "Email Auto Generated";
                chkEmpActive.Checked = true;
                txtEmpID.Text = HelperMethods.GetNewID("select max(employeeID) from employee").ToString();
                txtEmpPassword.Text = "P@ssw0rd-";
                chkEmpLocked.Visible = false;
            }
        }

        //On cancel button click: close form.
        private void btnAddEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //On button save click: Verify fields are valid, and if so commit changes to the database.
        private void btnAddEditSave_Click(object sender, EventArgs e)
        {
            //Check if form is in edit mode.
            if (formType.Equals("edit"))
            {
                if (VerifyEmpFields())
                {
                    if (!CheckUsername().Equals(""))
                    {
                        string newName = CheckUsername();
                        DialogResult result = ReviewEmployee(newName, newName + "@bullseye.ca");
                        if (result == DialogResult.Yes)
                        {

                            int posnID = PositionAccessor.GetPositionByName(cboEmpPosition.Text).PositionID;
                            int siteID = SiteAccessor.GetSiteByName(cboEmpLocation.Text).SiteID;
                            string updateSql = $@"
                                UPDATE employee
                                SET
                                    Username = @newName,
                                    Email = @newEmail,
                                    LastName = @lastName,
                                    FirstName = @firstName,
                                    Notes = @notes,
                                    Active = @active,
                                    SiteID = @siteID,
                                    PositionID = @positionID,
                                    Locked = @locked";

                            List<MySqlParameter> updateParameters = new List<MySqlParameter>
                            {
                                new MySqlParameter("@newName", newName),
                                new MySqlParameter("@newEmail", newName + "@bullseye.ca"),
                                new MySqlParameter("@lastName", txtEmpLastName.Text),
                                new MySqlParameter("@firstName", txtEmpFirstName.Text),
                                new MySqlParameter("@notes", txtEmpNotes.Text),
                                new MySqlParameter("@active", chkEmpActive.Checked),
                                new MySqlParameter("@siteID", siteID),
                                new MySqlParameter("@positionID", posnID),
                                new MySqlParameter("@locked", chkEmpLocked.Checked)
                            };

                            //Check if locked and set loginAttempts to 0 if not.
                            if (!chkEmpLocked.Checked)
                            {
                                updateSql += ", LoginAttempts = @loginAttempts";
                                updateParameters.Add(new MySqlParameter("@loginAttempts", MySqlDbType.Int32) { Value = 0 });
                            }

                            //Check if password is unchanged
                            if (!txtEmpPassword.Text.Equals(txtEmpPassword.Tag))
                            {
                                string password = HelperMethods.EncryptPassword(txtEmpPassword.Text, int.Parse(txtEmpID.Text));
                                updateSql += ", Password = @password";
                                updateParameters.Add(new MySqlParameter("@password", password));
                            }

                            updateSql += " WHERE EmployeeID = @empID";
                            updateParameters.Add(new MySqlParameter("@empID", txtEmpID.Text));

                            bool success = EmployeeAccessor.AddUpdateEmployee(updateSql, updateParameters);

                            if (!success)
                            {
                                MessageBox.Show("Employee Not Updated", "Update Error");
                            }
                            else
                            {
                                this.Close();
                            }

                        }

                    }
                }
            }

            //If not in edit mode, insert the new employee if valid.
            else
            {
                if (VerifyEmpFields())
                {
                    string newUsername = CheckUsername();
                    if (!newUsername.Equals(""))
                    {
                        string empEmail = newUsername + "@bullseye.ca";

                        DialogResult result = ReviewEmployee(newUsername, empEmail);
                        if (result == DialogResult.Yes)
                        {
                            List<Site> sites = SiteAccessor.GetAllSites();
                            int siteID = sites.FirstOrDefault(site => site.Name == cboEmpLocation.Text).SiteID;
                            List<Position> positions = PositionAccessor.GetAllPositions();
                            int posnID = positions.FirstOrDefault(posn => posn.PermissionLevel == cboEmpPosition.Text).PositionID;
                            string insertSql = "INSERT INTO employee (Password, FirstName, LastName, Email, active, PositionID, siteID, locked, username, notes) " +
                                               "VALUES (@password, @firstName, @lastName, @email, @active, @positionID, @siteID, @locked, @username, @notes)";

                            MySqlParameter[] insertParameters = {
                                new MySqlParameter("@password", txtEmpPassword.Text),
                                new MySqlParameter("@firstName", txtEmpFirstName.Text),
                                new MySqlParameter("@lastName", txtEmpLastName.Text),
                                new MySqlParameter("@email", empEmail),
                                new MySqlParameter("@active", chkEmpActive.Checked),
                                new MySqlParameter("@positionID", posnID),
                                new MySqlParameter("@siteID", siteID),
                                new MySqlParameter("@locked", false),
                                new MySqlParameter("@username", newUsername),
                                new MySqlParameter("@notes", txtEmpNotes.Text)
                            };

                            EmployeeAccessor.AddUpdateEmployee(insertSql, insertParameters);
                            if(!txtEmpPassword.Text.Equals(Constants.DEFAULT_PASSWORD))
                                HelperMethods.EncryptPassword(txtEmpPassword.Text, int.Parse(txtEmpID.Text));
                            this.Close();
                        }
                    }

                }
            }
        }

        //Check the username and verify that it doesnt exist in the database, if it does
        // exist then add an 01, if that exists then 02, etc.
        private string CheckUsername()
        {
            int usernameNum = 1;
            string newUsername = txtEmpUsername.Text;
            bool nameCheck = false;
            while (EmployeeAccessor.GetEmployeeByUsername(newUsername) != null)
            {
                if (EmployeeAccessor.GetEmployeeByUsername(newUsername).EmployeeID == int.Parse(txtEmpID.Text))
                {
                    nameCheck = true;
                    break;
                }
                else
                {
                    newUsername = txtEmpUsername.Text + "0" + usernameNum.ToString();
                    usernameNum++;
                }
            }
            DialogResult result = DialogResult.Yes;
            if (usernameNum > 1 && !nameCheck)
            {
                result = MessageBox.Show("Username: " + txtEmpUsername.Text + " already exists, username will be saved as " + newUsername,
                    "Confirm Username", MessageBoxButtons.YesNo);
            }
            if (result == DialogResult.Yes)
                return newUsername;
            else
                return "";
        }

        //Display the employee details for the user to confirm before committing to the database.
        private DialogResult ReviewEmployee(string newUsername, string empEmail)
        {
            DialogResult result =
                MessageBox.Show($"Please review and confirm employee details:\n" +
                            $"EmployeeID: {txtEmpID.Text}\n" +
                            $"Username: {newUsername}\n" +
                            $"First Name: {txtEmpFirstName.Text}\n" +
                            $"Last Name: {txtEmpLastName.Text}\n" +
                            $"Email: {empEmail}\n" +
                            $"Position: {cboEmpPosition.Text}\n" +
                            $"Location: {cboEmpLocation.Text}\n" +
                            $"Notes: {txtEmpNotes.Text}\n" +
                            $"Active: {chkEmpActive.Checked}\n" +
                            $"{(chkEmpLocked.Visible ? "Locked: " + chkEmpLocked.Checked : "")}",
                            "Confirm Add Employee", MessageBoxButtons.YesNo);

            return result;
        }

        //Verifies the fields on the form to ensure they all follow the requirements. Return false if not.
        private bool VerifyEmpFields()
        {
            string msg = "Error: ";
            bool success = true;
            List<Control> empFields = new List<Control> {
                txtEmpID,
                txtEmpUsername,
                txtEmpPassword,
                txtEmpFirstName,
                txtEmpLastName,
                txtEmpEmail,
                cboEmpPosition,
                cboEmpLocation
            };
            List<Label> errLabels = new List<Label> {
                lblErrID,
                lblErrUsername,
                lblErrPassword,
                lblErrFirstName,
                lblErrLastName,
                lblErrEmail,
                lblErrPosn,
                lblErrLocation
            };

            //Loop through controls and check if any are empty (other than notes)
            for (int i = 0; i < empFields.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(empFields[i].Text))
                {
                    errLabels[i].Visible = true;
                    msg += $"\n{errLabels[i].Tag?.ToString()}is required.";
                    lblAddEditDetails.Visible = true;
                }
                else
                    errLabels[i].Visible = false;
            }

            if (lblErrPassword.Visible)
            {
                tipError.SetToolTip(lblErrPassword, "Password is Required");
            }

            string passwordMsg = HelperMethods.VerifyNewPassword(txtEmpPassword.Text, txtEmpPassword.Text);

            //check if password is not empty, but also verify it meets the requirements. Show error message if not valid.
            if (passwordMsg.Length > 1 && !lblErrPassword.Visible && (txtEmpPassword.Text != (string)txtEmpPassword.Tag))
            {
                msg += "\nPasswords must contain at least:\r\n - 8 characters\r\n - 1 special character (!@#$%^&*)\r\n - 1 upper case letter\r\n - 1 number";
                lblErrPassword.Visible = true;
                tipError.SetToolTip(lblErrPassword, passwordMsg);
            }
            //check if username valid.
            if (!txtEmpUsername.Text.StartsWith(GenerateUsername()) && !lblErrUsername.Visible)
            {
                msg += "\nUsername must follow the pattern: First initial, and lastname.";
                lblErrUsername.Visible = true;
            }
            //check if email valid.
            if (txtEmpEmail.Text != (txtEmpUsername.Text + "@bullseye.ca") && !lblErrEmail.Visible)
            {
                msg += "\nEmail must follow the pattern: username@bullseye.ca";
                lblErrEmail.Visible = true;
            }
            //if there is any error messages, show the errors and return false.
            if (!msg.Equals("Error: "))
            {
                MessageBox.Show(msg);
                success = false;
            }

            return success;
        }

        //Generates the username in the format first name initial and last name.
        private string GenerateUsername()
        {
            string username = "";
            if (txtEmpFirstName.Text.Length > 0)
            {
                username = $"{txtEmpFirstName.Text[0].ToString().ToLower()}{txtEmpLastName.Text.ToLower()}";
            }
            return username;
        }

        //When first name text changed generate username/email.
        private void txtEmpFirstName_TextChanged(object sender, EventArgs e)
        {

            if (txtEmpLastName.Text.Length > 0 && txtEmpFirstName.Text.Length > 0)
            {
                txtEmpUsername.Text = GenerateUsername();
                txtEmpEmail.Text = $"{GenerateUsername()}@bullseye.ca";
            }
            else
            {
                txtEmpUsername.Text = "";
                txtEmpEmail.Text = "";
            }

        }

        //When last name text changed generate username/email.
        private void txtEmpLastName_TextChanged(object sender, EventArgs e)
        {

            if (txtEmpLastName.Text.Length > 0 && txtEmpFirstName.Text.Length > 0)
            {
                txtEmpUsername.Text = GenerateUsername();
                txtEmpEmail.Text = $"{GenerateUsername()}@bullseye.ca";
            }
            else
            {
                txtEmpUsername.Text = "";
                txtEmpEmail.Text = "";
            }
        }

        //Show the password on click.
        private void picShowPassword_Click(object sender, EventArgs e)
        {
            if (txtEmpPassword.UseSystemPasswordChar)
                txtEmpPassword.UseSystemPasswordChar = false;
            else
                txtEmpPassword.UseSystemPasswordChar = true;

        }

        //Resets all of the employees fields back to what it was when the form was opened (only while editting).
        private void lblResetEmp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmpUsername.Text = txtEmpUsername.Tag.ToString();

            txtEmpPassword.Text = txtEmpPassword.Tag.ToString();

            txtEmpEmail.Text = txtEmpEmail.Tag.ToString();

            txtEmpLastName.Text = txtEmpLastName.Tag.ToString();

            txtEmpFirstName.Text = txtEmpFirstName.Tag.ToString();

            if (txtEmpNotes.Tag != null)
                txtEmpNotes.Text = txtEmpNotes.Tag.ToString();

            chkEmpActive.Checked = (bool)chkEmpActive.Tag;

            chkEmpLocked.Checked = (bool)chkEmpLocked.Tag;

            cboEmpLocation.Text = cboEmpLocation.Tag.ToString();

            cboEmpPosition.Text = cboEmpPosition.Tag.ToString();
        }

        //Check if F1 pressed, then open help.
        private void AddEditEmployeeForm_KeyDown(object sender, KeyEventArgs e)
        {
            HelpMenus.ShowHelp("AddEditEmployee", e);
        }

        //If help icon clicked, open help.
        private void picHelp_Click(object sender, EventArgs e)
        {
            HelpMenus.ShowHelp("AddEditEmployee");
        }
    }
}
