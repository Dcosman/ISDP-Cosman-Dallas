using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
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
    public partial class frmEditInventory : Form
    {

        Inventory theInv;
        bool formSubmitted = false;
        public frmEditInventory()
        {
            InitializeComponent();
        }

        private void btnCancelInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveInv_Click(object sender, EventArgs e)
        {
            string inventorySql = @"
                UPDATE inventory 
                SET reorderThreshold = @reorderThreshold
                WHERE itemID = @itemID 
                AND siteID = @siteID
                AND itemLocation = @itemLocation";

            List<MySqlParameter> invParameters = new List<MySqlParameter>
            {
                new MySqlParameter($"@reorderThreshold", (int)numReorder.Value),
                new MySqlParameter($"@itemID", theInv.ItemID),
                new MySqlParameter($"@siteID", theInv.SiteID),
                new MySqlParameter($"@itemLocation", theInv.ItemLocation),
            };

            InventoryAccessor.AddUpdateInventory(inventorySql, invParameters);

            MessageBox.Show("Inventory updated.", "Confirm", MessageBoxButtons.OK);
            formSubmitted = true;
            this.Close();
        }

        private void frmEditInventory_Load(object sender, EventArgs e)
        {
            theInv = this.Tag as Inventory;
            txtItemID.Text = theInv.ItemID.ToString();
            if(theInv.Notes != null )
                txtInvNotes.Text = theInv.Notes.ToString();
            txtItemLocation.Text = theInv.ItemLocation;

            numQuantity.Value = theInv.Quantity;
            numOptimum.Value = theInv.OptimumThreshold;
            if(theInv.ReorderThreshold != null)
                numReorder.Value = theInv.ReorderThreshold.GetValueOrDefault();

            List<Site> sites = SiteAccessor.GetAllSites();

            foreach (Site site in sites)
            {
                cboInvSite.Items.Add(site.Name);
            }

            cboInvSite.Text = SiteAccessor.GetSiteByID(theInv.SiteID).Name;
        }

        private void frmEditInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formSubmitted)
            {
                DialogResult result = MessageBox.Show("Cancel editting inventory? Changes will not be saved.", "Confirm Cancel", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
