using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class TransactionType
    {
        private string txnType;
        public string TxnType
        {
            get { return txnType; }
            set { txnType = value; }
        }        
        
        public TransactionType(string txnType)
        {
            TxnType = txnType;
        }
    }
}
