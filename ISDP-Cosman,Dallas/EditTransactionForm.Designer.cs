namespace ISDP_Cosman_Dallas
{
    partial class frmEditTxn
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
            components = new System.ComponentModel.Container();
            pnlEdit = new Panel();
            lblErrFrom = new Label();
            lblErrTo = new Label();
            txtDeliveryID = new TextBox();
            dtpShipDate = new DateTimePicker();
            cboStatus = new ComboBox();
            cboSiteFrom = new ComboBox();
            cboSiteTo = new ComboBox();
            chkEmergency = new CheckBox();
            lblErrBarCode = new Label();
            txtCreateDate = new TextBox();
            lblCreateDate = new Label();
            picHelp = new PictureBox();
            lblModifyError = new Label();
            txtTxnNotes = new RichTextBox();
            lblTxnNotes = new Label();
            btnCancelTxn = new Button();
            btnSaveTxn = new Button();
            lblAddEditDetails = new Label();
            lblAddEditSite = new Label();
            pictureBox1 = new PictureBox();
            lblErrShip = new Label();
            cboTxnType = new ComboBox();
            txtBarCode = new TextBox();
            txtTxnID = new TextBox();
            lblSiteAddress = new Label();
            lblSiteName = new Label();
            lblSiteAddress2 = new Label();
            lblSiteCity = new Label();
            lblSitePostal = new Label();
            lblSiteProv = new Label();
            lblSiteCountry = new Label();
            lblSiteID = new Label();
            grpDeliveryID = new GroupBox();
            btnCancelSelect = new Button();
            btnSelect = new Button();
            dgvDelivery = new DataGridView();
            DeliveryID = new DataGridViewTextBoxColumn();
            DistanceCost = new DataGridViewTextBoxColumn();
            VehicleType = new DataGridViewTextBoxColumn();
            tipError = new ToolTip(components);
            btnClear = new Button();
            pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpDeliveryID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDelivery).BeginInit();
            SuspendLayout();
            // 
            // pnlEdit
            // 
            pnlEdit.Controls.Add(lblErrFrom);
            pnlEdit.Controls.Add(lblErrTo);
            pnlEdit.Controls.Add(txtDeliveryID);
            pnlEdit.Controls.Add(dtpShipDate);
            pnlEdit.Controls.Add(cboStatus);
            pnlEdit.Controls.Add(cboSiteFrom);
            pnlEdit.Controls.Add(cboSiteTo);
            pnlEdit.Controls.Add(chkEmergency);
            pnlEdit.Controls.Add(lblErrBarCode);
            pnlEdit.Controls.Add(txtCreateDate);
            pnlEdit.Controls.Add(lblCreateDate);
            pnlEdit.Controls.Add(picHelp);
            pnlEdit.Controls.Add(lblModifyError);
            pnlEdit.Controls.Add(txtTxnNotes);
            pnlEdit.Controls.Add(lblTxnNotes);
            pnlEdit.Controls.Add(btnCancelTxn);
            pnlEdit.Controls.Add(btnSaveTxn);
            pnlEdit.Controls.Add(lblAddEditDetails);
            pnlEdit.Controls.Add(lblAddEditSite);
            pnlEdit.Controls.Add(pictureBox1);
            pnlEdit.Controls.Add(lblErrShip);
            pnlEdit.Controls.Add(cboTxnType);
            pnlEdit.Controls.Add(txtBarCode);
            pnlEdit.Controls.Add(txtTxnID);
            pnlEdit.Controls.Add(lblSiteAddress);
            pnlEdit.Controls.Add(lblSiteName);
            pnlEdit.Controls.Add(lblSiteAddress2);
            pnlEdit.Controls.Add(lblSiteCity);
            pnlEdit.Controls.Add(lblSitePostal);
            pnlEdit.Controls.Add(lblSiteProv);
            pnlEdit.Controls.Add(lblSiteCountry);
            pnlEdit.Controls.Add(lblSiteID);
            pnlEdit.Location = new Point(1, 4);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(436, 596);
            pnlEdit.TabIndex = 0;
            // 
            // lblErrFrom
            // 
            lblErrFrom.Anchor = AnchorStyles.None;
            lblErrFrom.AutoSize = true;
            lblErrFrom.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrFrom.ForeColor = Color.Red;
            lblErrFrom.Location = new Point(379, 153);
            lblErrFrom.Name = "lblErrFrom";
            lblErrFrom.Size = new Size(12, 15);
            lblErrFrom.TabIndex = 167;
            lblErrFrom.Tag = "City ";
            lblErrFrom.Text = "*";
            tipError.SetToolTip(lblErrFrom, "Sites Must be Different");
            lblErrFrom.Visible = false;
            // 
            // lblErrTo
            // 
            lblErrTo.Anchor = AnchorStyles.None;
            lblErrTo.AutoSize = true;
            lblErrTo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrTo.ForeColor = Color.Red;
            lblErrTo.Location = new Point(379, 113);
            lblErrTo.Name = "lblErrTo";
            lblErrTo.Size = new Size(12, 15);
            lblErrTo.TabIndex = 166;
            lblErrTo.Tag = "City ";
            lblErrTo.Text = "*";
            tipError.SetToolTip(lblErrTo, "Sites Must be Different");
            lblErrTo.Visible = false;
            // 
            // txtDeliveryID
            // 
            txtDeliveryID.Anchor = AnchorStyles.None;
            txtDeliveryID.BackColor = Color.White;
            txtDeliveryID.BorderStyle = BorderStyle.FixedSingle;
            txtDeliveryID.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDeliveryID.Location = new Point(297, 74);
            txtDeliveryID.Name = "txtDeliveryID";
            txtDeliveryID.ReadOnly = true;
            txtDeliveryID.Size = new Size(76, 21);
            txtDeliveryID.TabIndex = 165;
            txtDeliveryID.Click += txtDeliveryID_Click;
            // 
            // dtpShipDate
            // 
            dtpShipDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpShipDate.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpShipDate.Location = new Point(114, 234);
            dtpShipDate.Name = "dtpShipDate";
            dtpShipDate.Size = new Size(259, 25);
            dtpShipDate.TabIndex = 164;
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.None;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(114, 195);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(259, 23);
            cboStatus.TabIndex = 163;
            // 
            // cboSiteFrom
            // 
            cboSiteFrom.Anchor = AnchorStyles.None;
            cboSiteFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSiteFrom.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSiteFrom.FormattingEnabled = true;
            cboSiteFrom.Location = new Point(114, 153);
            cboSiteFrom.Name = "cboSiteFrom";
            cboSiteFrom.Size = new Size(259, 23);
            cboSiteFrom.TabIndex = 162;
            // 
            // cboSiteTo
            // 
            cboSiteTo.Anchor = AnchorStyles.None;
            cboSiteTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSiteTo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSiteTo.FormattingEnabled = true;
            cboSiteTo.Location = new Point(114, 113);
            cboSiteTo.Name = "cboSiteTo";
            cboSiteTo.Size = new Size(259, 23);
            cboSiteTo.TabIndex = 161;
            // 
            // chkEmergency
            // 
            chkEmergency.AutoSize = true;
            chkEmergency.Location = new Point(259, 493);
            chkEmergency.Name = "chkEmergency";
            chkEmergency.RightToLeft = RightToLeft.Yes;
            chkEmergency.Size = new Size(134, 19);
            chkEmergency.TabIndex = 160;
            chkEmergency.Text = "Emergency Delivery";
            chkEmergency.UseVisualStyleBackColor = true;
            // 
            // lblErrBarCode
            // 
            lblErrBarCode.Anchor = AnchorStyles.None;
            lblErrBarCode.AutoSize = true;
            lblErrBarCode.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrBarCode.ForeColor = Color.Red;
            lblErrBarCode.Location = new Point(379, 320);
            lblErrBarCode.Name = "lblErrBarCode";
            lblErrBarCode.Size = new Size(12, 15);
            lblErrBarCode.TabIndex = 159;
            lblErrBarCode.Tag = "Province ";
            lblErrBarCode.Text = "*";
            tipError.SetToolTip(lblErrBarCode, "Barcode Must Contain Only Numbers (Min 12 Numbers, Max 50 Numbers)");
            lblErrBarCode.Visible = false;
            // 
            // txtCreateDate
            // 
            txtCreateDate.Anchor = AnchorStyles.None;
            txtCreateDate.BackColor = Color.White;
            txtCreateDate.BorderStyle = BorderStyle.FixedSingle;
            txtCreateDate.Enabled = false;
            txtCreateDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCreateDate.Location = new Point(114, 360);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.Size = new Size(259, 21);
            txtCreateDate.TabIndex = 155;
            // 
            // lblCreateDate
            // 
            lblCreateDate.Anchor = AnchorStyles.None;
            lblCreateDate.AutoSize = true;
            lblCreateDate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreateDate.Location = new Point(16, 363);
            lblCreateDate.Name = "lblCreateDate";
            lblCreateDate.Size = new Size(58, 15);
            lblCreateDate.TabIndex = 154;
            lblCreateDate.Text = "Created: ";
            // 
            // picHelp
            // 
            picHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHelp.Cursor = Cursors.Hand;
            picHelp.Image = Properties.Resources.help;
            picHelp.Location = new Point(398, 6);
            picHelp.Name = "picHelp";
            picHelp.Size = new Size(30, 30);
            picHelp.SizeMode = PictureBoxSizeMode.Zoom;
            picHelp.TabIndex = 149;
            picHelp.TabStop = false;
            // 
            // lblModifyError
            // 
            lblModifyError.Anchor = AnchorStyles.None;
            lblModifyError.AutoSize = true;
            lblModifyError.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblModifyError.ForeColor = Color.Red;
            lblModifyError.Location = new Point(60, 528);
            lblModifyError.Name = "lblModifyError";
            lblModifyError.Size = new Size(316, 15);
            lblModifyError.TabIndex = 143;
            lblModifyError.Text = "Transaction Information Invalid: Hover over * for details";
            lblModifyError.Visible = false;
            // 
            // txtTxnNotes
            // 
            txtTxnNotes.BorderStyle = BorderStyle.FixedSingle;
            txtTxnNotes.Enabled = false;
            txtTxnNotes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTxnNotes.Location = new Point(114, 403);
            txtTxnNotes.Name = "txtTxnNotes";
            txtTxnNotes.Size = new Size(279, 82);
            txtTxnNotes.TabIndex = 142;
            txtTxnNotes.Text = "";
            // 
            // lblTxnNotes
            // 
            lblTxnNotes.Anchor = AnchorStyles.None;
            lblTxnNotes.AutoSize = true;
            lblTxnNotes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTxnNotes.Location = new Point(16, 402);
            lblTxnNotes.Name = "lblTxnNotes";
            lblTxnNotes.Size = new Size(46, 15);
            lblTxnNotes.TabIndex = 141;
            lblTxnNotes.Text = "Notes: ";
            // 
            // btnCancelTxn
            // 
            btnCancelTxn.Anchor = AnchorStyles.None;
            btnCancelTxn.BackColor = Color.OrangeRed;
            btnCancelTxn.Cursor = Cursors.Hand;
            btnCancelTxn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelTxn.ForeColor = Color.White;
            btnCancelTxn.Location = new Point(221, 553);
            btnCancelTxn.Name = "btnCancelTxn";
            btnCancelTxn.Size = new Size(189, 38);
            btnCancelTxn.TabIndex = 140;
            btnCancelTxn.Text = "CANCEL";
            btnCancelTxn.UseVisualStyleBackColor = false;
            btnCancelTxn.Click += btnCancelTxn_Click;
            // 
            // btnSaveTxn
            // 
            btnSaveTxn.Anchor = AnchorStyles.None;
            btnSaveTxn.BackColor = Color.OrangeRed;
            btnSaveTxn.Cursor = Cursors.Hand;
            btnSaveTxn.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveTxn.ForeColor = Color.White;
            btnSaveTxn.Location = new Point(26, 553);
            btnSaveTxn.Name = "btnSaveTxn";
            btnSaveTxn.Size = new Size(189, 38);
            btnSaveTxn.TabIndex = 139;
            btnSaveTxn.Text = "SAVE";
            btnSaveTxn.UseVisualStyleBackColor = false;
            btnSaveTxn.Click += btnSaveTxn_Click;
            // 
            // lblAddEditDetails
            // 
            lblAddEditDetails.Anchor = AnchorStyles.None;
            lblAddEditDetails.AutoSize = true;
            lblAddEditDetails.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditDetails.Location = new Point(133, 42);
            lblAddEditDetails.Name = "lblAddEditDetails";
            lblAddEditDetails.Size = new Size(171, 16);
            lblAddEditDetails.TabIndex = 138;
            lblAddEditDetails.Tag = "";
            lblAddEditDetails.Text = "Modify Transaction and Save Changes";
            // 
            // lblAddEditSite
            // 
            lblAddEditSite.Anchor = AnchorStyles.Top;
            lblAddEditSite.AutoSize = true;
            lblAddEditSite.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditSite.Location = new Point(118, 19);
            lblAddEditSite.Name = "lblAddEditSite";
            lblAddEditSite.Size = new Size(201, 24);
            lblAddEditSite.TabIndex = 137;
            lblAddEditSite.Text = "Modify Transaction";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bullseye;
            pictureBox1.Location = new Point(8, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 136;
            pictureBox1.TabStop = false;
            // 
            // lblErrShip
            // 
            lblErrShip.Anchor = AnchorStyles.None;
            lblErrShip.AutoSize = true;
            lblErrShip.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrShip.ForeColor = Color.Red;
            lblErrShip.Location = new Point(379, 235);
            lblErrShip.Name = "lblErrShip";
            lblErrShip.Size = new Size(12, 15);
            lblErrShip.TabIndex = 147;
            lblErrShip.Tag = "City ";
            lblErrShip.Text = "*";
            tipError.SetToolTip(lblErrShip, "Ship Date Must be After the Current Date");
            lblErrShip.Visible = false;
            // 
            // cboTxnType
            // 
            cboTxnType.Anchor = AnchorStyles.None;
            cboTxnType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTxnType.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboTxnType.FormattingEnabled = true;
            cboTxnType.Location = new Point(114, 279);
            cboTxnType.Name = "cboTxnType";
            cboTxnType.Size = new Size(259, 23);
            cboTxnType.TabIndex = 135;
            // 
            // txtBarCode
            // 
            txtBarCode.Anchor = AnchorStyles.None;
            txtBarCode.BackColor = Color.White;
            txtBarCode.BorderStyle = BorderStyle.FixedSingle;
            txtBarCode.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarCode.Location = new Point(114, 320);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(259, 21);
            txtBarCode.TabIndex = 134;
            // 
            // txtTxnID
            // 
            txtTxnID.Anchor = AnchorStyles.None;
            txtTxnID.BackColor = Color.White;
            txtTxnID.BorderStyle = BorderStyle.FixedSingle;
            txtTxnID.Enabled = false;
            txtTxnID.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTxnID.Location = new Point(114, 74);
            txtTxnID.Name = "txtTxnID";
            txtTxnID.ReadOnly = true;
            txtTxnID.Size = new Size(76, 21);
            txtTxnID.TabIndex = 128;
            // 
            // lblSiteAddress
            // 
            lblSiteAddress.Anchor = AnchorStyles.None;
            lblSiteAddress.AutoSize = true;
            lblSiteAddress.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteAddress.Location = new Point(16, 157);
            lblSiteAddress.Name = "lblSiteAddress";
            lblSiteAddress.Size = new Size(67, 15);
            lblSiteAddress.TabIndex = 127;
            lblSiteAddress.Text = "From Site: ";
            // 
            // lblSiteName
            // 
            lblSiteName.Anchor = AnchorStyles.None;
            lblSiteName.AutoSize = true;
            lblSiteName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteName.Location = new Point(16, 116);
            lblSiteName.Name = "lblSiteName";
            lblSiteName.Size = new Size(51, 15);
            lblSiteName.TabIndex = 126;
            lblSiteName.Text = "To Site: ";
            // 
            // lblSiteAddress2
            // 
            lblSiteAddress2.Anchor = AnchorStyles.None;
            lblSiteAddress2.AutoSize = true;
            lblSiteAddress2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteAddress2.Location = new Point(16, 198);
            lblSiteAddress2.Name = "lblSiteAddress2";
            lblSiteAddress2.Size = new Size(50, 15);
            lblSiteAddress2.TabIndex = 125;
            lblSiteAddress2.Text = "Status: ";
            // 
            // lblSiteCity
            // 
            lblSiteCity.Anchor = AnchorStyles.None;
            lblSiteCity.AutoSize = true;
            lblSiteCity.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteCity.Location = new Point(16, 241);
            lblSiteCity.Name = "lblSiteCity";
            lblSiteCity.Size = new Size(67, 15);
            lblSiteCity.TabIndex = 124;
            lblSiteCity.Text = "Ship Date: ";
            // 
            // lblSitePostal
            // 
            lblSitePostal.Anchor = AnchorStyles.None;
            lblSitePostal.AutoSize = true;
            lblSitePostal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSitePostal.Location = new Point(16, 323);
            lblSitePostal.Name = "lblSitePostal";
            lblSitePostal.Size = new Size(65, 15);
            lblSitePostal.TabIndex = 123;
            lblSitePostal.Text = "Bar Code: ";
            // 
            // lblSiteProv
            // 
            lblSiteProv.Anchor = AnchorStyles.None;
            lblSiteProv.AutoSize = true;
            lblSiteProv.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteProv.Location = new Point(214, 76);
            lblSiteProv.Name = "lblSiteProv";
            lblSiteProv.Size = new Size(72, 15);
            lblSiteProv.TabIndex = 122;
            lblSiteProv.Text = "Delivery ID: ";
            // 
            // lblSiteCountry
            // 
            lblSiteCountry.Anchor = AnchorStyles.None;
            lblSiteCountry.AutoSize = true;
            lblSiteCountry.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteCountry.Location = new Point(16, 282);
            lblSiteCountry.Name = "lblSiteCountry";
            lblSiteCountry.Size = new Size(39, 15);
            lblSiteCountry.TabIndex = 121;
            lblSiteCountry.Text = "Type: ";
            // 
            // lblSiteID
            // 
            lblSiteID.Anchor = AnchorStyles.None;
            lblSiteID.AutoSize = true;
            lblSiteID.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteID.Location = new Point(16, 76);
            lblSiteID.Name = "lblSiteID";
            lblSiteID.Size = new Size(45, 15);
            lblSiteID.TabIndex = 120;
            lblSiteID.Text = "Txn ID:";
            // 
            // grpDeliveryID
            // 
            grpDeliveryID.Controls.Add(btnClear);
            grpDeliveryID.Controls.Add(btnCancelSelect);
            grpDeliveryID.Controls.Add(btnSelect);
            grpDeliveryID.Controls.Add(dgvDelivery);
            grpDeliveryID.Location = new Point(44, 82);
            grpDeliveryID.Name = "grpDeliveryID";
            grpDeliveryID.Size = new Size(350, 437);
            grpDeliveryID.TabIndex = 168;
            grpDeliveryID.TabStop = false;
            grpDeliveryID.Text = "Select Delivery";
            grpDeliveryID.Visible = false;
            // 
            // btnCancelSelect
            // 
            btnCancelSelect.Anchor = AnchorStyles.None;
            btnCancelSelect.BackColor = Color.OrangeRed;
            btnCancelSelect.Cursor = Cursors.Hand;
            btnCancelSelect.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelSelect.ForeColor = Color.White;
            btnCancelSelect.Location = new Point(233, 389);
            btnCancelSelect.Name = "btnCancelSelect";
            btnCancelSelect.Size = new Size(111, 38);
            btnCancelSelect.TabIndex = 141;
            btnCancelSelect.Text = "CANCEL";
            btnCancelSelect.UseVisualStyleBackColor = false;
            btnCancelSelect.Click += btnCancelSelect_Click;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.None;
            btnSelect.BackColor = Color.OrangeRed;
            btnSelect.Cursor = Cursors.Hand;
            btnSelect.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(6, 389);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(111, 38);
            btnSelect.TabIndex = 140;
            btnSelect.Text = "SELECT";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // dgvDelivery
            // 
            dgvDelivery.AllowUserToAddRows = false;
            dgvDelivery.AllowUserToDeleteRows = false;
            dgvDelivery.AllowUserToResizeColumns = false;
            dgvDelivery.AllowUserToResizeRows = false;
            dgvDelivery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDelivery.BackgroundColor = Color.White;
            dgvDelivery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDelivery.Columns.AddRange(new DataGridViewColumn[] { DeliveryID, DistanceCost, VehicleType });
            dgvDelivery.Location = new Point(6, 20);
            dgvDelivery.MultiSelect = false;
            dgvDelivery.Name = "dgvDelivery";
            dgvDelivery.ReadOnly = true;
            dgvDelivery.RowHeadersVisible = false;
            dgvDelivery.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDelivery.RowTemplate.Height = 40;
            dgvDelivery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDelivery.Size = new Size(338, 359);
            dgvDelivery.TabIndex = 49;
            // 
            // DeliveryID
            // 
            DeliveryID.HeaderText = "ID";
            DeliveryID.Name = "DeliveryID";
            DeliveryID.ReadOnly = true;
            // 
            // DistanceCost
            // 
            DistanceCost.HeaderText = "Cost";
            DistanceCost.Name = "DistanceCost";
            DistanceCost.ReadOnly = true;
            // 
            // VehicleType
            // 
            VehicleType.HeaderText = "Type";
            VehicleType.Name = "VehicleType";
            VehicleType.ReadOnly = true;
            // 
            // tipError
            // 
            tipError.AutoPopDelay = 5000;
            tipError.InitialDelay = 200;
            tipError.IsBalloon = true;
            tipError.ReshowDelay = 100;
            tipError.ToolTipIcon = ToolTipIcon.Warning;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.OrangeRed;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(119, 389);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 38);
            btnClear.TabIndex = 142;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmEditTxn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(438, 601);
            Controls.Add(grpDeliveryID);
            Controls.Add(pnlEdit);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmEditTxn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTransactionForm";
            FormClosing += frmEditTxn_FormClosing;
            Load += frmEditTxn_Load;
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpDeliveryID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDelivery).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEdit;
        private ToolTip tipError;
        private Label lblErrBarCode;
        private Label lblErrCountry;
        private TextBox txtCreateDate;
        private Label lblCreateDate;
        private Label lblSitePhone;
        private PictureBox picHelp;
        private LinkLabel lblResetSite;
        private Label lblModifyError;
        private RichTextBox txtTxnNotes;
        private Label lblTxnNotes;
        private Button btnCancelTxn;
        private Button btnSaveTxn;
        private Label lblAddEditDetails;
        private Label lblAddEditSite;
        private PictureBox pictureBox1;
        private Label lblErrShip;
        private ComboBox cboTxnType;
        private TextBox txtBarCode;
        private ComboBox cboSiteProvince;
        private TextBox txtTxnID;
        private Label lblSiteAddress;
        private Label lblSiteName;
        private Label lblSiteAddress2;
        private Label lblSiteCity;
        private Label lblSitePostal;
        private Label lblSiteCountry;
        private Label lblSiteID;
        private ComboBox cboStatus;
        private ComboBox cboSiteFrom;
        private ComboBox cboSiteTo;
        private CheckBox chkEmergency;
        private DateTimePicker dtpShipDate;
        private Label lblSiteProv;
        private TextBox txtDeliveryID;
        private Label lblErrFrom;
        private Label lblErrTo;
        private GroupBox grpDeliveryID;
        private DataGridView dgvDelivery;
        private Button btnCancelSelect;
        private Button btnSelect;
        private DataGridViewTextBoxColumn DeliveryID;
        private DataGridViewTextBoxColumn DistanceCost;
        private DataGridViewTextBoxColumn VehicleType;
        private Button btnClear;
    }
}