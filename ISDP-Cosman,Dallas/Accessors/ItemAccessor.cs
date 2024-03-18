using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ISDP_Cosman_Dallas.Accessors
{
    public static class ItemAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        public static List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();
            string sqlItem = "SELECT * FROM item";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdItem = new MySqlCommand(sqlItem, conn);

                using (MySqlDataReader itemReader = cmdItem.ExecuteReader())
                {
                    while (itemReader.Read())
                    {
                        items.Add(HelperMethods.CreateItem(itemReader));
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

            return items;
        }

        public static Item GetItemByID(int itemID)
        {
            string sqlItem = "SELECT * FROM item WHERE itemid = @itemID";
            return GetItem(sqlItem, new MySqlParameter("@itemID", itemID));
        }

        public static Item GetItemByName(string itemName)
        {
            string sqlItem = "SELECT * FROM item WHERE name = @itemName";
            return GetItem(sqlItem, new MySqlParameter("@itemName", itemName));
        }

        private static Item GetItem(string sqlQuery, params MySqlParameter[] parameters)
        {
            Item item = new Item();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdItem = new MySqlCommand(sqlQuery, conn);
                cmdItem.Parameters.AddRange(parameters);

                using (MySqlDataReader reader = cmdItem.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        item = HelperMethods.CreateItem(reader);
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

            return item;
        }

        public static bool AddUpdateItem(string sql, params MySqlParameter[] parameters)
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
                MessageBox.Show($"Error: Item update was unsuccessful\n{ex.Message}");
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
