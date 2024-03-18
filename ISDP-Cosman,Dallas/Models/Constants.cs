using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Constants
    {
        public const int REGIONAL_MANAGER = 1;
        public const int FINANCIAL_MANAGER = 2;
        public const int STORE_MANAGER = 3;
        public const int WAREHOUSE_MANAGER = 4;
        public const int TRUCKING_DELIVERY = 5;
        public const int WAREHOUSE_EMPLOYEE = 6;
        public const int ADMIN = 99999999;
        public const string ORDER_BARCODE = "111222333444";

        public const string DEFAULT_PASSWORD = "P@ssw0rd-";

        public const int WAREHOUSE_SITE = 2;

        public static readonly String[] DAYSOFWEEK = {
                "SUNDAY",
                "MONDAY",
                "TUESDAY",
                "WEDNESDAY",
                "THURSDAY",
                "FRIDAY",
                "SATURDAY"
            };
    }
}
