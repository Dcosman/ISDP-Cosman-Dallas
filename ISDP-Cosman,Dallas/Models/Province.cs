using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Province
    {
        private string provinceID;
        public string ProvinceID
        {
            get { return provinceID; }
            set { provinceID = value; }
        }

        private string provinceName;
        public string ProvinceName
        {
            get { return provinceName; }
            set { provinceName = value; }
        }

        private string countryCode;
        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        public Province(string provinceID, string provinceName, string countryCode)
        {
            ProvinceID = provinceID;
            ProvinceName = provinceName;
            CountryCode = countryCode;
        }

        public Province() { }
    }
}
