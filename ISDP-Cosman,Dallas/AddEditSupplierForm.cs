using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace ISDP_Cosman_Dallas
{
    public partial class frmAddEditSupplier : Form
    {
        string formType = "";
        bool submitted = false;

        public frmAddEditSupplier()
        {
            InitializeComponent();
        }

        private void frmAddEditSupplier_Load(object sender, EventArgs e)
        {
            List<Province> provinces = new List<Province>();
            List<String> countries = new List<String>
            {
                "Canada",
                "United States"
            };

            //Get all provinces and populate corresponding dropdownlists.
            try
            {
                provinces = ProvinceAccessor.GetAllProvinces();
                foreach (Province province in provinces)
                {
                    cboSuppProvince.Items.Add(province.ProvinceName);
                }
                foreach (string country in countries)
                {
                    cboSuppCountry.Items.Add(country);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //If the form has a supplier sent, populate fields to be editted.
            if (this.Tag != null)
            {
                this.Text = "Edit Supplier";
                lblAddEditSupplier.Text = "Edit Supplier";
                Supplier editSupp = this.Tag as Supplier;
                Province suppProvince = provinces.FirstOrDefault(Province => Province.ProvinceID == editSupp.Province);
                string suppCountry = countries.FirstOrDefault(Country => Country == editSupp.Country);

                lblAddEditDetails.Text = "Edit " + lblAddEditDetails.Tag.ToString();

                txtSupplierID.Text = editSupp.SupplierID.ToString();

                txtSupplierName.Text = editSupp.Name.ToString();
                txtSupplierName.Tag = editSupp.Name.ToString();

                txtSupplierAdd.Text = editSupp.Address1.ToString();
                txtSupplierAdd.Tag = editSupp.Address1.ToString();

                if (editSupp.Address2 != null)
                {
                    txtSupplierAdd2.Text = editSupp.Address2.ToString();
                    txtSupplierAdd2.Tag = editSupp.Address2.ToString();
                }

                if (editSupp.Notes != null)
                {
                    txtSuppNotes.Text = editSupp.Notes.ToString();
                    txtSuppNotes.Tag = editSupp.Notes.ToString();
                }

                txtSupplierCity.Text = editSupp.City.ToString();
                txtSupplierCity.Tag = editSupp.City.ToString();

                cboSuppProvince.Text = suppProvince.ProvinceName.ToString();
                cboSuppProvince.Tag = suppProvince.ProvinceName.ToString();

                cboSuppCountry.Text = suppCountry.ToString();
                cboSuppCountry.Tag = suppCountry.ToString();

                txtSuppPostal.Text = editSupp.PostalCode.ToString();
                txtSuppPostal.Tag = editSupp.PostalCode.ToString();

                txtSuppContact.Text = editSupp.Contact.ToString();
                txtSuppContact.Tag = editSupp.Contact.ToString();

                txtSuppPhone.Text = editSupp.Phone.ToString();
                txtSuppPhone.Tag = editSupp.Phone.ToString();

                formType = "edit";
            }
            else
            {
                this.Text = "Add New Supplier";
                lblAddEditSupplier.Text = "Add Supplier";
                lblAddEditDetails.Text = "Add " + lblAddEditDetails.Tag.ToString();
                formType = "add";
                txtSupplierID.Text = HelperMethods.GetNewID("select max(supplierID) from supplier").ToString();
            }
        }

        private bool VerifyFields()
        {
            string msg = "Error: ";
            bool success = true;
            List<Control> siteFields = new List<Control> {
                txtSupplierAdd,
                txtSupplierCity,
                txtSupplierName,
                txtSuppPhone,
                txtSuppPostal,
                cboSuppCountry,
                cboSuppProvince,
                txtSuppContact
            };
            List<Label> errLabels = new List<Label> {
                lblErrAddress,
                lblErrCity,
                lblErrName,
                lblErrPhone,
                lblErrPostal,
                lblErrCountry,
                lblErrProvince,
                lblErrContact
            };

            //Loop through controls and check if any are empty
            for (int i = 0; i < siteFields.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(siteFields[i].Text))
                {
                    errLabels[i].Visible = true;
                    msg += $"\n{errLabels[i].Tag?.ToString()}is required.";
                    lblAddEditDetails.Visible = true;
                }
                else
                    errLabels[i].Visible = false;
            }

            //check if phone is valid
            if (!Regex.IsMatch(txtSuppPhone.Text, Constants.PHONE_PATTERN) && !lblErrPhone.Visible)
            {
                msg += "\nPhone number must follow the pattern: 5061234567.";
                lblErrPhone.Visible = true;
            }

            //check if postal code is valid.
            if (!Regex.IsMatch(txtSuppPostal.Text, Constants.POSTAL_PATTERN) && !lblErrPostal.Visible)
            {
                msg += "\nPostal Code must follow the pattern: E1J2E3 or E1J 2E3";
                lblErrPostal.Visible = true;
            }
            //if there is any error messages, show the errors and return false.
            if (!msg.Equals("Error: "))
            {
                MessageBox.Show(msg);
                success = false;
            }

            return success;
        }

        private void btnAddEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!submitted)
            {
                DialogResult result = MessageBox.Show("Are you sure you would like to close the window?\nChanges will not be saved.", "Confirm Close", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnAddEditSave_Click(object sender, EventArgs e)
        {
            if (formType.Equals("edit"))
            {
                if (VerifyFields())
                {
                    txtSuppPostal.Text = txtSuppPostal.Text.Replace(" ", "");
                    string provinceID = ProvinceAccessor.GetProvinceByName(cboSuppProvince.Text).ProvinceID;
                    string updateSql = $@"
                        UPDATE supplier
                        SET
                            Name = @newName,
                            Province = @newProvince,
                            Address1 = @newAddress1,
                            Address2 = @newAddress2,
                            City = @newCity,
                            Country = @newCountry,
                            PostalCode = @newPostalCode,
                            Phone = @newPhone,
                            Contact = @newContact,
                            Notes = @newNotes
                        WHERE
                            SupplierID = @supplierID";

                    List<MySqlParameter> updateParameters = new List<MySqlParameter>
                    {
                        new MySqlParameter("@newName", txtSupplierName.Text),
                        new MySqlParameter("@newProvince", provinceID),
                        new MySqlParameter("@newAddress1", txtSupplierAdd.Text),
                        new MySqlParameter("@newAddress2", txtSupplierAdd2.Text),
                        new MySqlParameter("@newCity", txtSupplierCity.Text),
                        new MySqlParameter("@newCountry", cboSuppCountry.Text),
                        new MySqlParameter("@newPostalCode", txtSuppPostal.Text),
                        new MySqlParameter("@newPhone", txtSuppPhone.Text),
                        new MySqlParameter("@newContact", txtSuppContact.Text),
                        new MySqlParameter("@newNotes", txtSuppNotes.Text),
                        new MySqlParameter("@supplierID", txtSupplierID.Text)
                    };

                    bool success = SupplierAccessor.AddUpdateSupplier(updateSql, updateParameters);

                    if (!success)
                    {
                        MessageBox.Show("Supplier Not Updated", "Update Error");
                    }
                    else
                    {
                        submitted = true;
                        this.Close();
                    }
                }
            }

            //If not in edit mode, insert the new supplier if valid.
            else
            {
                if (VerifyFields())
                {

                    txtSuppPostal.Text = txtSuppPostal.Text.Replace(" ", "");
                    string provinceID = ProvinceAccessor.GetProvinceByName(cboSuppProvince.Text).ProvinceID;
                    string insertSql = @"
                        INSERT INTO supplier (Name, Province, Address1, Address2, City, Country, PostalCode, Phone, Contact, Notes)
                        VALUES (@name, @province, @address1, @address2, @city, @country, @postalCode, @phone, @contact, @notes)";

                    List<MySqlParameter> insertParameters = new List<MySqlParameter>
                    {
                        new MySqlParameter("@name", txtSupplierName.Text),
                        new MySqlParameter("@province", provinceID),
                        new MySqlParameter("@address1", txtSupplierAdd.Text),
                        new MySqlParameter("@address2", txtSupplierAdd2.Text),
                        new MySqlParameter("@city", txtSupplierCity.Text),
                        new MySqlParameter("@country", cboSuppCountry.Text),
                        new MySqlParameter("@postalCode", txtSuppPostal.Text),
                        new MySqlParameter("@phone", txtSuppPhone.Text),
                        new MySqlParameter("@contact", txtSuppContact.Text),
                        new MySqlParameter("@notes", txtSuppNotes.Text)
                    };

                    bool success = SupplierAccessor.AddUpdateSupplier(insertSql, insertParameters);
                    submitted = true;

                    this.Close();
                }

            }
        }
    }
}
