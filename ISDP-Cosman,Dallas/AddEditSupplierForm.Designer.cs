namespace ISDP_Cosman_Dallas
{
    partial class frmAddEditSupplier
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
            lblErrPhone = new Label();
            lblErrProvince = new Label();
            lblErrContact = new Label();
            lblErrPostal = new Label();
            lblErrCountry = new Label();
            txtSuppContact = new TextBox();
            lblSuppContact = new Label();
            txtSuppPhone = new TextBox();
            lblSuppPhone = new Label();
            picHelp = new PictureBox();
            lblErrName = new Label();
            lblAddEditError = new Label();
            txtSuppNotes = new RichTextBox();
            lblSuppNotes = new Label();
            btnAddEditCancel = new Button();
            btnAddEditSave = new Button();
            lblAddEditDetails = new Label();
            lblAddEditSupplier = new Label();
            pictureBox1 = new PictureBox();
            tipError = new ToolTip(components);
            lblErrCity = new Label();
            lblErrAddress = new Label();
            cboSuppCountry = new ComboBox();
            txtSuppPostal = new TextBox();
            txtSupplierCity = new TextBox();
            txtSupplierAdd2 = new TextBox();
            txtSupplierAdd = new TextBox();
            txtSupplierName = new TextBox();
            cboSuppProvince = new ComboBox();
            txtSupplierID = new TextBox();
            lblSupplierAddress = new Label();
            lblSupplierName = new Label();
            lblSupplierAddress2 = new Label();
            lblSupplierCity = new Label();
            lblSuppPostal = new Label();
            lblSuppProv = new Label();
            lblSuppCountry = new Label();
            lblSupplierID = new Label();
            ((System.ComponentModel.ISupportInitialize)picHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblErrPhone
            // 
            lblErrPhone.Anchor = AnchorStyles.None;
            lblErrPhone.AutoSize = true;
            lblErrPhone.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrPhone.ForeColor = Color.Red;
            lblErrPhone.Location = new Point(466, 322);
            lblErrPhone.Name = "lblErrPhone";
            lblErrPhone.Size = new Size(12, 15);
            lblErrPhone.TabIndex = 160;
            lblErrPhone.Tag = "Phone ";
            lblErrPhone.Text = "*";
            tipError.SetToolTip(lblErrPhone, "Phone Required: Must be 10 digits (ex. 5061234567)");
            lblErrPhone.Visible = false;
            // 
            // lblErrProvince
            // 
            lblErrProvince.Anchor = AnchorStyles.None;
            lblErrProvince.AutoSize = true;
            lblErrProvince.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrProvince.ForeColor = Color.Red;
            lblErrProvince.Location = new Point(466, 281);
            lblErrProvince.Name = "lblErrProvince";
            lblErrProvince.Size = new Size(12, 15);
            lblErrProvince.TabIndex = 159;
            lblErrProvince.Tag = "Province ";
            lblErrProvince.Text = "*";
            tipError.SetToolTip(lblErrProvince, "Province Required");
            lblErrProvince.Visible = false;
            // 
            // lblErrContact
            // 
            lblErrContact.Anchor = AnchorStyles.None;
            lblErrContact.AutoSize = true;
            lblErrContact.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrContact.ForeColor = Color.Red;
            lblErrContact.Location = new Point(466, 362);
            lblErrContact.Name = "lblErrContact";
            lblErrContact.Size = new Size(12, 15);
            lblErrContact.TabIndex = 158;
            lblErrContact.Tag = "Distance ";
            lblErrContact.Text = "*";
            tipError.SetToolTip(lblErrContact, "Contact Required");
            lblErrContact.Visible = false;
            // 
            // lblErrPostal
            // 
            lblErrPostal.Anchor = AnchorStyles.None;
            lblErrPostal.AutoSize = true;
            lblErrPostal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrPostal.ForeColor = Color.Red;
            lblErrPostal.Location = new Point(223, 322);
            lblErrPostal.Name = "lblErrPostal";
            lblErrPostal.Size = new Size(12, 15);
            lblErrPostal.TabIndex = 157;
            lblErrPostal.Tag = "Postal Code ";
            lblErrPostal.Text = "*";
            tipError.SetToolTip(lblErrPostal, "Postal Code Required: Must be a valid code (ex. E1J2E3 or E1J 2E3)");
            lblErrPostal.Visible = false;
            // 
            // lblErrCountry
            // 
            lblErrCountry.Anchor = AnchorStyles.None;
            lblErrCountry.AutoSize = true;
            lblErrCountry.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrCountry.ForeColor = Color.Red;
            lblErrCountry.Location = new Point(223, 281);
            lblErrCountry.Name = "lblErrCountry";
            lblErrCountry.Size = new Size(12, 15);
            lblErrCountry.TabIndex = 156;
            lblErrCountry.Tag = "Country ";
            lblErrCountry.Text = "*";
            tipError.SetToolTip(lblErrCountry, "Country Required");
            lblErrCountry.Visible = false;
            // 
            // txtSuppContact
            // 
            txtSuppContact.Anchor = AnchorStyles.None;
            txtSuppContact.BackColor = Color.White;
            txtSuppContact.BorderStyle = BorderStyle.FixedSingle;
            txtSuppContact.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSuppContact.Location = new Point(110, 364);
            txtSuppContact.Name = "txtSuppContact";
            txtSuppContact.Size = new Size(353, 21);
            txtSuppContact.TabIndex = 155;
            // 
            // lblSuppContact
            // 
            lblSuppContact.Anchor = AnchorStyles.None;
            lblSuppContact.AutoSize = true;
            lblSuppContact.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuppContact.Location = new Point(12, 365);
            lblSuppContact.Name = "lblSuppContact";
            lblSuppContact.Size = new Size(57, 15);
            lblSuppContact.TabIndex = 154;
            lblSuppContact.Text = "Contact: ";
            // 
            // txtSuppPhone
            // 
            txtSuppPhone.Anchor = AnchorStyles.None;
            txtSuppPhone.BackColor = Color.White;
            txtSuppPhone.BorderStyle = BorderStyle.FixedSingle;
            txtSuppPhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSuppPhone.Location = new Point(323, 323);
            txtSuppPhone.Name = "txtSuppPhone";
            txtSuppPhone.Size = new Size(140, 21);
            txtSuppPhone.TabIndex = 151;
            // 
            // lblSuppPhone
            // 
            lblSuppPhone.Anchor = AnchorStyles.None;
            lblSuppPhone.AutoSize = true;
            lblSuppPhone.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuppPhone.Location = new Point(241, 325);
            lblSuppPhone.Name = "lblSuppPhone";
            lblSuppPhone.Size = new Size(49, 15);
            lblSuppPhone.TabIndex = 150;
            lblSuppPhone.Text = "Phone: ";
            // 
            // picHelp
            // 
            picHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHelp.Cursor = Cursors.Hand;
            picHelp.Image = Properties.Resources.help;
            picHelp.Location = new Point(451, 7);
            picHelp.Name = "picHelp";
            picHelp.Size = new Size(30, 30);
            picHelp.SizeMode = PictureBoxSizeMode.Zoom;
            picHelp.TabIndex = 149;
            picHelp.TabStop = false;
            // 
            // lblErrName
            // 
            lblErrName.Anchor = AnchorStyles.None;
            lblErrName.AutoSize = true;
            lblErrName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrName.ForeColor = Color.Red;
            lblErrName.Location = new Point(466, 117);
            lblErrName.Name = "lblErrName";
            lblErrName.Size = new Size(12, 15);
            lblErrName.TabIndex = 145;
            lblErrName.Tag = "Location ";
            lblErrName.Text = "*";
            tipError.SetToolTip(lblErrName, "Name Required");
            lblErrName.Visible = false;
            // 
            // lblAddEditError
            // 
            lblAddEditError.Anchor = AnchorStyles.None;
            lblAddEditError.AutoSize = true;
            lblAddEditError.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditError.ForeColor = Color.Red;
            lblAddEditError.Location = new Point(97, 524);
            lblAddEditError.Name = "lblAddEditError";
            lblAddEditError.Size = new Size(296, 15);
            lblAddEditError.TabIndex = 143;
            lblAddEditError.Text = "Supplier information invalid: Hover over * for details";
            lblAddEditError.Visible = false;
            // 
            // txtSuppNotes
            // 
            txtSuppNotes.BorderStyle = BorderStyle.FixedSingle;
            txtSuppNotes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSuppNotes.Location = new Point(110, 410);
            txtSuppNotes.Name = "txtSuppNotes";
            txtSuppNotes.Size = new Size(353, 82);
            txtSuppNotes.TabIndex = 142;
            txtSuppNotes.Text = "";
            // 
            // lblSuppNotes
            // 
            lblSuppNotes.Anchor = AnchorStyles.None;
            lblSuppNotes.AutoSize = true;
            lblSuppNotes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuppNotes.Location = new Point(12, 404);
            lblSuppNotes.Name = "lblSuppNotes";
            lblSuppNotes.Size = new Size(46, 15);
            lblSuppNotes.TabIndex = 141;
            lblSuppNotes.Text = "Notes: ";
            // 
            // btnAddEditCancel
            // 
            btnAddEditCancel.Anchor = AnchorStyles.None;
            btnAddEditCancel.BackColor = Color.OrangeRed;
            btnAddEditCancel.Cursor = Cursors.Hand;
            btnAddEditCancel.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEditCancel.ForeColor = Color.White;
            btnAddEditCancel.Location = new Point(266, 555);
            btnAddEditCancel.Name = "btnAddEditCancel";
            btnAddEditCancel.Size = new Size(189, 38);
            btnAddEditCancel.TabIndex = 140;
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
            btnAddEditSave.Location = new Point(31, 555);
            btnAddEditSave.Name = "btnAddEditSave";
            btnAddEditSave.Size = new Size(189, 38);
            btnAddEditSave.TabIndex = 139;
            btnAddEditSave.Text = "SAVE";
            btnAddEditSave.UseVisualStyleBackColor = false;
            btnAddEditSave.Click += btnAddEditSave_Click;
            // 
            // lblAddEditDetails
            // 
            lblAddEditDetails.Anchor = AnchorStyles.None;
            lblAddEditDetails.AutoSize = true;
            lblAddEditDetails.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditDetails.Location = new Point(167, 44);
            lblAddEditDetails.Name = "lblAddEditDetails";
            lblAddEditDetails.Size = new Size(162, 16);
            lblAddEditDetails.TabIndex = 138;
            lblAddEditDetails.Tag = "supplier fields and save changes";
            lblAddEditDetails.Text = "Edit supplier fields and save changes";
            // 
            // lblAddEditSupplier
            // 
            lblAddEditSupplier.Anchor = AnchorStyles.None;
            lblAddEditSupplier.AutoSize = true;
            lblAddEditSupplier.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditSupplier.Location = new Point(177, 20);
            lblAddEditSupplier.Name = "lblAddEditSupplier";
            lblAddEditSupplier.Size = new Size(138, 24);
            lblAddEditSupplier.TabIndex = 137;
            lblAddEditSupplier.Tag = "Supplier";
            lblAddEditSupplier.Text = "Edit Supplier";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bullseye;
            pictureBox1.Location = new Point(9, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 136;
            pictureBox1.TabStop = false;
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
            lblErrCity.Location = new Point(466, 241);
            lblErrCity.Name = "lblErrCity";
            lblErrCity.Size = new Size(12, 15);
            lblErrCity.TabIndex = 147;
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
            lblErrAddress.Location = new Point(466, 158);
            lblErrAddress.Name = "lblErrAddress";
            lblErrAddress.Size = new Size(12, 15);
            lblErrAddress.TabIndex = 146;
            lblErrAddress.Tag = "Address ";
            lblErrAddress.Text = "*";
            tipError.SetToolTip(lblErrAddress, "Address Required");
            lblErrAddress.Visible = false;
            // 
            // cboSuppCountry
            // 
            cboSuppCountry.Anchor = AnchorStyles.None;
            cboSuppCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuppCountry.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSuppCountry.FormattingEnabled = true;
            cboSuppCountry.Location = new Point(110, 281);
            cboSuppCountry.Name = "cboSuppCountry";
            cboSuppCountry.Size = new Size(110, 23);
            cboSuppCountry.TabIndex = 135;
            // 
            // txtSuppPostal
            // 
            txtSuppPostal.Anchor = AnchorStyles.None;
            txtSuppPostal.BackColor = Color.White;
            txtSuppPostal.BorderStyle = BorderStyle.FixedSingle;
            txtSuppPostal.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSuppPostal.Location = new Point(110, 322);
            txtSuppPostal.Name = "txtSuppPostal";
            txtSuppPostal.Size = new Size(110, 21);
            txtSuppPostal.TabIndex = 134;
            // 
            // txtSupplierCity
            // 
            txtSupplierCity.Anchor = AnchorStyles.None;
            txtSupplierCity.BackColor = Color.White;
            txtSupplierCity.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierCity.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierCity.Location = new Point(110, 241);
            txtSupplierCity.Name = "txtSupplierCity";
            txtSupplierCity.Size = new Size(353, 21);
            txtSupplierCity.TabIndex = 133;
            // 
            // txtSupplierAdd2
            // 
            txtSupplierAdd2.Anchor = AnchorStyles.None;
            txtSupplierAdd2.BackColor = Color.White;
            txtSupplierAdd2.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierAdd2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierAdd2.Location = new Point(110, 199);
            txtSupplierAdd2.Name = "txtSupplierAdd2";
            txtSupplierAdd2.Size = new Size(353, 21);
            txtSupplierAdd2.TabIndex = 132;
            // 
            // txtSupplierAdd
            // 
            txtSupplierAdd.Anchor = AnchorStyles.None;
            txtSupplierAdd.BackColor = Color.White;
            txtSupplierAdd.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierAdd.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierAdd.Location = new Point(110, 158);
            txtSupplierAdd.Name = "txtSupplierAdd";
            txtSupplierAdd.Size = new Size(353, 21);
            txtSupplierAdd.TabIndex = 131;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = AnchorStyles.None;
            txtSupplierName.BackColor = Color.White;
            txtSupplierName.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierName.Location = new Point(110, 117);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(353, 21);
            txtSupplierName.TabIndex = 130;
            // 
            // cboSuppProvince
            // 
            cboSuppProvince.Anchor = AnchorStyles.None;
            cboSuppProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuppProvince.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSuppProvince.FormattingEnabled = true;
            cboSuppProvince.Location = new Point(323, 281);
            cboSuppProvince.Name = "cboSuppProvince";
            cboSuppProvince.Size = new Size(140, 23);
            cboSuppProvince.TabIndex = 129;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Anchor = AnchorStyles.None;
            txtSupplierID.BackColor = Color.White;
            txtSupplierID.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierID.Enabled = false;
            txtSupplierID.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierID.Location = new Point(110, 76);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.ReadOnly = true;
            txtSupplierID.Size = new Size(110, 21);
            txtSupplierID.TabIndex = 128;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.Anchor = AnchorStyles.None;
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSupplierAddress.Location = new Point(12, 160);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(61, 15);
            lblSupplierAddress.TabIndex = 127;
            lblSupplierAddress.Text = "Address: ";
            // 
            // lblSupplierName
            // 
            lblSupplierName.Anchor = AnchorStyles.None;
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSupplierName.Location = new Point(12, 119);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(46, 15);
            lblSupplierName.TabIndex = 126;
            lblSupplierName.Text = "Name: ";
            // 
            // lblSupplierAddress2
            // 
            lblSupplierAddress2.Anchor = AnchorStyles.None;
            lblSupplierAddress2.AutoSize = true;
            lblSupplierAddress2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSupplierAddress2.Location = new Point(12, 201);
            lblSupplierAddress2.Name = "lblSupplierAddress2";
            lblSupplierAddress2.Size = new Size(71, 15);
            lblSupplierAddress2.TabIndex = 125;
            lblSupplierAddress2.Text = "Address 2: ";
            // 
            // lblSupplierCity
            // 
            lblSupplierCity.Anchor = AnchorStyles.None;
            lblSupplierCity.AutoSize = true;
            lblSupplierCity.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSupplierCity.Location = new Point(12, 243);
            lblSupplierCity.Name = "lblSupplierCity";
            lblSupplierCity.Size = new Size(34, 15);
            lblSupplierCity.TabIndex = 124;
            lblSupplierCity.Text = "City: ";
            // 
            // lblSuppPostal
            // 
            lblSuppPostal.Anchor = AnchorStyles.None;
            lblSuppPostal.AutoSize = true;
            lblSuppPostal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuppPostal.Location = new Point(12, 325);
            lblSuppPostal.Name = "lblSuppPostal";
            lblSuppPostal.Size = new Size(81, 15);
            lblSuppPostal.TabIndex = 123;
            lblSuppPostal.Text = "Postal Code: ";
            // 
            // lblSuppProv
            // 
            lblSuppProv.Anchor = AnchorStyles.None;
            lblSuppProv.AutoSize = true;
            lblSuppProv.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuppProv.Location = new Point(241, 285);
            lblSuppProv.Name = "lblSuppProv";
            lblSuppProv.Size = new Size(63, 15);
            lblSuppProv.TabIndex = 122;
            lblSuppProv.Text = "Province: ";
            // 
            // lblSuppCountry
            // 
            lblSuppCountry.Anchor = AnchorStyles.None;
            lblSuppCountry.AutoSize = true;
            lblSuppCountry.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuppCountry.Location = new Point(12, 284);
            lblSuppCountry.Name = "lblSuppCountry";
            lblSuppCountry.Size = new Size(57, 15);
            lblSuppCountry.TabIndex = 121;
            lblSuppCountry.Text = "Country: ";
            // 
            // lblSupplierID
            // 
            lblSupplierID.Anchor = AnchorStyles.None;
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSupplierID.Location = new Point(12, 78);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(74, 15);
            lblSupplierID.TabIndex = 120;
            lblSupplierID.Text = "Supplier ID: ";
            // 
            // frmAddEditSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(491, 601);
            Controls.Add(lblErrPhone);
            Controls.Add(lblErrProvince);
            Controls.Add(lblErrContact);
            Controls.Add(lblErrPostal);
            Controls.Add(lblErrCountry);
            Controls.Add(txtSuppContact);
            Controls.Add(lblSuppContact);
            Controls.Add(txtSuppPhone);
            Controls.Add(lblSuppPhone);
            Controls.Add(picHelp);
            Controls.Add(lblErrName);
            Controls.Add(lblAddEditError);
            Controls.Add(txtSuppNotes);
            Controls.Add(lblSuppNotes);
            Controls.Add(btnAddEditCancel);
            Controls.Add(btnAddEditSave);
            Controls.Add(lblAddEditDetails);
            Controls.Add(lblAddEditSupplier);
            Controls.Add(pictureBox1);
            Controls.Add(lblErrCity);
            Controls.Add(lblErrAddress);
            Controls.Add(cboSuppCountry);
            Controls.Add(txtSuppPostal);
            Controls.Add(txtSupplierCity);
            Controls.Add(txtSupplierAdd2);
            Controls.Add(txtSupplierAdd);
            Controls.Add(txtSupplierName);
            Controls.Add(cboSuppProvince);
            Controls.Add(txtSupplierID);
            Controls.Add(lblSupplierAddress);
            Controls.Add(lblSupplierName);
            Controls.Add(lblSupplierAddress2);
            Controls.Add(lblSupplierCity);
            Controls.Add(lblSuppPostal);
            Controls.Add(lblSuppProv);
            Controls.Add(lblSuppCountry);
            Controls.Add(lblSupplierID);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmAddEditSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditSupplierForm";
            FormClosing += frmAddEditSupplier_FormClosing;
            Load += frmAddEditSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)picHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip tipError;
        private Label lblErrPhone;
        private Label lblErrProvince;
        private Label lblErrContact;
        private Label lblErrPostal;
        private Label lblErrCountry;
        private TextBox txtSuppContact;
        private TextBox txtSupplierName;
        private Label lblSuppContact;
        private TextBox txtSuppPhone;
        private Label lblSuppPhone;
        private PictureBox picHelp;
        private Label lblErrSite;
        private Label lblErrName;
        private Label lblAddEditError;
        private RichTextBox txtSuppNotes;
        private Label lblSuppNotes;
        private Button btnAddEditCancel;
        private Button btnAddEditSave;
        private Label lblAddEditDetails;
        private Label lblAddEditSupplier;
        private PictureBox pictureBox1;
        private Label lblErrCity;
        private Label lblErrAddress;
        private Label lblErrSiteID;
        private ComboBox cboSuppCountry;
        private TextBox txtSuppPostal;
        private TextBox txtSupplierCity;
        private TextBox txtSupplierAdd2;
        private TextBox txtSupplierAdd;
        private TextBox txtSiteName;
        private ComboBox cboSuppProvince;
        private TextBox txtSupplierID;
        private Label lblSupplierAddress;
        private Label lblSupplierName;
        private Label lblSupplierAddress2;
        private Label lblSupplierCity;
        private Label lblSuppPostal;
        private Label lblSuppProv;
        private Label lblSuppCountry;
        private Label lblSupplierID;
    }
}