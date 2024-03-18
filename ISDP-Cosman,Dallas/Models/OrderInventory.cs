using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class OrderInventory
    {
        private int itemID;
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private int caseSize;
        public int CaseSize
        {
            get { return caseSize; }
            set { caseSize = value; }
        }

        public OrderInventory(int itemID, int quantity, string itemName, int caseSize)
        {
            ItemID = itemID;
            Quantity = quantity;
            ItemName = itemName;
            CaseSize = caseSize;
        }

        public OrderInventory() { }
    }
}

