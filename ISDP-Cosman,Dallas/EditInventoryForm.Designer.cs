namespace ISDP_Cosman_Dallas
{
    partial class frmEditInventory
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
            tipError = new ToolTip(components);
            picHelp = new PictureBox();
            txtInvNotes = new RichTextBox();
            label4 = new Label();
            btnCancelInv = new Button();
            btnSaveInv = new Button();
            lblEditInventory = new Label();
            pictureBox1 = new PictureBox();
            cboInvSite = new ComboBox();
            txtItemLocation = new TextBox();
            txtItemID = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblEmpID = new Label();
            numQuantity = new NumericUpDown();
            numReorder = new NumericUpDown();
            numOptimum = new NumericUpDown();
            label2 = new Label();
            lblAddEditDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)picHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOptimum).BeginInit();
            SuspendLayout();
            // 
            // tipError
            // 
            tipError.AutoPopDelay = 5000;
            tipError.InitialDelay = 200;
            tipError.IsBalloon = true;
            tipError.ReshowDelay = 100;
            tipError.ToolTipIcon = ToolTipIcon.Warning;
            // 
            // picHelp
            // 
            picHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHelp.Cursor = Cursors.Hand;
            picHelp.Image = Properties.Resources.help;
            picHelp.Location = new Point(385, 12);
            picHelp.Name = "picHelp";
            picHelp.Size = new Size(30, 30);
            picHelp.SizeMode = PictureBoxSizeMode.Zoom;
            picHelp.TabIndex = 107;
            picHelp.TabStop = false;
            // 
            // txtInvNotes
            // 
            txtInvNotes.BorderStyle = BorderStyle.FixedSingle;
            txtInvNotes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtInvNotes.Location = new Point(169, 358);
            txtInvNotes.Name = "txtInvNotes";
            txtInvNotes.Size = new Size(210, 82);
            txtInvNotes.TabIndex = 94;
            txtInvNotes.Text = "";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 358);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 93;
            label4.Text = "Inventory Notes: ";
            // 
            // btnCancelInv
            // 
            btnCancelInv.Anchor = AnchorStyles.None;
            btnCancelInv.BackColor = Color.OrangeRed;
            btnCancelInv.Cursor = Cursors.Hand;
            btnCancelInv.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelInv.ForeColor = Color.White;
            btnCancelInv.Location = new Point(230, 460);
            btnCancelInv.Name = "btnCancelInv";
            btnCancelInv.Size = new Size(169, 38);
            btnCancelInv.TabIndex = 92;
            btnCancelInv.Text = "CANCEL";
            btnCancelInv.UseVisualStyleBackColor = false;
            btnCancelInv.Click += btnCancelInv_Click;
            // 
            // btnSaveInv
            // 
            btnSaveInv.Anchor = AnchorStyles.None;
            btnSaveInv.BackColor = Color.OrangeRed;
            btnSaveInv.Cursor = Cursors.Hand;
            btnSaveInv.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveInv.ForeColor = Color.White;
            btnSaveInv.Location = new Point(25, 460);
            btnSaveInv.Name = "btnSaveInv";
            btnSaveInv.Size = new Size(169, 38);
            btnSaveInv.TabIndex = 91;
            btnSaveInv.Text = "SAVE";
            btnSaveInv.UseVisualStyleBackColor = false;
            btnSaveInv.Click += btnSaveInv_Click;
            // 
            // lblEditInventory
            // 
            lblEditInventory.Anchor = AnchorStyles.None;
            lblEditInventory.AutoSize = true;
            lblEditInventory.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditInventory.Location = new Point(137, 18);
            lblEditInventory.Name = "lblEditInventory";
            lblEditInventory.Size = new Size(150, 24);
            lblEditInventory.TabIndex = 89;
            lblEditInventory.Text = "Edit Inventory";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bullseye;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // cboInvSite
            // 
            cboInvSite.Anchor = AnchorStyles.None;
            cboInvSite.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInvSite.Enabled = false;
            cboInvSite.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboInvSite.FormattingEnabled = true;
            cboInvSite.Location = new Point(169, 305);
            cboInvSite.Name = "cboInvSite";
            cboInvSite.Size = new Size(210, 23);
            cboInvSite.TabIndex = 86;
            // 
            // txtItemLocation
            // 
            txtItemLocation.Anchor = AnchorStyles.None;
            txtItemLocation.BackColor = Color.White;
            txtItemLocation.BorderStyle = BorderStyle.FixedSingle;
            txtItemLocation.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemLocation.Location = new Point(172, 134);
            txtItemLocation.Name = "txtItemLocation";
            txtItemLocation.Size = new Size(85, 21);
            txtItemLocation.TabIndex = 82;
            txtItemLocation.UseSystemPasswordChar = true;
            // 
            // txtItemID
            // 
            txtItemID.Anchor = AnchorStyles.None;
            txtItemID.BackColor = Color.White;
            txtItemID.BorderStyle = BorderStyle.FixedSingle;
            txtItemID.Enabled = false;
            txtItemID.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemID.Location = new Point(172, 92);
            txtItemID.Name = "txtItemID";
            txtItemID.ReadOnly = true;
            txtItemID.Size = new Size(85, 21);
            txtItemID.TabIndex = 79;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(36, 136);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 78;
            label8.Text = "Item Location: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(36, 217);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 76;
            label6.Text = "Reorder Threshold: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 176);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 74;
            label3.Text = "Quantity: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 308);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 72;
            label1.Text = "Inventory Site: ";
            // 
            // lblEmpID
            // 
            lblEmpID.Anchor = AnchorStyles.None;
            lblEmpID.AutoSize = true;
            lblEmpID.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpID.Location = new Point(36, 94);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(52, 15);
            lblEmpID.TabIndex = 71;
            lblEmpID.Text = "Item ID: ";
            // 
            // numQuantity
            // 
            numQuantity.Enabled = false;
            numQuantity.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numQuantity.Location = new Point(172, 172);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(85, 25);
            numQuantity.TabIndex = 108;
            // 
            // numReorder
            // 
            numReorder.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numReorder.Location = new Point(172, 213);
            numReorder.Name = "numReorder";
            numReorder.Size = new Size(85, 25);
            numReorder.TabIndex = 109;
            // 
            // numOptimum
            // 
            numOptimum.Enabled = false;
            numOptimum.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numOptimum.Location = new Point(172, 259);
            numOptimum.Name = "numOptimum";
            numOptimum.Size = new Size(85, 25);
            numOptimum.TabIndex = 111;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 263);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 110;
            label2.Text = "Optimum Threshold: ";
            // 
            // lblAddEditDetails
            // 
            lblAddEditDetails.Anchor = AnchorStyles.None;
            lblAddEditDetails.AutoSize = true;
            lblAddEditDetails.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditDetails.Location = new Point(133, 42);
            lblAddEditDetails.Name = "lblAddEditDetails";
            lblAddEditDetails.Size = new Size(156, 16);
            lblAddEditDetails.TabIndex = 112;
            lblAddEditDetails.Tag = "";
            lblAddEditDetails.Text = "Edit reorder and optimum thresholds\r\n";
            // 
            // frmEditInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(424, 521);
            Controls.Add(lblAddEditDetails);
            Controls.Add(numOptimum);
            Controls.Add(label2);
            Controls.Add(numReorder);
            Controls.Add(numQuantity);
            Controls.Add(picHelp);
            Controls.Add(txtInvNotes);
            Controls.Add(label4);
            Controls.Add(btnCancelInv);
            Controls.Add(btnSaveInv);
            Controls.Add(lblEditInventory);
            Controls.Add(pictureBox1);
            Controls.Add(cboInvSite);
            Controls.Add(txtItemLocation);
            Controls.Add(txtItemID);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblEmpID);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Inventory";
            FormClosing += frmEditInventory_FormClosing;
            Load += frmEditInventory_Load;
            ((System.ComponentModel.ISupportInitialize)picHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOptimum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip tipError;
        private PictureBox picHelp;
        private CheckBox chkEmpLocked;
        private RichTextBox txtInvNotes;
        private Label label4;
        private Button btnCancelInv;
        private Button btnSaveInv;
        private Label lblAddEditDetails;
        private Label lblEditInventory;
        private PictureBox pictureBox1;
        private CheckBox chkEmpActive;
        private ComboBox cboInvSite;
        private TextBox txtItemLocation;
        private TextBox txtItemID;
        private Label label8;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label lblEmpID;
        private NumericUpDown numQuantity;
        private NumericUpDown numReorder;
        private NumericUpDown numOptimum;
        private Label label2;
    }
}