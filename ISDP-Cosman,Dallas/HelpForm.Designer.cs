namespace ISDP_Cosman_Dallas
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            picHelp = new PictureBox();
            picLogout = new PictureBox();
            picRefresh = new PictureBox();
            grpHelpIcons = new GroupBox();
            lblHelpIcons = new Label();
            grpHelpInfo = new GroupBox();
            lblEmpLocation = new Label();
            lblEmpUsername = new Label();
            label1 = new Label();
            grpHelpEmployees = new GroupBox();
            label5 = new Label();
            grpAddEmployee = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            grpHelpTab = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            grpHelpEmployeeButtons = new GroupBox();
            btnDeleteEmp = new Button();
            btnEditEmp = new Button();
            btnAddEmp = new Button();
            label6 = new Label();
            grpEmpRequirement = new GroupBox();
            label4 = new Label();
            grpEditItems = new GroupBox();
            button2 = new Button();
            label7 = new Label();
            grpItems = new GroupBox();
            label8 = new Label();
            grpEditEmployees = new GroupBox();
            button3 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)picHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRefresh).BeginInit();
            grpHelpIcons.SuspendLayout();
            grpHelpInfo.SuspendLayout();
            grpHelpEmployees.SuspendLayout();
            grpAddEmployee.SuspendLayout();
            grpHelpTab.SuspendLayout();
            tabControl1.SuspendLayout();
            grpHelpEmployeeButtons.SuspendLayout();
            grpEmpRequirement.SuspendLayout();
            grpEditItems.SuspendLayout();
            grpItems.SuspendLayout();
            grpEditEmployees.SuspendLayout();
            SuspendLayout();
            // 
            // picHelp
            // 
            picHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHelp.Cursor = Cursors.Hand;
            picHelp.Image = Properties.Resources.help;
            picHelp.Location = new Point(119, 35);
            picHelp.Name = "picHelp";
            picHelp.Size = new Size(30, 30);
            picHelp.SizeMode = PictureBoxSizeMode.Zoom;
            picHelp.TabIndex = 21;
            picHelp.TabStop = false;
            // 
            // picLogout
            // 
            picLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picLogout.Cursor = Cursors.Hand;
            picLogout.Image = Properties.Resources.logout;
            picLogout.Location = new Point(170, 35);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(30, 30);
            picLogout.SizeMode = PictureBoxSizeMode.Zoom;
            picLogout.TabIndex = 20;
            picLogout.TabStop = false;
            // 
            // picRefresh
            // 
            picRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRefresh.Cursor = Cursors.Hand;
            picRefresh.Image = Properties.Resources.refresh;
            picRefresh.Location = new Point(68, 35);
            picRefresh.Name = "picRefresh";
            picRefresh.Size = new Size(31, 31);
            picRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            picRefresh.TabIndex = 22;
            picRefresh.TabStop = false;
            picRefresh.Tag = "Refresh";
            // 
            // grpHelpIcons
            // 
            grpHelpIcons.Controls.Add(lblHelpIcons);
            grpHelpIcons.Controls.Add(picHelp);
            grpHelpIcons.Controls.Add(picRefresh);
            grpHelpIcons.Controls.Add(picLogout);
            grpHelpIcons.Location = new Point(24, 21);
            grpHelpIcons.Name = "grpHelpIcons";
            grpHelpIcons.Size = new Size(275, 401);
            grpHelpIcons.TabIndex = 23;
            grpHelpIcons.TabStop = false;
            grpHelpIcons.Text = "Icons";
            grpHelpIcons.Visible = false;
            // 
            // lblHelpIcons
            // 
            lblHelpIcons.Location = new Point(17, 94);
            lblHelpIcons.Name = "lblHelpIcons";
            lblHelpIcons.Size = new Size(240, 289);
            lblHelpIcons.TabIndex = 23;
            lblHelpIcons.Text = resources.GetString("lblHelpIcons.Text");
            // 
            // grpHelpInfo
            // 
            grpHelpInfo.Controls.Add(lblEmpLocation);
            grpHelpInfo.Controls.Add(lblEmpUsername);
            grpHelpInfo.Controls.Add(label1);
            grpHelpInfo.Location = new Point(305, 21);
            grpHelpInfo.Name = "grpHelpInfo";
            grpHelpInfo.Size = new Size(275, 401);
            grpHelpInfo.TabIndex = 24;
            grpHelpInfo.TabStop = false;
            grpHelpInfo.Text = "Info";
            grpHelpInfo.Visible = false;
            // 
            // lblEmpLocation
            // 
            lblEmpLocation.AutoSize = true;
            lblEmpLocation.Location = new Point(74, 51);
            lblEmpLocation.Name = "lblEmpLocation";
            lblEmpLocation.Size = new Size(127, 15);
            lblEmpLocation.TabIndex = 25;
            lblEmpLocation.Text = "Location: Site Location";
            // 
            // lblEmpUsername
            // 
            lblEmpUsername.AutoSize = true;
            lblEmpUsername.Location = new Point(74, 26);
            lblEmpUsername.Name = "lblEmpUsername";
            lblEmpUsername.Size = new Size(101, 15);
            lblEmpUsername.TabIndex = 24;
            lblEmpUsername.Text = "User: Username01";
            // 
            // label1
            // 
            label1.Location = new Point(17, 94);
            label1.Name = "label1";
            label1.Size = new Size(240, 289);
            label1.TabIndex = 23;
            label1.Text = resources.GetString("label1.Text");
            // 
            // grpHelpEmployees
            // 
            grpHelpEmployees.Controls.Add(label5);
            grpHelpEmployees.Location = new Point(305, 21);
            grpHelpEmployees.Name = "grpHelpEmployees";
            grpHelpEmployees.Size = new Size(275, 401);
            grpHelpEmployees.TabIndex = 26;
            grpHelpEmployees.TabStop = false;
            grpHelpEmployees.Text = "Employees Screen";
            grpHelpEmployees.Visible = false;
            // 
            // label5
            // 
            label5.Location = new Point(17, 94);
            label5.Name = "label5";
            label5.Size = new Size(240, 289);
            label5.TabIndex = 23;
            label5.Text = resources.GetString("label5.Text");
            // 
            // grpAddEmployee
            // 
            grpAddEmployee.Controls.Add(button1);
            grpAddEmployee.Controls.Add(label3);
            grpAddEmployee.Location = new Point(305, 21);
            grpAddEmployee.Name = "grpAddEmployee";
            grpAddEmployee.Size = new Size(275, 401);
            grpAddEmployee.TabIndex = 27;
            grpAddEmployee.TabStop = false;
            grpAddEmployee.Text = "Add Employee";
            grpAddEmployee.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.OrangeRed;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(51, 35);
            button1.Name = "button1";
            button1.Size = new Size(169, 38);
            button1.TabIndex = 24;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Location = new Point(17, 94);
            label3.Name = "label3";
            label3.Size = new Size(240, 289);
            label3.TabIndex = 23;
            label3.Text = resources.GetString("label3.Text");
            // 
            // grpHelpTab
            // 
            grpHelpTab.Controls.Add(tabControl1);
            grpHelpTab.Controls.Add(label2);
            grpHelpTab.Location = new Point(586, 21);
            grpHelpTab.Name = "grpHelpTab";
            grpHelpTab.Size = new Size(275, 401);
            grpHelpTab.TabIndex = 25;
            grpHelpTab.TabStop = false;
            grpHelpTab.Text = "Tabs";
            grpHelpTab.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(71, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(128, 31);
            tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(120, 3);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tab 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(120, 3);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tab 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(17, 94);
            label2.Name = "label2";
            label2.Size = new Size(240, 289);
            label2.TabIndex = 23;
            label2.Text = "Tabs are shown on all screens and are used for navigation through the system.\r\n\r\nTabs are shown based on your position, so all tabs are relevant to your needs.";
            // 
            // grpHelpEmployeeButtons
            // 
            grpHelpEmployeeButtons.Controls.Add(btnDeleteEmp);
            grpHelpEmployeeButtons.Controls.Add(btnEditEmp);
            grpHelpEmployeeButtons.Controls.Add(btnAddEmp);
            grpHelpEmployeeButtons.Controls.Add(label6);
            grpHelpEmployeeButtons.Location = new Point(586, 21);
            grpHelpEmployeeButtons.Name = "grpHelpEmployeeButtons";
            grpHelpEmployeeButtons.Size = new Size(275, 401);
            grpHelpEmployeeButtons.TabIndex = 26;
            grpHelpEmployeeButtons.TabStop = false;
            grpHelpEmployeeButtons.Text = "Employees Buttons";
            grpHelpEmployeeButtons.Visible = false;
            // 
            // btnDeleteEmp
            // 
            btnDeleteEmp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteEmp.BackColor = Color.OrangeRed;
            btnDeleteEmp.Cursor = Cursors.Hand;
            btnDeleteEmp.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteEmp.ForeColor = Color.White;
            btnDeleteEmp.Location = new Point(56, 115);
            btnDeleteEmp.Name = "btnDeleteEmp";
            btnDeleteEmp.Size = new Size(169, 38);
            btnDeleteEmp.TabIndex = 26;
            btnDeleteEmp.Text = "DELETE";
            btnDeleteEmp.UseVisualStyleBackColor = false;
            // 
            // btnEditEmp
            // 
            btnEditEmp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditEmp.BackColor = Color.OrangeRed;
            btnEditEmp.Cursor = Cursors.Hand;
            btnEditEmp.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditEmp.ForeColor = Color.White;
            btnEditEmp.Location = new Point(56, 71);
            btnEditEmp.Name = "btnEditEmp";
            btnEditEmp.Size = new Size(169, 38);
            btnEditEmp.TabIndex = 25;
            btnEditEmp.Text = "EDIT";
            btnEditEmp.UseVisualStyleBackColor = false;
            // 
            // btnAddEmp
            // 
            btnAddEmp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddEmp.BackColor = Color.OrangeRed;
            btnAddEmp.Cursor = Cursors.Hand;
            btnAddEmp.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEmp.ForeColor = Color.White;
            btnAddEmp.Location = new Point(56, 27);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(169, 38);
            btnAddEmp.TabIndex = 24;
            btnAddEmp.Text = "ADD";
            btnAddEmp.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Location = new Point(17, 168);
            label6.Name = "label6";
            label6.Size = new Size(240, 215);
            label6.TabIndex = 23;
            label6.Text = resources.GetString("label6.Text");
            // 
            // grpEmpRequirement
            // 
            grpEmpRequirement.Controls.Add(label4);
            grpEmpRequirement.Location = new Point(24, 21);
            grpEmpRequirement.Name = "grpEmpRequirement";
            grpEmpRequirement.Size = new Size(275, 401);
            grpEmpRequirement.TabIndex = 28;
            grpEmpRequirement.TabStop = false;
            grpEmpRequirement.Text = "Field Requirements";
            grpEmpRequirement.Visible = false;
            // 
            // label4
            // 
            label4.Location = new Point(17, 26);
            label4.Name = "label4";
            label4.Size = new Size(240, 357);
            label4.TabIndex = 23;
            label4.Text = resources.GetString("label4.Text");
            // 
            // grpEditItems
            // 
            grpEditItems.Controls.Add(button2);
            grpEditItems.Controls.Add(label7);
            grpEditItems.Location = new Point(586, 21);
            grpEditItems.Name = "grpEditItems";
            grpEditItems.Size = new Size(275, 401);
            grpEditItems.TabIndex = 29;
            grpEditItems.TabStop = false;
            grpEditItems.Text = "Edit Items";
            grpEditItems.Visible = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.OrangeRed;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(56, 35);
            button2.Name = "button2";
            button2.Size = new Size(169, 38);
            button2.TabIndex = 24;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Location = new Point(17, 94);
            label7.Name = "label7";
            label7.Size = new Size(240, 289);
            label7.TabIndex = 23;
            label7.Text = resources.GetString("label7.Text");
            // 
            // grpItems
            // 
            grpItems.Controls.Add(label8);
            grpItems.Location = new Point(305, 21);
            grpItems.Name = "grpItems";
            grpItems.Size = new Size(275, 401);
            grpItems.TabIndex = 28;
            grpItems.TabStop = false;
            grpItems.Text = "Items";
            grpItems.Visible = false;
            // 
            // label8
            // 
            label8.Location = new Point(17, 26);
            label8.Name = "label8";
            label8.Size = new Size(240, 289);
            label8.TabIndex = 23;
            label8.Text = resources.GetString("label8.Text");
            // 
            // grpEditEmployees
            // 
            grpEditEmployees.Controls.Add(button3);
            grpEditEmployees.Controls.Add(label9);
            grpEditEmployees.Location = new Point(586, 21);
            grpEditEmployees.Name = "grpEditEmployees";
            grpEditEmployees.Size = new Size(275, 401);
            grpEditEmployees.TabIndex = 30;
            grpEditEmployees.TabStop = false;
            grpEditEmployees.Text = "Edit Employee";
            grpEditEmployees.Visible = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.OrangeRed;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(56, 27);
            button3.Name = "button3";
            button3.Size = new Size(169, 38);
            button3.TabIndex = 24;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.Location = new Point(17, 94);
            label9.Name = "label9";
            label9.Size = new Size(240, 289);
            label9.TabIndex = 23;
            label9.Text = resources.GetString("label9.Text");
            // 
            // frmHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 450);
            Controls.Add(grpEditEmployees);
            Controls.Add(grpItems);
            Controls.Add(grpAddEmployee);
            Controls.Add(grpEditItems);
            Controls.Add(grpEmpRequirement);
            Controls.Add(grpHelpEmployeeButtons);
            Controls.Add(grpHelpEmployees);
            Controls.Add(grpHelpTab);
            Controls.Add(grpHelpInfo);
            Controls.Add(grpHelpIcons);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpForm";
            Load += frmHelp_Load;
            ((System.ComponentModel.ISupportInitialize)picHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRefresh).EndInit();
            grpHelpIcons.ResumeLayout(false);
            grpHelpInfo.ResumeLayout(false);
            grpHelpInfo.PerformLayout();
            grpHelpEmployees.ResumeLayout(false);
            grpAddEmployee.ResumeLayout(false);
            grpHelpTab.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            grpHelpEmployeeButtons.ResumeLayout(false);
            grpEmpRequirement.ResumeLayout(false);
            grpEditItems.ResumeLayout(false);
            grpItems.ResumeLayout(false);
            grpEditEmployees.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picHelp;
        private PictureBox picLogout;
        private PictureBox picRefresh;
        private GroupBox grpHelpIcons;
        private Label lblHelpIcons;
        private GroupBox grpHelpInfo;
        private Label label1;
        private GroupBox grpHelpTab;
        private Label label2;
        private Label lblEmpLocation;
        private Label lblEmpUsername;
        private GroupBox grpHelpEmployees;
        private Label label5;
        private GroupBox grpHelpEmployeeButtons;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnDeleteEmp;
        private Button btnEditEmp;
        private Button btnAddEmp;
        private GroupBox grpAddEmployee;
        private Label label3;
        private GroupBox grpEmpRequirement;
        private Label label4;
        private GroupBox grpEditItems;
        private Label label7;
        private Button button1;
        private GroupBox grpItems;
        private Label label8;
        private Button button2;
        private GroupBox grpEditEmployees;
        private Button button3;
        private Label label9;
    }
}