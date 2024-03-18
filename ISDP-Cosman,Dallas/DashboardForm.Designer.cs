namespace ISDP_Cosman_Dallas
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            lblEmpUsername = new Label();
            lblEmpLocation = new Label();
            tabDelivery = new TabPage();
            tabShipReceipts = new TabPage();
            tabSupplierOrder = new TabPage();
            tabLossReturn = new TabPage();
            tabEmergencyOrder = new TabPage();
            tabStoreOrder = new TabPage();
            btnAcceptOrder = new Button();
            btnCreateBackOrder = new Button();
            btnEditBackOrder = new Button();
            btnFulfillOrder = new Button();
            groupBox1 = new GroupBox();
            radEmergency = new RadioButton();
            radRegular = new RadioButton();
            btnSubmitOrder = new Button();
            btnRecieveOrder = new Button();
            dtpOrderEnd = new DateTimePicker();
            dtpOrderStart = new DateTimePicker();
            chkClosedOrders = new CheckBox();
            cboFilterLocation = new ComboBox();
            cboFilterStatus = new ComboBox();
            btnSearchOrders = new Button();
            btnEditOrder = new Button();
            dgvStoreOrders = new DataGridView();
            btnCreateOrder = new Button();
            tabReports = new TabPage();
            tabPOSLink = new TabPage();
            tabPermissions = new TabPage();
            tabSuppliers = new TabPage();
            tabInventory = new TabPage();
            btnSearchInventory = new Button();
            txtSearchInventory = new TextBox();
            btnEditInventory = new Button();
            dgvInventory = new DataGridView();
            tabLocations = new TabPage();
            cboFilterSiteDay = new ComboBox();
            cboFilterSiteProvince = new ComboBox();
            btnSearchSites = new Button();
            txtSearchSites = new TextBox();
            btnEditSite = new Button();
            dgvSites = new DataGridView();
            btnAddSite = new Button();
            tabEmployees = new TabPage();
            cboSearchEmpLocations = new ComboBox();
            cboSearchEmpPosition = new ComboBox();
            btnSearchEmp = new Button();
            txtSearchEmp = new TextBox();
            btnDeleteEmp = new Button();
            btnEditEmp = new Button();
            dgvEmployees = new DataGridView();
            btnAddEmp = new Button();
            tbcMainScreen = new TabControl();
            tabItems = new TabPage();
            btnSearchItem = new Button();
            txtSearchItem = new TextBox();
            grpItemView = new GroupBox();
            chkItemActive = new CheckBox();
            btnCancelItem = new Button();
            btnSaveItem = new Button();
            btnRemoveItemImg = new Button();
            btnUpdateItemImg = new Button();
            label11 = new Label();
            txtItemNotes = new RichTextBox();
            txtItemCost = new TextBox();
            txtItemWeight = new TextBox();
            txtItemRetail = new TextBox();
            txtItemSKU = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cboItemSupplier = new ComboBox();
            label6 = new Label();
            cboItemCategory = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtItemName = new TextBox();
            label2 = new Label();
            txtItemID = new TextBox();
            label1 = new Label();
            picItem = new PictureBox();
            txtItemDescription = new RichTextBox();
            txtItemSize = new TextBox();
            btnDeleteItem = new Button();
            btnEditItem = new Button();
            dgvItems = new DataGridView();
            picLogout = new PictureBox();
            picHelp = new PictureBox();
            picRefresh = new PictureBox();
            ofdItemImage = new OpenFileDialog();
            sfdItemImage = new SaveFileDialog();
            grpAcceptOrder = new GroupBox();
            btnExitAccept = new Button();
            btnAccept = new Button();
            dgvAcceptOrder = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            itemName = new DataGridViewTextBoxColumn();
            quantityOrdered = new DataGridViewTextBoxColumn();
            quantityAvailable = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabStoreOrder.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStoreOrders).BeginInit();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            tabLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSites).BeginInit();
            tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            tbcMainScreen.SuspendLayout();
            tabItems.SuspendLayout();
            grpItemView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRefresh).BeginInit();
            grpAcceptOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptOrder).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bullseye;
            pictureBox2.Location = new Point(12, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // lblEmpUsername
            // 
            lblEmpUsername.AutoSize = true;
            lblEmpUsername.Location = new Point(101, 16);
            lblEmpUsername.Name = "lblEmpUsername";
            lblEmpUsername.Size = new Size(47, 17);
            lblEmpUsername.TabIndex = 15;
            lblEmpUsername.Text = "User: ";
            // 
            // lblEmpLocation
            // 
            lblEmpLocation.AutoSize = true;
            lblEmpLocation.Location = new Point(101, 41);
            lblEmpLocation.Name = "lblEmpLocation";
            lblEmpLocation.Size = new Size(71, 17);
            lblEmpLocation.TabIndex = 16;
            lblEmpLocation.Text = "Location: ";
            // 
            // tabDelivery
            // 
            tabDelivery.Location = new Point(4, 26);
            tabDelivery.Name = "tabDelivery";
            tabDelivery.Size = new Size(1280, 689);
            tabDelivery.TabIndex = 12;
            tabDelivery.Text = "Deliveries";
            tabDelivery.UseVisualStyleBackColor = true;
            // 
            // tabShipReceipts
            // 
            tabShipReceipts.Location = new Point(4, 26);
            tabShipReceipts.Name = "tabShipReceipts";
            tabShipReceipts.Size = new Size(1280, 689);
            tabShipReceipts.TabIndex = 11;
            tabShipReceipts.Text = "Shipping Receipts";
            tabShipReceipts.UseVisualStyleBackColor = true;
            // 
            // tabSupplierOrder
            // 
            tabSupplierOrder.Location = new Point(4, 26);
            tabSupplierOrder.Name = "tabSupplierOrder";
            tabSupplierOrder.Size = new Size(1280, 689);
            tabSupplierOrder.TabIndex = 10;
            tabSupplierOrder.Text = "Supplier Orders";
            tabSupplierOrder.UseVisualStyleBackColor = true;
            // 
            // tabLossReturn
            // 
            tabLossReturn.Location = new Point(4, 26);
            tabLossReturn.Name = "tabLossReturn";
            tabLossReturn.Size = new Size(1280, 689);
            tabLossReturn.TabIndex = 9;
            tabLossReturn.Text = "Loss/Return";
            tabLossReturn.UseVisualStyleBackColor = true;
            // 
            // tabEmergencyOrder
            // 
            tabEmergencyOrder.Location = new Point(4, 26);
            tabEmergencyOrder.Name = "tabEmergencyOrder";
            tabEmergencyOrder.Size = new Size(1280, 689);
            tabEmergencyOrder.TabIndex = 8;
            tabEmergencyOrder.Text = "Emergency Orders";
            tabEmergencyOrder.UseVisualStyleBackColor = true;
            // 
            // tabStoreOrder
            // 
            tabStoreOrder.Controls.Add(btnAcceptOrder);
            tabStoreOrder.Controls.Add(btnCreateBackOrder);
            tabStoreOrder.Controls.Add(btnEditBackOrder);
            tabStoreOrder.Controls.Add(btnFulfillOrder);
            tabStoreOrder.Controls.Add(groupBox1);
            tabStoreOrder.Controls.Add(btnSubmitOrder);
            tabStoreOrder.Controls.Add(btnRecieveOrder);
            tabStoreOrder.Controls.Add(dtpOrderEnd);
            tabStoreOrder.Controls.Add(dtpOrderStart);
            tabStoreOrder.Controls.Add(chkClosedOrders);
            tabStoreOrder.Controls.Add(cboFilterLocation);
            tabStoreOrder.Controls.Add(cboFilterStatus);
            tabStoreOrder.Controls.Add(btnSearchOrders);
            tabStoreOrder.Controls.Add(btnEditOrder);
            tabStoreOrder.Controls.Add(dgvStoreOrders);
            tabStoreOrder.Controls.Add(btnCreateOrder);
            tabStoreOrder.Location = new Point(4, 26);
            tabStoreOrder.Name = "tabStoreOrder";
            tabStoreOrder.Size = new Size(1280, 689);
            tabStoreOrder.TabIndex = 7;
            tabStoreOrder.Text = "Store Orders";
            tabStoreOrder.UseVisualStyleBackColor = true;
            // 
            // btnAcceptOrder
            // 
            btnAcceptOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAcceptOrder.BackColor = Color.OrangeRed;
            btnAcceptOrder.Cursor = Cursors.Hand;
            btnAcceptOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcceptOrder.ForeColor = Color.White;
            btnAcceptOrder.Location = new Point(406, 648);
            btnAcceptOrder.Name = "btnAcceptOrder";
            btnAcceptOrder.Size = new Size(206, 38);
            btnAcceptOrder.TabIndex = 64;
            btnAcceptOrder.Text = "ACCEPT ORDER";
            btnAcceptOrder.UseVisualStyleBackColor = false;
            btnAcceptOrder.Click += btnAcceptOrder_Click;
            // 
            // btnCreateBackOrder
            // 
            btnCreateBackOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateBackOrder.BackColor = Color.OrangeRed;
            btnCreateBackOrder.Cursor = Cursors.Hand;
            btnCreateBackOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateBackOrder.ForeColor = Color.White;
            btnCreateBackOrder.Location = new Point(406, 648);
            btnCreateBackOrder.Name = "btnCreateBackOrder";
            btnCreateBackOrder.Size = new Size(206, 38);
            btnCreateBackOrder.TabIndex = 63;
            btnCreateBackOrder.Tag = "BACK ORDER";
            btnCreateBackOrder.Text = "CREATE BACK ORDER";
            btnCreateBackOrder.UseVisualStyleBackColor = false;
            btnCreateBackOrder.Click += btnCreateBackOrder_Click;
            // 
            // btnEditBackOrder
            // 
            btnEditBackOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditBackOrder.BackColor = Color.OrangeRed;
            btnEditBackOrder.Cursor = Cursors.Hand;
            btnEditBackOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditBackOrder.ForeColor = Color.White;
            btnEditBackOrder.Location = new Point(618, 648);
            btnEditBackOrder.Name = "btnEditBackOrder";
            btnEditBackOrder.Size = new Size(206, 38);
            btnEditBackOrder.TabIndex = 62;
            btnEditBackOrder.Tag = "BACK ORDER";
            btnEditBackOrder.Text = "EDIT BACK ORDER";
            btnEditBackOrder.UseVisualStyleBackColor = false;
            btnEditBackOrder.Click += btnEditBackOrder_Click;
            // 
            // btnFulfillOrder
            // 
            btnFulfillOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFulfillOrder.BackColor = Color.OrangeRed;
            btnFulfillOrder.Cursor = Cursors.Hand;
            btnFulfillOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFulfillOrder.ForeColor = Color.White;
            btnFulfillOrder.Location = new Point(1042, 648);
            btnFulfillOrder.Name = "btnFulfillOrder";
            btnFulfillOrder.Size = new Size(206, 38);
            btnFulfillOrder.TabIndex = 61;
            btnFulfillOrder.Text = "FULFILL ORDER";
            btnFulfillOrder.UseVisualStyleBackColor = false;
            btnFulfillOrder.Click += btnFulfillOrder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radEmergency);
            groupBox1.Controls.Add(radRegular);
            groupBox1.Location = new Point(36, 633);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 50);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Type";
            // 
            // radEmergency
            // 
            radEmergency.AutoSize = true;
            radEmergency.Location = new Point(105, 20);
            radEmergency.Name = "radEmergency";
            radEmergency.Size = new Size(104, 21);
            radEmergency.TabIndex = 59;
            radEmergency.Tag = "Emergency";
            radEmergency.Text = "Emergency";
            radEmergency.UseVisualStyleBackColor = true;
            // 
            // radRegular
            // 
            radRegular.AutoSize = true;
            radRegular.Checked = true;
            radRegular.Location = new Point(18, 20);
            radRegular.Name = "radRegular";
            radRegular.Size = new Size(80, 21);
            radRegular.TabIndex = 58;
            radRegular.TabStop = true;
            radRegular.Tag = "Store";
            radRegular.Text = "Regular";
            radRegular.UseVisualStyleBackColor = true;
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitOrder.BackColor = Color.OrangeRed;
            btnSubmitOrder.Cursor = Cursors.Hand;
            btnSubmitOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmitOrder.ForeColor = Color.White;
            btnSubmitOrder.Location = new Point(618, 648);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new Size(206, 38);
            btnSubmitOrder.TabIndex = 57;
            btnSubmitOrder.Text = "SUBMIT STORE ORDER";
            btnSubmitOrder.UseVisualStyleBackColor = false;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // btnRecieveOrder
            // 
            btnRecieveOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecieveOrder.BackColor = Color.OrangeRed;
            btnRecieveOrder.Cursor = Cursors.Hand;
            btnRecieveOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecieveOrder.ForeColor = Color.White;
            btnRecieveOrder.Location = new Point(830, 648);
            btnRecieveOrder.Name = "btnRecieveOrder";
            btnRecieveOrder.Size = new Size(206, 38);
            btnRecieveOrder.TabIndex = 56;
            btnRecieveOrder.Text = "RECIEVE ORDER";
            btnRecieveOrder.UseVisualStyleBackColor = false;
            btnRecieveOrder.Click += btnRecieveOrder_Click;
            // 
            // dtpOrderEnd
            // 
            dtpOrderEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpOrderEnd.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpOrderEnd.Location = new Point(898, 16);
            dtpOrderEnd.Name = "dtpOrderEnd";
            dtpOrderEnd.Size = new Size(178, 29);
            dtpOrderEnd.TabIndex = 55;
            // 
            // dtpOrderStart
            // 
            dtpOrderStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpOrderStart.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpOrderStart.Location = new Point(713, 16);
            dtpOrderStart.Name = "dtpOrderStart";
            dtpOrderStart.Size = new Size(179, 29);
            dtpOrderStart.TabIndex = 54;
            // 
            // chkClosedOrders
            // 
            chkClosedOrders.AutoSize = true;
            chkClosedOrders.BackColor = Color.Transparent;
            chkClosedOrders.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkClosedOrders.Location = new Point(36, 18);
            chkClosedOrders.Name = "chkClosedOrders";
            chkClosedOrders.Size = new Size(248, 26);
            chkClosedOrders.TabIndex = 53;
            chkClosedOrders.Text = "Include Cancelled Orders";
            chkClosedOrders.UseVisualStyleBackColor = false;
            // 
            // cboFilterLocation
            // 
            cboFilterLocation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboFilterLocation.BackColor = Color.White;
            cboFilterLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterLocation.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboFilterLocation.FormattingEnabled = true;
            cboFilterLocation.Location = new Point(248, 15);
            cboFilterLocation.Name = "cboFilterLocation";
            cboFilterLocation.Size = new Size(261, 31);
            cboFilterLocation.TabIndex = 52;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboFilterStatus.BackColor = Color.White;
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(515, 15);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(192, 31);
            cboFilterStatus.TabIndex = 51;
            // 
            // btnSearchOrders
            // 
            btnSearchOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchOrders.BackColor = Color.OrangeRed;
            btnSearchOrders.Cursor = Cursors.Hand;
            btnSearchOrders.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchOrders.ForeColor = Color.White;
            btnSearchOrders.Location = new Point(1082, 11);
            btnSearchOrders.Name = "btnSearchOrders";
            btnSearchOrders.Size = new Size(160, 35);
            btnSearchOrders.TabIndex = 50;
            btnSearchOrders.Text = "SEARCH";
            btnSearchOrders.UseVisualStyleBackColor = false;
            btnSearchOrders.Click += btnSearchOrders_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditOrder.BackColor = Color.OrangeRed;
            btnEditOrder.Cursor = Cursors.Hand;
            btnEditOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditOrder.ForeColor = Color.White;
            btnEditOrder.Location = new Point(1042, 648);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(206, 38);
            btnEditOrder.TabIndex = 47;
            btnEditOrder.Text = "EDIT STORE ORDER";
            btnEditOrder.UseVisualStyleBackColor = false;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // dgvStoreOrders
            // 
            dgvStoreOrders.AllowUserToAddRows = false;
            dgvStoreOrders.AllowUserToDeleteRows = false;
            dgvStoreOrders.AllowUserToResizeColumns = false;
            dgvStoreOrders.AllowUserToResizeRows = false;
            dgvStoreOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStoreOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStoreOrders.BackgroundColor = Color.White;
            dgvStoreOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStoreOrders.Location = new Point(36, 58);
            dgvStoreOrders.MultiSelect = false;
            dgvStoreOrders.Name = "dgvStoreOrders";
            dgvStoreOrders.ReadOnly = true;
            dgvStoreOrders.RowHeadersVisible = false;
            dgvStoreOrders.RowHeadersWidth = 51;
            dgvStoreOrders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvStoreOrders.RowTemplate.Height = 40;
            dgvStoreOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStoreOrders.Size = new Size(1207, 572);
            dgvStoreOrders.TabIndex = 46;
            dgvStoreOrders.CellFormatting += dgvStoreOrders_CellFormatting;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateOrder.BackColor = Color.OrangeRed;
            btnCreateOrder.Cursor = Cursors.Hand;
            btnCreateOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateOrder.ForeColor = Color.White;
            btnCreateOrder.Location = new Point(830, 648);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(206, 38);
            btnCreateOrder.TabIndex = 45;
            btnCreateOrder.Text = "PLACE STORE ORDER";
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // tabReports
            // 
            tabReports.Location = new Point(4, 26);
            tabReports.Name = "tabReports";
            tabReports.Size = new Size(1280, 689);
            tabReports.TabIndex = 6;
            tabReports.Text = "Reports";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // tabPOSLink
            // 
            tabPOSLink.Location = new Point(4, 26);
            tabPOSLink.Name = "tabPOSLink";
            tabPOSLink.Size = new Size(1280, 689);
            tabPOSLink.TabIndex = 5;
            tabPOSLink.Text = "POS Link";
            tabPOSLink.UseVisualStyleBackColor = true;
            // 
            // tabPermissions
            // 
            tabPermissions.Location = new Point(4, 26);
            tabPermissions.Name = "tabPermissions";
            tabPermissions.Size = new Size(1280, 689);
            tabPermissions.TabIndex = 4;
            tabPermissions.Text = "Permissions";
            tabPermissions.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Location = new Point(4, 26);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Size = new Size(1280, 689);
            tabSuppliers.TabIndex = 3;
            tabSuppliers.Text = "Suppliers";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(btnSearchInventory);
            tabInventory.Controls.Add(txtSearchInventory);
            tabInventory.Controls.Add(btnEditInventory);
            tabInventory.Controls.Add(dgvInventory);
            tabInventory.Location = new Point(4, 26);
            tabInventory.Name = "tabInventory";
            tabInventory.Size = new Size(1280, 689);
            tabInventory.TabIndex = 2;
            tabInventory.Text = "Inventory";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnSearchInventory
            // 
            btnSearchInventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchInventory.BackColor = Color.OrangeRed;
            btnSearchInventory.Cursor = Cursors.Hand;
            btnSearchInventory.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchInventory.ForeColor = Color.White;
            btnSearchInventory.Location = new Point(1084, 12);
            btnSearchInventory.Name = "btnSearchInventory";
            btnSearchInventory.Size = new Size(160, 35);
            btnSearchInventory.TabIndex = 50;
            btnSearchInventory.Text = "SEARCH";
            btnSearchInventory.UseVisualStyleBackColor = false;
            // 
            // txtSearchInventory
            // 
            txtSearchInventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchInventory.BackColor = Color.White;
            txtSearchInventory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchInventory.Location = new Point(711, 17);
            txtSearchInventory.Name = "txtSearchInventory";
            txtSearchInventory.PlaceholderText = "Search ID or Name";
            txtSearchInventory.Size = new Size(367, 30);
            txtSearchInventory.TabIndex = 49;
            // 
            // btnEditInventory
            // 
            btnEditInventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditInventory.BackColor = Color.OrangeRed;
            btnEditInventory.Cursor = Cursors.Hand;
            btnEditInventory.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditInventory.ForeColor = Color.White;
            btnEditInventory.Location = new Point(1033, 643);
            btnEditInventory.Name = "btnEditInventory";
            btnEditInventory.Size = new Size(211, 38);
            btnEditInventory.TabIndex = 48;
            btnEditInventory.Text = "EDIT INVENTORY";
            btnEditInventory.UseVisualStyleBackColor = false;
            btnEditInventory.Click += btnEditInventory_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeColumns = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(36, 58);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInventory.RowTemplate.Height = 40;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(1207, 572);
            dgvInventory.TabIndex = 46;
            dgvInventory.CellFormatting += dgvInventory_CellFormatting;
            // 
            // tabLocations
            // 
            tabLocations.Controls.Add(cboFilterSiteDay);
            tabLocations.Controls.Add(cboFilterSiteProvince);
            tabLocations.Controls.Add(btnSearchSites);
            tabLocations.Controls.Add(txtSearchSites);
            tabLocations.Controls.Add(btnEditSite);
            tabLocations.Controls.Add(dgvSites);
            tabLocations.Controls.Add(btnAddSite);
            tabLocations.Location = new Point(4, 26);
            tabLocations.Name = "tabLocations";
            tabLocations.Padding = new Padding(3);
            tabLocations.Size = new Size(1280, 689);
            tabLocations.TabIndex = 1;
            tabLocations.Text = "Locations";
            tabLocations.UseVisualStyleBackColor = true;
            // 
            // cboFilterSiteDay
            // 
            cboFilterSiteDay.Anchor = AnchorStyles.Top;
            cboFilterSiteDay.BackColor = Color.White;
            cboFilterSiteDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterSiteDay.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboFilterSiteDay.FormattingEnabled = true;
            cboFilterSiteDay.Location = new Point(213, 17);
            cboFilterSiteDay.Name = "cboFilterSiteDay";
            cboFilterSiteDay.Size = new Size(243, 31);
            cboFilterSiteDay.TabIndex = 52;
            // 
            // cboFilterSiteProvince
            // 
            cboFilterSiteProvince.Anchor = AnchorStyles.Top;
            cboFilterSiteProvince.BackColor = Color.White;
            cboFilterSiteProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterSiteProvince.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboFilterSiteProvince.FormattingEnabled = true;
            cboFilterSiteProvince.Location = new Point(462, 17);
            cboFilterSiteProvince.Name = "cboFilterSiteProvince";
            cboFilterSiteProvince.Size = new Size(243, 31);
            cboFilterSiteProvince.TabIndex = 51;
            // 
            // btnSearchSites
            // 
            btnSearchSites.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchSites.BackColor = Color.OrangeRed;
            btnSearchSites.Cursor = Cursors.Hand;
            btnSearchSites.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchSites.ForeColor = Color.White;
            btnSearchSites.Location = new Point(1084, 12);
            btnSearchSites.Name = "btnSearchSites";
            btnSearchSites.Size = new Size(160, 35);
            btnSearchSites.TabIndex = 50;
            btnSearchSites.Text = "SEARCH";
            btnSearchSites.UseVisualStyleBackColor = false;
            btnSearchSites.Click += btnSearchSites_Click;
            // 
            // txtSearchSites
            // 
            txtSearchSites.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchSites.BackColor = Color.White;
            txtSearchSites.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchSites.Location = new Point(711, 17);
            txtSearchSites.Name = "txtSearchSites";
            txtSearchSites.PlaceholderText = "Search ID or Name";
            txtSearchSites.Size = new Size(367, 30);
            txtSearchSites.TabIndex = 49;
            // 
            // btnEditSite
            // 
            btnEditSite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditSite.BackColor = Color.OrangeRed;
            btnEditSite.Cursor = Cursors.Hand;
            btnEditSite.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditSite.ForeColor = Color.White;
            btnEditSite.Location = new Point(1076, 643);
            btnEditSite.Name = "btnEditSite";
            btnEditSite.Size = new Size(169, 38);
            btnEditSite.TabIndex = 47;
            btnEditSite.Text = "EDIT";
            btnEditSite.UseVisualStyleBackColor = false;
            btnEditSite.Click += btnEditSite_Click;
            // 
            // dgvSites
            // 
            dgvSites.AllowUserToAddRows = false;
            dgvSites.AllowUserToDeleteRows = false;
            dgvSites.AllowUserToResizeColumns = false;
            dgvSites.AllowUserToResizeRows = false;
            dgvSites.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSites.BackgroundColor = Color.White;
            dgvSites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSites.Location = new Point(36, 58);
            dgvSites.MultiSelect = false;
            dgvSites.Name = "dgvSites";
            dgvSites.ReadOnly = true;
            dgvSites.RowHeadersVisible = false;
            dgvSites.RowHeadersWidth = 51;
            dgvSites.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSites.RowTemplate.Height = 40;
            dgvSites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSites.Size = new Size(1207, 572);
            dgvSites.TabIndex = 46;
            dgvSites.CellFormatting += dgvSites_CellFormatting;
            // 
            // btnAddSite
            // 
            btnAddSite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddSite.BackColor = Color.OrangeRed;
            btnAddSite.Cursor = Cursors.Hand;
            btnAddSite.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSite.ForeColor = Color.White;
            btnAddSite.Location = new Point(901, 643);
            btnAddSite.Name = "btnAddSite";
            btnAddSite.Size = new Size(169, 38);
            btnAddSite.TabIndex = 45;
            btnAddSite.Text = "ADD";
            btnAddSite.UseVisualStyleBackColor = false;
            btnAddSite.Click += btnAddSite_Click;
            // 
            // tabEmployees
            // 
            tabEmployees.Controls.Add(cboSearchEmpLocations);
            tabEmployees.Controls.Add(cboSearchEmpPosition);
            tabEmployees.Controls.Add(btnSearchEmp);
            tabEmployees.Controls.Add(txtSearchEmp);
            tabEmployees.Controls.Add(btnDeleteEmp);
            tabEmployees.Controls.Add(btnEditEmp);
            tabEmployees.Controls.Add(dgvEmployees);
            tabEmployees.Controls.Add(btnAddEmp);
            tabEmployees.Location = new Point(4, 26);
            tabEmployees.Name = "tabEmployees";
            tabEmployees.Padding = new Padding(3);
            tabEmployees.Size = new Size(1280, 689);
            tabEmployees.TabIndex = 0;
            tabEmployees.Text = "Employees";
            tabEmployees.UseVisualStyleBackColor = true;
            // 
            // cboSearchEmpLocations
            // 
            cboSearchEmpLocations.Anchor = AnchorStyles.Top;
            cboSearchEmpLocations.BackColor = Color.White;
            cboSearchEmpLocations.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSearchEmpLocations.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboSearchEmpLocations.FormattingEnabled = true;
            cboSearchEmpLocations.Location = new Point(212, 15);
            cboSearchEmpLocations.Name = "cboSearchEmpLocations";
            cboSearchEmpLocations.Size = new Size(243, 31);
            cboSearchEmpLocations.TabIndex = 44;
            // 
            // cboSearchEmpPosition
            // 
            cboSearchEmpPosition.Anchor = AnchorStyles.Top;
            cboSearchEmpPosition.BackColor = Color.White;
            cboSearchEmpPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSearchEmpPosition.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboSearchEmpPosition.FormattingEnabled = true;
            cboSearchEmpPosition.Location = new Point(461, 15);
            cboSearchEmpPosition.Name = "cboSearchEmpPosition";
            cboSearchEmpPosition.Size = new Size(243, 31);
            cboSearchEmpPosition.TabIndex = 43;
            // 
            // btnSearchEmp
            // 
            btnSearchEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchEmp.BackColor = Color.OrangeRed;
            btnSearchEmp.Cursor = Cursors.Hand;
            btnSearchEmp.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchEmp.ForeColor = Color.White;
            btnSearchEmp.Location = new Point(1083, 10);
            btnSearchEmp.Name = "btnSearchEmp";
            btnSearchEmp.Size = new Size(160, 35);
            btnSearchEmp.TabIndex = 39;
            btnSearchEmp.Text = "SEARCH";
            btnSearchEmp.UseVisualStyleBackColor = false;
            btnSearchEmp.Click += btnSearchEmp_Click;
            // 
            // txtSearchEmp
            // 
            txtSearchEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchEmp.BackColor = Color.White;
            txtSearchEmp.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchEmp.Location = new Point(710, 15);
            txtSearchEmp.Name = "txtSearchEmp";
            txtSearchEmp.PlaceholderText = "Search ID or Name";
            txtSearchEmp.Size = new Size(367, 30);
            txtSearchEmp.TabIndex = 38;
            // 
            // btnDeleteEmp
            // 
            btnDeleteEmp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteEmp.BackColor = Color.OrangeRed;
            btnDeleteEmp.Cursor = Cursors.Hand;
            btnDeleteEmp.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteEmp.ForeColor = Color.White;
            btnDeleteEmp.Location = new Point(1074, 638);
            btnDeleteEmp.Name = "btnDeleteEmp";
            btnDeleteEmp.Size = new Size(169, 38);
            btnDeleteEmp.TabIndex = 11;
            btnDeleteEmp.Text = "DELETE";
            btnDeleteEmp.UseVisualStyleBackColor = false;
            btnDeleteEmp.Click += btnDeleteEmp_Click;
            // 
            // btnEditEmp
            // 
            btnEditEmp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditEmp.BackColor = Color.OrangeRed;
            btnEditEmp.Cursor = Cursors.Hand;
            btnEditEmp.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditEmp.ForeColor = Color.White;
            btnEditEmp.Location = new Point(899, 638);
            btnEditEmp.Name = "btnEditEmp";
            btnEditEmp.Size = new Size(169, 38);
            btnEditEmp.TabIndex = 10;
            btnEditEmp.Text = "EDIT";
            btnEditEmp.UseVisualStyleBackColor = false;
            btnEditEmp.Click += btnEditEmp_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeColumns = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(35, 56);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEmployees.RowTemplate.Height = 40;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1207, 569);
            dgvEmployees.TabIndex = 8;
            dgvEmployees.CellFormatting += dgvEmployees_CellFormatting;
            // 
            // btnAddEmp
            // 
            btnAddEmp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddEmp.BackColor = Color.OrangeRed;
            btnAddEmp.Cursor = Cursors.Hand;
            btnAddEmp.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEmp.ForeColor = Color.White;
            btnAddEmp.Location = new Point(724, 638);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(169, 38);
            btnAddEmp.TabIndex = 7;
            btnAddEmp.Text = "ADD";
            btnAddEmp.UseVisualStyleBackColor = false;
            btnAddEmp.Click += btnAddEmployee_Click;
            // 
            // tbcMainScreen
            // 
            tbcMainScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbcMainScreen.Controls.Add(tabEmployees);
            tbcMainScreen.Controls.Add(tabLocations);
            tbcMainScreen.Controls.Add(tabInventory);
            tbcMainScreen.Controls.Add(tabSuppliers);
            tbcMainScreen.Controls.Add(tabPermissions);
            tbcMainScreen.Controls.Add(tabPOSLink);
            tbcMainScreen.Controls.Add(tabReports);
            tbcMainScreen.Controls.Add(tabStoreOrder);
            tbcMainScreen.Controls.Add(tabEmergencyOrder);
            tbcMainScreen.Controls.Add(tabLossReturn);
            tbcMainScreen.Controls.Add(tabSupplierOrder);
            tbcMainScreen.Controls.Add(tabShipReceipts);
            tbcMainScreen.Controls.Add(tabDelivery);
            tbcMainScreen.Controls.Add(tabItems);
            tbcMainScreen.Location = new Point(65, 76);
            tbcMainScreen.Name = "tbcMainScreen";
            tbcMainScreen.SelectedIndex = 0;
            tbcMainScreen.Size = new Size(1288, 719);
            tbcMainScreen.TabIndex = 14;
            tbcMainScreen.SelectedIndexChanged += tbcMainScreen_SelectedIndexChanged;
            // 
            // tabItems
            // 
            tabItems.BackColor = Color.Transparent;
            tabItems.Controls.Add(btnSearchItem);
            tabItems.Controls.Add(txtSearchItem);
            tabItems.Controls.Add(grpItemView);
            tabItems.Controls.Add(btnDeleteItem);
            tabItems.Controls.Add(btnEditItem);
            tabItems.Controls.Add(dgvItems);
            tabItems.Location = new Point(4, 26);
            tabItems.Name = "tabItems";
            tabItems.Padding = new Padding(3);
            tabItems.Size = new Size(1280, 689);
            tabItems.TabIndex = 13;
            tabItems.Text = "Items";
            // 
            // btnSearchItem
            // 
            btnSearchItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchItem.BackColor = Color.OrangeRed;
            btnSearchItem.Cursor = Cursors.Hand;
            btnSearchItem.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchItem.ForeColor = Color.White;
            btnSearchItem.Location = new Point(1097, 13);
            btnSearchItem.Name = "btnSearchItem";
            btnSearchItem.Size = new Size(160, 35);
            btnSearchItem.TabIndex = 37;
            btnSearchItem.Text = "SEARCH";
            btnSearchItem.UseVisualStyleBackColor = false;
            btnSearchItem.Click += btnSearchItem_Click;
            // 
            // txtSearchItem
            // 
            txtSearchItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchItem.Location = new Point(724, 18);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.PlaceholderText = "Search ID or Name";
            txtSearchItem.Size = new Size(367, 30);
            txtSearchItem.TabIndex = 36;
            // 
            // grpItemView
            // 
            grpItemView.Controls.Add(chkItemActive);
            grpItemView.Controls.Add(btnCancelItem);
            grpItemView.Controls.Add(btnSaveItem);
            grpItemView.Controls.Add(btnRemoveItemImg);
            grpItemView.Controls.Add(btnUpdateItemImg);
            grpItemView.Controls.Add(label11);
            grpItemView.Controls.Add(txtItemNotes);
            grpItemView.Controls.Add(txtItemCost);
            grpItemView.Controls.Add(txtItemWeight);
            grpItemView.Controls.Add(txtItemRetail);
            grpItemView.Controls.Add(txtItemSKU);
            grpItemView.Controls.Add(label10);
            grpItemView.Controls.Add(label9);
            grpItemView.Controls.Add(label8);
            grpItemView.Controls.Add(label7);
            grpItemView.Controls.Add(cboItemSupplier);
            grpItemView.Controls.Add(label6);
            grpItemView.Controls.Add(cboItemCategory);
            grpItemView.Controls.Add(label5);
            grpItemView.Controls.Add(label3);
            grpItemView.Controls.Add(label4);
            grpItemView.Controls.Add(txtItemName);
            grpItemView.Controls.Add(label2);
            grpItemView.Controls.Add(txtItemID);
            grpItemView.Controls.Add(label1);
            grpItemView.Controls.Add(picItem);
            grpItemView.Controls.Add(txtItemDescription);
            grpItemView.Controls.Add(txtItemSize);
            grpItemView.Location = new Point(21, 17);
            grpItemView.Name = "grpItemView";
            grpItemView.Size = new Size(694, 608);
            grpItemView.TabIndex = 15;
            grpItemView.TabStop = false;
            grpItemView.Visible = false;
            // 
            // chkItemActive
            // 
            chkItemActive.AutoSize = true;
            chkItemActive.Location = new Point(619, 19);
            chkItemActive.Name = "chkItemActive";
            chkItemActive.Size = new Size(69, 21);
            chkItemActive.TabIndex = 35;
            chkItemActive.Text = "Active";
            chkItemActive.UseVisualStyleBackColor = true;
            // 
            // btnCancelItem
            // 
            btnCancelItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelItem.BackColor = Color.OrangeRed;
            btnCancelItem.Cursor = Cursors.Hand;
            btnCancelItem.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelItem.ForeColor = Color.White;
            btnCancelItem.Location = new Point(519, 555);
            btnCancelItem.Name = "btnCancelItem";
            btnCancelItem.Size = new Size(169, 38);
            btnCancelItem.TabIndex = 34;
            btnCancelItem.Text = "CANCEL";
            btnCancelItem.UseVisualStyleBackColor = false;
            btnCancelItem.Click += btnCancelItem_Click;
            // 
            // btnSaveItem
            // 
            btnSaveItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveItem.BackColor = Color.OrangeRed;
            btnSaveItem.Cursor = Cursors.Hand;
            btnSaveItem.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveItem.ForeColor = Color.White;
            btnSaveItem.Location = new Point(519, 511);
            btnSaveItem.Name = "btnSaveItem";
            btnSaveItem.Size = new Size(169, 38);
            btnSaveItem.TabIndex = 33;
            btnSaveItem.Text = "SAVE";
            btnSaveItem.UseVisualStyleBackColor = false;
            btnSaveItem.Click += btnSaveItem_Click;
            // 
            // btnRemoveItemImg
            // 
            btnRemoveItemImg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveItemImg.BackColor = Color.OrangeRed;
            btnRemoveItemImg.Cursor = Cursors.Hand;
            btnRemoveItemImg.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveItemImg.ForeColor = Color.White;
            btnRemoveItemImg.Location = new Point(209, 371);
            btnRemoveItemImg.Name = "btnRemoveItemImg";
            btnRemoveItemImg.Size = new Size(169, 32);
            btnRemoveItemImg.TabIndex = 32;
            btnRemoveItemImg.Text = "REMOVE IMAGE";
            btnRemoveItemImg.UseVisualStyleBackColor = false;
            btnRemoveItemImg.Click += btnRemoveItemImg_Click;
            // 
            // btnUpdateItemImg
            // 
            btnUpdateItemImg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateItemImg.BackColor = Color.OrangeRed;
            btnUpdateItemImg.Cursor = Cursors.Hand;
            btnUpdateItemImg.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateItemImg.ForeColor = Color.White;
            btnUpdateItemImg.Location = new Point(18, 371);
            btnUpdateItemImg.Name = "btnUpdateItemImg";
            btnUpdateItemImg.Size = new Size(169, 32);
            btnUpdateItemImg.TabIndex = 16;
            btnUpdateItemImg.Text = "UPDATE IMAGE";
            btnUpdateItemImg.UseVisualStyleBackColor = false;
            btnUpdateItemImg.Click += btnUpdateItemImg_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(18, 500);
            label11.Name = "label11";
            label11.Size = new Size(50, 18);
            label11.TabIndex = 30;
            label11.Text = "Notes";
            // 
            // txtItemNotes
            // 
            txtItemNotes.BorderStyle = BorderStyle.FixedSingle;
            txtItemNotes.Location = new Point(18, 523);
            txtItemNotes.Name = "txtItemNotes";
            txtItemNotes.Size = new Size(360, 70);
            txtItemNotes.TabIndex = 31;
            txtItemNotes.Text = "";
            // 
            // txtItemCost
            // 
            txtItemCost.Enabled = false;
            txtItemCost.Location = new Point(399, 456);
            txtItemCost.Name = "txtItemCost";
            txtItemCost.Size = new Size(132, 25);
            txtItemCost.TabIndex = 29;
            // 
            // txtItemWeight
            // 
            txtItemWeight.Enabled = false;
            txtItemWeight.Location = new Point(399, 378);
            txtItemWeight.Name = "txtItemWeight";
            txtItemWeight.Size = new Size(132, 25);
            txtItemWeight.TabIndex = 28;
            // 
            // txtItemRetail
            // 
            txtItemRetail.Enabled = false;
            txtItemRetail.Location = new Point(544, 456);
            txtItemRetail.Name = "txtItemRetail";
            txtItemRetail.Size = new Size(132, 25);
            txtItemRetail.TabIndex = 27;
            // 
            // txtItemSKU
            // 
            txtItemSKU.Enabled = false;
            txtItemSKU.Location = new Point(399, 111);
            txtItemSKU.Name = "txtItemSKU";
            txtItemSKU.Size = new Size(132, 25);
            txtItemSKU.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(544, 433);
            label10.Name = "label10";
            label10.Size = new Size(90, 18);
            label10.TabIndex = 23;
            label10.Text = "Retail Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(399, 433);
            label9.Name = "label9";
            label9.Size = new Size(82, 18);
            label9.TabIndex = 21;
            label9.Text = "Cost Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(544, 357);
            label8.Name = "label8";
            label8.Size = new Size(79, 18);
            label8.TabIndex = 19;
            label8.Text = "Case Size";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(399, 357);
            label7.Name = "label7";
            label7.Size = new Size(57, 18);
            label7.TabIndex = 17;
            label7.Text = "Weight";
            // 
            // cboItemSupplier
            // 
            cboItemSupplier.Enabled = false;
            cboItemSupplier.FormattingEnabled = true;
            cboItemSupplier.Location = new Point(220, 456);
            cboItemSupplier.Name = "cboItemSupplier";
            cboItemSupplier.Size = new Size(158, 25);
            cboItemSupplier.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(220, 435);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 15;
            label6.Text = "Supplier";
            // 
            // cboItemCategory
            // 
            cboItemCategory.Enabled = false;
            cboItemCategory.FormattingEnabled = true;
            cboItemCategory.Location = new Point(18, 456);
            cboItemCategory.Name = "cboItemCategory";
            cboItemCategory.Size = new Size(182, 25);
            cboItemCategory.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 435);
            label5.Name = "label5";
            label5.Size = new Size(72, 18);
            label5.TabIndex = 12;
            label5.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(399, 230);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 9;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(399, 90);
            label4.Name = "label4";
            label4.Size = new Size(40, 18);
            label4.TabIndex = 7;
            label4.Text = "SKU";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(399, 181);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(277, 25);
            txtItemName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(399, 160);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtItemID
            // 
            txtItemID.Enabled = false;
            txtItemID.Location = new Point(399, 41);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(132, 25);
            txtItemID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(399, 20);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 1;
            label1.Text = "Item ID";
            // 
            // picItem
            // 
            picItem.BackColor = Color.White;
            picItem.BorderStyle = BorderStyle.FixedSingle;
            picItem.ErrorImage = Properties.Resources.NoImage;
            picItem.Image = Properties.Resources.NoImage;
            picItem.Location = new Point(18, 20);
            picItem.Name = "picItem";
            picItem.Size = new Size(360, 345);
            picItem.SizeMode = PictureBoxSizeMode.Zoom;
            picItem.TabIndex = 0;
            picItem.TabStop = false;
            // 
            // txtItemDescription
            // 
            txtItemDescription.BorderStyle = BorderStyle.FixedSingle;
            txtItemDescription.Location = new Point(399, 251);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(277, 70);
            txtItemDescription.TabIndex = 11;
            txtItemDescription.Text = "";
            // 
            // txtItemSize
            // 
            txtItemSize.Enabled = false;
            txtItemSize.Location = new Point(544, 378);
            txtItemSize.Name = "txtItemSize";
            txtItemSize.Size = new Size(132, 25);
            txtItemSize.TabIndex = 26;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteItem.BackColor = Color.OrangeRed;
            btnDeleteItem.Cursor = Cursors.Hand;
            btnDeleteItem.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteItem.ForeColor = Color.White;
            btnDeleteItem.Location = new Point(1088, 640);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(169, 38);
            btnDeleteItem.TabIndex = 14;
            btnDeleteItem.Text = "DELETE";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditItem.BackColor = Color.OrangeRed;
            btnEditItem.Cursor = Cursors.Hand;
            btnEditItem.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditItem.ForeColor = Color.White;
            btnEditItem.Location = new Point(913, 640);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(169, 38);
            btnEditItem.TabIndex = 13;
            btnEditItem.Text = "EDIT";
            btnEditItem.UseVisualStyleBackColor = false;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(724, 50);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvItems.RowTemplate.Height = 40;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(533, 578);
            dgvItems.TabIndex = 10;
            dgvItems.CellFormatting += dgvItems_CellFormatting;
            // 
            // picLogout
            // 
            picLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picLogout.Cursor = Cursors.Hand;
            picLogout.Image = Properties.Resources.logout;
            picLogout.Location = new Point(1382, 12);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(30, 30);
            picLogout.SizeMode = PictureBoxSizeMode.Zoom;
            picLogout.TabIndex = 17;
            picLogout.TabStop = false;
            picLogout.Click += picLogout_Click;
            // 
            // picHelp
            // 
            picHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHelp.Cursor = Cursors.Hand;
            picHelp.Image = Properties.Resources.help;
            picHelp.Location = new Point(1331, 12);
            picHelp.Name = "picHelp";
            picHelp.Size = new Size(30, 30);
            picHelp.SizeMode = PictureBoxSizeMode.Zoom;
            picHelp.TabIndex = 18;
            picHelp.TabStop = false;
            picHelp.Click += picHelp_Click;
            // 
            // picRefresh
            // 
            picRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRefresh.Cursor = Cursors.Hand;
            picRefresh.Image = Properties.Resources.refresh;
            picRefresh.Location = new Point(1280, 12);
            picRefresh.Name = "picRefresh";
            picRefresh.Size = new Size(31, 31);
            picRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            picRefresh.TabIndex = 19;
            picRefresh.TabStop = false;
            picRefresh.Tag = "Refresh";
            picRefresh.Click += picRefresh_Click;
            // 
            // ofdItemImage
            // 
            ofdItemImage.FileName = "openFileDialog1";
            ofdItemImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofdItemImage.Title = "Select an Item Image";
            // 
            // grpAcceptOrder
            // 
            grpAcceptOrder.BackColor = Color.Transparent;
            grpAcceptOrder.Controls.Add(btnExitAccept);
            grpAcceptOrder.Controls.Add(btnAccept);
            grpAcceptOrder.Controls.Add(dgvAcceptOrder);
            grpAcceptOrder.Location = new Point(65, 158);
            grpAcceptOrder.Name = "grpAcceptOrder";
            grpAcceptOrder.Size = new Size(1288, 627);
            grpAcceptOrder.TabIndex = 65;
            grpAcceptOrder.TabStop = false;
            grpAcceptOrder.Visible = false;
            // 
            // btnExitAccept
            // 
            btnExitAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExitAccept.BackColor = Color.OrangeRed;
            btnExitAccept.Cursor = Cursors.Hand;
            btnExitAccept.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExitAccept.ForeColor = Color.White;
            btnExitAccept.Location = new Point(1037, 576);
            btnExitAccept.Name = "btnExitAccept";
            btnExitAccept.Size = new Size(206, 38);
            btnExitAccept.TabIndex = 63;
            btnExitAccept.Text = "EXIT";
            btnExitAccept.UseVisualStyleBackColor = false;
            btnExitAccept.Click += btnExitAccept_Click;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAccept.BackColor = Color.OrangeRed;
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(825, 576);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(206, 38);
            btnAccept.TabIndex = 62;
            btnAccept.Text = "ACCEPT";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // dgvAcceptOrder
            // 
            dgvAcceptOrder.AllowUserToAddRows = false;
            dgvAcceptOrder.AllowUserToDeleteRows = false;
            dgvAcceptOrder.AllowUserToResizeColumns = false;
            dgvAcceptOrder.AllowUserToResizeRows = false;
            dgvAcceptOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAcceptOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAcceptOrder.BackgroundColor = Color.White;
            dgvAcceptOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcceptOrder.Columns.AddRange(new DataGridViewColumn[] { ID, itemName, quantityOrdered, quantityAvailable });
            dgvAcceptOrder.Location = new Point(36, 20);
            dgvAcceptOrder.MultiSelect = false;
            dgvAcceptOrder.Name = "dgvAcceptOrder";
            dgvAcceptOrder.ReadOnly = true;
            dgvAcceptOrder.RowHeadersVisible = false;
            dgvAcceptOrder.RowHeadersWidth = 51;
            dgvAcceptOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAcceptOrder.RowTemplate.Height = 40;
            dgvAcceptOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcceptOrder.Size = new Size(1207, 549);
            dgvAcceptOrder.TabIndex = 64;
            // 
            // ID
            // 
            ID.HeaderText = "Item ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // itemName
            // 
            itemName.HeaderText = "Name";
            itemName.MinimumWidth = 6;
            itemName.Name = "itemName";
            itemName.ReadOnly = true;
            // 
            // quantityOrdered
            // 
            quantityOrdered.HeaderText = "Quantity";
            quantityOrdered.MinimumWidth = 6;
            quantityOrdered.Name = "quantityOrdered";
            quantityOrdered.ReadOnly = true;
            // 
            // quantityAvailable
            // 
            quantityAvailable.HeaderText = "Available";
            quantityAvailable.MinimumWidth = 6;
            quantityAvailable.Name = "quantityAvailable";
            quantityAvailable.ReadOnly = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1424, 841);
            Controls.Add(picRefresh);
            Controls.Add(picHelp);
            Controls.Add(picLogout);
            Controls.Add(lblEmpLocation);
            Controls.Add(lblEmpUsername);
            Controls.Add(tbcMainScreen);
            Controls.Add(pictureBox2);
            Controls.Add(grpAcceptOrder);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bullseye - Dashboard";
            FormClosing += frmDashboard_FormClosing;
            FormClosed += frmDashboard_FormClosed;
            Load += frmDashboard_Load;
            SizeChanged += frmDashboard_SizeChanged;
            KeyDown += frmDashboard_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabStoreOrder.ResumeLayout(false);
            tabStoreOrder.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStoreOrders).EndInit();
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            tabLocations.ResumeLayout(false);
            tabLocations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSites).EndInit();
            tabEmployees.ResumeLayout(false);
            tabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            tbcMainScreen.ResumeLayout(false);
            tabItems.ResumeLayout(false);
            tabItems.PerformLayout();
            grpItemView.ResumeLayout(false);
            grpItemView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRefresh).EndInit();
            grpAcceptOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAcceptOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label lblEmpUsername;
        private Label lblEmpLocation;
        private TabPage tabDelivery;
        private TabPage tabShipReceipts;
        private TabPage tabSupplierOrder;
        private TabPage tabLossReturn;
        private TabPage tabEmergencyOrder;
        private TabPage tabStoreOrder;
        private TabPage tabReports;
        private TabPage tabPOSLink;
        private TabPage tabPermissions;
        private TabPage tabSuppliers;
        private TabPage tabInventory;
        private TabPage tabLocations;
        private TabPage tabEmployees;
        private TabControl tbcMainScreen;
        private PictureBox picLogout;
        private PictureBox picHelp;
        private PictureBox picRefresh;
        private Button btnAddEmp;
        private DataGridView dgvEmployees;
        private Button btnDeleteEmp;
        private Button btnEditEmp;
        private Label label4;
        private TabPage tabItems;
        private DataGridView dgvItems;
        private Button btnDeleteItem;
        private Button btnEditItem;
        private GroupBox grpItemView;
        private PictureBox picItem;
        private Label label3;
        private TextBox txtItemName;
        private Label label2;
        private TextBox txtItemID;
        private Label label1;
        private RichTextBox txtItemDescription;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cboItemSupplier;
        private Label label6;
        private ComboBox cboItemCategory;
        private TextBox txtItemCost;
        private TextBox txtItemWeight;
        private TextBox txtItemRetail;
        private TextBox txtItemSKU;
        private TextBox txtItemSize;
        private Button btnUpdateItemImg;
        private Label label11;
        private RichTextBox txtItemNotes;
        private Button btnRemoveItemImg;
        private Button btnCancelItem;
        private Button btnSaveItem;
        private OpenFileDialog ofdItemImage;
        private SaveFileDialog sfdItemImage;
        private CheckBox chkItemActive;
        private TextBox txtSearchItem;
        private Button btnSearchItem;
        private Button btnSearchEmp;
        private TextBox txtSearchEmp;
        private ComboBox cboSearchEmpLocations;
        private ComboBox cboSearchEmpPosition;
        private ComboBox cboFilterSiteDay;
        private ComboBox cboFilterSiteProvince;
        private Button btnSearchSites;
        private TextBox txtSearchSites;
        private Button btnEditSite;
        private DataGridView dgvSites;
        private Button btnAddSite;
        private ComboBox cboFilterLocation;
        private ComboBox cboFilterStatus;
        private Button btnSearchOrders;
        private Button btnEditOrder;
        private DataGridView dgvStoreOrders;
        private Button btnCreateOrder;
        private CheckBox chkClosedOrders;
        private DateTimePicker dtpOrderStart;
        private DateTimePicker dtpOrderEnd;
        private Button btnRecieveOrder;
        private Button btnSubmitOrder;
        private GroupBox groupBox1;
        private RadioButton radEmergency;
        private RadioButton radRegular;
        private Button btnFulfillOrder;
        private Button btnEditBackOrder;
        private Button btnCreateBackOrder;
        private Button btnAcceptOrder;
        private GroupBox grpAcceptOrder;
        private DataGridView dgvAcceptOrder;
        private Button btnExitAccept;
        private Button btnAccept;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn quantityOrdered;
        private DataGridViewTextBoxColumn quantityAvailable;
        private Button btnSearchInventory;
        private TextBox txtSearchInventory;
        private Button btnEditInventory;
        private DataGridView dgvInventory;
    }
}