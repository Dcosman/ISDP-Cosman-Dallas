using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;


namespace ISDP_Cosman_Dallas
{

    //Author: Dallas Cosman
    //Form: Login
    //Desc: The login form is the first form shown to the user. The user can login with a valid username/password,
    // or the user may reset a password as long as they have a valid login. Passwords that are being reset must follow,
    // certain requirements which are displayed on the reset password form. Users are limited to 3 login attempts before
    // being locked, in which case the password will need to be reset.

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        //List for storing employee login attempts
        List<Employee> employeeLogins = new List<Employee>();

        //class level employee to send to dashboard when successful login
        Employee theEmployee;

        //Connection management
        static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(connStr);

        //On form load open connection to database
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "Password1!";
            try
            {
                //conn.Open();
                //RunScript();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Closing form");
                Close();
            }
        }

        //Checks the users login credentials with the records from the database and ensures there is a match.
        //Also, ensures that the account is active and not locked, along with locking accounts with 3 failed login attempts.
        private bool checkLogin(string type)
        {
            bool valid = false;

            if (type.Equals("login"))
            {
                Employee employee = EmployeeAccessor.GetEmployeeByUsername(txtUsername.Text);
                if (employee != null)
                {
                    string decryptSql = "SELECT passwordKey, passwordIV FROM passwordEncrypt WHERE employeeID = @empID";
                    MySqlParameter[] decryptParameters = {
                        new MySqlParameter("@empID", employee.EmployeeID)
                    };

                    MySqlCommand decryptCmd = new MySqlCommand(decryptSql, conn);
                    decryptCmd.Parameters.AddRange(decryptParameters);

                    string empPassword = "";

                    using (MySqlDataReader encryptRead = decryptCmd.ExecuteReader())
                    {
                        if (encryptRead.Read())
                        {
                            string key = encryptRead["passwordKey"].ToString();
                            string IV = encryptRead["passwordIV"].ToString();
                            empPassword = HelperMethods.DecryptPassword(employee.Password, key, IV);
                        }
                    }

                    if (employee.Password.Equals(Constants.DEFAULT_PASSWORD) && txtPassword.Text.Equals(employee.Password))
                    {
                        ShowPasswordReset();
                        grpResetPassword.Visible = true;
                        grpLogin.Visible = false;
                        txtConfirmUsername.Text = employee.Username;
                        txtConfirmUsername.Enabled = false;
                    }

                    //check if account is locked
                    else if (employee.Locked)
                    {
                        MessageBox.Show("This account has been locked, please contact an admin.");

                    }
                    //check if account is inactive
                    else if (!employee.Active)
                    {
                        MessageBox.Show("This is an inactive account, please contact an admin.");
 
                    }
                    //check if login matches a record, if the credentials have a match, exit loop and set valid to true
                    else if (employee.Username.Equals(txtUsername.Text, StringComparison.OrdinalIgnoreCase) && empPassword.Equals(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        theEmployee = employee;

                        valid = true;
                    }
                    //if password is invalid track login attempts
                    else
                    {
                        string updateSql = "UPDATE employee SET loginAttempts = loginAttempts + 1 WHERE employeeID = @empID";
                        MySqlParameter[] updateParameters = {
                                    new MySqlParameter("@empID", employee.EmployeeID)
                                };
                        EmployeeAccessor.AddUpdateEmployee(updateSql, updateParameters);
                        //if 3 login attempts, lock account
                        if (employee.LoginAttempts >= 2)
                        {
                            string lockSql = "UPDATE employee SET locked = 1 WHERE EmployeeID = @empID";
                            MySqlParameter[] lockParameters = {
                                        new MySqlParameter("@empID", employee.EmployeeID)
                                    };
                            EmployeeAccessor.AddUpdateEmployee(lockSql, lockParameters);

                        }
                    }
                }
                else
                    valid = false;
            }

            else if (type.Equals("reset password"))
            {
                Employee employee = EmployeeAccessor.GetEmployeeByUsername(txtConfirmUsername.Text);
                if (employee != null)
                {
                    string empUsername = employee.Username;
                    bool empActive =employee.Active;

                    if (!empActive)
                    {
                        valid = false;
                        MessageBox.Show("The employee username entered is an inactive user, please contact an administrator");
                    }
                    else if (empUsername.Equals(txtConfirmUsername.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        valid = true;
                    }
                }
                else
                    valid = false;
            }

            return valid;
        }

        //method to run bullseye script
        private void RunScript()
        {
            //try catch
            try
            {
                string script = System.IO.File.ReadAllText("Bullseye_DB2024_1.3.sql");
                MySqlCommand cmd = new MySqlCommand(script, conn);
                int num = cmd.ExecuteNonQuery();
                MessageBox.Show(num + " records updated after running the script", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Cannot run script");
            }
        }

        private bool UpdateEmployee(Employee empToUpdate)
        {
            bool success = false;

            string empEncryptedPassword = HelperMethods.EncryptPassword(txtConfirmPassword.Text, empToUpdate.EmployeeID);

            string updateSql = "UPDATE employee SET password = @empEncryptedPassword WHERE EmployeeID = @empID";
            MySqlParameter[] updateParameters = {
                new MySqlParameter("@empEncryptedPassword", empEncryptedPassword),
                new MySqlParameter("@empID", empToUpdate.EmployeeID)
            };
            success = EmployeeAccessor.AddUpdateEmployee(updateSql, updateParameters);

            return success;
        }

        //close connection on form closing
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Closing Connection");
            }
        }

        //on login button click, call checkLogin to validate credentials and show error message if invalid
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = checkLogin("login");
            if (!login)
            {
                lblInvalidLogin.Show();
                txtPassword.Text = "";
                txtPassword.Focus();
            }
            else if (!grpResetPassword.Visible)
            {
                string updateSql = "UPDATE employee SET loginAttempts = 0 WHERE employeeID = @empID";
                MySqlParameter[] updateParameters = {
                    new MySqlParameter("@empID", theEmployee.EmployeeID)
                };
                EmployeeAccessor.AddUpdateEmployee(updateSql, updateParameters);
                frmDashboard dashboard = new frmDashboard();
                ClearInputs();
                dashboard.Tag = theEmployee;
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.Show();

                this.Hide();
            }
        }

        //Clear input fields, called when forgot password window opened/closed.
        private void ClearInputs()
        {
            txtConfirmUsername.Enabled = true;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtConfirmUsername.Text = "";
            txtNewPassword.Text = "";
            lblResetPasswordError.Text = "";
            lblInvalidLogin.Hide();

        }

        private void ShowPasswordReset()
        {
            ClearInputs();
            this.AcceptButton = btnResetPassword;
            this.CancelButton = btnCancelPassword;
            grpResetPassword.Show();
            grpLogin.Hide();
        }

        private void ShowLogin()
        {
            this.AcceptButton = btnLogin;
            this.CancelButton = null;
            ClearInputs();
            grpLogin.Show();
            grpResetPassword.Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the login form again when the dashboard form is closed
            this.Show();
        }

        //on forgot password click, open reset password group box and hide login
        private void txtForgotPassword_Click(object sender, EventArgs e)
        {
            ShowPasswordReset();
        }

        //cancel reset password, hide group box and show login
        private void btnCancelPassword_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        //on reset password click, verify username exists and the password is valid
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            bool login = checkLogin("reset password");
            string msg = "";
            if (login)
            {
                msg = HelperMethods.VerifyNewPassword(txtNewPassword.Text, txtConfirmPassword.Text);
                if (msg.Length < 1)
                {

                    Employee empUpdate = EmployeeAccessor.GetEmployeeByUsername(txtConfirmUsername.Text);
                    string updateSql = "UPDATE employee SET loginAttempts = 0, locked = 0 WHERE employeeID = @empID";
                    MySqlParameter[] updateParameters = {
                        new MySqlParameter("@empID", empUpdate.EmployeeID)
                    };
                    EmployeeAccessor.AddUpdateEmployee(updateSql, updateParameters);
                    if (UpdateEmployee(empUpdate))
                        MessageBox.Show("Password successfully changed.");
                    else
                        MessageBox.Show("Password could not be updated.");

                    ShowLogin();
                }
                else
                {
                    lblResetPasswordError.Text = msg;
                }
            }
            else
                lblResetPasswordError.Text = "The username entered is invalid";
        }

        //open a connection when the form becomes visible, otherwise close the connection.
        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\nClosing Form");
                    this.Close();
                }
            }
            else
            {
                conn.Close();
            }
        }

        //calls show password on show password button click.
        private void picShowPassword_Click(object sender, EventArgs e)
        {
            showPassword(txtPassword);
        }

        //Shows the password corresponding to the textbox it was selected on.
        private void showPassword(TextBox input)
        {
            if (input.UseSystemPasswordChar)
                input.UseSystemPasswordChar = false;
            else
                input.UseSystemPasswordChar = true;
        }

        //calls show password on show password button click.
        private void picShowNewPassword_Click(object sender, EventArgs e)
        {
            showPassword(txtNewPassword);
        }

        //calls show password on show password button click.
        private void picShowConfirmPassword_Click(object sender, EventArgs e)
        {
            showPassword(txtConfirmPassword);
        }

        //On encrypt password button click, encrypt all employee passwords and save to database. (Only for initial laod).
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            HelperMethods.EncryptEmpPasswords();
            MessageBox.Show("Employee Passwords Encrypted.", "Encrypt Success");
        }
    }
}