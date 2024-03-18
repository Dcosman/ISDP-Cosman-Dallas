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

    //Author: Dallas Cosman
    //Form: Help
    //Desc: This form is shown whenever the user presses F1 or the help icon on a screen.
    // The help that is displayed will be relevant to the current screen that the user is on.
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        //On form load, check which screen the user is currently selected on and display help accordingly.
        private void frmHelp_Load(object sender, EventArgs e)
        {
            string title = this.Text.Split(" ")[0];

            switch (title)
            {
                case "Dashboard":
                    grpHelpIcons.Show();
                    grpHelpInfo.Show();
                    grpHelpTab.Show();
                    break;

                case "Employees":
                    grpHelpIcons.Show();
                    grpHelpEmployees.Show();
                    grpHelpEmployeeButtons.Show();
                    break;

                case "AddEditEmployee":
                    grpAddEmployee.Show();
                    grpEditEmployees.Show();
                    grpEmpRequirement.Show();
                    break;
                case "Items":
                    grpHelpIcons.Show();
                    grpEditItems.Show();
                    grpItems.Show();
                    break;

                default:
                    break;
            }
        }
    }
}
