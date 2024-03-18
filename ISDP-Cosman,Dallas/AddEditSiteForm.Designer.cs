namespace ISDP_Cosman_Dallas
{
    partial class AddEditSiteForm
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
            picHelp = new PictureBox();
            lblResetSite = new LinkLabel();
            tipError = new ToolTip(components);
            lblErrCity = new Label();
            lblErrAddress = new Label();
            lblErrSite = new Label();
            lblErrSiteID = new Label();
            lblErrCountry = new Label();
            lblErrPostal = new Label();
            lblErrDistance = new Label();
            lblErrProvince = new Label();
            lblErrPhone = new Label();
            lblErrDay = new Label();
            lblAddEditError = new Label();
            txtSiteNotes = new RichTextBox();
            lblSiteNotes = new Label();
            btnAddEditCancel = new Button();
            btnAddEditSave = new Button();
            lblAddEditDetails = new Label();
            lblAddEditSite = new Label();
            pictureBox1 = new PictureBox();
            cboSiteCountry = new ComboBox();
            txtSitePostal = new TextBox();
            txtSiteCity = new TextBox();
            txtSiteAdd2 = new TextBox();
            txtSiteAdd = new TextBox();
            txtSiteName = new TextBox();
            cboSiteProvince = new ComboBox();
            txtSiteID = new TextBox();
            lblSiteAddress = new Label();
            lblSiteName = new Label();
            lblSiteAddress2 = new Label();
            lblSiteCity = new Label();
            lblSitePostal = new Label();
            lblSiteProv = new Label();
            lblSiteCountry = new Label();
            lblSiteID = new Label();
            txtSitePhone = new TextBox();
            lblSitePhone = new Label();
            cboSiteDay = new ComboBox();
            lblSiteDay = new Label();
            txtSiteDistance = new TextBox();
            lblSiteDistance = new Label();
            ((System.ComponentModel.ISupportInitialize)picHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picHelp
            // 
            picHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHelp.Cursor = Cursors.Hand;
            picHelp.Image = Properties.Resources.help;
            picHelp.Location = new Point(452, 7);
            picHelp.Name = "picHelp";
            picHelp.Size = new Size(30, 30);
            picHelp.SizeMode = PictureBoxSizeMode.Zoom;
            picHelp.TabIndex = 107;
            picHelp.TabStop = false;
            // 
            // lblResetSite
            // 
            lblResetSite.AutoSize = true;
            lblResetSite.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblResetSite.LinkColor = Color.Gray;
            lblResetSite.Location = new Point(399, 507);
            lblResetSite.Name = "lblResetSite";
            lblResetSite.Size = new Size(65, 16);
            lblResetSite.TabIndex = 106;
            lblResetSite.TabStop = true;
            lblResetSite.Text = "Reset Fields";
            lblResetSite.Visible = false;
            // 
            // tipError
            // 
            tipError.AutoPopDelay = 5000;
            tipError.InitialDelay = 200;
            tipError.IsBalloon = true;
            tipError.ReshowDelay = 100;
            tipError.ToolTipIcon = ToolTipIcon.Warning;
            // 
            // lblErrCity
            // 
            lblErrCity.Anchor = AnchorStyles.None;
            lblErrCity.AutoSize = true;
            lblErrCity.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrCity.ForeColor = Color.Red;
            lblErrCity.Location = new Point(467, 241);
            lblErrCity.Name = "lblErrCity";
            lblErrCity.Size = new Size(12, 15);
            lblErrCity.TabIndex = 101;
            lblErrCity.Tag = "City ";
            lblErrCity.Text = "*";
            tipError.SetToolTip(lblErrCity, "City Required");
            lblErrCity.Visible = false;
            // 
            // lblErrAddress
            // 
            lblErrAddress.Anchor = AnchorStyles.None;
            lblErrAddress.AutoSize = true;
            lblErrAddress.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrAddress.ForeColor = Color.Red;
            lblErrAddress.Location = new Point(467, 158);
            lblErrAddress.Name = "lblErrAddress";
            lblErrAddress.Size = new Size(12, 15);
            lblErrAddress.TabIndex = 99;
            lblErrAddress.Tag = "Address ";
            lblErrAddress.Text = "*";
            tipError.SetToolTip(lblErrAddress, "Address Required");
            lblErrAddress.Visible = false;
            // 
            // lblErrSite
            // 
            lblErrSite.Anchor = AnchorStyles.None;
            lblErrSite.AutoSize = true;
            lblErrSite.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrSite.ForeColor = Color.Red;
            lblErrSite.Location = new Point(467, 117);
            lblErrSite.Name = "lblErrSite";
            lblErrSite.Size = new Size(12, 15);
            lblErrSite.TabIndex = 98;
            lblErrSite.Tag = "Location ";
            lblErrSite.Text = "*";
            tipError.SetToolTip(lblErrSite, "Location Required");
            lblErrSite.Visible = false;
            // 
            // lblErrSiteID
            // 
            lblErrSiteID.Anchor = AnchorStyles.None;
            lblErrSiteID.AutoSize = true;
            lblErrSiteID.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrSiteID.ForeColor = Color.Red;
            lblErrSiteID.Location = new Point(193, 76);
            lblErrSiteID.Name = "lblErrSiteID";
            lblErrSiteID.Size = new Size(12, 15);
            lblErrSiteID.TabIndex = 97;
            lblErrSiteID.Tag = "Site ID ";
            lblErrSiteID.Text = "*";
            tipError.SetToolTip(lblErrSiteID, "Site ID is Required");
            lblErrSiteID.Visible = false;
            // 
            // lblErrCountry
            // 
            lblErrCountry.Anchor = AnchorStyles.None;
            lblErrCountry.AutoSize = true;
            lblErrCountry.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrCountry.ForeColor = Color.Red;
            lblErrCountry.Location = new Point(224, 281);
            lblErrCountry.Name = "lblErrCountry";
            lblErrCountry.Size = new Size(12, 15);
            lblErrCountry.TabIndex = 114;
            lblErrCountry.Tag = "Country ";
            lblErrCountry.Text = "*";
            tipError.SetToolTip(lblErrCountry, "Country Required");
            lblErrCountry.Visible = false;
            // 
            // lblErrPostal
            // 
            lblErrPostal.Anchor = AnchorStyles.None;
            lblErrPostal.AutoSize = true;
            lblErrPostal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrPostal.ForeColor = Color.Red;
            lblErrPostal.Location = new Point(224, 322);
            lblErrPostal.Name = "lblErrPostal";
            lblErrPostal.Size = new Size(12, 15);
            lblErrPostal.TabIndex = 115;
            lblErrPostal.Tag = "Postal Code ";
            lblErrPostal.Text = "*";
            tipError.SetToolTip(lblErrPostal, "Postal Code Required: Must be a valid code (ex. E1J2E3 or E1J 2E3)");
            lblErrPostal.Visible = false;
            // 
            // lblErrDistance
            // 
            lblErrDistance.Anchor = AnchorStyles.None;
            lblErrDistance.AutoSize = true;
            lblErrDistance.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrDistance.ForeColor = Color.Red;
            lblErrDistance.Location = new Point(224, 362);
            lblErrDistance.Name = "lblErrDistance";
            lblErrDistance.Size = new Size(12, 15);
            lblErrDistance.TabIndex = 116;
            lblErrDistance.Tag = "Distance ";
            lblErrDistance.Text = "*";
            tipError.SetToolTip(lblErrDistance, "Distance Required: Must be a number");
            lblErrDistance.Visible = false;
            // 
            // lblErrProvince
            // 
            lblErrProvince.Anchor = AnchorStyles.None;
            lblErrProvince.AutoSize = true;
            lblErrProvince.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrProvince.ForeColor = Color.Red;
            lblErrProvince.Location = new Point(467, 281);
            lblErrProvince.Name = "lblErrProvince";
            lblErrProvince.Size = new Size(12, 15);
            lblErrProvince.TabIndex = 117;
            lblErrProvince.Tag = "Province ";
            lblErrProvince.Text = "*";
            tipError.SetToolTip(lblErrProvince, "Province Required");
            lblErrProvince.Visible = false;
            // 
            // lblErrPhone
            // 
            lblErrPhone.Anchor = AnchorStyles.None;
            lblErrPhone.AutoSize = true;
            lblErrPhone.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrPhone.ForeColor = Color.Red;
            lblErrPhone.Location = new Point(467, 322);
            lblErrPhone.Name = "lblErrPhone";
            lblErrPhone.Size = new Size(12, 15);
            lblErrPhone.TabIndex = 118;
            lblErrPhone.Tag = "Phone ";
            lblErrPhone.Text = "*";
            tipError.SetToolTip(lblErrPhone, "Phone Required: Must be 10 digits (ex. 5061234567)");
            lblErrPhone.Visible = false;
            // 
            // lblErrDay
            // 
            lblErrDay.Anchor = AnchorStyles.None;
            lblErrDay.AutoSize = true;
            lblErrDay.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrDay.ForeColor = Color.Red;
            lblErrDay.Location = new Point(467, 362);
            lblErrDay.Name = "lblErrDay";
            lblErrDay.Size = new Size(12, 15);
            lblErrDay.TabIndex = 119;
            lblErrDay.Tag = "Delivery Day ";
            lblErrDay.Text = "*";
            tipError.SetToolTip(lblErrDay, "Delivery Day Required");
            lblErrDay.Visible = false;
            // 
            // lblAddEditError
            // 
            lblAddEditError.Anchor = AnchorStyles.None;
            lblAddEditError.AutoSize = true;
            lblAddEditError.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditError.ForeColor = Color.Red;
            lblAddEditError.Location = new Point(32, 524);
            lblAddEditError.Name = "lblAddEditError";
            lblAddEditError.Size = new Size(298, 15);
            lblAddEditError.TabIndex = 96;
            lblAddEditError.Text = "Location information invalid: Hover over * for details";
            lblAddEditError.Visible = false;
            // 
            // txtSiteNotes
            // 
            txtSiteNotes.BorderStyle = BorderStyle.FixedSingle;
            txtSiteNotes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSiteNotes.Location = new Point(111, 410);
            txtSiteNotes.Name = "txtSiteNotes";
            txtSiteNotes.Size = new Size(328, 82);
            txtSiteNotes.TabIndex = 94;
            txtSiteNotes.Text = "";
            // 
            // lblSiteNotes
            // 
            lblSiteNotes.Anchor = AnchorStyles.None;
            lblSiteNotes.AutoSize = true;
            lblSiteNotes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteNotes.Location = new Point(13, 404);
            lblSiteNotes.Name = "lblSiteNotes";
            lblSiteNotes.Size = new Size(46, 15);
            lblSiteNotes.TabIndex = 93;
            lblSiteNotes.Text = "Notes: ";
            // 
            // btnAddEditCancel
            // 
            btnAddEditCancel.Anchor = AnchorStyles.None;
            btnAddEditCancel.BackColor = Color.OrangeRed;
            btnAddEditCancel.Cursor = Cursors.Hand;
            btnAddEditCancel.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEditCancel.ForeColor = Color.White;
            btnAddEditCancel.Location = new Point(267, 555);
            btnAddEditCancel.Name = "btnAddEditCancel";
            btnAddEditCancel.Size = new Size(189, 38);
            btnAddEditCancel.TabIndex = 92;
            btnAddEditCancel.Text = "CANCEL";
            btnAddEditCancel.UseVisualStyleBackColor = false;
            btnAddEditCancel.Click += btnAddEditCancel_Click;
            // 
            // btnAddEditSave
            // 
            btnAddEditSave.Anchor = AnchorStyles.None;
            btnAddEditSave.BackColor = Color.OrangeRed;
            btnAddEditSave.Cursor = Cursors.Hand;
            btnAddEditSave.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEditSave.ForeColor = Color.White;
            btnAddEditSave.Location = new Point(32, 555);
            btnAddEditSave.Name = "btnAddEditSave";
            btnAddEditSave.Size = new Size(189, 38);
            btnAddEditSave.TabIndex = 91;
            btnAddEditSave.Text = "SAVE";
            btnAddEditSave.UseVisualStyleBackColor = false;
            btnAddEditSave.Click += btnAddEditSave_Click;
            // 
            // lblAddEditDetails
            // 
            lblAddEditDetails.Anchor = AnchorStyles.None;
            lblAddEditDetails.AutoSize = true;
            lblAddEditDetails.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditDetails.Location = new Point(168, 44);
            lblAddEditDetails.Name = "lblAddEditDetails";
            lblAddEditDetails.Size = new Size(161, 16);
            lblAddEditDetails.TabIndex = 90;
            lblAddEditDetails.Tag = "location fields and save changes";
            lblAddEditDetails.Text = "Edit location fields and save changes";
            // 
            // lblAddEditSite
            // 
            lblAddEditSite.Anchor = AnchorStyles.None;
            lblAddEditSite.AutoSize = true;
            lblAddEditSite.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditSite.Location = new Point(178, 20);
            lblAddEditSite.Name = "lblAddEditSite";
            lblAddEditSite.Size = new Size(143, 24);
            lblAddEditSite.TabIndex = 89;
            lblAddEditSite.Text = "Edit Location";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bullseye;
            pictureBox1.Location = new Point(10, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // cboSiteCountry
            // 
            cboSiteCountry.Anchor = AnchorStyles.None;
            cboSiteCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSiteCountry.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSiteCountry.FormattingEnabled = true;
            cboSiteCountry.Location = new Point(111, 281);
            cboSiteCountry.Name = "cboSiteCountry";
            cboSiteCountry.Size = new Size(110, 23);
            cboSiteCountry.TabIndex = 86;
            // 
            // txtSitePostal
            // 
            txtSitePostal.Anchor = AnchorStyles.None;
            txtSitePostal.BackColor = Color.White;
            txtSitePostal.BorderStyle = BorderStyle.FixedSingle;
            txtSitePostal.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSitePostal.Location = new Point(111, 322);
            txtSitePostal.Name = "txtSitePostal";
            txtSitePostal.Size = new Size(110, 21);
            txtSitePostal.TabIndex = 85;
            // 
            // txtSiteCity
            // 
            txtSiteCity.Anchor = AnchorStyles.None;
            txtSiteCity.BackColor = Color.White;
            txtSiteCity.BorderStyle = BorderStyle.FixedSingle;
            txtSiteCity.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSiteCity.Location = new Point(111, 241);
            txtSiteCity.Name = "txtSiteCity";
            txtSiteCity.Size = new Size(353, 21);
            txtSiteCity.TabIndex = 84;
            // 
            // txtSiteAdd2
            // 
            txtSiteAdd2.Anchor = AnchorStyles.None;
            txtSiteAdd2.BackColor = Color.White;
            txtSiteAdd2.BorderStyle = BorderStyle.FixedSingle;
            txtSiteAdd2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSiteAdd2.Location = new Point(111, 199);
            txtSiteAdd2.Name = "txtSiteAdd2";
            txtSiteAdd2.Size = new Size(353, 21);
            txtSiteAdd2.TabIndex = 83;
            // 
            // txtSiteAdd
            // 
            txtSiteAdd.Anchor = AnchorStyles.None;
            txtSiteAdd.BackColor = Color.White;
            txtSiteAdd.BorderStyle = BorderStyle.FixedSingle;
            txtSiteAdd.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSiteAdd.Location = new Point(111, 158);
            txtSiteAdd.Name = "txtSiteAdd";
            txtSiteAdd.Size = new Size(353, 21);
            txtSiteAdd.TabIndex = 82;
            // 
            // txtSiteName
            // 
            txtSiteName.Anchor = AnchorStyles.None;
            txtSiteName.BackColor = Color.White;
            txtSiteName.BorderStyle = BorderStyle.FixedSingle;
            txtSiteName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSiteName.Location = new Point(111, 117);
            txtSiteName.Name = "txtSiteName";
            txtSiteName.Size = new Size(353, 21);
            txtSiteName.TabIndex = 81;
            // 
            // cboSiteProvince
            // 
            cboSiteProvince.Anchor = AnchorStyles.None;
            cboSiteProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSiteProvince.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSiteProvince.FormattingEnabled = true;
            cboSiteProvince.Location = new Point(324, 281);
            cboSiteProvince.Name = "cboSiteProvince";
            cboSiteProvince.Size = new Size(140, 23);
            cboSiteProvince.TabIndex = 80;
            // 
            // txtSiteID
            // 
            txtSiteID.Anchor = AnchorStyles.None;
            txtSiteID.BackColor = Color.White;
            txtSiteID.BorderStyle = BorderStyle.FixedSingle;
            txtSiteID.Enabled = false;
            txtSiteID.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSiteID.Location = new Point(111, 76);
            txtSiteID.Name = "txtSiteID";
            txtSiteID.ReadOnly = true;
            txtSiteID.Size = new Size(76, 21);
            txtSiteID.TabIndex = 79;
            // 
            // lblSiteAddress
            // 
            lblSiteAddress.Anchor = AnchorStyles.None;
            lblSiteAddress.AutoSize = true;
            lblSiteAddress.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteAddress.Location = new Point(13, 160);
            lblSiteAddress.Name = "lblSiteAddress";
            lblSiteAddress.Size = new Size(61, 15);
            lblSiteAddress.TabIndex = 78;
            lblSiteAddress.Text = "Address: ";
            // 
            // lblSiteName
            // 
            lblSiteName.Anchor = AnchorStyles.None;
            lblSiteName.AutoSize = true;
            lblSiteName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteName.Location = new Point(13, 119);
            lblSiteName.Name = "lblSiteName";
            lblSiteName.Size = new Size(62, 15);
            lblSiteName.TabIndex = 77;
            lblSiteName.Text = "Location: ";
            // 
            // lblSiteAddress2
            // 
            lblSiteAddress2.Anchor = AnchorStyles.None;
            lblSiteAddress2.AutoSize = true;
            lblSiteAddress2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteAddress2.Location = new Point(13, 201);
            lblSiteAddress2.Name = "lblSiteAddress2";
            lblSiteAddress2.Size = new Size(71, 15);
            lblSiteAddress2.TabIndex = 76;
            lblSiteAddress2.Text = "Address 2: ";
            // 
            // lblSiteCity
            // 
            lblSiteCity.Anchor = AnchorStyles.None;
            lblSiteCity.AutoSize = true;
            lblSiteCity.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteCity.Location = new Point(13, 243);
            lblSiteCity.Name = "lblSiteCity";
            lblSiteCity.Size = new Size(34, 15);
            lblSiteCity.TabIndex = 75;
            lblSiteCity.Text = "City: ";
            // 
            // lblSitePostal
            // 
            lblSitePostal.Anchor = AnchorStyles.None;
            lblSitePostal.AutoSize = true;
            lblSitePostal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSitePostal.Location = new Point(13, 325);
            lblSitePostal.Name = "lblSitePostal";
            lblSitePostal.Size = new Size(81, 15);
            lblSitePostal.TabIndex = 74;
            lblSitePostal.Text = "Postal Code: ";
            // 
            // lblSiteProv
            // 
            lblSiteProv.Anchor = AnchorStyles.None;
            lblSiteProv.AutoSize = true;
            lblSiteProv.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteProv.Location = new Point(242, 285);
            lblSiteProv.Name = "lblSiteProv";
            lblSiteProv.Size = new Size(63, 15);
            lblSiteProv.TabIndex = 73;
            lblSiteProv.Text = "Province: ";
            // 
            // lblSiteCountry
            // 
            lblSiteCountry.Anchor = AnchorStyles.None;
            lblSiteCountry.AutoSize = true;
            lblSiteCountry.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteCountry.Location = new Point(13, 284);
            lblSiteCountry.Name = "lblSiteCountry";
            lblSiteCountry.Size = new Size(57, 15);
            lblSiteCountry.TabIndex = 72;
            lblSiteCountry.Text = "Country: ";
            // 
            // lblSiteID
            // 
            lblSiteID.Anchor = AnchorStyles.None;
            lblSiteID.AutoSize = true;
            lblSiteID.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteID.Location = new Point(13, 78);
            lblSiteID.Name = "lblSiteID";
            lblSiteID.Size = new Size(49, 15);
            lblSiteID.TabIndex = 71;
            lblSiteID.Text = "Site ID: ";
            // 
            // txtSitePhone
            // 
            txtSitePhone.Anchor = AnchorStyles.None;
            txtSitePhone.BackColor = Color.White;
            txtSitePhone.BorderStyle = BorderStyle.FixedSingle;
            txtSitePhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSitePhone.Location = new Point(324, 323);
            txtSitePhone.Name = "txtSitePhone";
            txtSitePhone.Size = new Size(140, 21);
            txtSitePhone.TabIndex = 109;
            // 
            // lblSitePhone
            // 
            lblSitePhone.Anchor = AnchorStyles.None;
            lblSitePhone.AutoSize = true;
            lblSitePhone.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSitePhone.Location = new Point(242, 325);
            lblSitePhone.Name = "lblSitePhone";
            lblSitePhone.Size = new Size(49, 15);
            lblSitePhone.TabIndex = 108;
            lblSitePhone.Text = "Phone: ";
            // 
            // cboSiteDay
            // 
            cboSiteDay.Anchor = AnchorStyles.None;
            cboSiteDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSiteDay.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSiteDay.FormattingEnabled = true;
            cboSiteDay.Location = new Point(324, 362);
            cboSiteDay.Name = "cboSiteDay";
            cboSiteDay.Size = new Size(140, 23);
            cboSiteDay.TabIndex = 111;
            // 
            // lblSiteDay
            // 
            lblSiteDay.Anchor = AnchorStyles.None;
            lblSiteDay.AutoSize = true;
            lblSiteDay.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteDay.Location = new Point(242, 365);
            lblSiteDay.Name = "lblSiteDay";
            lblSiteDay.Size = new Size(82, 15);
            lblSiteDay.TabIndex = 110;
            lblSiteDay.Text = "Delivery Day: ";
            // 
            // txtSiteDistance
            // 
            txtSiteDistance.Anchor = AnchorStyles.None;
            txtSiteDistance.BackColor = Color.White;
            txtSiteDistance.BorderStyle = BorderStyle.FixedSingle;
            txtSiteDistance.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSiteDistance.Location = new Point(111, 362);
            txtSiteDistance.Name = "txtSiteDistance";
            txtSiteDistance.Size = new Size(110, 21);
            txtSiteDistance.TabIndex = 113;
            // 
            // lblSiteDistance
            // 
            lblSiteDistance.Anchor = AnchorStyles.None;
            lblSiteDistance.AutoSize = true;
            lblSiteDistance.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiteDistance.Location = new Point(13, 365);
            lblSiteDistance.Name = "lblSiteDistance";
            lblSiteDistance.Size = new Size(92, 15);
            lblSiteDistance.TabIndex = 112;
            lblSiteDistance.Text = "Distance (km): ";
            // 
            // AddEditSiteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(491, 601);
            Controls.Add(lblErrDay);
            Controls.Add(lblErrPhone);
            Controls.Add(lblErrProvince);
            Controls.Add(lblErrDistance);
            Controls.Add(lblErrPostal);
            Controls.Add(lblErrCountry);
            Controls.Add(txtSiteDistance);
            Controls.Add(lblSiteDistance);
            Controls.Add(cboSiteDay);
            Controls.Add(lblSiteDay);
            Controls.Add(txtSitePhone);
            Controls.Add(lblSitePhone);
            Controls.Add(picHelp);
            Controls.Add(lblResetSite);
            Controls.Add(lblErrCity);
            Controls.Add(lblErrAddress);
            Controls.Add(lblErrSite);
            Controls.Add(lblErrSiteID);
            Controls.Add(lblAddEditError);
            Controls.Add(txtSiteNotes);
            Controls.Add(lblSiteNotes);
            Controls.Add(btnAddEditCancel);
            Controls.Add(btnAddEditSave);
            Controls.Add(lblAddEditDetails);
            Controls.Add(lblAddEditSite);
            Controls.Add(pictureBox1);
            Controls.Add(cboSiteCountry);
            Controls.Add(txtSitePostal);
            Controls.Add(txtSiteCity);
            Controls.Add(txtSiteAdd2);
            Controls.Add(txtSiteAdd);
            Controls.Add(txtSiteName);
            Controls.Add(cboSiteProvince);
            Controls.Add(txtSiteID);
            Controls.Add(lblSiteAddress);
            Controls.Add(lblSiteName);
            Controls.Add(lblSiteAddress2);
            Controls.Add(lblSiteCity);
            Controls.Add(lblSitePostal);
            Controls.Add(lblSiteProv);
            Controls.Add(lblSiteCountry);
            Controls.Add(lblSiteID);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddEditSiteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditSiteForm - ";
            Load += AddEditSiteForm_Load;
            ((System.ComponentModel.ISupportInitialize)picHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picHelp;
        private LinkLabel lblResetSite;
        private ToolTip tipError;
        private Label lblErrCity;
        private Label lblErrAddress;
        private Label lblErrSite;
        private Label lblErrSiteID;
        private Label lblAddEditError;
        private RichTextBox txtSiteNotes;
        private Label lblSiteNotes;
        private Button btnAddEditCancel;
        private Button btnAddEditSave;
        private Label lblAddEditDetails;
        private Label lblAddEditSite;
        private PictureBox pictureBox1;
        private ComboBox cboSiteCountry;
        private TextBox txtSitePostal;
        private TextBox txtSiteCity;
        private TextBox txtSiteAdd2;
        private TextBox txtSiteAdd;
        private TextBox txtSiteName;
        private ComboBox cboSiteProvince;
        private TextBox txtSiteID;
        private Label lblSiteAddress;
        private Label lblSiteName;
        private Label lblSiteAddress2;
        private Label lblSiteCity;
        private Label lblSitePostal;
        private Label lblSiteProv;
        private Label lblSiteCountry;
        private Label lblSiteID;
        private TextBox txtSitePhone;
        private Label lblSitePhone;
        private ComboBox cboSiteDay;
        private Label lblSiteDay;
        private TextBox txtSiteDistance;
        private Label lblSiteDistance;
        private Label lblErrCountry;
        private Label lblErrPostal;
        private Label lblErrDistance;
        private Label lblErrProvince;
        private Label lblErrPhone;
        private Label lblErrDay;
    }
}