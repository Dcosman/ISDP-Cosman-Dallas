using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDP_Cosman_Dallas.Accessors
{
    public static class TransactionItemsAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        public static List<TransactionItems> GetTransactionItemsById(int txnID)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            List<TransactionItems> transactionItemsList = new List<TransactionItems>();
            string sql = "SELECT * FROM txnItems WHERE txnID = @txnID";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@txnID", txnID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TransactionItems transactionItems = new TransactionItems
                        {
                            TxnID = reader.GetInt32("txnID"),
                            ItemID = reader.GetInt32("itemID"),
                            Quantity = reader.GetInt32("quantity"),
                            Notes = reader.IsDBNull(reader.GetOrdinal("notes")) ? null : reader.GetString("notes")
                        };
                        transactionItemsList.Add(transactionItems);
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

            return transactionItemsList;
        }

        public static TransactionItems GetTransactionItemByItemId(int itemID)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            TransactionItems item = new TransactionItems();
            string sql = "SELECT * FROM txnItems WHERE itemID = @itemID";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@itemID", itemID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TransactionItems transactionItems = new TransactionItems
                        {
                            TxnID = reader.GetInt32("txnID"),
                            ItemID = reader.GetInt32("itemID"),
                            Quantity = reader.GetInt32("quantity"),
                            Notes = reader.IsDBNull(reader.GetOrdinal("notes")) ? null : reader.GetString("notes")
                        };
                        item = transactionItems;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return item;
        }

        public static bool AddUpdateTransactionItems(string sql, List<MySqlParameter> parameters)
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
                    MessageBox.Show($"Error: Transaction items update was unsuccessful\n{ex.Message}");
                    success = false;
                }
            }
            return success;
        }

        public static bool AddUpdateTransactionItems(string sql, params MySqlParameter[] parameters)
        {
            return AddUpdateTransactionItems(sql, new List<MySqlParameter>(parameters));
        }

    }
}
