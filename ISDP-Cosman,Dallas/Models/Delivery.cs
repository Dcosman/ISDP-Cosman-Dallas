using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Delivery
    {
        private int deliveryID;
        public int DeliveryID
        {
            get { return deliveryID; }
            set { deliveryID = value; }
        }

        private decimal distanceCost;
        public decimal DistanceCost
        {
            get { return distanceCost; }
            set { distanceCost = value; }
        }

        private string vehicleType;
        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public Delivery(int deliveryID, decimal distanceCost, string vehicleType, string notes = null)
        {
            DeliveryID = deliveryID;
            DistanceCost = distanceCost;
            VehicleType = vehicleType;
            Notes = notes;
        }
    }
}
