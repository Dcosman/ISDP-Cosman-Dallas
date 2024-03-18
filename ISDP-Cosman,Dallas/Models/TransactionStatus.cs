using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class TransactionStatus
    {
        private string statusName;
        public string StatusName
        {
            get { return statusName; }
            set { statusName = value; }
        }

        private string statusDescription;
        public string StatusDescription
        {
            get { return statusDescription; }
            set { statusDescription = value; }
        }        
        
        public TransactionStatus(string statusName, string statusDescription)
        {
            StatusName = statusName;
            StatusDescription = statusDescription;
        }
    }
}
