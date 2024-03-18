using MySql.Data.MySqlClient;
using System.Configuration;

namespace ISDP_Cosman_Dallas.Models
{
    public class TransactionAudit
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        private int txnAuditID;
        public int TxnAuditID
        {
            get { return txnAuditID; }
            set { txnAuditID = value; }
        }

        private int txnID;
        public int TxnID
        {
            get { return txnID; }
            set { txnID = value; }
        }

        private string txnType;
        public string TxnType
        {
            get { return txnType; }
            set { txnType = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime txnDate;
        public DateTime TxnDate
        {
            get { return txnDate; }
            set { txnDate = value; }
        }

        private int siteID;
        public int SiteID
        {
            get { return siteID; }
            set { siteID = value; }
        }

        private int? deliveryID;
        public int? DeliveryID
        {
            get { return deliveryID; }
            set { deliveryID = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public TransactionAudit(int txnAuditID, int txnID, string txnType, string status, DateTime txnDate, int siteID, int? deliveryID = null, string notes = null)
        {
            TxnAuditID = txnAuditID;
            TxnID = txnID;
            TxnType = txnType;
            Status = status;
            TxnDate = txnDate;
            SiteID = siteID;
            DeliveryID = deliveryID;
            Notes = notes;
        }

        public bool CommitTransactionAudit()
        {
            bool success = false;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Insert the new transaction audit
                    string insertSql = @"
                        INSERT INTO txnAudit (txnID, txnType, status, txnDate, siteID, deliveryID, notes)
                        VALUES (@txnID, @txnType, @status, @txnDate, @siteID, @deliveryID, @notes)";

                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@txnID", TxnID);
                    insertCmd.Parameters.AddWithValue("@txnType", TxnType);
                    insertCmd.Parameters.AddWithValue("@status", Status);
                    insertCmd.Parameters.AddWithValue("@txnDate", TxnDate);
                    insertCmd.Parameters.AddWithValue("@siteID", SiteID);
                    insertCmd.Parameters.AddWithValue("@deliveryID", (object)DeliveryID ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@notes", (object)Notes ?? DBNull.Value);
                    insertCmd.ExecuteNonQuery();

                    success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Transaction audit set was unsuccessful\n{ex.Message}");
                    success = false;
                }
            }

            return success;
        }
    }
}
