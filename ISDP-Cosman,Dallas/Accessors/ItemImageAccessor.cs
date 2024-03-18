using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Accessors
{
    public static class ItemImageAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        public static string GetImageByItemID(int itemID)
        {
            string path = "";
            string sqlItem = "SELECT imagePath FROM itemImage WHERE itemid = @itemID";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                using (MySqlCommand cmdItem = new MySqlCommand(sqlItem, conn))
                {
                    cmdItem.Parameters.AddWithValue("@itemID", itemID);

                    using (MySqlDataReader reader = cmdItem.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            path = reader.GetString("ImagePath");
                        }
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

            return path;
        }

        public static bool DeleteImageByItemID(int itemID)
        {
            bool success = false;
            string delSql = "DELETE FROM itemImage WHERE itemid = @itemID";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                using (MySqlCommand delCmd = new MySqlCommand(delSql, conn))
                {
                    delCmd.Parameters.AddWithValue("@itemID", itemID);
                    delCmd.ExecuteNonQuery();
                }
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                success = false;
            }
            finally
            {
                conn.Close();
            }

            return success;
        }

        public static bool AddUpdateItemImage(string sql, params MySqlParameter[] parameters)
        {
            bool success = false;
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                using (MySqlCommand updateCmd = new MySqlCommand(sql, conn))
                {
                    updateCmd.Parameters.AddRange(parameters);
                    updateCmd.ExecuteNonQuery();
                }
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Image update was unsuccessful\n{ex.Message}");
                success = false;
            }
            finally
            {
                conn.Close();
            }

            return success;
        }
    }
}
