namespace ISDP_Cosman_Dallas
{
    partial class AddEditEmployeeForm
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
            btnAddEditCancel = new Button();
            btnAddEditSave = new Button();
            lblAddEditDetails = new Label();
            lblAddEditEmp = new Label();
            pictureBox1 = new PictureBox();
            chkEmpActive = new CheckBox();
            cboEmpLocation = new ComboBox();
            txtEmpEmail = new TextBox();
            txtEmpLastName = new TextBox();
            txtEmpFirstName = new TextBox();
            txtEmpPassword = new TextBox();
            txtEmpUsername = new TextBox();
            cboEmpPosition = new ComboBox();
            txtEmpID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblEmpID = new Label();
            label4 = new Label();
            txtEmpNotes = new RichTextBox();
            picShowPassword = new PictureBox();
            lblAddEditError = new Label();
            lblErrID = new Label();
            lblErrUsername = new Label();
            lblErrPassword = new Label();
            lblErrFirstName = new Label();
            lblErrLastName = new Label();
            lblErrEmail = new Label();
            lblErrPosn = new Label();
            lblErrLocation = new Label();
            tipError = new ToolTip(components);
            chkEmpLocked = new CheckBox();
            lblResetEmp = new LinkLabel();
            picHelp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHelp).BeginInit();
            SuspendLayout();
            // 
            // btnAddEditCancel
            // 
            btnAddEditCancel.Anchor = AnchorStyles.None;
            btnAddEditCancel.BackColor = Color.OrangeRed;
            btnAddEditCancel.Cursor = Cursors.Hand;
            btnAddEditCancel.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEditCancel.ForeColor = Color.White;
            btnAddEditCancel.Location = new Point(230, 550);
            btnAddEditCancel.Name = "btnAddEditCancel";
            btnAddEditCancel.Size = new Size(169, 38);
            btnAddEditCancel.TabIndex = 54;
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
            btnAddEditSave.Location = new Point(23, 550);
            btnAddEditSave.Name = "btnAddEditSave";
            btnAddEditSave.Size = new Size(169, 38);
            btnAddEditSave.TabIndex = 53;
            btnAddEditSave.Text = "SAVE";
            btnAddEditSave.UseVisualStyleBackColor = false;
            btnAddEditSave.Click += btnAddEditSave_Click;
            // 
            // lblAddEditDetails
            // 
            lblAddEditDetails.Anchor = AnchorStyles.None;
            lblAddEditDetails.AutoSize = true;
            lblAddEditDetails.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditDetails.Location = new Point(128, 39);
            lblAddEditDetails.Name = "lblAddEditDetails";
            lblAddEditDetails.Size = new Size(171, 16);
            lblAddEditDetails.TabIndex = 52;
            lblAddEditDetails.Tag = "employee fields and save changes";
            lblAddEditDetails.Text = "Edit employee fields and save changes";
            // 
            // lblAddEditEmp
            // 
            lblAddEditEmp.Anchor = AnchorStyles.None;
            lblAddEditEmp.AutoSize = true;
            lblAddEditEmp.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditEmp.Location = new Point(138, 15);
            lblAddEditEmp.Name = "lblAddEditEmp";
            lblAddEditEmp.Size = new Size(154, 24);
            lblAddEditEmp.TabIndex = 51;
            lblAddEditEmp.Text = "Edit Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bullseye;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // chkEmpActive
            // 
            chkEmpActive.Anchor = AnchorStyles.None;
            chkEmpActive.AutoSize = true;
            chkEmpActive.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkEmpActive.Location = new Point(329, 78);
            chkEmpActive.Name = "chkEmpActive";
            chkEmpActive.Size = new Size(61, 19);
            chkEmpActive.TabIndex = 49;
            chkEmpActive.Text = "Active";
            chkEmpActive.UseVisualStyleBackColor = true;
            // 
            // cboEmpLocation
            // 
            cboEmpLocation.Anchor = AnchorStyles.None;
            cboEmpLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpLocation.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboEmpLocation.FormattingEnabled = true;
            cboEmpLocation.Location = new Point(129, 364);
            cboEmpLocation.Name = "cboEmpLocation";
            cboEmpLocation.Size = new Size(243, 23);
            cboEmpLocation.TabIndex = 48;
            // 
            // txtEmpEmail
            // 
            txtEmpEmail.Anchor = AnchorStyles.None;
            txtEmpEmail.BackColor = Color.White;
            txtEmpEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmpEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpEmail.Location = new Point(129, 283);
            txtEmpEmail.Name = "txtEmpEmail";
            txtEmpEmail.Size = new Size(243, 21);
            txtEmpEmail.TabIndex = 47;
            // 
            // txtEmpLastName
            // 
            txtEmpLastName.Anchor = AnchorStyles.None;
            txtEmpLastName.BackColor = Color.White;
            txtEmpLastName.BorderStyle = BorderStyle.FixedSingle;
            txtEmpLastName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpLastName.Location = new Point(129, 242);
            txtEmpLastName.Name = "txtEmpLastName";
            txtEmpLastName.Size = new Size(243, 21);
            txtEmpLastName.TabIndex = 46;
            txtEmpLastName.TextChanged += txtEmpLastName_TextChanged;
            // 
            // txtEmpFirstName
            // 
            txtEmpFirstName.Anchor = AnchorStyles.None;
            txtEmpFirstName.BackColor = Color.White;
            txtEmpFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtEmpFirstName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpFirstName.Location = new Point(129, 200);
            txtEmpFirstName.Name = "txtEmpFirstName";
            txtEmpFirstName.Size = new Size(243, 21);
            txtEmpFirstName.TabIndex = 45;
            txtEmpFirstName.TextChanged += txtEmpFirstName_TextChanged;
            // 
            // txtEmpPassword
            // 
            txtEmpPassword.Anchor = AnchorStyles.None;
            txtEmpPassword.BackColor = Color.White;
            txtEmpPassword.BorderStyle = BorderStyle.FixedSingle;
            txtEmpPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpPassword.Location = new Point(129, 159);
            txtEmpPassword.Name = "txtEmpPassword";
            txtEmpPassword.Size = new Size(243, 21);
            txtEmpPassword.TabIndex = 44;
            txtEmpPassword.UseSystemPasswordChar = true;
            // 
            // txtEmpUsername
            // 
            txtEmpUsername.Anchor = AnchorStyles.None;
            txtEmpUsername.BackColor = Color.White;
            txtEmpUsername.BorderStyle = BorderStyle.FixedSingle;
            txtEmpUsername.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpUsername.Location = new Point(129, 118);
            txtEmpUsername.Name = "txtEmpUsername";
            txtEmpUsername.Size = new Size(243, 21);
            txtEmpUsername.TabIndex = 43;
            // 
            // cboEmpPosition
            // 
            cboEmpPosition.Anchor = AnchorStyles.None;
            cboEmpPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpPosition.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboEmpPosition.FormattingEnabled = true;
            cboEmpPosition.Location = new Point(129, 323);
            cboEmpPosition.Name = "cboEmpPosition";
            cboEmpPosition.Size = new Size(243, 23);
            cboEmpPosition.TabIndex = 42;
            // 
            // txtEmpID
            // 
            txtEmpID.Anchor = AnchorStyles.None;
            txtEmpID.BackColor = Color.White;
            txtEmpID.BorderStyle = BorderStyle.FixedSingle;
            txtEmpID.Enabled = false;
            txtEmpID.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpID.Location = new Point(129, 77);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.ReadOnly = true;
            txtEmpID.Size = new Size(85, 21);
            txtEmpID.TabIndex = 41;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(34, 161);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 40;
            label8.Text = "Password: ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(34, 120);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 39;
            label7.Text = "Username: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 202);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 38;
            label6.Text = "First Name: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 244);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 37;
            label5.Text = "Last Name: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 285);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 36;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 326);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 35;
            label2.Text = "Position: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 367);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 34;
            label1.Text = "Location: ";
            // 
            // lblEmpID
            // 
            lblEmpID.Anchor = AnchorStyles.None;
            lblEmpID.AutoSize = true;
            lblEmpID.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpID.Location = new Point(34, 79);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(82, 15);
            lblEmpID.TabIndex = 33;
            lblEmpID.Text = "Employee ID: ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 413);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 55;
            label4.Text = "Notes: ";
            // 
            // txtEmpNotes
            // 
            txtEmpNotes.BorderStyle = BorderStyle.FixedSingle;
            txtEmpNotes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpNotes.Location = new Point(129, 410);
            txtEmpNotes.Name = "txtEmpNotes";
            txtEmpNotes.Size = new Size(243, 82);
            txtEmpNotes.TabIndex = 56;
            txtEmpNotes.Text = "";
            // 
            // picShowPassword
            // 
            picShowPassword.BorderStyle = BorderStyle.FixedSingle;
            picShowPassword.Cursor = Cursors.Hand;
            picShowPassword.Image = Properties.Resources.ShowPassword;
            picShowPassword.Location = new Point(351, 159);
            picShowPassword.Name = "picShowPassword";
            picShowPassword.Size = new Size(21, 21);
            picShowPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            picShowPassword.TabIndex = 57;
            picShowPassword.TabStop = false;
            picShowPassword.Click += picShowPassword_Click;
            // 
            // lblAddEditError
            // 
            lblAddEditError.Anchor = AnchorStyles.None;
            lblAddEditError.AutoSize = true;
            lblAddEditError.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditError.ForeColor = Color.Red;
            lblAddEditError.Location = new Point(23, 526);
            lblAddEditError.Name = "lblAddEditError";
            lblAddEditError.Size = new Size(304, 15);
            lblAddEditError.TabIndex = 58;
            lblAddEditError.Text = "Employee information invalid: Hover over * for details";
            lblAddEditError.Visible = false;
            // 
            // lblErrID
            // 
            lblErrID.Anchor = AnchorStyles.None;
            lblErrID.AutoSize = true;
            lblErrID.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrID.ForeColor = Color.Red;
            lblErrID.Location = new Point(220, 77);
            lblErrID.Name = "lblErrID";
            lblErrID.Size = new Size(12, 15);
            lblErrID.TabIndex = 59;
            lblErrID.Tag = "Employee ID ";
            lblErrID.Text = "*";
            tipError.SetToolTip(lblErrID, "Employee ID is Required");
            lblErrID.Visible = false;
            // 
            // lblErrUsername
            // 
            lblErrUsername.Anchor = AnchorStyles.None;
            lblErrUsername.AutoSize = true;
            lblErrUsername.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrUsername.ForeColor = Color.Red;
            lblErrUsername.Location = new Point(378, 118);
            lblErrUsername.Name = "lblErrUsername";
            lblErrUsername.Size = new Size(12, 15);
            lblErrUsername.TabIndex = 60;
            lblErrUsername.Tag = "Username ";
            lblErrUsername.Text = "*";
            tipError.SetToolTip(lblErrUsername, "Username Required: Generated on valid first/last name");
            lblErrUsername.Visible = false;
            // 
            // lblErrPassword
            // 
            lblErrPassword.Anchor = AnchorStyles.None;
            lblErrPassword.AutoSize = true;
            lblErrPassword.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrPassword.ForeColor = Color.Red;
            lblErrPassword.Location = new Point(378, 159);
            lblErrPassword.Name = "lblErrPassword";
            lblErrPassword.Size = new Size(12, 15);
            lblErrPassword.TabIndex = 61;
            lblErrPassword.Tag = "Password ";
            lblErrPassword.Text = "*";
            tipError.SetToolTip(lblErrPassword, "Password Is Required");
            lblErrPassword.Visible = false;
            // 
            // lblErrFirstName
            // 
            lblErrFirstName.Anchor = AnchorStyles.None;
            lblErrFirstName.AutoSize = true;
            lblErrFirstName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrFirstName.ForeColor = Color.Red;
            lblErrFirstName.Location = new Point(378, 200);
            lblErrFirstName.Name = "lblErrFirstName";
            lblErrFirstName.Size = new Size(12, 15);
            lblErrFirstName.TabIndex = 62;
            lblErrFirstName.Tag = "First Name ";
            lblErrFirstName.Text = "*";
            tipError.SetToolTip(lblErrFirstName, "Last Name is Required");
            lblErrFirstName.Visible = false;
            // 
            // lblErrLastName
            // 
            lblErrLastName.Anchor = AnchorStyles.None;
            lblErrLastName.AutoSize = true;
            lblErrLastName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrLastName.ForeColor = Color.Red;
            lblErrLastName.Location = new Point(378, 242);
            lblErrLastName.Name = "lblErrLastName";
            lblErrLastName.Size = new Size(12, 15);
            lblErrLastName.TabIndex = 63;
            lblErrLastName.Tag = "Last Name ";
            lblErrLastName.Text = "*";
            tipError.SetToolTip(lblErrLastName, "Last Name is Required");
            lblErrLastName.Visible = false;
            // 
            // lblErrEmail
            // 
            lblErrEmail.Anchor = AnchorStyles.None;
            lblErrEmail.AutoSize = true;
            lblErrEmail.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrEmail.ForeColor = Color.Red;
            lblErrEmail.Location = new Point(378, 283);
            lblErrEmail.Name = "lblErrEmail";
            lblErrEmail.Size = new Size(12, 15);
            lblErrEmail.TabIndex = 64;
            lblErrEmail.Tag = "Email ";
            lblErrEmail.Text = "*";
            tipError.SetToolTip(lblErrEmail, "Email Required: Generated with valid first/last name");
            lblErrEmail.Visible = false;
            // 
            // lblErrPosn
            // 
            lblErrPosn.Anchor = AnchorStyles.None;
            lblErrPosn.AutoSize = true;
            lblErrPosn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrPosn.ForeColor = Color.Red;
            lblErrPosn.Location = new Point(378, 323);
            lblErrPosn.Name = "lblErrPosn";
            lblErrPosn.Size = new Size(12, 15);
            lblErrPosn.TabIndex = 65;
            lblErrPosn.Tag = "Position ";
            lblErrPosn.Text = "*";
            tipError.SetToolTip(lblErrPosn, "Position Is Required");
            lblErrPosn.Visible = false;
            // 
            // lblErrLocation
            // 
            lblErrLocation.Anchor = AnchorStyles.None;
            lblErrLocation.AutoSize = true;
            lblErrLocation.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrLocation.ForeColor = Color.Red;
            lblErrLocation.Location = new Point(378, 364);
            lblErrLocation.Name = "lblErrLocation";
            lblErrLocation.Size = new Size(12, 15);
            lblErrLocation.TabIndex = 66;
            lblErrLocation.Tag = "Location ";
            lblErrLocation.Text = "*";
            tipError.SetToolTip(lblErrLocation, "Location Is Required");
            lblErrLocation.Visible = false;
            // 
            // tipError
            // 
            tipError.AutoPopDelay = 5000;
            tipError.InitialDelay = 200;
            tipError.IsBalloon = true;
            tipError.ReshowDelay = 100;
            tipError.ToolTipIcon = ToolTipIcon.Warning;
            // 
            // chkEmpLocked
            // 
            chkEmpLocked.Anchor = AnchorStyles.None;
            chkEmpLocked.AutoSize = true;
            chkEmpLocked.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkEmpLocked.Location = new Point(250, 78);
            chkEmpLocked.Name = "chkEmpLocked";
            chkEmpLocked.Size = new Size(68, 19);
            chkEmpLocked.TabIndex = 67;
            chkEmpLocked.Text = "Locked";
            chkEmpLocked.UseVisualStyleBackColor = true;
            // 
            // lblResetEmp
            // 
            lblResetEmp.AutoSize = true;
            lblResetEmp.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblResetEmp.LinkColor = Color.Gray;
            lblResetEmp.Location = new Point(325, 505);
            lblResetEmp.Name = "lblResetEmp";
            lblResetEmp.Size = new Size(65, 16);
            lblResetEmp.TabIndex = 69;
            lblResetEmp.TabStop = true;
            lblResetEmp.Text = "Reset Fields";
            lblResetEmp.Visible = false;
            lblResetEmp.LinkClicked += lblResetEmp_LinkClicked;
            // 
            // picHelp
            // 
            picHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHelp.Cursor = Cursors.Hand;
            picHelp.Image = Properties.Resources.help;
            picHelp.Location = new Point(378, 15);
            picHelp.Name = "picHelp";
            picHelp.Size = new Size(30, 30);
            picHelp.SizeMode = PictureBoxSizeMode.Zoom;
            picHelp.TabIndex = 70;
            picHelp.TabStop = false;
            picHelp.Click += picHelp_Click;
            // 
            // AddEditEmployeeForm
            // 
            AcceptButton = btnAddEditSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnAddEditCancel;
            ClientSize = new Size(424, 601);
            Controls.Add(picHelp);
            Controls.Add(lblResetEmp);
            Controls.Add(chkEmpLocked);
            Controls.Add(lblErrLocation);
            Controls.Add(lblErrPosn);
            Controls.Add(lblErrEmail);
            Controls.Add(lblErrLastName);
            Controls.Add(lblErrFirstName);
            Controls.Add(lblErrPassword);
            Controls.Add(lblErrUsername);
            Controls.Add(lblErrID);
            Controls.Add(lblAddEditError);
            Controls.Add(picShowPassword);
            Controls.Add(txtEmpNotes);
            Controls.Add(label4);
            Controls.Add(btnAddEditCancel);
            Controls.Add(btnAddEditSave);
            Controls.Add(lblAddEditDetails);
            Controls.Add(lblAddEditEmp);
            Controls.Add(pictureBox1);
            Controls.Add(chkEmpActive);
            Controls.Add(cboEmpLocation);
            Controls.Add(txtEmpEmail);
            Controls.Add(txtEmpLastName);
            Controls.Add(txtEmpFirstName);
            Controls.Add(txtEmpPassword);
            Controls.Add(txtEmpUsername);
            Controls.Add(cboEmpPosition);
            Controls.Add(txtEmpID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEmpID);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddEditEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bullseye - ";
            Load += AddEditEmployeeForm_Load;
            KeyDown += AddEditEmployeeForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHelp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddEditCancel;
        private Button btnAddEditSave;
        private Label lblAddEditDetails;
        private Label lblAddEditEmp;
        private PictureBox pictureBox1;
        private CheckBox chkEmpActive;
        private ComboBox cboEmpLocation;
        private TextBox txtEmpEmail;
        private TextBox txtEmpLastName;
        private TextBox txtEmpFirstName;
        private TextBox txtEmpPassword;
        private TextBox txtEmpUsername;
        private ComboBox cboEmpPosition;
        private TextBox txtEmpID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblEmpID;
        private Label label4;
        private RichTextBox txtEmpNotes;
        private PictureBox picShowPassword;
        private Label lblAddEditError;
        private Label lblErrID;
        private Label lblErrUsername;
        private Label lblErrPassword;
        private Label lblErrFirstName;
        private Label lblErrLastName;
        private Label lblErrEmail;
        private Label lblErrPosn;
        private Label lblErrLocation;
        private ToolTip tipError;
        private CheckBox chkEmpLocked;
        private LinkLabel lblResetEmp;
        private PictureBox picHelp;
    }
}