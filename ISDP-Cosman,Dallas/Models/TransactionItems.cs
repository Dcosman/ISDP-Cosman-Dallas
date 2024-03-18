using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class TransactionItems
    {
        public TransactionItems() { }

        public TransactionItems(int txnID, int itemID, int quantity, string notes = null)
        {
            TxnID = txnID;
            ItemID = itemID;
            Quantity = quantity;
            Notes = notes;
        }

        private int txnID;
        public int TxnID
        {
            get { return txnID; }
            set { txnID = value; }
        }

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

        private string? notes;
        public string? Notes
        {
            get { return notes; }
            set { notes = value; }
        }
    }
}
