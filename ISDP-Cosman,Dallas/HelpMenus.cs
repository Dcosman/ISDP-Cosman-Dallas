using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas
{
    public static class HelpMenus
    {
        public static void ShowHelp(string title, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmHelp help = new frmHelp();
                help.Text = title + " Help";
                help.ShowDialog();
            }
        }
        public static void ShowHelp(string title)
        {
            frmHelp help = new frmHelp();
            help.Text = title + " Help";
            help.ShowDialog();
        }
    }
}

