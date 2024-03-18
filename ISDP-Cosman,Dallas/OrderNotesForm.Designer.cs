namespace ISDP_Cosman_Dallas
{
    partial class frmOrderNotes
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
            txtOrderNotes = new RichTextBox();
            pictureBox1 = new PictureBox();
            lblNoteDetails = new Label();
            lblNotes = new Label();
            btnConfirmNotes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtOrderNotes
            // 
            txtOrderNotes.BorderStyle = BorderStyle.FixedSingle;
            txtOrderNotes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderNotes.Location = new Point(45, 57);
            txtOrderNotes.Name = "txtOrderNotes";
            txtOrderNotes.Size = new Size(347, 148);
            txtOrderNotes.TabIndex = 59;
            txtOrderNotes.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bullseye;
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // lblNoteDetails
            // 
            lblNoteDetails.Anchor = AnchorStyles.None;
            lblNoteDetails.AutoSize = true;
            lblNoteDetails.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoteDetails.Location = new Point(151, 34);
            lblNoteDetails.Name = "lblNoteDetails";
            lblNoteDetails.Size = new Size(98, 16);
            lblNoteDetails.TabIndex = 62;
            lblNoteDetails.Tag = "";
            lblNoteDetails.Text = "Add notes for order # ";
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.None;
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.Location = new Point(151, 10);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(131, 24);
            lblNotes.TabIndex = 61;
            lblNotes.Text = "Order Notes";
            // 
            // btnConfirmNotes
            // 
            btnConfirmNotes.Anchor = AnchorStyles.None;
            btnConfirmNotes.BackColor = Color.OrangeRed;
            btnConfirmNotes.Cursor = Cursors.Hand;
            btnConfirmNotes.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmNotes.ForeColor = Color.White;
            btnConfirmNotes.Location = new Point(114, 215);
            btnConfirmNotes.Name = "btnConfirmNotes";
            btnConfirmNotes.Size = new Size(198, 44);
            btnConfirmNotes.TabIndex = 64;
            btnConfirmNotes.Text = "CONFIRM";
            btnConfirmNotes.UseVisualStyleBackColor = false;
            btnConfirmNotes.Click += btnConfirmNotes_Click;
            // 
            // frmOrderNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 270);
            ControlBox = false;
            Controls.Add(btnConfirmNotes);
            Controls.Add(lblNoteDetails);
            Controls.Add(lblNotes);
            Controls.Add(pictureBox1);
            Controls.Add(txtOrderNotes);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderNotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Notes";
            Load += frmOrderNotes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtOrderNotes;
        private PictureBox pictureBox1;
        private Label lblNoteDetails;
        private Label lblNotes;
        private Button btnConfirmNotes;
    }
}