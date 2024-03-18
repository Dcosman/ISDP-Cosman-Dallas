using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Inventory
    {
        private int itemID;
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        private int siteID;
        public int SiteID
        {
            get { return siteID; }
            set { siteID = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private string itemLocation;
        public string ItemLocation
        {
            get { return itemLocation; }
            set { itemLocation = value; }
        }

        private int? reorderThreshold;
        public int? ReorderThreshold
        {
            get { return reorderThreshold; }
            set { reorderThreshold = value; }
        }

        private int optimumThreshold;
        public int OptimumThreshold
        {
            get { return optimumThreshold; }
            set { optimumThreshold = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public Inventory(int itemID, int siteID, int quantity, string itemLocation, int optimumThreshold, int? reorderThreshold = null, string notes = null)
        {
            ItemID = itemID;
            SiteID = siteID;
            Quantity = quantity;
            ItemLocation = itemLocation;
            ReorderThreshold = reorderThreshold;
            OptimumThreshold = optimumThreshold;
            Notes = notes;
        }

        public Inventory() { }
    }
}
