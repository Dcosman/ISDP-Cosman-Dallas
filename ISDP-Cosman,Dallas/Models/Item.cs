using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Item
    {
        private int itemID;
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string sku;
        public string SKU
        {
            get { return sku; }
            set { sku = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private decimal weight;
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int caseSize;
        public int CaseSize
        {
            get { return caseSize; }
            set { caseSize = value; }
        }

        private decimal costPrice;
        public decimal CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }

        private decimal retailPrice;
        public decimal RetailPrice
        {
            get { return retailPrice; }
            set { retailPrice = value; }
        }

        private int supplierID;
        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }

        private bool active;
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public Item(int itemID, string name, string sku, string category, decimal weight, int caseSize, decimal costPrice, decimal retailPrice, int supplierID, bool active, string description = null, string notes = null)
        {
            ItemID = itemID;
            Name = name;
            SKU = sku;
            Description = description;
            Category = category;
            Weight = weight;
            CaseSize = caseSize;
            CostPrice = costPrice;
            RetailPrice = retailPrice;
            SupplierID = supplierID;
            Active = active;
            Notes = notes;
        }

        public Item() { }
    }
}
