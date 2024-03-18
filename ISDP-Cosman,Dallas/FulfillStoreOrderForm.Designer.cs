namespace ISDP_Cosman_Dallas
{
    partial class frmFulfillStoreOrder
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
            btnFulfillOrder = new Button();
            btnCancelOrder = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtStatus = new TextBox();
            txtShipDate = new TextBox();
            txtDispatch = new TextBox();
            txtSite = new TextBox();
            txtEmployee = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            txtOrderType = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtOrderID = new TextBox();
            lblEmpID = new Label();
            groupBox2 = new GroupBox();
            chkFulfilled = new CheckBox();
            chkPartialFulfill = new CheckBox();
            chkUnfulfilled = new CheckBox();
            btnSearchOrder = new Button();
            txtSearchOrder = new TextBox();
            dgvOrder = new DataGridView();
            itemID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            optimumThreshold = new DataGridViewTextBoxColumn();
            reorderThreshold = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            itemQuantity = new DataGridViewTextBoxColumn();
            quantityAssigned = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            btnFulfillItem = new Button();
            txtQuantityOrdered = new TextBox();
            label15 = new Label();
            txtItemReorder = new TextBox();
            label13 = new Label();
            lblItemName = new Label();
            numQuantityAssigned = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantityAssigned).BeginInit();
            SuspendLayout();
            // 
            // btnFulfillOrder
            // 
            btnFulfillOrder.Anchor = AnchorStyles.None;
            btnFulfillOrder.BackColor = Color.OrangeRed;
            btnFulfillOrder.Cursor = Cursors.Hand;
            btnFulfillOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFulfillOrder.ForeColor = Color.White;
            btnFulfillOrder.Location = new Point(892, 663);
            btnFulfillOrder.Name = "btnFulfillOrder";
            btnFulfillOrder.Size = new Size(180, 44);
            btnFulfillOrder.TabIndex = 63;
            btnFulfillOrder.Text = "CONFIRM";
            btnFulfillOrder.UseVisualStyleBackColor = false;
            btnFulfillOrder.Click += btnFulfillOrder_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Anchor = AnchorStyles.None;
            btnCancelOrder.BackColor = Color.OrangeRed;
            btnCancelOrder.Cursor = Cursors.Hand;
            btnCancelOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelOrder.ForeColor = Color.White;
            btnCancelOrder.Location = new Point(892, 711);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(180, 44);
            btnCancelOrder.TabIndex = 62;
            btnCancelOrder.Text = "EXIT";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(txtShipDate);
            groupBox1.Controls.Add(txtDispatch);
            groupBox1.Controls.Add(txtSite);
            groupBox1.Controls.Add(txtEmployee);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtOrderType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtOrderID);
            groupBox1.Controls.Add(lblEmpID);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1060, 125);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(675, 66);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 72;
            label7.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Anchor = AnchorStyles.None;
            txtStatus.BackColor = Color.White;
            txtStatus.BorderStyle = BorderStyle.FixedSingle;
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(675, 84);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(143, 24);
            txtStatus.TabIndex = 71;
            // 
            // txtShipDate
            // 
            txtShipDate.Anchor = AnchorStyles.None;
            txtShipDate.BackColor = Color.White;
            txtShipDate.BorderStyle = BorderStyle.FixedSingle;
            txtShipDate.Enabled = false;
            txtShipDate.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipDate.Location = new Point(473, 84);
            txtShipDate.Name = "txtShipDate";
            txtShipDate.ReadOnly = true;
            txtShipDate.Size = new Size(196, 24);
            txtShipDate.TabIndex = 70;
            // 
            // txtDispatch
            // 
            txtDispatch.Anchor = AnchorStyles.None;
            txtDispatch.BackColor = Color.White;
            txtDispatch.BorderStyle = BorderStyle.FixedSingle;
            txtDispatch.Enabled = false;
            txtDispatch.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDispatch.Location = new Point(271, 84);
            txtDispatch.Name = "txtDispatch";
            txtDispatch.ReadOnly = true;
            txtDispatch.Size = new Size(196, 24);
            txtDispatch.TabIndex = 69;
            // 
            // txtSite
            // 
            txtSite.Anchor = AnchorStyles.None;
            txtSite.BackColor = Color.White;
            txtSite.BorderStyle = BorderStyle.FixedSingle;
            txtSite.Enabled = false;
            txtSite.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSite.Location = new Point(69, 84);
            txtSite.Name = "txtSite";
            txtSite.ReadOnly = true;
            txtSite.Size = new Size(196, 24);
            txtSite.TabIndex = 68;
            // 
            // txtEmployee
            // 
            txtEmployee.Anchor = AnchorStyles.None;
            txtEmployee.BackColor = Color.White;
            txtEmployee.BorderStyle = BorderStyle.FixedSingle;
            txtEmployee.Enabled = false;
            txtEmployee.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployee.Location = new Point(384, 29);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.ReadOnly = true;
            txtEmployee.Size = new Size(214, 24);
            txtEmployee.TabIndex = 67;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(384, 11);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 66;
            label6.Text = "Employee";
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
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(473, 66);
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
            label4.Location = new Point(271, 66);
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
            txtOrderType.Location = new Point(195, 29);
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
            label3.Location = new Point(195, 11);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 49;
            label3.Text = "Order Type";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 66);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 44;
            label1.Text = "Order Location";
            // 
            // txtOrderID
            // 
            txtOrderID.Anchor = AnchorStyles.None;
            txtOrderID.BackColor = Color.White;
            txtOrderID.BorderStyle = BorderStyle.FixedSingle;
            txtOrderID.Enabled = false;
            txtOrderID.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderID.Location = new Point(69, 29);
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
            lblEmpID.Location = new Point(69, 11);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(50, 15);
            lblEmpID.TabIndex = 42;
            lblEmpID.Text = "Order #";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkFulfilled);
            groupBox2.Controls.Add(chkPartialFulfill);
            groupBox2.Controls.Add(chkUnfulfilled);
            groupBox2.Controls.Add(btnSearchOrder);
            groupBox2.Controls.Add(txtSearchOrder);
            groupBox2.Controls.Add(dgvOrder);
            groupBox2.Location = new Point(12, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1060, 526);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            // 
            // chkFulfilled
            // 
            chkFulfilled.AutoSize = true;
            chkFulfilled.Checked = true;
            chkFulfilled.CheckState = CheckState.Checked;
            chkFulfilled.Location = new Point(194, 34);
            chkFulfilled.Name = "chkFulfilled";
            chkFulfilled.Size = new Size(103, 19);
            chkFulfilled.TabIndex = 67;
            chkFulfilled.Text = "Show Fulfilled";
            chkFulfilled.UseVisualStyleBackColor = true;
            // 
            // chkPartialFulfill
            // 
            chkPartialFulfill.AutoSize = true;
            chkPartialFulfill.Checked = true;
            chkPartialFulfill.CheckState = CheckState.Checked;
            chkPartialFulfill.Location = new Point(326, 34);
            chkPartialFulfill.Name = "chkPartialFulfill";
            chkPartialFulfill.Size = new Size(141, 19);
            chkPartialFulfill.TabIndex = 66;
            chkPartialFulfill.Text = "Show Partial Fulfilled";
            chkPartialFulfill.UseVisualStyleBackColor = true;
            // 
            // chkUnfulfilled
            // 
            chkUnfulfilled.AutoSize = true;
            chkUnfulfilled.Checked = true;
            chkUnfulfilled.CheckState = CheckState.Checked;
            chkUnfulfilled.Location = new Point(494, 34);
            chkUnfulfilled.Name = "chkUnfulfilled";
            chkUnfulfilled.Size = new Size(115, 19);
            chkUnfulfilled.TabIndex = 65;
            chkUnfulfilled.Text = "Show Unfulfilled";
            chkUnfulfilled.UseVisualStyleBackColor = true;
            // 
            // btnSearchOrder
            // 
            btnSearchOrder.Anchor = AnchorStyles.None;
            btnSearchOrder.BackColor = Color.OrangeRed;
            btnSearchOrder.Cursor = Cursors.Hand;
            btnSearchOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchOrder.ForeColor = Color.White;
            btnSearchOrder.Location = new Point(875, 27);
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
            txtSearchOrder.Location = new Point(628, 30);
            txtSearchOrder.Name = "txtSearchOrder";
            txtSearchOrder.PlaceholderText = "Search ID or Name";
            txtSearchOrder.Size = new Size(241, 27);
            txtSearchOrder.TabIndex = 63;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AllowUserToResizeColumns = false;
            dgvOrder.AllowUserToResizeRows = false;
            dgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.BackgroundColor = Color.White;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { itemID, name, optimumThreshold, reorderThreshold, quantity, itemQuantity, quantityAssigned });
            dgvOrder.Location = new Point(6, 65);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvOrder.RowTemplate.Height = 40;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(1048, 455);
            dgvOrder.TabIndex = 48;
            dgvOrder.SelectionChanged += dgvOrder_SelectionChanged;
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
            // quantity
            // 
            quantity.HeaderText = "Current Stock";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // itemQuantity
            // 
            itemQuantity.HeaderText = "Quantity Ordered";
            itemQuantity.Name = "itemQuantity";
            itemQuantity.ReadOnly = true;
            // 
            // quantityAssigned
            // 
            quantityAssigned.HeaderText = "Quantity Assigned";
            quantityAssigned.Name = "quantityAssigned";
            quantityAssigned.ReadOnly = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnFulfillItem);
            groupBox5.Controls.Add(txtQuantityOrdered);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(txtItemReorder);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(lblItemName);
            groupBox5.Controls.Add(numQuantityAssigned);
            groupBox5.Controls.Add(txtItemName);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(txtItemStock);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(txtItemThreshold);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(txtItemID);
            groupBox5.Controls.Add(label8);
            groupBox5.Location = new Point(12, 663);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(874, 92);
            groupBox5.TabIndex = 67;
            groupBox5.TabStop = false;
            // 
            // btnFulfillItem
            // 
            btnFulfillItem.Anchor = AnchorStyles.None;
            btnFulfillItem.BackColor = Color.OrangeRed;
            btnFulfillItem.Cursor = Cursors.Hand;
            btnFulfillItem.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFulfillItem.ForeColor = Color.White;
            btnFulfillItem.Location = new Point(752, 18);
            btnFulfillItem.Name = "btnFulfillItem";
            btnFulfillItem.Size = new Size(116, 60);
            btnFulfillItem.TabIndex = 81;
            btnFulfillItem.Text = "FULFILL\r\nITEM";
            btnFulfillItem.UseVisualStyleBackColor = false;
            btnFulfillItem.Click += btnFulfillItem_Click;
            // 
            // txtQuantityOrdered
            // 
            txtQuantityOrdered.Anchor = AnchorStyles.None;
            txtQuantityOrdered.BackColor = Color.White;
            txtQuantityOrdered.BorderStyle = BorderStyle.FixedSingle;
            txtQuantityOrdered.Enabled = false;
            txtQuantityOrdered.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantityOrdered.Location = new Point(564, 54);
            txtQuantityOrdered.Name = "txtQuantityOrdered";
            txtQuantityOrdered.ReadOnly = true;
            txtQuantityOrdered.Size = new Size(91, 24);
            txtQuantityOrdered.TabIndex = 80;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(564, 21);
            label15.Name = "label15";
            label15.Size = new Size(54, 30);
            label15.TabIndex = 79;
            label15.Text = "Quantity\r\nOrdered";
            // 
            // txtItemReorder
            // 
            txtItemReorder.Anchor = AnchorStyles.None;
            txtItemReorder.BackColor = Color.White;
            txtItemReorder.BorderStyle = BorderStyle.FixedSingle;
            txtItemReorder.Enabled = false;
            txtItemReorder.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemReorder.Location = new Point(461, 54);
            txtItemReorder.Name = "txtItemReorder";
            txtItemReorder.ReadOnly = true;
            txtItemReorder.Size = new Size(97, 24);
            txtItemReorder.TabIndex = 77;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(461, 21);
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
            lblItemName.Location = new Point(6, 16);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(67, 15);
            lblItemName.TabIndex = 75;
            lblItemName.Text = "Fullfill Item";
            // 
            // numQuantityAssigned
            // 
            numQuantityAssigned.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numQuantityAssigned.Location = new Point(661, 54);
            numQuantityAssigned.Name = "numQuantityAssigned";
            numQuantityAssigned.Size = new Size(85, 24);
            numQuantityAssigned.TabIndex = 74;
            numQuantityAssigned.ValueChanged += numQuantityAssigned_ValueChanged;
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.None;
            txtItemName.BackColor = Color.White;
            txtItemName.BorderStyle = BorderStyle.FixedSingle;
            txtItemName.Enabled = false;
            txtItemName.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemName.Location = new Point(78, 54);
            txtItemName.Name = "txtItemName";
            txtItemName.ReadOnly = true;
            txtItemName.ScrollBars = ScrollBars.Horizontal;
            txtItemName.Size = new Size(210, 24);
            txtItemName.TabIndex = 72;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(78, 36);
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
            txtItemStock.Location = new Point(294, 54);
            txtItemStock.Name = "txtItemStock";
            txtItemStock.ReadOnly = true;
            txtItemStock.Size = new Size(71, 24);
            txtItemStock.TabIndex = 70;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(294, 21);
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
            label10.Location = new Point(661, 21);
            label10.Name = "label10";
            label10.Size = new Size(60, 30);
            label10.TabIndex = 67;
            label10.Text = "Quantity\r\nAssigned";
            // 
            // txtItemThreshold
            // 
            txtItemThreshold.Anchor = AnchorStyles.None;
            txtItemThreshold.BackColor = Color.White;
            txtItemThreshold.BorderStyle = BorderStyle.FixedSingle;
            txtItemThreshold.Enabled = false;
            txtItemThreshold.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemThreshold.Location = new Point(371, 54);
            txtItemThreshold.Name = "txtItemThreshold";
            txtItemThreshold.ReadOnly = true;
            txtItemThreshold.Size = new Size(84, 24);
            txtItemThreshold.TabIndex = 66;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(371, 21);
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
            txtItemID.Location = new Point(8, 54);
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
            label8.Location = new Point(6, 36);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 56;
            label8.Text = "Item ID";
            // 
            // frmFulfillStoreOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 761);
            Controls.Add(groupBox5);
            Controls.Add(btnCancelOrder);
            Controls.Add(groupBox1);
            Controls.Add(btnFulfillOrder);
            Controls.Add(groupBox2);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFulfillStoreOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FulfillStoreOrderForm";
            FormClosing += frmFulfillStoreOrder_FormClosing;
            Load += frmFulfillStoreOrder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantityAssigned).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnFulfillOrder;
        private Button btnCancelOrder;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private TextBox txtOrderType;
        private Label label3;
        private Label label1;
        private TextBox txtOrderID;
        private Label lblEmpID;
        private GroupBox groupBox2;
        private Button btnSearchOrder;
        private TextBox txtSearchOrder;
        private DataGridView dgvOrder;
        private TextBox txtShipDate;
        private TextBox txtDispatch;
        private TextBox txtSite;
        private TextBox txtEmployee;
        private Label label6;
        private Label label7;
        private TextBox txtStatus;
        private DataGridViewTextBoxColumn itemID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn optimumThreshold;
        private DataGridViewTextBoxColumn reorderThreshold;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn itemQuantity;
        private DataGridViewTextBoxColumn quantityAssigned;
        private GroupBox groupBox5;
        private TextBox txtItemReorder;
        private Label label13;
        private Label lblItemName;
        private NumericUpDown numQuantityAssigned;
        private TextBox txtItemName;
        private Label label12;
        private TextBox txtItemStock;
        private Label label11;
        private Label label10;
        private TextBox txtItemThreshold;
        private Label label9;
        private TextBox txtItemID;
        private Label label8;
        private TextBox txtQuantityOrdered;
        private Label label15;
        private Button btnFulfillItem;
        private CheckBox chkUnfulfilled;
        private CheckBox chkFulfilled;
        private CheckBox chkPartialFulfill;
    }
}