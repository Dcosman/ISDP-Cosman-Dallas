namespace ISDP_Cosman_Dallas
{
    partial class frmBackOrder
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
            btnSearchOrder = new Button();
            txtSearchOrder = new TextBox();
            btnCancelOrder = new Button();
            groupBox1 = new GroupBox();
            cboOrderLocation = new ComboBox();
            dtpOrderShipDate = new DateTimePicker();
            txtDispatch = new TextBox();
            txtEmployee = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtOrderID = new TextBox();
            lblEmpID = new Label();
            btnConfirmBackOrder = new Button();
            dgvOrder = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            itemName = new DataGridViewTextBoxColumn();
            itemQuantity = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            numQuantity = new NumericUpDown();
            btnAddToOrder = new Button();
            btnSearchItem = new Button();
            txtSearchItem = new TextBox();
            dgvItems = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            caseSize = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // btnSearchOrder
            // 
            btnSearchOrder.Anchor = AnchorStyles.None;
            btnSearchOrder.BackColor = Color.OrangeRed;
            btnSearchOrder.Cursor = Cursors.Hand;
            btnSearchOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchOrder.ForeColor = Color.White;
            btnSearchOrder.Location = new Point(341, 19);
            btnSearchOrder.Name = "btnSearchOrder";
            btnSearchOrder.Size = new Size(179, 33);
            btnSearchOrder.TabIndex = 64;
            btnSearchOrder.Text = "SEARCH";
            btnSearchOrder.UseVisualStyleBackColor = false;
            // 
            // txtSearchOrder
            // 
            txtSearchOrder.Anchor = AnchorStyles.None;
            txtSearchOrder.BackColor = Color.White;
            txtSearchOrder.BorderStyle = BorderStyle.FixedSingle;
            txtSearchOrder.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchOrder.Location = new Point(9, 23);
            txtSearchOrder.Name = "txtSearchOrder";
            txtSearchOrder.PlaceholderText = "Search ID or Name";
            txtSearchOrder.Size = new Size(326, 27);
            txtSearchOrder.TabIndex = 63;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Anchor = AnchorStyles.None;
            btnCancelOrder.BackColor = Color.OrangeRed;
            btnCancelOrder.Cursor = Cursors.Hand;
            btnCancelOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelOrder.ForeColor = Color.White;
            btnCancelOrder.Location = new Point(895, 711);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(180, 44);
            btnCancelOrder.TabIndex = 68;
            btnCancelOrder.Text = "CANCEL";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboOrderLocation);
            groupBox1.Controls.Add(dtpOrderShipDate);
            groupBox1.Controls.Add(txtDispatch);
            groupBox1.Controls.Add(txtEmployee);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtOrderID);
            groupBox1.Controls.Add(lblEmpID);
            groupBox1.Location = new Point(15, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1060, 72);
            groupBox1.TabIndex = 70;
            groupBox1.TabStop = false;
            // 
            // cboOrderLocation
            // 
            cboOrderLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrderLocation.FormattingEnabled = true;
            cboOrderLocation.Location = new Point(412, 38);
            cboOrderLocation.Name = "cboOrderLocation";
            cboOrderLocation.Size = new Size(227, 23);
            cboOrderLocation.TabIndex = 70;
            cboOrderLocation.SelectedIndexChanged += cboOrderLocation_SelectedIndexChanged;
            // 
            // dtpOrderShipDate
            // 
            dtpOrderShipDate.Anchor = AnchorStyles.None;
            dtpOrderShipDate.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpOrderShipDate.Location = new Point(871, 37);
            dtpOrderShipDate.Name = "dtpOrderShipDate";
            dtpOrderShipDate.Size = new Size(168, 24);
            dtpOrderShipDate.TabIndex = 50;
            // 
            // txtDispatch
            // 
            txtDispatch.Anchor = AnchorStyles.None;
            txtDispatch.BackColor = Color.White;
            txtDispatch.BorderStyle = BorderStyle.FixedSingle;
            txtDispatch.Enabled = false;
            txtDispatch.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDispatch.Location = new Point(645, 37);
            txtDispatch.Name = "txtDispatch";
            txtDispatch.ReadOnly = true;
            txtDispatch.Size = new Size(220, 24);
            txtDispatch.TabIndex = 69;
            // 
            // txtEmployee
            // 
            txtEmployee.Anchor = AnchorStyles.None;
            txtEmployee.BackColor = Color.White;
            txtEmployee.BorderStyle = BorderStyle.FixedSingle;
            txtEmployee.Enabled = false;
            txtEmployee.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployee.Location = new Point(191, 37);
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
            label6.Location = new Point(191, 19);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 66;
            label6.Text = "Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bullseye;
            pictureBox1.Location = new Point(2, 9);
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
            label5.Location = new Point(871, 19);
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
            label4.Location = new Point(645, 19);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 51;
            label4.Text = "Dispatch Location";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(412, 19);
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
            txtOrderID.Location = new Point(64, 37);
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
            lblEmpID.Location = new Point(64, 19);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(50, 15);
            lblEmpID.TabIndex = 42;
            lblEmpID.Text = "Order #";
            // 
            // btnConfirmBackOrder
            // 
            btnConfirmBackOrder.Anchor = AnchorStyles.None;
            btnConfirmBackOrder.BackColor = Color.OrangeRed;
            btnConfirmBackOrder.Cursor = Cursors.Hand;
            btnConfirmBackOrder.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmBackOrder.ForeColor = Color.White;
            btnConfirmBackOrder.Location = new Point(709, 711);
            btnConfirmBackOrder.Name = "btnConfirmBackOrder";
            btnConfirmBackOrder.Size = new Size(180, 44);
            btnConfirmBackOrder.TabIndex = 69;
            btnConfirmBackOrder.Text = "CONFIRM";
            btnConfirmBackOrder.UseVisualStyleBackColor = false;
            btnConfirmBackOrder.Click += btnConfirmBackOrder_Click;
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
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { id, itemName, itemQuantity });
            dgvOrder.Location = new Point(9, 54);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvOrder.RowTemplate.Height = 40;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvOrder.Size = new Size(511, 568);
            dgvOrder.TabIndex = 48;
            // 
            // id
            // 
            id.HeaderText = "Item ID";
            id.Name = "id";
            // 
            // itemName
            // 
            itemName.HeaderText = "Name";
            itemName.Name = "itemName";
            // 
            // itemQuantity
            // 
            itemQuantity.HeaderText = "Quantity Ordered";
            itemQuantity.Name = "itemQuantity";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearchOrder);
            groupBox2.Controls.Add(txtSearchOrder);
            groupBox2.Controls.Add(dgvOrder);
            groupBox2.Location = new Point(15, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(526, 628);
            groupBox2.TabIndex = 71;
            groupBox2.TabStop = false;
            groupBox2.Text = "Back Order";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(numQuantity);
            groupBox3.Controls.Add(btnAddToOrder);
            groupBox3.Controls.Add(btnSearchItem);
            groupBox3.Controls.Add(txtSearchItem);
            groupBox3.Controls.Add(dgvItems);
            groupBox3.Location = new Point(547, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(526, 628);
            groupBox3.TabIndex = 73;
            groupBox3.TabStop = false;
            groupBox3.Text = "Items";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 592);
            label7.Name = "label7";
            label7.Size = new Size(67, 18);
            label7.TabIndex = 69;
            label7.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numQuantity.Location = new Point(82, 585);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(125, 30);
            numQuantity.TabIndex = 68;
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
            btnAddToOrder.Location = new Point(298, 581);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(222, 38);
            btnAddToOrder.TabIndex = 67;
            btnAddToOrder.Text = "ADD TO ORDER";
            btnAddToOrder.UseVisualStyleBackColor = false;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // btnSearchItem
            // 
            btnSearchItem.Anchor = AnchorStyles.None;
            btnSearchItem.BackColor = Color.OrangeRed;
            btnSearchItem.Cursor = Cursors.Hand;
            btnSearchItem.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchItem.ForeColor = Color.White;
            btnSearchItem.Location = new Point(341, 18);
            btnSearchItem.Name = "btnSearchItem";
            btnSearchItem.Size = new Size(179, 33);
            btnSearchItem.TabIndex = 66;
            btnSearchItem.Text = "SEARCH";
            btnSearchItem.UseVisualStyleBackColor = false;
            btnSearchItem.Click += btnSearchItem_Click;
            // 
            // txtSearchItem
            // 
            txtSearchItem.Anchor = AnchorStyles.None;
            txtSearchItem.BackColor = Color.White;
            txtSearchItem.BorderStyle = BorderStyle.FixedSingle;
            txtSearchItem.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchItem.Location = new Point(9, 21);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.PlaceholderText = "Search ID or Name";
            txtSearchItem.Size = new Size(326, 27);
            txtSearchItem.TabIndex = 65;
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
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { ItemID, name, caseSize });
            dgvItems.Location = new Point(9, 54);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvItems.RowTemplate.Height = 40;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(511, 521);
            dgvItems.TabIndex = 49;
            // 
            // ItemID
            // 
            ItemID.HeaderText = "Item ID";
            ItemID.Name = "ItemID";
            ItemID.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // caseSize
            // 
            caseSize.HeaderText = "Case Size";
            caseSize.Name = "caseSize";
            caseSize.ReadOnly = true;
            // 
            // frmBackOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 761);
            Controls.Add(groupBox3);
            Controls.Add(btnCancelOrder);
            Controls.Add(groupBox1);
            Controls.Add(btnConfirmBackOrder);
            Controls.Add(groupBox2);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBackOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Back Order";
            FormClosing += frmBackOrder_FormClosing;
            Load += frmBackOrder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSearchOrder;
        private TextBox txtSearchOrder;
        private Button btnCancelOrder;
        private GroupBox groupBox1;
        private TextBox txtDispatch;
        private TextBox txtEmployee;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtOrderID;
        private Label lblEmpID;
        private Button btnConfirmBackOrder;
        private DataGridView dgvOrder;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgvItems;
        private DateTimePicker dtpOrderShipDate;
        private Button btnSearchItem;
        private TextBox txtSearchItem;
        private Label label7;
        private NumericUpDown numQuantity;
        private Button btnAddToOrder;
        private ComboBox cboOrderLocation;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn itemQuantity;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn caseSize;
    }
}