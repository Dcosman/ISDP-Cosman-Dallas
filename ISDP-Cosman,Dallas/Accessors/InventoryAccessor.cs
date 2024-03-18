using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Accessors
{
    public static class InventoryAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        private static List<Inventory> InventoryByField(int itemID, int siteID)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            List<Inventory> inventoryItems = new List<Inventory>();
            string sqlInventory;

            if (itemID > 0 && siteID > 0)
            {
                sqlInventory = "SELECT * FROM inventory WHERE itemID = @itemID AND siteID = @siteID AND itemLocation = 0";
            }
            else if (itemID > 0)
            {
                sqlInventory = "SELECT * FROM inventory WHERE itemID = @itemID";
            }
            else if (siteID > 0)
            {
                sqlInventory = "SELECT * FROM inventory WHERE siteID = @siteID";
            }
            else
            {
                sqlInventory = "SELECT * FROM inventory";
            }

            try
            {
                conn.Open();
                MySqlCommand cmdInventory = new MySqlCommand(sqlInventory, conn);

                // Add parameters based on conditions
                if (itemID > 0)
                {
                    cmdInventory.Parameters.AddWithValue("@itemID", itemID);
                }
                if (siteID > 0)
                {
                    cmdInventory.Parameters.AddWithValue("@siteID", siteID);
                }

                using (MySqlDataReader inventoryReader = cmdInventory.ExecuteReader())
                {
                    while (inventoryReader.Read())
                    {
                        inventoryItems.Add(HelperMethods.CreateInventory(inventoryReader));
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

            return inventoryItems;
        }

        public static Inventory GetInventoryByItemID(int itemID)
        {
            List<Inventory> inventoryItems = InventoryByField(itemID, -1);
            if (inventoryItems.Count > 0)
                return inventoryItems[0];
            else
                return null;
        }

        public static List<Inventory> GetInventoryBySiteID(int siteID)
        {
            List<Inventory> inventoryItems = InventoryByField(-1, siteID);
            if (inventoryItems.Count > 0)
                return inventoryItems;
            else
                return null;
        }

        public static List<Inventory> GetAllInventory()
        {
            List<Inventory> inventoryItems = InventoryByField(-1, -1);
            return inventoryItems;
        }

        public static List<Inventory> GetThresholdInventory(int siteID)
        {
            List<Inventory> lowQuantityInventory = new List<Inventory>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM inventory WHERE siteID = @siteID AND quantity < optimumThreshold AND itemLocation = '0'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@siteID", siteID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lowQuantityInventory.Add(HelperMethods.CreateInventory(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Inventory threshold get was unsuccessful\n{ex.Message}");
            }

            return lowQuantityInventory;
        }

        public static List<OrderInventory> GetSiteInventory(int siteID)
        {
            List<OrderInventory> lowQuantityInventory = new List<OrderInventory>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"
                        SELECT i.itemID, i.name, inv.quantity, i.caseSize
                        FROM inventory inv
                        INNER JOIN item i ON inv.itemID = i.itemID
                        WHERE inv.siteID = @siteID
                        AND itemLocation = '0'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@siteID", siteID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lowQuantityInventory.Add(HelperMethods.CreateOrderInventory(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Inventory by site get was unsuccessful\n{ex.Message}");
            }

            return lowQuantityInventory;
        }

        public static List<OrderInventory> GetOrderInventory(int txnID)
        {
            List<OrderInventory> lowQuantityInventory = new List<OrderInventory>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"
                        SELECT i.itemID, i.name, inv.quantity, i.caseSize
                        FROM inventory inv
                        INNER JOIN item i ON inv.itemID = i.itemID
                        WHERE inv.itemLocation = @txnID";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@txnID", txnID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lowQuantityInventory.Add(HelperMethods.CreateOrderInventory(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Inventory by site get was unsuccessful\n{ex.Message}");
            }

            return lowQuantityInventory;
        }


        public static Inventory GetInventoryByItemIDAndSiteID(int itemID, int siteID)
        {
            List<Inventory> inventoryItems = InventoryByField(itemID, siteID);
            if (inventoryItems.Count > 0)
                return inventoryItems[0];
            else
                return null;
        }

        public static List<Inventory> GetInventoryByLocation(string itemLocation)
        {
            List<Inventory> locationInventory = new List<Inventory>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"
                        SELECT * from inventory WHERE itemLocation = @itemLocation";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@itemLocation", itemLocation);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            locationInventory.Add(HelperMethods.CreateInventory(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Inventory by location get was unsuccessful\n{ex.Message}");
            }

            return locationInventory;
        }

        public static Inventory GetInventoryByItemIdAndLocation(int itemID, string itemLocation)
        {
            Inventory itemLocationInventory = new Inventory();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"
                        SELECT * FROM inventory WHERE itemID = @itemID AND itemLocation = @itemLocation";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@itemID", itemID);
                    cmd.Parameters.AddWithValue("@itemLocation", itemLocation);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            itemLocationInventory = HelperMethods.CreateInventory(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Inventory by itemID and location get was unsuccessful\n{ex.Message}");
            }

            return itemLocationInventory;
        }


        public static bool AddUpdateInventory(string sql, List<MySqlParameter> parameters)
        {
            bool success = false;
            string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

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
                    MessageBox.Show($"Error: Inventory update was unsuccessful\n{ex.Message}");
                    success = false;
                }
            }

            return success;
        }

        public static bool AddUpdateInventory(string sql, params MySqlParameter[] parameters)
        {
            return AddUpdateInventory(sql, parameters.ToList());
        }
    }
}
