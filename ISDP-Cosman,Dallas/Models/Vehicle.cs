using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Vehicle
    {
        private string vehicleType;
        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        private decimal maxWeight;
        public decimal MaxWeight
        {
            get { return maxWeight; }
            set { maxWeight = value; }
        }

        private decimal hourlyTruckCost;
        public decimal HourlyTruckCost
        {
            get { return hourlyTruckCost; }
            set { hourlyTruckCost = value; }
        }

        private decimal costPerKm;
        public decimal CostPerKm
        {
            get { return costPerKm; }
            set { costPerKm = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public Vehicle(string vehicleType, decimal maxWeight, decimal hourlyTruckCost, decimal costPerKm, string notes)
        {
            VehicleType = vehicleType;
            MaxWeight = maxWeight;
            HourlyTruckCost = hourlyTruckCost;
            CostPerKm = costPerKm;
            Notes = notes;
        }
    }
}
