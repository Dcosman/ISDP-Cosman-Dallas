using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace ISDP_Cosman_Dallas.Accessors
{
    public static class TransactionStatusAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        public static List<TransactionStatus> GetAllTransactionStatus()
        {
            List<TransactionStatus> transactionStatuses = new List<TransactionStatus>();

            MySqlConnection conn = new MySqlConnection(connStr);
            string sql = "SELECT * FROM txnStatus";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string statusName = reader["statusName"].ToString();
                        string statusDescription = reader["statusDescription"].ToString();

                        TransactionStatus transactionStatus = new TransactionStatus(statusName, statusDescription);
                        transactionStatuses.Add(transactionStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Unable to retrieve transaction statuses\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return transactionStatuses;
        }

        public static TransactionStatus GetTransactionStatusByName(string statusName)
        {
            TransactionStatus transactionStatus = null;

            MySqlConnection conn = new MySqlConnection(connStr);
            string sql = "SELECT * FROM txnStatus WHERE statusName = @statusName";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@statusName", statusName);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string statusDescription = reader["statusDescription"].ToString();
                        transactionStatus = new TransactionStatus(statusName, statusDescription);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Unable to retrieve transaction status by name\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return transactionStatus;
        }
    }
}
