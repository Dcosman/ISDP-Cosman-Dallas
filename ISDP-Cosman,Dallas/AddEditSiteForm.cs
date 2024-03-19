using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace ISDP_Cosman_Dallas
{
    public partial class AddEditSiteForm : Form
    {
        string formType;

        public AddEditSiteForm()
        {
            InitializeComponent();
        }

        private void AddEditSiteForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

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
                    cboSiteProvince.Items.Add(province.ProvinceName);
                }
                foreach (string country in countries)
                {
                    cboSiteCountry.Items.Add(country);
                }
                foreach (string day in Constants.DAYSOFWEEK)
                {
                    cboSiteDay.Items.Add(day);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //If the form has a location sent, populate fields to be editted.
            if (this.Tag != null)
            {
                this.Text = "Edit Location";
                lblAddEditSite.Text = "Edit Location";
                Site editSite = (Site)this.Tag;
                Province siteProvince = provinces.FirstOrDefault(Province => Province.ProvinceID == editSite.ProvinceID);
                string siteCountry = countries.FirstOrDefault(Country => Country == editSite.Country);
                string siteDay = Constants.DAYSOFWEEK.FirstOrDefault(Day => Day == editSite.DayOfWeek);
                lblAddEditDetails.Text = "Edit " + lblAddEditDetails.Tag.ToString();

                txtSiteID.Text = editSite.SiteID.ToString();

                txtSiteName.Text = editSite.Name.ToString();
                txtSiteName.Tag = editSite.Name.ToString();

                txtSiteAdd.Text = editSite.Address.ToString();
                txtSiteAdd.Tag = editSite.Address.ToString();

                if (editSite.Address2 != null)
                {
                    txtSiteAdd2.Text = editSite.Address2.ToString();
                    txtSiteAdd2.Tag = editSite.Address2.ToString();
                }

                if (editSite.Notes != null)
                {
                    txtSiteNotes.Text = editSite.Notes.ToString();
                    txtSiteNotes.Tag = editSite.Notes.ToString();
                }

                txtSiteCity.Text = editSite.City.ToString();
                txtSiteCity.Text = editSite.City.ToString();

                cboSiteProvince.Text = siteProvince.ProvinceName.ToString();
                cboSiteProvince.Tag = siteProvince.ProvinceName.ToString();

                cboSiteCountry.Text = siteCountry.ToString();
                cboSiteCountry.Tag = siteCountry.ToString();

                txtSitePostal.Text = editSite.PostalCode.ToString();
                txtSitePostal.Tag = editSite.PostalCode.ToString();

                txtSiteDistance.Text = editSite.DistanceFromWH.ToString();
                txtSiteDistance.Tag = editSite.DistanceFromWH.ToString();

                cboSiteDay.Text = siteDay.ToString();
                cboSiteDay.Tag = siteDay.ToString();

                txtSitePhone.Text = editSite.Phone.ToString();
                txtSitePhone.Tag = editSite.Phone.ToString();

                lblResetSite.Visible = true;

                formType = "edit";
            }

            //If there was no location sent to the form, change details accordingly.
            else
            {
                this.Text = "Add New Location";
                lblAddEditSite.Text = "Add Location";
                lblAddEditDetails.Text = "Add " + lblAddEditDetails.Tag.ToString();
                formType = "add";
                txtSiteID.Text = HelperMethods.GetNewID("select max(siteID) from site").ToString();
            }
        }

        private void btnAddEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DialogResult ReviewSite()
        {
            DialogResult result =
                MessageBox.Show($"Please review and confirm location details:\n" +
                            $"Site ID: {txtSiteID.Text}\n" +
                            $"Location: {txtSiteName.Text}\n" +
                            $"Address: {txtSiteAdd.Text}\n" +
                            $"Address 2: {txtSiteAdd2.Text}\n" +
                            $"City: {txtSiteCity.Text}\n" +
                            $"Country: {cboSiteCountry.Text}\n" +
                            $"Province: {cboSiteProvince.Text}\n" +
                            $"Postal Code: {txtSitePostal.Text}\n" +
                            $"Phone Number: {txtSitePhone.Text}\n" +
                            $"Distance: {txtSiteDistance.Text}\n" +
                            $"Delivery Day: {cboSiteDay.Text}\n",
                            $"Notes: {txtSiteNotes.Text}\n" +
                            "Confirm Add Employee", MessageBoxButtons.YesNo);

            return result;
        }

        private void btnAddEditSave_Click(object sender, EventArgs e)
        {
            if (formType.Equals("edit"))
            {
                if (VerifySiteFields())
                {
                    DialogResult result = ReviewSite();
                    if (result == DialogResult.Yes)
                    {
                        txtSitePostal.Text = txtSitePostal.Text.Replace(" ", "");
                        string provinceID = ProvinceAccessor.GetProvinceByName(cboSiteProvince.Text).ProvinceID;
                        string updateSql = $@"
                            UPDATE site
                            SET
                                Name = @newName,
                                ProvinceID = @newProvinceID,
                                Address = @newAddress,
                                Address2 = @newAddress2,
                                City = @newCity,
                                Country = @newCountry,
                                PostalCode = @newPostalCode,
                                Phone = @newPhone,
                                DayOfWeek = @newDayOfWeek,
                                DistanceFromWH = @newDistanceFromWH,
                                Notes = @newNotes
                            WHERE
                                SiteID = @siteID";
                        List<MySqlParameter> updateParameters = new List<MySqlParameter>
                        {
                            new MySqlParameter("@newName", txtSiteName.Text),
                            new MySqlParameter("@newProvinceID", provinceID),
                            new MySqlParameter("@newAddress", txtSiteAdd.Text),
                            new MySqlParameter("@newAddress2", txtSiteAdd2.Text),
                            new MySqlParameter("@newCity", txtSiteCity.Text),
                            new MySqlParameter("@newCountry", cboSiteCountry.Text),
                            new MySqlParameter("@newPostalCode", txtSitePostal.Text),
                            new MySqlParameter("@newPhone", txtSitePhone.Text),
                            new MySqlParameter("@newDayOfWeek", cboSiteDay.Text),
                            new MySqlParameter("@newDistanceFromWH", txtSiteDistance.Text),
                            new MySqlParameter("@newNotes", txtSiteNotes.Text),
                            new MySqlParameter("@siteID", txtSiteID.Text)
                        };

                        bool success = SiteAccessor.AddUpdateSite(updateSql, updateParameters);

                        if (!success)
                        {
                            MessageBox.Show("Location Not Updated", "Update Error");
                        }
                        else
                        {
                            this.Close();
                        }

                    }

                }
            }

            //If not in edit mode, insert the new location if valid.
            else
            {
                if (VerifySiteFields())
                {
                    DialogResult result = ReviewSite();
                    if (result == DialogResult.Yes)
                    {
                        txtSitePostal.Text = txtSitePostal.Text.Replace(" ", "");
                        string provinceID = ProvinceAccessor.GetProvinceByName(cboSiteProvince.Text).ProvinceID;
                        string insertSql = @"
                            INSERT INTO site (Name, ProvinceID, Address, Address2, City, Country, PostalCode, Phone, DayOfWeek, DistanceFromWH, Notes)
                            VALUES (@name, @provinceID, @address, @address2, @city, @country, @postalCode, @phone, @dayOfWeek, @distanceFromWH, @notes)";

                        List<MySqlParameter> insertParameters = new List<MySqlParameter>
                        {
                            new MySqlParameter("@name", txtSiteName.Text),
                            new MySqlParameter("@provinceID", provinceID),
                            new MySqlParameter("@address", txtSiteAdd.Text),
                            new MySqlParameter("@address2", txtSiteAdd2.Text),
                            new MySqlParameter("@city", txtSiteCity.Text),
                            new MySqlParameter("@country", cboSiteCountry.Text),
                            new MySqlParameter("@postalCode", txtSitePostal.Text),
                            new MySqlParameter("@phone", txtSitePhone.Text),
                            new MySqlParameter("@dayOfWeek", cboSiteDay.Text),
                            new MySqlParameter("@distanceFromWH", txtSiteDistance.Text),
                            new MySqlParameter("@notes", txtSiteNotes.Text)
                        };


                        SiteAccessor.AddUpdateSite(insertSql, insertParameters);
                        this.Close();
                    }
                }
            }
        }

        private bool VerifySiteFields()
        {
            string msg = "Error: ";
            bool success = true;
            List<Control> siteFields = new List<Control> {
                txtSiteID,
                txtSiteAdd,
                txtSiteCity,
                txtSiteDistance,
                txtSiteName,
                txtSitePhone,
                txtSitePostal,
                cboSiteCountry,
                cboSiteDay,
                cboSiteProvince
            };
            List<Label> errLabels = new List<Label> {
                lblErrSiteID,
                lblErrAddress,
                lblErrCity,
                lblErrDistance,
                lblErrSite,
                lblErrPhone,
                lblErrPostal,
                lblErrCountry,
                lblErrDay,
                lblErrProvince
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
            if (!Regex.IsMatch(txtSitePhone.Text, Constants.PHONE_PATTERN) && !lblErrPhone.Visible)
            {
                msg += "\nPhone number must follow the pattern: 5061234567.";
                lblErrPhone.Visible = true;
            }

            //check if postal code is valid.
            if (!Regex.IsMatch(txtSitePostal.Text, Constants.POSTAL_PATTERN) && !lblErrPostal.Visible)
            {
                msg += "\nPostal Code must follow the pattern: E1J2E3 or E1J 2E3";
                lblErrPostal.Visible = true;
            }
            //check if distance is valid.
            if (!int.TryParse(txtSiteDistance.Text, out _) && !lblErrDistance.Visible)
            {
                msg += "\nDistance must be a non decimal number";
                lblErrDistance.Visible = true;
            }
            //if there is any error messages, show the errors and return false.
            if (!msg.Equals("Error: "))
            {
                MessageBox.Show(msg);
                success = false;
            }

            return success;
        }
    }
}
