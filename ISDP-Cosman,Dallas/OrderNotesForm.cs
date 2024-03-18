using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDP_Cosman_Dallas
{
    public partial class frmOrderNotes : Form
    {
        public frmOrderNotes()
        {
            InitializeComponent();
        }

        private void frmOrderNotes_Load(object sender, EventArgs e)
        {
            lblNoteDetails.Text += this.Tag.ToString();
        }

        private void btnConfirmNotes_Click(object sender, EventArgs e)
        {
            this.Tag = txtOrderNotes.Text;
            this.Close();
        }
    }
}
