using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace ISDP_Cosman_Dallas.Accessors
{
    public static class TransactionAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        private static List<Transaction> TransactionsByField(int txnID, int siteIDTo, string status)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            List<Transaction> transactions = new List<Transaction>();
            string sql;

            if (txnID > 0)
            {
                sql = "SELECT * FROM txn WHERE txnID = @txnID";
            }
            else if (siteIDTo > 0)
            {
                sql = "SELECT * FROM txn WHERE siteIDTo = @siteIDTo";
            }            
            else if (!status.Equals(""))
            {
                sql = "SELECT * FROM txn WHERE Status NOT IN ('CLOSED', 'CANCELLED')";
            }
            else
            {
                sql = "SELECT * FROM txn";
            }

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // Add parameters based on conditions
                if (txnID > 0)
                {
                    cmd.Parameters.AddWithValue("@txnID", txnID);
                }
                else if (siteIDTo > 0)
                {
                    cmd.Parameters.AddWithValue("@siteIDTo", siteIDTo);
                }                

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(HelperMethods.CreateTransaction(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return transactions;
        }

        public static Transaction GetTransactionByTxnID(int txnID)
        {
            List<Transaction> transactions = TransactionsByField(txnID, 0, "");
            if (transactions.Count > 0)
                return transactions[0];
            else
                return null;
        }

        public static Transaction GetTransactionBySiteIDTo(int siteIDTo)
        {
            List<Transaction> transactions = TransactionsByField(0, siteIDTo, "");
            if (transactions.Count > 0)
                return transactions[0];
            else
                return null;
        }

        public static List<Transaction> GetAllTransactions(string status)
        {
            if(status.Equals("open"))
                return TransactionsByField(0, 0, "");
            else
                return TransactionsByField(0, 0, status);

        }

        public static bool AddUpdateTransaction(string sql, List<MySqlParameter> parameters)
        {
            bool success = false;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                        cmd.ExecuteNonQuery();
                    }
                    success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Transaction update was unsuccessful\n{ex.Message}");
                    success = false;
                }
            }
            return success;
        }

        public static bool AddUpdateTransaction(string sql, params MySqlParameter[] parameters)
        {
            return AddUpdateTransaction(sql, new List<MySqlParameter>(parameters));
        }

        public static List<Transaction> GetBackOrder(int siteID)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            List<Transaction> transactions = new List<Transaction>();

            string sql = "SELECT * FROM txn WHERE siteIDTo = @siteID AND status = 'Pending Back Order'";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@siteID", siteID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(HelperMethods.CreateTransaction(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return transactions;
        }
    }
}
