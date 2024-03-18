namespace ISDP_Cosman_Dallas
{
    partial class frmStoreOrder
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
            txtOrderID = new TextBox();
            lblEmpID = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            cboDispatchLocation = new ComboBox();
            cboOrderLocation = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtOrderType = new TextBox();
            label3 = new Label();
            dtpOrderShipDate = new DateTimePicker();
            txtEmployee = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSearchOrder = new Button();
            txtSearchOrder = new TextBox();
            label14 = new Label();
            dgvSiteInventory = new DataGridView();
            itemID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            optimumThreshold = new DataGridViewTextBoxColumn();
            reorderThreshold = new DataGridViewTextBoxColumn();
            itemQuantity = new DataGridViewTextBoxColumn();
            dgvDispatchInventory = new DataGridView();
            groupBox3 = new GroupBox();
            picRefreshDispatch = new PictureBox();
            btnSearchDispatch = new Button();
            label7 = new Label();
            numQuantity = new NumericUpDown();
            btnAddToOrder = new Button();
            txtSearchDispatch = new TextBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            btnSubmitOrder = new Button();
            btnCancelOrder = new Button();
            groupBox5 = new GroupBox();
            txtItemReorder = new TextBox();
            label13 = new Label();
            lblItemName = new Label();
            numItemQuantity = new NumericUpDown();
            picRemoveInventory = new PictureBox();
            picConfirmInventory = new PictureBox();
            txtItemName = new TextBox();
            label12 = new Label();
            txtItemStock = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtItemThreshold = new TextBox();
            label9 = new Label();
            txtItemID = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiteInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDispatchInventory).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRefreshDispatch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numItemQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRemoveInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picConfirmInventory).BeginInit();
            SuspendLayout();
            // 
            // txtOrderID
            // 
            txtOrderID.Anchor = AnchorStyles.None;
            txtOrderID.BackColor = Color.White;
            txtOrderID.BorderStyle = BorderStyle.FixedSingle;
            txtOrderID.Enabled = false;
            txtOrderID.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderID.Location = new Point(58, 35);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(121, 24);
            txtOrderID.TabIndex = 43;
            // 
            // lblEmpID
            // 
            lblEmpID.Anchor = AnchorStyles.None;
            lblEmpID.AutoSize = true;
            lblEmpID.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpID.Location = new Point(58, 17);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(50, 15);
            lblEmpID.TabIndex = 42;
            lblEmpID.Text = "Order #";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(cboDispatchLocation);
            groupBox1.Controls.Add(cboOrderLocation);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtOrderType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpOrderShipDate);
            groupBox1.Controls.Add(txtEmployee);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtOrderID);
            groupBox1.Controls.Add(lblEmpID);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 125);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bullseye;
            pictureBox1.Location = new Point(4, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // cboDispatchLocation
            // 
            cboDispatchLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDispatchLocation.Enabled = false;
            cboDispatchLocation.FormattingEnabled = true;
            cboDispatchLocation.Location = new Point(224, 90);
            cboDispatchLocation.Name = "cboDispatchLocation";
            cboDispatchLocation.Size = new Size(196, 23);
            cboDispatchLocation.TabIndex = 55;
            // 
            // cboOrderLocation
            // 
            cboOrderLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrderLocation.Enabled = false;
            cboOrderLocation.FormattingEnabled = true;
            cboOrderLocation.Location = new Point(22, 90);
            cboOrderLocation.Name = "cboOrderLocation";
            cboOrderLocation.Size = new Size(196, 23);
            cboOrderLocation.TabIndex = 54;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(426, 71);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 53;
            label5.Text = "Ship Date";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(224, 72);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 51;
            label4.Text = "Dispatch Location";
            // 
            // txtOrderType
            // 
            txtOrderType.Anchor = AnchorStyles.None;
            txtOrderType.BackColor = Color.White;
            txtOrderType.BorderStyle = BorderStyle.FixedSingle;
            txtOrderType.Enabled = false;
            txtOrderType.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderType.Location = new Point(185, 35);
            txtOrderType.Name = "txtOrderType";
            txtOrderType.ReadOnly = true;
            txtOrderType.Size = new Size(183, 24);
            txtOrderType.TabIndex = 50;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(185, 17);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 49;
            label3.Text = "Order Type";
            // 
            // dtpOrderShipDate
            // 
            dtpOrderShipDate.Anchor = AnchorStyles.None;
            dtpOrderShipDate.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpOrderShipDate.Location = new Point(426, 89);
            dtpOrderShipDate.Name = "dtpOrderShipDate";
            dtpOrderShipDate.Size = new Size(162, 24);
            dtpOrderShipDate.TabIndex = 48;
            // 
            // txtEmployee
            // 
            txtEmployee.Anchor = AnchorStyles.None;
            txtEmployee.BackColor = Color.White;
            txtEmployee.BorderStyle = BorderStyle.FixedSingle;
            txtEmployee.Enabled = false;
            txtEmployee.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployee.Location = new Point(374, 35);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.ReadOnly = true;
            txtEmployee.Size = new Size(214, 24);
            txtEmployee.TabIndex = 47;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(374, 17);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 46;
            label2.Text = "Employee";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 72);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 44;
            label1.Text = "Location";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearchOrder);
            groupBox2.Controls.Add(txtSearchOrder);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(dgvSiteInventory);
            groupBox2.Location = new Point(12, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(616, 540);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            // 
            // btnSearchOrder
            // 
            btnSearchOrder.Anchor = AnchorStyles.None;
            btnSearchOrder.BackColor = Color.OrangeRed;
            btnSearchOrder.Cursor = Cursors.Hand;
            btnSearchOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchOrder.ForeColor = Color.White;
            btnSearchOrder.Location = new Point(253, 17);
            btnSearchOrder.Name = "btnSearchOrder";
            btnSearchOrder.Size = new Size(179, 33);
            btnSearchOrder.TabIndex = 64;
            btnSearchOrder.Text = "SEARCH";
            btnSearchOrder.UseVisualStyleBackColor = false;
            btnSearchOrder.Click += btnSearchOrder_Click;
            // 
            // txtSearchOrder
            // 
            txtSearchOrder.Anchor = AnchorStyles.None;
            txtSearchOrder.BackColor = Color.White;
            txtSearchOrder.BorderStyle = BorderStyle.FixedSingle;
            txtSearchOrder.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchOrder.Location = new Point(6, 20);
            txtSearchOrder.Name = "txtSearchOrder";
            txtSearchOrder.PlaceholderText = "Search ID or Name";
            txtSearchOrder.Size = new Size(241, 27);
            txtSearchOrder.TabIndex = 63;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(6, 2);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 62;
            label14.Text = "Search Order";
            // 
            // dgvSiteInventory
            // 
            dgvSiteInventory.AllowUserToAddRows = false;
            dgvSiteInventory.AllowUserToDeleteRows = false;
            dgvSiteInventory.AllowUserToResizeColumns = false;
            dgvSiteInventory.AllowUserToResizeRows = false;
            dgvSiteInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvSiteInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSiteInventory.BackgroundColor = Color.White;
            dgvSiteInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiteInventory.Columns.AddRange(new DataGridViewColumn[] { itemID, name, quantity, optimumThreshold, reorderThreshold, itemQuantity });
            dgvSiteInventory.Location = new Point(6, 56);
            dgvSiteInventory.MultiSelect = false;
            dgvSiteInventory.Name = "dgvSiteInventory";
            dgvSiteInventory.ReadOnly = true;
            dgvSiteInventory.RowHeadersVisible = false;
            dgvSiteInventory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSiteInventory.RowTemplate.Height = 40;
            dgvSiteInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiteInventory.Size = new Size(604, 476);
            dgvSiteInventory.TabIndex = 48;
            dgvSiteInventory.SelectionChanged += dgvSiteInventory_SelectionChanged;
            // 
            // itemID
            // 
            itemID.HeaderText = "Item ID";
            itemID.Name = "itemID";
            itemID.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.HeaderText = "Current Stock";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // optimumThreshold
            // 
            optimumThreshold.HeaderText = "Optimum Threshold";
            optimumThreshold.Name = "optimumThreshold";
            optimumThreshold.ReadOnly = true;
            // 
            // reorderThreshold
            // 
            reorderThreshold.HeaderText = "Reorder Threshold";
            reorderThreshold.Name = "reorderThreshold";
            reorderThreshold.ReadOnly = true;
            // 
            // itemQuantity
            // 
            itemQuantity.HeaderText = "Quantity Ordered";
            itemQuantity.Name = "itemQuantity";
            itemQuantity.ReadOnly = true;
            // 
            // dgvDispatchInventory
            // 
            dgvDispatchInventory.AllowUserToAddRows = false;
            dgvDispatchInventory.AllowUserToDeleteRows = false;
            dgvDispatchInventory.AllowUserToResizeColumns = false;
            dgvDispatchInventory.AllowUserToResizeRows = false;
            dgvDispatchInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvDispatchInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDispatchInventory.BackgroundColor = Color.White;
            dgvDispatchInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDispatchInventory.Location = new Point(6, 76);
            dgvDispatchInventory.MultiSelect = false;
            dgvDispatchInventory.Name = "dgvDispatchInventory";
            dgvDispatchInventory.ReadOnly = true;
            dgvDispatchInventory.RowHeadersVisible = false;
            dgvDispatchInventory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDispatchInventory.RowTemplate.Height = 40;
            dgvDispatchInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDispatchInventory.Size = new Size(426, 540);
            dgvDispatchInventory.TabIndex = 47;
            dgvDispatchInventory.CellFormatting += dgvDispatchInventory_CellFormatting;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picRefreshDispatch);
            groupBox3.Controls.Add(btnSearchDispatch);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(numQuantity);
            groupBox3.Controls.Add(btnAddToOrder);
            groupBox3.Controls.Add(txtSearchDispatch);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dgvDispatchInventory);
            groupBox3.Location = new Point(634, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(438, 665);
            groupBox3.TabIndex = 46;
            groupBox3.TabStop = false;
            // 
            // picRefreshDispatch
            // 
            picRefreshDispatch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRefreshDispatch.Cursor = Cursors.Hand;
            picRefreshDispatch.Image = Properties.Resources.refresh;
            picRefreshDispatch.Location = new Point(407, 8);
            picRefreshDispatch.Name = "picRefreshDispatch";
            picRefreshDispatch.Size = new Size(31, 31);
            picRefreshDispatch.SizeMode = PictureBoxSizeMode.Zoom;
            picRefreshDispatch.TabIndex = 65;
            picRefreshDispatch.TabStop = false;
            picRefreshDispatch.Tag = "Refresh";
            picRefreshDispatch.Click += picRefresh_Click;
            // 
            // btnSearchDispatch
            // 
            btnSearchDispatch.Anchor = AnchorStyles.None;
            btnSearchDispatch.BackColor = Color.OrangeRed;
            btnSearchDispatch.Cursor = Cursors.Hand;
            btnSearchDispatch.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchDispatch.ForeColor = Color.White;
            btnSearchDispatch.Location = new Point(253, 40);
            btnSearchDispatch.Name = "btnSearchDispatch";
            btnSearchDispatch.Size = new Size(179, 33);
            btnSearchDispatch.TabIndex = 61;
            btnSearchDispatch.Text = "SEARCH";
            btnSearchDispatch.UseVisualStyleBackColor = false;
            btnSearchDispatch.Click += btnSearchDispatch_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 632);
            label7.Name = "label7";
            label7.Size = new Size(67, 18);
            label7.TabIndex = 60;
            label7.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numQuantity.Location = new Point(79, 625);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(125, 30);
            numQuantity.TabIndex = 59;
            numQuantity.TextAlign = HorizontalAlignment.Center;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Anchor = AnchorStyles.None;
            btnAddToOrder.BackColor = Color.OrangeRed;
            btnAddToOrder.Cursor = Cursors.Hand;
            btnAddToOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddToOrder.ForeColor = Color.White;
            btnAddToOrder.Location = new Point(210, 621);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(222, 38);
            btnAddToOrder.TabIndex = 58;
            btnAddToOrder.Text = "ADD TO ORDER";
            btnAddToOrder.UseVisualStyleBackColor = false;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // txtSearchDispatch
            // 
            txtSearchDispatch.Anchor = AnchorStyles.None;
            txtSearchDispatch.BackColor = Color.White;
            txtSearchDispatch.BorderStyle = BorderStyle.FixedSingle;
            txtSearchDispatch.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchDispatch.Location = new Point(6, 43);
            txtSearchDispatch.Name = "txtSearchDispatch";
            txtSearchDispatch.PlaceholderText = "Search ID or Name";
            txtSearchDispatch.Size = new Size(241, 27);
            txtSearchDispatch.TabIndex = 57;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 25);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 56;
            label6.Text = "Search Inventory";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSubmitOrder);
            groupBox4.Controls.Add(btnCancelOrder);
            groupBox4.Location = new Point(634, 669);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(438, 84);
            groupBox4.TabIndex = 48;
            groupBox4.TabStop = false;
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.Anchor = AnchorStyles.None;
            btnSubmitOrder.BackColor = Color.OrangeRed;
            btnSubmitOrder.Cursor = Cursors.Hand;
            btnSubmitOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmitOrder.ForeColor = Color.White;
            btnSubmitOrder.Location = new Point(14, 25);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new Size(198, 44);
            btnSubmitOrder.TabIndex = 63;
            btnSubmitOrder.Text = "CONFIRM ORDER";
            btnSubmitOrder.UseVisualStyleBackColor = false;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Anchor = AnchorStyles.None;
            btnCancelOrder.BackColor = Color.OrangeRed;
            btnCancelOrder.Cursor = Cursors.Hand;
            btnCancelOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelOrder.ForeColor = Color.White;
            btnCancelOrder.Location = new Point(226, 25);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(198, 44);
            btnCancelOrder.TabIndex = 62;
            btnCancelOrder.Text = "CANCEL ORDER";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtItemReorder);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(lblItemName);
            groupBox5.Controls.Add(numItemQuantity);
            groupBox5.Controls.Add(picRemoveInventory);
            groupBox5.Controls.Add(picConfirmInventory);
            groupBox5.Controls.Add(txtItemName);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(txtItemStock);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(txtItemThreshold);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(txtItemID);
            groupBox5.Controls.Add(label8);
            groupBox5.Location = new Point(12, 669);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(616, 84);
            groupBox5.TabIndex = 64;
            groupBox5.TabStop = false;
            // 
            // txtItemReorder
            // 
            txtItemReorder.Anchor = AnchorStyles.None;
            txtItemReorder.BackColor = Color.White;
            txtItemReorder.BorderStyle = BorderStyle.FixedSingle;
            txtItemReorder.Enabled = false;
            txtItemReorder.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemReorder.Location = new Point(384, 54);
            txtItemReorder.Name = "txtItemReorder";
            txtItemReorder.ReadOnly = true;
            txtItemReorder.Size = new Size(64, 24);
            txtItemReorder.TabIndex = 77;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(384, 21);
            label13.Name = "label13";
            label13.Size = new Size(64, 30);
            label13.TabIndex = 76;
            label13.Text = "Reorder\r\nThreshold";
            // 
            // lblItemName
            // 
            lblItemName.Anchor = AnchorStyles.None;
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemName.ForeColor = Color.Gray;
            lblItemName.Location = new Point(9, 15);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(111, 15);
            lblItemName.TabIndex = 75;
            lblItemName.Text = "Edit Inventory Item";
            // 
            // numItemQuantity
            // 
            numItemQuantity.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numItemQuantity.Location = new Point(454, 54);
            numItemQuantity.Name = "numItemQuantity";
            numItemQuantity.Size = new Size(60, 24);
            numItemQuantity.TabIndex = 74;
            // 
            // picRemoveInventory
            // 
            picRemoveInventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRemoveInventory.Cursor = Cursors.Hand;
            picRemoveInventory.Image = Properties.Resources.InventoryRemove;
            picRemoveInventory.Location = new Point(570, 29);
            picRemoveInventory.Name = "picRemoveInventory";
            picRemoveInventory.Size = new Size(40, 40);
            picRemoveInventory.SizeMode = PictureBoxSizeMode.Zoom;
            picRemoveInventory.TabIndex = 73;
            picRemoveInventory.TabStop = false;
            picRemoveInventory.Tag = "Refresh";
            picRemoveInventory.Click += picRemoveInventory_Click;
            // 
            // picConfirmInventory
            // 
            picConfirmInventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picConfirmInventory.Cursor = Cursors.Hand;
            picConfirmInventory.Image = Properties.Resources.InventoryConfirm;
            picConfirmInventory.Location = new Point(524, 29);
            picConfirmInventory.Name = "picConfirmInventory";
            picConfirmInventory.Size = new Size(40, 40);
            picConfirmInventory.SizeMode = PictureBoxSizeMode.Zoom;
            picConfirmInventory.TabIndex = 66;
            picConfirmInventory.TabStop = false;
            picConfirmInventory.Tag = "Refresh";
            picConfirmInventory.Click += picConfirmInventory_Click;
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.None;
            txtItemName.BackColor = Color.White;
            txtItemName.BorderStyle = BorderStyle.FixedSingle;
            txtItemName.Enabled = false;
            txtItemName.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemName.Location = new Point(79, 54);
            txtItemName.Name = "txtItemName";
            txtItemName.ReadOnly = true;
            txtItemName.ScrollBars = ScrollBars.Horizontal;
            txtItemName.Size = new Size(164, 24);
            txtItemName.TabIndex = 72;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(79, 36);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 71;
            label12.Text = "Name";
            // 
            // txtItemStock
            // 
            txtItemStock.Anchor = AnchorStyles.None;
            txtItemStock.BackColor = Color.White;
            txtItemStock.BorderStyle = BorderStyle.FixedSingle;
            txtItemStock.Enabled = false;
            txtItemStock.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemStock.Location = new Point(249, 54);
            txtItemStock.Name = "txtItemStock";
            txtItemStock.ReadOnly = true;
            txtItemStock.Size = new Size(59, 24);
            txtItemStock.TabIndex = 70;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(249, 21);
            label11.Name = "label11";
            label11.Size = new Size(50, 30);
            label11.TabIndex = 69;
            label11.Text = "Current\r\nStock";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(452, 36);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 67;
            label10.Text = "Quantity";
            // 
            // txtItemThreshold
            // 
            txtItemThreshold.Anchor = AnchorStyles.None;
            txtItemThreshold.BackColor = Color.White;
            txtItemThreshold.BorderStyle = BorderStyle.FixedSingle;
            txtItemThreshold.Enabled = false;
            txtItemThreshold.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemThreshold.Location = new Point(314, 54);
            txtItemThreshold.Name = "txtItemThreshold";
            txtItemThreshold.ReadOnly = true;
            txtItemThreshold.Size = new Size(64, 24);
            txtItemThreshold.TabIndex = 66;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(314, 21);
            label9.Name = "label9";
            label9.Size = new Size(64, 30);
            label9.TabIndex = 65;
            label9.Text = "Min\r\nThreshold";
            // 
            // txtItemID
            // 
            txtItemID.Anchor = AnchorStyles.None;
            txtItemID.BackColor = Color.White;
            txtItemID.BorderStyle = BorderStyle.FixedSingle;
            txtItemID.Enabled = false;
            txtItemID.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemID.Location = new Point(9, 54);
            txtItemID.Name = "txtItemID";
            txtItemID.ReadOnly = true;
            txtItemID.Size = new Size(61, 24);
            txtItemID.TabIndex = 57;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(7, 36);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 56;
            label8.Text = "Item ID";
            // 
            // frmStoreOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 761);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmStoreOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoreOrderForm";
            FormClosing += frmStoreOrder_FormClosing;
            Load += frmStoreOrder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiteInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDispatchInventory).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRefreshDispatch).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numItemQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRemoveInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)picConfirmInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtOrderID;
        private Label lblEmpID;
        private GroupBox groupBox1;
        private TextBox txtEmployee;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtOrderType;
        private Label label3;
        private DateTimePicker dtpOrderShipDate;
        private Label label5;
        private ComboBox cboDispatchLocation;
        private ComboBox cboOrderLocation;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgvDispatchInventory;
        private GroupBox groupBox4;
        private TextBox txtSearchDispatch;
        private Label label6;
        private Label label7;
        private NumericUpDown numQuantity;
        private Button btnAddToOrder;
        private Button btnSearchDispatch;
        private Button btnSubmitOrder;
        private Button btnCancelOrder;
        private GroupBox groupBox5;
        private DataGridView dgvSiteInventory;
        private PictureBox picRefreshDispatch;
        private Label label10;
        private TextBox txtItemThreshold;
        private Label label9;
        private TextBox txtItemID;
        private Label label8;
        private TextBox txtItemName;
        private Label label12;
        private TextBox txtItemStock;
        private Label label11;
        private NumericUpDown numItemQuantity;
        private PictureBox picRemoveInventory;
        private PictureBox picConfirmInventory;
        private Label lblItemName;
        private TextBox txtItemReorder;
        private Label label13;
        private Button btnSearchOrder;
        private TextBox txtSearchOrder;
        private Label label14;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn itemID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn optimumThreshold;
        private DataGridViewTextBoxColumn reorderThreshold;
        private DataGridViewTextBoxColumn itemQuantity;
    }
}