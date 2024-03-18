using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ISDP_Cosman_Dallas
{

    //Author: Dallas Cosman
    //Form: Dashboard
    //Description: This form is the main form for the program, it has tabs and controls that are relevant to each users position.
    // Any datagridview within the dashboard will not be populated/refreshed unless the refresh button is clicked.
    // Users can log out by either selecting the X button, or by selecting the logout button.
    // Users can get help on any screen by selecting the ? icon or by pressing F1.

    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Timer logoutTimer;
        private const double timerMins = 10;
        private bool autoLogout = false;

        private int txnID;

        //initial load boolean to check if page is being loaded
        bool initialLoad = true;
        //class level employee
        Employee theEmployee;
        //Position empPosn;
        Site empSite;

        //Connection management
        static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(connStr);

        //Form Closed: Ensure any connection is closed.
        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void ShowLogoutMessage(object sender, EventArgs e)
        {
            MessageBox.Show("You have been automatically logged out due to inactivity.");
            autoLogout = true;
            logoutTimer.Stop();
            this.Close();
        }

        //Methods below for detecting activity
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            ResetLogoutTimer();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            ResetLogoutTimer();
        }

        private void ResetLogoutTimer()
        {
            // Reset the timer when there's user activity
            logoutTimer.Stop();
            logoutTimer.Start();
        }

        //Form Load: Get the employee information that has logged in and display the employees username/location. 
        // Also, check the employees permission using CheckPermission to show relevant tabs/controls.
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            logoutTimer = new System.Windows.Forms.Timer();
            logoutTimer.Interval = (int)(timerMins * 60 * 1000);
            logoutTimer.Tick += ShowLogoutMessage;

            // Start the timer
            logoutTimer.Start();

            this.KeyPreview = true;
            int tabCount = tbcMainScreen.TabCount;

            for (int i = 0; i < tabCount; i++)
            {
                tbcMainScreen.TabPages.RemoveAt(0);
            }

            AdjustTabSize();

            theEmployee = this.Tag as Employee;
            Site empSite = SiteAccessor.GetSiteByID(theEmployee.SiteID);
            lblEmpUsername.Text += theEmployee.Username;
            lblEmpLocation.Text += empSite.Name + $" ({empSite.City})";

            CheckPermission();

            tbcMainScreen.SelectedIndex = -1;
            initialLoad = false;
        }

        //Name: CheckPermission
        //Desc: Checks the class level employees permission and calls a relevant message to show the proper tabs/controls.
        private void CheckPermission()
        {
            switch (theEmployee.PositionID)
            {
                case Constants.REGIONAL_MANAGER:
                    DisplayRegionalManager();
                    break;

                case Constants.FINANCIAL_MANAGER:
                    DisplayFinancialManager();
                    break;

                case Constants.STORE_MANAGER:
                    DisplayStoreManager();
                    break;

                case Constants.WAREHOUSE_MANAGER:
                    DisplayWarehouseManager();
                    break;

                case Constants.TRUCKING_DELIVERY:
                    DisplayTruckingDelivery();
                    break;

                case Constants.WAREHOUSE_EMPLOYEE:
                    DisplayWarehouseEmployee();
                    break;

                case Constants.ADMIN:
                    DisplayAdmin();
                    break;

                default:
                    MessageBox.Show("Employee Position does not exist, please contact an admin");
                    break;
            }
        }

        private void DisplayAdmin()
        {
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmployees);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabLocations);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabInventory);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabSuppliers);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabPOSLink);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabReports);
        }

        private void DisplayStoreManager()
        {
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabReports);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabLocations);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabStoreOrder);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmergencyOrder);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabInventory);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabLossReturn);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmployees);
        }

        private void DisplayWarehouseManager()
        {
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabSupplierOrder);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabLocations);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmergencyOrder);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabStoreOrder);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabInventory);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabReports);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabLossReturn);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabItems);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmployees);
        }

        private void DisplayFinancialManager()
        {
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabReports);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmployees);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabLocations);
        }

        private void DisplayRegionalManager()
        {
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmployees);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabLocations);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabInventory);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabSuppliers);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabPOSLink);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabReports);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmployees);
        }

        private void DisplayTruckingDelivery()
        {
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabStoreOrder);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabShipReceipts);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabDelivery);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmployees);
        }

        private void DisplayWarehouseEmployee()
        {
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabStoreOrder);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabInventory);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabSupplierOrder);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabReports);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabEmployees);
            tbcMainScreen.TabPages.Insert(tbcMainScreen.TabCount, tabLocations);

        }

        //Form size change: adjust tabcontrol size.
        private void frmDashboard_SizeChanged(object sender, EventArgs e)
        {
            AdjustTabSize();
        }

        private void AdjustTabSize()
        {
            // Calculate the new width/height
            int newWidth = (int)(this.ClientSize.Width * 0.9);
            int newHeight = (int)(this.ClientSize.Height * 0.85);
            // Set the size of the TabControl
            tbcMainScreen.Size = new System.Drawing.Size(newWidth, newHeight);
        }

        //Logout button click, close form.
        private void picLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ask user to confirm logout, cancel form close if canceled.
        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!autoLogout)
            {
                DialogResult result = MessageBox.Show("You are about to logout. Continue?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        //On tab index change: set the refresh button to target the new tab.
        private void tbcMainScreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initialLoad)
            {
                picRefresh.Tag = tbcMainScreen.SelectedTab.Text;
                if (theEmployee.PositionID != Constants.ADMIN)
                {
                    HideAdminControls();
                }
                if (tbcMainScreen.SelectedTab.Text.Equals("Store Orders"))
                {
                    HideOrderButtons();
                    if (theEmployee.PositionID == Constants.STORE_MANAGER)
                    {
                        btnCreateOrder.Visible = true;
                        btnEditOrder.Visible = true;
                        btnSubmitOrder.Visible = true;
                        btnAcceptOrder.Visible = true;
                    }
                    else if (theEmployee.PositionID == Constants.WAREHOUSE_MANAGER)
                    {
                        btnRecieveOrder.Visible = true;
                        btnFulfillOrder.Visible = true;
                        btnEditBackOrder.Visible = true;
                        btnCreateBackOrder.Visible = true;
                    }
                    else if (theEmployee.PositionID == Constants.WAREHOUSE_EMPLOYEE)
                    {
                        btnFulfillOrder.Visible = true;
                    }
                }
            }
        }

        //Hide admin controls, called when employee is not an admin.
        private void HideAdminControls()
        {
            btnEditEmp.Hide();
            btnDeleteEmp.Hide();
            btnAddEmp.Hide();
            btnAddSite.Hide();
            btnEditSite.Hide();
        }

        //On refresh click: Check the current tab selected and populate the corresponding datagridview within the tab.
        private void picRefresh_Click(object sender, EventArgs e)
        {
            if (picRefresh.Tag.ToString().Equals("Employees"))
            {
                List<Employee> employess = EmployeeAccessor.GetAllEmployees();
                dgvEmployees.DataSource = employess;

                List<Site> sites = new List<Site>();
                List<Position> positions = new List<Position>();

                cboSearchEmpLocations.Items.Clear();
                cboSearchEmpPosition.Items.Clear();

                cboSearchEmpLocations.Items.Add("All Locations");
                cboSearchEmpPosition.Items.Add("All Positions");

                cboSearchEmpPosition.SelectedIndex = 0;
                cboSearchEmpLocations.SelectedIndex = 0;

                sites = SiteAccessor.GetAllSites();
                positions = PositionAccessor.GetAllPositions();
                foreach (Position posn in positions)
                {
                    cboSearchEmpPosition.Items.Add(posn.PermissionLevel);
                }
                foreach (Site site in sites)
                {
                    cboSearchEmpLocations.Items.Add(site.Name);
                }

            }

            else if (picRefresh.Tag.ToString().Equals("Locations"))
            {
                List<Site> sites = SiteAccessor.GetAllSites();
                dgvSites.DataSource = sites;

                List<Province> provinces = new List<Province>();

                cboFilterSiteDay.Items.Clear();
                cboFilterSiteProvince.Items.Clear();

                cboFilterSiteDay.Items.Add("All Days");
                cboFilterSiteProvince.Items.Add("All Provinces");

                cboFilterSiteDay.SelectedIndex = 0;
                cboFilterSiteProvince.SelectedIndex = 0;

                provinces = ProvinceAccessor.GetAllProvinces();
                foreach (Province prov in provinces)
                {
                    cboFilterSiteProvince.Items.Add(prov.ProvinceName);
                }
                foreach (String day in Constants.DAYSOFWEEK)
                {
                    cboFilterSiteDay.Items.Add(day);
                }
            }

            else if (picRefresh.Tag.ToString().Equals("Items") && dgvItems.Enabled)
            {
                List<Item> items = ItemAccessor.GetAllItems();
                dgvItems.DataSource = items;
                foreach (DataGridViewColumn column in dgvItems.Columns)
                {
                    column.Visible = false;
                }
                dgvItems.Columns["ItemID"].Visible = true;
                dgvItems.Columns["Active"].Visible = true;
                dgvItems.Columns["Name"].Visible = true;
                dgvItems.Columns["Active"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvItems.Columns["ItemID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            else if (picRefresh.Tag.ToString().Equals("Store Orders") && tbcMainScreen.Visible)
            {
                cboFilterStatus.Items.Clear();
                cboFilterLocation.Items.Clear();

                cboFilterStatus.Items.Add("All Statuses");
                cboFilterLocation.Items.Add("All Locations");

                cboFilterStatus.SelectedIndex = 0;
                cboFilterLocation.SelectedIndex = 0;

                List<TransactionStatus> statuses = TransactionStatusAccessor.GetAllTransactionStatus();
                List<Site> sites = SiteAccessor.GetAllSites();

                foreach (TransactionStatus status in statuses)
                {
                    cboFilterStatus.Items.Add(status.StatusName);
                }
                foreach (Site site in sites)
                {
                    cboFilterLocation.Items.Add(site.Name);
                }

                if (theEmployee.PositionID != Constants.WAREHOUSE_MANAGER && theEmployee.PositionID != Constants.WAREHOUSE_EMPLOYEE)
                {
                    cboFilterLocation.SelectedIndex = cboFilterLocation.Items.IndexOf(SiteAccessor.GetSiteByID(theEmployee.SiteID).Name);
                    dgvStoreOrders.DataSource = GetStoreOrders("SELECT * FROM txn WHERE Status != 'Cancelled' and siteIDTo = @siteID and txnType in ('Store Order', 'Emergency', 'Back Order')");
                }
                else
                {
                    cboFilterLocation.SelectedIndex = cboFilterLocation.Items.IndexOf("All Locations");
                    dgvStoreOrders.DataSource = GetStoreOrders("SELECT * FROM txn WHERE Status != 'Cancelled' and txnType in ('Store Order', 'Emergency', 'Back Order')");
                }
            }
            else if (!tbcMainScreen.Visible)
            {
                dgvAcceptOrder.DataSource = TransactionItemsAccessor.GetTransactionItemsById(txnID);
            }
            else if (picRefresh.Tag.ToString().Equals("Inventory"))
            {
                dgvInventory.DataSource = InventoryAccessor.GetInventoryBySiteID(theEmployee.SiteID);

            }
        }

        private void HideOrderButtons()
        {
            btnCreateOrder.Visible = false;
            btnEditOrder.Visible = false;
            btnRecieveOrder.Visible = false;
            btnSubmitOrder.Visible = false;
            btnFulfillOrder.Visible = false;
            btnEditBackOrder.Visible = false;
            btnCreateBackOrder.Visible = false;
            btnAcceptOrder.Visible = false;
        }

        private List<Transaction> GetStoreOrders(string sql)
        {

            List<Transaction> transactions = new List<Transaction>();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@siteID", theEmployee.SiteID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(HelperMethods.CreateTransaction(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return transactions;
        }

        //On add employee button click: open the add employee form.
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEditEmployeeForm addEditEmpForm = new AddEditEmployeeForm();
            addEditEmpForm.ShowDialog();
        }

        //On edit employee button click: open edit employee form, and send the selected employee.
        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];
                    int selectedID = (int)selectedRow.Cells["employeeID"].Value;
                    Employee selectedEmp = EmployeeAccessor.GetEmployeeByID(selectedID);
                    AddEditEmployeeForm addEditEmpForm = new AddEditEmployeeForm();
                    addEditEmpForm.Tag = selectedEmp;
                    addEditEmpForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //Format employee datagridview.
        private void dgvEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvEmployees.Columns[e.ColumnIndex].Name == "Password")
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                    e.FormattingApplied = true;
                }
            }
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "PositionID")
            {
                dgvEmployees.Columns[e.ColumnIndex].HeaderText = "Position";
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int positionID))
                {
                    Position position = PositionAccessor.GetPositionByID(positionID);
                    e.Value = position.PermissionLevel;
                }
            }
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "SiteID")
            {
                dgvEmployees.Columns[e.ColumnIndex].HeaderText = "Site";
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int siteID))
                {
                    Site site = SiteAccessor.GetSiteByID(siteID);
                    e.Value = site.Name;
                }
            }

            HelperMethods.HideDataGridColumn(dgvEmployees, "Notes", e);
            HelperMethods.HideDataGridColumn(dgvEmployees, "LoginAttempts", e);
            HelperMethods.HideDataGridColumn(dgvEmployees, "Password", e);
            FormatDataGrid(dgvEmployees);

        }



        private void FormatDataGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            int lastVisibleColumnIndex = dgv.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).Index;
            dgv.Columns[lastVisibleColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //On delete employee button click: if an employee is selected, change it to inactive if user confirms.
        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                try
                {
                    //get selected employee
                    DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];
                    int selectedID = (int)selectedRow.Cells["employeeID"].Value;
                    Employee selectedEmp = EmployeeAccessor.GetEmployeeByID(selectedID);

                    //check if active, if is active confirm delete and set to inactive.
                    if (selectedEmp.Active)
                    {
                        DialogResult result = MessageBox.Show($"Are you sure you would like to set employee: {selectedEmp.EmployeeID} ({selectedEmp.Username}) to INACTIVE?",
                            "Confirm Employee Delete", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            string updateSql = "UPDATE employee SET active = 0 WHERE employeeID = @empID";
                            MySqlParameter[] updateParameters = {
                                new MySqlParameter("@empID", selectedEmp.EmployeeID)
                            };

                            EmployeeAccessor.AddUpdateEmployee(updateSql, updateParameters);
                        }
                    }
                    //Show error message if employee is already inactive.
                    else
                    {
                        MessageBox.Show($"Employee: {selectedEmp.EmployeeID} ({selectedEmp.Username}) is already set to INACTIVE", "Employee Delete Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        //On edit item button click: check if an item is selcted and if so disable datagridview and edit/delete buttons
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvItems.SelectedRows[0];
                    int selectedID = (int)selectedRow.Cells["ItemID"].Value;
                    Item selectedItem = ItemAccessor.GetItemByID(selectedID);
                    DisableButton(btnEditItem);
                    DisableButton(btnDeleteItem);
                    dgvItems.Enabled = false;
                    PopulateItemView(selectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DisableButton(Button inButton)
        {
            inButton.Enabled = false;
            inButton.BackColor = Color.White;
        }

        private void EnableButton(Button inButton)
        {
            inButton.Enabled = true;
            inButton.BackColor = Color.OrangeRed;
        }

        //Populate the item groupbox with the item sent. Called when a user selects Edit when an item is selected.
        private void PopulateItemView(Item item)
        {

            txtItemID.Text = item.ItemID.ToString();
            txtItemSKU.Text = item.SKU.ToString();
            txtItemName.Text = item.Name.ToString();
            txtItemDescription.Text = item.Description.ToString();
            txtItemWeight.Text = item.Weight.ToString();
            txtItemSize.Text = item.CaseSize.ToString();
            txtItemCost.Text = item.CostPrice.ToString();
            txtItemRetail.Text = item.RetailPrice.ToString();
            cboItemCategory.Text = item.Category.ToString();
            cboItemSupplier.Text = SupplierAccessor.GetSupplierByID(item.SupplierID).Name;
            chkItemActive.Checked = item.Active;
            if (item.Notes != null)
            {
                txtItemNotes.Text = item.Notes.ToString();
            }
            grpItemView.Visible = true;
            string imagePath = ItemImageAccessor.GetImageByItemID(item.ItemID);
            if (imagePath != "")
            {
                picItem.ImageLocation = Path.Combine(Environment.CurrentDirectory, "Images", imagePath);
            }
        }

        //On update image button click: open file explorer to select an image. When selected save it to the project and database.
        private void btnUpdateItemImg_Click(object sender, EventArgs e)
        {
            string imagesFolderPath = Path.Combine(Application.StartupPath, "Images");

            if (!Directory.Exists(imagesFolderPath))
            {
                Directory.CreateDirectory(imagesFolderPath);
            }

            else if (ofdItemImage.ShowDialog() == DialogResult.OK)
            {
                string imagePath = ofdItemImage.FileName;
                string newImagePath = $"{txtItemID.Text}.jpg";
                Image itemImage = Image.FromFile(imagePath);

                string savePath = Path.Combine(Environment.CurrentDirectory, "Images", newImagePath);

                itemImage.Save(savePath, itemImage.RawFormat);

                string dbImage = ItemImageAccessor.GetImageByItemID(int.Parse(txtItemID.Text));
                if (dbImage == "")
                {
                    string insertSql = "INSERT INTO itemImage (itemID, imagePath) VALUES (@itemID, @newImagePath)";
                    MySqlParameter[] parameters = {
                        new MySqlParameter("@itemID", int.Parse(txtItemID.Text)),
                        new MySqlParameter("@newImagePath", newImagePath)
                    };
                    bool success = ItemImageAccessor.AddUpdateItemImage(insertSql, parameters);

                }
                else
                {
                    string updateSql = "UPDATE itemImage SET imagePath = @newImagePath WHERE itemID = @itemID";
                    MySqlParameter[] parameters = {
                        new MySqlParameter("@newImagePath", newImagePath),
                        new MySqlParameter("@itemID", int.Parse(txtItemID.Text))
                    };
                    bool success = ItemImageAccessor.AddUpdateItemImage(updateSql, parameters);

                }

                picItem.ImageLocation = savePath;
            }

        }

        //On remove image button click, remove the items image from the project/database.
        private void btnRemoveItemImg_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Remove image for item {txtItemID.Text}?", "Confirm Remove Image", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool valid = ItemImageAccessor.DeleteImageByItemID(int.Parse(txtItemID.Text));
                if (valid)
                {
                    try
                    {
                        string deletePath = Path.Combine(Environment.CurrentDirectory, "Images", txtItemID.Text + ".jpg");
                        if (File.Exists(deletePath))
                        {
                            File.Delete(deletePath);
                            picItem.Image = picItem.ErrorImage;
                            picItem.Refresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not delete image: " + ex.Message);
                    }
                }
            }
        }

        //On cancel item edit click: clear/hide item group box and re-enable the datagridview.
        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            ClearItemView();
        }

        //on save item click: commit changed to the database.
        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            Supplier supp = SupplierAccessor.GetSupplierByName(cboItemSupplier.Text);
            string updateItemSql = @"
                UPDATE item
                SET
                    name = @itemName,
                    sku = @itemSKU,
                    description = @itemDescription,
                    category = @itemCategory,
                    weight = @itemWeight,
                    caseSize = @itemSize,
                    costPrice = @itemCost,
                    retailPrice = @itemRetail,
                    supplierID = @supplierID,
                    active = @itemActive,
                    notes = @itemNotes
                WHERE
                    itemID = @itemID";

            MySqlParameter[] parameters = {
                new MySqlParameter("@itemName", txtItemName.Text),
                new MySqlParameter("@itemSKU", txtItemSKU.Text),
                new MySqlParameter("@itemDescription", txtItemDescription.Text),
                new MySqlParameter("@itemCategory", cboItemCategory.Text),
                new MySqlParameter("@itemWeight", Convert.ToDecimal(txtItemWeight.Text)),
                new MySqlParameter("@itemSize", Convert.ToInt32(txtItemSize.Text)),
                new MySqlParameter("@itemCost", Convert.ToDecimal(txtItemCost.Text)),
                new MySqlParameter("@itemRetail", Convert.ToDecimal(txtItemRetail.Text)),
                new MySqlParameter("@supplierID", supp.SupplierID),
                new MySqlParameter("@itemActive", chkItemActive.Checked),
                new MySqlParameter("@itemNotes", txtItemNotes.Text),
                new MySqlParameter("@itemID", txtItemID.Text)
            };

            bool valid = ItemAccessor.AddUpdateItem(updateItemSql, parameters);

            if (valid)
            {
                ClearItemView();
            }
        }

        //Clear item group box and re-enable datagridview for items.
        private void ClearItemView()
        {
            txtItemID.Text = "";
            txtItemSKU.Text = "";
            txtItemName.Text = "";
            txtItemDescription.Text = "";
            txtItemWeight.Text = "";
            txtItemSize.Text = "";
            txtItemCost.Text = "";
            txtItemRetail.Text = "";
            cboItemCategory.Text = "";
            cboItemSupplier.Text = "";
            chkItemActive.Checked = false;
            txtItemNotes.Text = "";
            picItem.Image = picItem.ErrorImage;

            grpItemView.Visible = false;
            dgvItems.Enabled = true;

            EnableButton(btnDeleteItem);
            EnableButton(btnEditItem);
        }

        //on F1 press, display help menu
        private void frmDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbcMainScreen.SelectedTab != null)
            {
                HelpMenus.ShowHelp(tbcMainScreen.SelectedTab.Text, e);
            }
            else
            {
                HelpMenus.ShowHelp("Dashboard", e);
            }

        }

        //On search item button click: display the results into the items datagridview.
        private void btnSearchItem_Click(object sender, EventArgs e)
        {

            List<Item> filteredItems = HelperMethods.FilterData(ItemAccessor.GetAllItems(), txtSearchItem, dgvItems, item => item.ItemID.ToString());
            filteredItems.AddRange(HelperMethods.FilterData(ItemAccessor.GetAllItems(), txtSearchItem, dgvItems, item => item.Name));
            filteredItems = filteredItems.Distinct().ToList();
            dgvItems.DataSource = filteredItems;
        }

        //On search employee button click: display the results into the employee datagridview.
        // Also search for the filters set within the position and location drop down lists.
        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            List<Employee> allEmployees = EmployeeAccessor.GetAllEmployees();
            List<Employee> filteredEmployees = new List<Employee>();

            filteredEmployees = HelperMethods.FilterData(allEmployees, txtSearchEmp, dgvEmployees, employee => employee.EmployeeID.ToString());
            filteredEmployees.AddRange(HelperMethods.FilterData(allEmployees, txtSearchEmp, dgvEmployees, employee => employee.FirstName));
            filteredEmployees.AddRange(HelperMethods.FilterData(allEmployees, txtSearchEmp, dgvEmployees, employee => employee.LastName));

            filteredEmployees = filteredEmployees.Distinct().ToList();

            filteredEmployees = HelperMethods.FilterData(filteredEmployees, cboSearchEmpLocations, dgvEmployees, employee => SiteAccessor.GetSiteByID(employee.SiteID).Name);
            filteredEmployees = HelperMethods.FilterData(filteredEmployees, cboSearchEmpPosition, dgvEmployees, employee => PositionAccessor.GetPositionByID(employee.PositionID).PermissionLevel);

            dgvEmployees.DataSource = filteredEmployees;
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            if (tbcMainScreen.SelectedTab != null)
            {
                HelpMenus.ShowHelp(tbcMainScreen.SelectedTab.Text);
            }
            else
            {
                HelpMenus.ShowHelp("Dashboard");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvItems.SelectedRows[0];
                    int selectedID = (int)selectedRow.Cells["ItemID"].Value;
                    Item selectedItem = ItemAccessor.GetItemByID(selectedID);

                    if (selectedItem.Active)
                    {
                        DialogResult result = MessageBox.Show($"Are you sure you would like to set Item: {selectedItem.ItemID} ({selectedItem.Name}) to INACTIVE?",
                            "Confirm Item Delete", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            string updateSql = "UPDATE item SET active = 0 WHERE itemID = @itemID";
                            MySqlParameter[] updateParameters = {
                                new MySqlParameter("@itemID", selectedItem.ItemID)
                            };

                            EmployeeAccessor.AddUpdateEmployee(updateSql, updateParameters);
                        }
                    }

                    else
                    {
                        MessageBox.Show($"Item: {selectedItem.ItemID} ({selectedItem.Name}) is already set to INACTIVE", "Item Delete Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvSites_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            HelperMethods.HideDataGridColumn(dgvSites, "Notes", e);
            FormatDataGrid(dgvSites);
        }

        private void btnEditSite_Click(object sender, EventArgs e)
        {
            if (dgvSites.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvSites.SelectedRows[0];
                    int selectedID = (int)selectedRow.Cells["siteID"].Value;
                    Site selectedSite = SiteAccessor.GetSiteByID(selectedID);
                    AddEditSiteForm addEditSiteForm = new AddEditSiteForm();
                    addEditSiteForm.Tag = selectedSite;
                    addEditSiteForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            AddEditSiteForm addEditSiteForm = new AddEditSiteForm();
            addEditSiteForm.ShowDialog();
        }

        private void dgvStoreOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStoreOrders.Columns[e.ColumnIndex].Name == "SiteIDTo")
            {
                dgvStoreOrders.Columns[e.ColumnIndex].HeaderText = "Recieving Site";
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int siteID))
                {
                    Site site = SiteAccessor.GetSiteByID(siteID);
                    e.Value = site.Name;
                }
            }
            if (dgvStoreOrders.Columns[e.ColumnIndex].Name == "SiteIDFrom")
            {
                dgvStoreOrders.Columns[e.ColumnIndex].HeaderText = "Dispatch Site";
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int siteID))
                {
                    Site site = SiteAccessor.GetSiteByID(siteID);
                    e.Value = site.Name;
                }
            }

            HelperMethods.HideDataGridColumn(dgvStoreOrders, "Notes", e);
            FormatDataGrid(dgvStoreOrders);
        }

        private void btnSearchSites_Click(object sender, EventArgs e)
        {
            List<Site> allSites = SiteAccessor.GetAllSites();
            List<Site> filteredSites = new List<Site>();
            filteredSites = HelperMethods.FilterData(allSites, txtSearchSites, dgvSites, site => site.Address);
            filteredSites = HelperMethods.FilterData(filteredSites, cboFilterSiteDay, dgvSites, site => site.DayOfWeek);
            filteredSites = HelperMethods.FilterData(filteredSites, cboFilterSiteProvince, dgvSites, site => ProvinceAccessor.GetProvinceByID(site.ProvinceID).ProvinceName);

            dgvSites.DataSource = filteredSites;
        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {
            List<Transaction> allTxns = new List<Transaction>();

            if (chkClosedOrders.Checked)
                allTxns = TransactionAccessor.GetAllTransactions("closed");
            else
                allTxns = TransactionAccessor.GetAllTransactions("open");

            List<Transaction> filteredTxns = new List<Transaction>();
            filteredTxns = HelperMethods.FilterData(allTxns, cboFilterLocation, dgvStoreOrders, txn => SiteAccessor.GetSiteByID(txn.SiteIDTo).Name);
            filteredTxns = HelperMethods.FilterData(filteredTxns, cboFilterStatus, dgvStoreOrders, txn => txn.Status);

            List<Transaction> filtered = new List<Transaction>();
            foreach (var txn in filteredTxns)
            {
                if (txn.TxnType == "Store Order" || txn.TxnType == "Emergency" || txn.TxnType == "Back Order")
                {
                    filtered.Add(txn);
                }
            }
            dgvStoreOrders.DataSource = filtered;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = GetStoreOrders("SELECT * FROM txn WHERE Status != 'Cancelled' and siteIDTo = @siteID and txnType in ('Store Order', 'Emergency')");
            bool orderExists = false;
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Status == "New")
                {
                    orderExists = true;
                }
            }
            if (!orderExists)
            {
                string orderType;
                if (radRegular.Checked)
                    orderType = radRegular.Tag.ToString();
                else
                    orderType = radEmergency.Tag.ToString();

                frmStoreOrder newStoreOrder = new frmStoreOrder();
                newStoreOrder.Tag = theEmployee;
                newStoreOrder.Text = $"Create {orderType} Order";
                newStoreOrder.ShowDialog();
            }
            else
                MessageBox.Show("A store order has already been placed for this location.\n" +
                    "if you wish to make changes to the order please select it and edit the order.", "Create Order Error", MessageBoxButtons.OK);
        }

        private void btnRecieveOrder_Click(object sender, EventArgs e)
        {
            if (dgvStoreOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStoreOrders.SelectedRows[0];
                int selectedID = (int)selectedRow.Cells["txnID"].Value;
                Transaction selectedTxn = TransactionAccessor.GetTransactionByTxnID(selectedID);

                if (selectedTxn != null && selectedTxn.Status == "Submitted")
                {
                    string sql = "UPDATE txn SET status = @status WHERE txnID = @txnID";

                    List<MySqlParameter> parameters = new List<MySqlParameter>
                    {
                        new MySqlParameter("@status", "Assembling"),
                        new MySqlParameter("@txnID", selectedTxn.TxnID)
                    };

                    TransactionAccessor.AddUpdateTransaction(sql, parameters);
                    int auditID = HelperMethods.GetAuditID();

                    TransactionAudit txnAudit = new TransactionAudit((int)auditID, int.Parse(selectedRow.Cells["txnID"].Value.ToString()),
                        selectedRow.Cells["txnType"].Value.ToString(), "Recieved", DateTime.Now, theEmployee.SiteID, null,
                        $"Order recieved by {theEmployee.FirstName} {theEmployee.LastName}");

                    txnAudit.CommitTransactionAudit();

                    MessageBox.Show("Order recieved and may now be processed.", "Order Recieved", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Only orders with status 'Submitted' can be recieved.", "Recieve Order Error", MessageBoxButtons.OK);
            }
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (dgvStoreOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStoreOrders.SelectedRows[0];
                int selectedID = (int)selectedRow.Cells["txnID"].Value;
                Transaction selectedTxn = TransactionAccessor.GetTransactionByTxnID(selectedID);

                if (selectedTxn != null && selectedTxn.Status == "New")
                {
                    string sql = "UPDATE txn SET status = @status WHERE txnID = @txnID";

                    List<MySqlParameter> parameters = new List<MySqlParameter>
                    {
                        new MySqlParameter("@status", "Submitted"),
                        new MySqlParameter("@txnID", selectedTxn.TxnID)
                    };

                    TransactionAccessor.AddUpdateTransaction(sql, parameters);

                    int auditID = HelperMethods.GetAuditID();

                    TransactionAudit txnAudit = new TransactionAudit((int)auditID, int.Parse(selectedRow.Cells["txnID"].Value.ToString()),
                        selectedRow.Cells["txnType"].Value.ToString(), "Submitted", DateTime.Now, theEmployee.SiteID, null,
                        $"Order submitted by {theEmployee.FirstName} {theEmployee.LastName}");

                    txnAudit.CommitTransactionAudit();

                    MessageBox.Show($"Order submitted to {SiteAccessor.GetSiteByID(selectedTxn.SiteIDFrom).Name}.", "Order Submitted", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Only orders with status 'New' can be submitted.", "Submit Order Error", MessageBoxButtons.OK);
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dgvStoreOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStoreOrders.SelectedRows[0];
                int selectedID = (int)selectedRow.Cells["txnID"].Value;
                Transaction selectedTxn = TransactionAccessor.GetTransactionByTxnID(selectedID);

                if (selectedTxn != null && selectedTxn.Status == "New")
                {
                    string orderType;
                    if (radRegular.Checked)
                        orderType = radRegular.Tag.ToString();
                    else
                        orderType = radEmergency.Tag.ToString();

                    frmStoreOrder newStoreOrder = new frmStoreOrder();
                    newStoreOrder.Tag = theEmployee;
                    newStoreOrder.Data = selectedTxn;
                    newStoreOrder.Text = $"Edit {orderType} Order";
                    newStoreOrder.ShowDialog();
                }
                else
                    MessageBox.Show("Only store orders with status 'New' can be editted.", "Edit Order Error", MessageBoxButtons.OK);
            }
        }

        private void btnFulfillOrder_Click(object sender, EventArgs e)
        {
            if (dgvStoreOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStoreOrders.SelectedRows[0];
                int selectedID = (int)selectedRow.Cells["txnID"].Value;
                Transaction selectedTxn = TransactionAccessor.GetTransactionByTxnID(selectedID);

                if (selectedTxn != null && (selectedTxn.Status == "Assembling" || selectedTxn.Status == "Pending Back Order"))
                {
                    string orderType;
                    if (radRegular.Checked)
                        orderType = radRegular.Tag.ToString();
                    else
                        orderType = radEmergency.Tag.ToString();

                    frmFulfillStoreOrder fulfillOrder = new frmFulfillStoreOrder();
                    fulfillOrder.Tag = theEmployee;
                    fulfillOrder.Data = selectedTxn;
                    fulfillOrder.Text = $"Fulfill {orderType} Order";
                    fulfillOrder.ShowDialog();
                }
                else
                    MessageBox.Show("Only store orders with status 'Assembling' can be fulfilled.", "Fulfill Order Error", MessageBoxButtons.OK);
            }
        }

        private void btnEditBackOrder_Click(object sender, EventArgs e)
        {
            if (dgvStoreOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStoreOrders.SelectedRows[0];
                int selectedID = (int)selectedRow.Cells["txnID"].Value;
                Transaction selectedTxn = TransactionAccessor.GetTransactionByTxnID(selectedID);

                if (selectedTxn != null && selectedTxn.Status == "Pending Back Order")
                {
                    string orderType = "Back Order";

                    frmBackOrder backorder = new frmBackOrder();
                    backorder.Tag = theEmployee;
                    backorder.Data = selectedTxn;
                    backorder.Text = $"Edit {orderType}";
                    backorder.ShowDialog();
                }
                else
                    MessageBox.Show("A back order must be selected in order to edit.", "Back Order Edit Error", MessageBoxButtons.OK);
            }
        }

        private void btnCreateBackOrder_Click(object sender, EventArgs e)
        {
            string orderType = "Back Order";

            frmBackOrder backorder = new frmBackOrder();
            backorder.Tag = theEmployee;
            backorder.Text = $"Create {orderType}";
            backorder.ShowDialog();
        }

        private void btnAcceptOrder_Click(object sender, EventArgs e)
        {
            if (dgvStoreOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStoreOrders.SelectedRows[0];
                int selectedID = (int)selectedRow.Cells["txnID"].Value;
                Transaction selectedTxn = TransactionAccessor.GetTransactionByTxnID(selectedID);

                if (selectedTxn != null && (selectedTxn.Status == "Delivered" && selectedTxn.SiteIDTo == theEmployee.SiteID))
                {
                    tbcMainScreen.Hide();
                    txnID = selectedID;
                    grpAcceptOrder.Show();
                    List<TransactionItems> transactionItems = TransactionItemsAccessor.GetTransactionItemsById(selectedID);
                    foreach (TransactionItems transactionItem in transactionItems)
                    {
                        int rowIndex = dgvAcceptOrder.Rows.Add();
                        Item theItem = ItemAccessor.GetItemByID(transactionItem.ItemID);
                        Inventory inv = InventoryAccessor.GetInventoryByItemIdAndLocation(theItem.ItemID, selectedID.ToString());
                        dgvAcceptOrder.Rows[rowIndex].Cells["ID"].Value = theItem.ItemID;
                        dgvAcceptOrder.Rows[rowIndex].Cells["itemName"].Value = theItem.Name;
                        dgvAcceptOrder.Rows[rowIndex].Cells["quantityOrdered"].Value = inv.Quantity;
                        dgvAcceptOrder.Rows[rowIndex].Cells["quantityAvailable"].Value = transactionItem.Quantity;
                    }
                }
                else
                    MessageBox.Show("A delivered order must be selected for your location in order to accept.", "Accept Order Error", MessageBoxButtons.OK);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            HideAcceptOrder();
            MessageBox.Show("Order accepted", "Accept Confirm", MessageBoxButtons.OK);
            foreach (DataGridViewRow row in dgvAcceptOrder.Rows)
            {
                string updateInv = @"UPDATE inventory SET quantity = @quantity WHERE siteID = @siteID";
                List<MySqlParameter> invParameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@quantity", row.Cells["quantityAvailable"].Value),
                    new MySqlParameter("@siteID", theEmployee.SiteID)
                };
                InventoryAccessor.AddUpdateInventory(updateInv, invParameters);

                invParameters.Clear();

                Inventory truck = InventoryAccessor.GetInventoryByItemIDAndSiteID(int.Parse(row.Cells["ID"].Value.ToString()), Constants.TRUCKING_DELIVERY);
                invParameters.Add(new MySqlParameter("@quantity", truck.Quantity - int.Parse(row.Cells["quantityAvailable"].Value.ToString())));
                invParameters.Add(new MySqlParameter("@siteID", Constants.TRUCKING_DELIVERY));
                InventoryAccessor.AddUpdateInventory(updateInv, invParameters);

                string updateTxn = @"UPDATE txn SET status = @status WHERE txnID = @txnID";
                List<MySqlParameter> txnParameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@status", "Complete"),
                    new MySqlParameter("@txnID", txnID)
                };
                TransactionAccessor.AddUpdateTransaction(updateTxn, txnParameters);
            }
        }

        private void btnExitAccept_Click(object sender, EventArgs e)
        {
            HideAcceptOrder();
        }

        private void HideAcceptOrder()
        {
            tbcMainScreen.Show();
            grpAcceptOrder.Hide();
            dgvAcceptOrder.Rows.Clear();
        }

        private void dgvInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInventory.Columns[e.ColumnIndex].Name == "SiteID")
            {
                dgvInventory.Columns[e.ColumnIndex].HeaderText = "Site";
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int siteID))
                {
                    Site site = SiteAccessor.GetSiteByID(siteID);
                    e.Value = site.Name;
                }
            }

            HelperMethods.HideDataGridColumn(dgvInventory, "notes", e);
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0 )
            {
                DataGridViewRow selectedRow = dgvInventory.SelectedRows[0];
                Inventory inventory = InventoryAccessor.GetInventoryByItemIDAndSiteID(Convert.ToInt32(selectedRow.Cells["itemID"].Value), theEmployee.SiteID);

                frmEditInventory editInvForm = new frmEditInventory();
                editInvForm.Tag = inventory;
                editInvForm.ShowDialog();
            }
        }
    }
}

