namespace ISDP_Cosman_Dallas
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpLogin = new GroupBox();
            picShowPassword = new PictureBox();
            lblInvalidLogin = new Label();
            lblForgotPassword = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            grpResetPassword = new GroupBox();
            picShowConfirmPassword = new PictureBox();
            picShowNewPassword = new PictureBox();
            pictureBox2 = new PictureBox();
            lblResetPasswordError = new Label();
            btnCancelPassword = new Button();
            label8 = new Label();
            txtConfirmPassword = new TextBox();
            label4 = new Label();
            btnResetPassword = new Button();
            txtNewPassword = new TextBox();
            txtConfirmUsername = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpResetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShowNewPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.Anchor = AnchorStyles.None;
            grpLogin.BackColor = Color.White;
            grpLogin.Controls.Add(picShowPassword);
            grpLogin.Controls.Add(lblInvalidLogin);
            grpLogin.Controls.Add(lblForgotPassword);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(txtUsername);
            grpLogin.Controls.Add(label3);
            grpLogin.Controls.Add(label2);
            grpLogin.Controls.Add(label1);
            grpLogin.Controls.Add(pictureBox1);
            grpLogin.Location = new Point(158, 99);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(1095, 615);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            // 
            // picShowPassword
            // 
            picShowPassword.BorderStyle = BorderStyle.FixedSingle;
            picShowPassword.Cursor = Cursors.Hand;
            picShowPassword.Image = Properties.Resources.ShowPassword;
            picShowPassword.Location = new Point(1031, 315);
            picShowPassword.Name = "picShowPassword";
            picShowPassword.Size = new Size(26, 26);
            picShowPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            picShowPassword.TabIndex = 9;
            picShowPassword.TabStop = false;
            picShowPassword.Click += picShowPassword_Click;
            // 
            // lblInvalidLogin
            // 
            lblInvalidLogin.AutoSize = true;
            lblInvalidLogin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvalidLogin.ForeColor = Color.Red;
            lblInvalidLogin.Location = new Point(617, 168);
            lblInvalidLogin.Name = "lblInvalidLogin";
            lblInvalidLogin.Size = new Size(183, 16);
            lblInvalidLogin.TabIndex = 8;
            lblInvalidLogin.Text = "Invalid Username/Password";
            lblInvalidLogin.Visible = false;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Cursor = Cursors.Hand;
            lblForgotPassword.Font = new Font("Copperplate Gothic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblForgotPassword.ForeColor = SystemColors.ButtonShadow;
            lblForgotPassword.Location = new Point(759, 440);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(165, 15);
            lblForgotPassword.TabIndex = 7;
            lblForgotPassword.Text = "FORGOT PASSWORD?";
            lblForgotPassword.Click += txtForgotPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(691, 376);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(626, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(431, 26);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(626, 229);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(431, 26);
            txtUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(615, 283);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(615, 198);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(644, 82);
            label1.Name = "label1";
            label1.Size = new Size(391, 74);
            label1.TabIndex = 1;
            label1.Text = "BULLSEYE";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.bullseye;
            pictureBox1.InitialImage = Properties.Resources.bullseye;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(585, 587);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grpResetPassword
            // 
            grpResetPassword.Anchor = AnchorStyles.None;
            grpResetPassword.BackColor = Color.White;
            grpResetPassword.Controls.Add(picShowConfirmPassword);
            grpResetPassword.Controls.Add(picShowNewPassword);
            grpResetPassword.Controls.Add(pictureBox2);
            grpResetPassword.Controls.Add(lblResetPasswordError);
            grpResetPassword.Controls.Add(btnCancelPassword);
            grpResetPassword.Controls.Add(label8);
            grpResetPassword.Controls.Add(txtConfirmPassword);
            grpResetPassword.Controls.Add(label4);
            grpResetPassword.Controls.Add(btnResetPassword);
            grpResetPassword.Controls.Add(txtNewPassword);
            grpResetPassword.Controls.Add(txtConfirmUsername);
            grpResetPassword.Controls.Add(label5);
            grpResetPassword.Controls.Add(label6);
            grpResetPassword.Controls.Add(label7);
            grpResetPassword.Location = new Point(463, 93);
            grpResetPassword.Name = "grpResetPassword";
            grpResetPassword.Size = new Size(537, 615);
            grpResetPassword.TabIndex = 8;
            grpResetPassword.TabStop = false;
            grpResetPassword.Visible = false;
            // 
            // picShowConfirmPassword
            // 
            picShowConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            picShowConfirmPassword.Cursor = Cursors.Hand;
            picShowConfirmPassword.Image = Properties.Resources.ShowPassword;
            picShowConfirmPassword.Location = new Point(465, 384);
            picShowConfirmPassword.Name = "picShowConfirmPassword";
            picShowConfirmPassword.Size = new Size(26, 26);
            picShowConfirmPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            picShowConfirmPassword.TabIndex = 14;
            picShowConfirmPassword.TabStop = false;
            picShowConfirmPassword.Click += picShowConfirmPassword_Click;
            // 
            // picShowNewPassword
            // 
            picShowNewPassword.BorderStyle = BorderStyle.FixedSingle;
            picShowNewPassword.Cursor = Cursors.Hand;
            picShowNewPassword.Image = Properties.Resources.ShowPassword;
            picShowNewPassword.Location = new Point(465, 305);
            picShowNewPassword.Name = "picShowNewPassword";
            picShowNewPassword.Size = new Size(26, 26);
            picShowNewPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            picShowNewPassword.TabIndex = 13;
            picShowNewPassword.TabStop = false;
            picShowNewPassword.Click += picShowNewPassword_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bullseye;
            pictureBox2.Location = new Point(19, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // lblResetPasswordError
            // 
            lblResetPasswordError.AutoSize = true;
            lblResetPasswordError.Font = new Font("Copperplate Gothic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblResetPasswordError.ForeColor = Color.Red;
            lblResetPasswordError.Location = new Point(42, 434);
            lblResetPasswordError.Name = "lblResetPasswordError";
            lblResetPasswordError.Size = new Size(0, 15);
            lblResetPasswordError.TabIndex = 11;
            // 
            // btnCancelPassword
            // 
            btnCancelPassword.BackColor = Color.White;
            btnCancelPassword.Cursor = Cursors.Hand;
            btnCancelPassword.FlatAppearance.BorderColor = Color.OrangeRed;
            btnCancelPassword.FlatAppearance.BorderSize = 2;
            btnCancelPassword.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelPassword.ForeColor = Color.OrangeRed;
            btnCancelPassword.Location = new Point(315, 477);
            btnCancelPassword.Name = "btnCancelPassword";
            btnCancelPassword.Size = new Size(176, 51);
            btnCancelPassword.TabIndex = 8;
            btnCancelPassword.Text = "CANCEL";
            btnCancelPassword.UseVisualStyleBackColor = false;
            btnCancelPassword.Click += btnCancelPassword_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(154, 102);
            label8.Name = "label8";
            label8.Size = new Size(235, 90);
            label8.TabIndex = 9;
            label8.Text = "Passwords must contain at least:\r\n - 8 characters\r\n - 1 special character (!@#$%^&*)\r\n - 1 upper case letter\r\n - 1 number";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(60, 384);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(431, 26);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 352);
            label4.Name = "label4";
            label4.Size = new Size(192, 19);
            label4.TabIndex = 7;
            label4.Text = "CONFIRM PASSWORD";
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.OrangeRed;
            btnResetPassword.Cursor = Cursors.Hand;
            btnResetPassword.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(60, 477);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(249, 51);
            btnResetPassword.TabIndex = 7;
            btnResetPassword.Text = "RESET PASSWORD";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.White;
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(60, 305);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(431, 26);
            txtNewPassword.TabIndex = 5;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmUsername
            // 
            txtConfirmUsername.BackColor = Color.White;
            txtConfirmUsername.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmUsername.Location = new Point(60, 229);
            txtConfirmUsername.Name = "txtConfirmUsername";
            txtConfirmUsername.Size = new Size(431, 26);
            txtConfirmUsername.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 273);
            label5.Name = "label5";
            label5.Size = new Size(152, 19);
            label5.TabIndex = 3;
            label5.Text = "NEW PASSWORD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 198);
            label6.Name = "label6";
            label6.Size = new Size(106, 19);
            label6.TabIndex = 2;
            label6.Text = "USERNAME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(79, 29);
            label7.Name = "label7";
            label7.Size = new Size(391, 74);
            label7.TabIndex = 1;
            label7.Text = "BULLSEYE";
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoginBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1424, 841);
            Controls.Add(grpResetPassword);
            Controls.Add(grpLogin);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bullseye - Login";
            FormClosing += frmLogin_FormClosing;
            Load += frmLogin_Load;
            VisibleChanged += frmLogin_VisibleChanged;
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpResetPassword.ResumeLayout(false);
            grpResetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShowConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShowNewPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblForgotPassword;
        private GroupBox grpResetPassword;
        private Label label8;
        private TextBox txtConfirmPassword;
        private Label label4;
        private Button btnResetPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmUsername;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCancelPassword;
        private Label lblInvalidLogin;
        private Label lblResetPasswordError;
        private PictureBox pictureBox2;
        private PictureBox picShowPassword;
        private PictureBox picShowConfirmPassword;
        private PictureBox picShowNewPassword;
    }
}