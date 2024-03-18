using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Transaction
    {
        private int txnID;
        public int TxnID
        {
            get { return txnID; }
            set { txnID = value; }
        }

        private int siteIDTo;
        public int SiteIDTo
        {
            get { return siteIDTo; }
            set { siteIDTo = value; }
        }

        private int siteIDFrom;
        public int SiteIDFrom
        {
            get { return siteIDFrom; }
            set { siteIDFrom = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
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

        private string barCode;
        public string BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }

        private DateTime createdDate;
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private int? deliveryID;
        public int? DeliveryID
        {
            get { return deliveryID; }
            set { deliveryID = value; }
        }

        private bool? emergencyDelivery;
        public bool? EmergencyDelivery
        {
            get { return emergencyDelivery; }
            set { emergencyDelivery = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public Transaction(int txnID, int siteIDTo, int siteIDFrom, string status, DateTime shipDate, string txnType, string barCode, DateTime createdDate, int? deliveryID = null, bool? emergencyDelivery = null, string? notes = null)
        {
            TxnID = txnID;
            SiteIDTo = siteIDTo;
            SiteIDFrom = siteIDFrom;
            Status = status;
            ShipDate = shipDate;
            TxnType = txnType;
            BarCode = barCode;
            CreatedDate = createdDate;
            DeliveryID = deliveryID;
            EmergencyDelivery = emergencyDelivery;
            Notes = notes;
        }
    }
}

