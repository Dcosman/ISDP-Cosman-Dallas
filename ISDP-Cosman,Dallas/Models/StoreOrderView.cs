using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class StoreOrderView
    {
        private int txnID;
        public int TxnID
        {
            get { return txnID; }
            set { txnID = value; }
        }

        private string siteNameTo;
        public string SiteNameTo
        {
            get { return siteNameTo; }
            set { siteNameTo = value; }
        }

        private string siteNameFrom;
        public string SiteNameFrom
        {
            get { return siteNameFrom; }
            set { siteNameFrom = value; }
        }

        private string statusName;
        public string StatusName
        {
            get { return statusName; }
            set { statusName = value; }
        }

        private DateTime shipDate;
        public DateTime ShipDate
        {
            get { return shipDate; }
            set { shipDate = value; }
        }

        private string txnType;
        public string TxnType
        {
            get { return txnType; }
            set { txnType = value; }
        }

        private string vehicleType;
        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        private decimal weight;
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public StoreOrderView(int txnID, string siteNameTo, string siteNameFrom, string statusName, DateTime shipDate, string txnType, string vehicleType, decimal weight)
        {
            TxnID = txnID;
            SiteNameTo = siteNameTo;
            SiteNameFrom = siteNameFrom;
            StatusName = statusName;
            ShipDate = shipDate;
            TxnType = txnType;
            VehicleType = vehicleType;
            Weight = weight;
        }

        public StoreOrderView() { }
    }
}
