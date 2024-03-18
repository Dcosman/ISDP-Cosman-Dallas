using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Supplier
    {
        private int supplierID;
        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address1;
        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        private string address2;
        public string Address2
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

        private string province;
        public string Province
        {
            get { return province; }
            set { province = value; }
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

        private string contact;
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public Supplier(int supplierID, string name, string address1, string city, string country, string province, string postalCode, string phone, string address2 = null, string contact = null, string notes = null)
        {
            SupplierID = supplierID;
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            Country = country;
            Province = province;
            PostalCode = postalCode;
            Phone = phone;
            Contact = contact;
            Notes = notes;
        }

        public Supplier() { }

    }
}
