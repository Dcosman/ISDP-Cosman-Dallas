using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Site
    {
        private int siteID;
        public int SiteID
        {
            get { return siteID; }
            set { siteID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string provinceID;
        public string ProvinceID
        {
            get { return provinceID; }
            set { provinceID = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string? address2;
        public string? Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string postalCode;
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string? dayOfWeek;
        public string? DayOfWeek
        {
            get { return dayOfWeek; }
            set { dayOfWeek = value; }
        }

        private int distanceFromWH;
        public int DistanceFromWH
        {
            get { return distanceFromWH; }
            set { distanceFromWH = value; }
        }

        private string? notes;
        public string? Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public Site(int siteID, string name, string provinceID, string address, string city, string country, string postalCode, string phone, int distanceFromWH, string dayOfWeek, string address2, string notes)
        {
            SiteID = siteID;
            Name = name;
            ProvinceID = provinceID;
            Address = address;
            Address2 = address2;
            City = city;
            Country = country;
            PostalCode = postalCode;
            Phone = phone;
            DayOfWeek = dayOfWeek;
            DistanceFromWH = distanceFromWH;
            Notes = notes;
        }

        public Site() { }
    }
}
