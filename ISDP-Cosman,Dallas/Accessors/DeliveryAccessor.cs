using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace ISDP_Cosman_Dallas.Accessors
{
    public static class DeliveryAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        public static List<Delivery> GetAllDeliveries()
        {
            List<Delivery> deliveries = new List<Delivery>();
            string sqlDelivery = "SELECT * FROM delivery";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdDelivery = new MySqlCommand(sqlDelivery, conn);

                using (MySqlDataReader deliveryReader = cmdDelivery.ExecuteReader())
                {
                    while (deliveryReader.Read())
                    {
                        deliveries.Add(CreateDelivery(deliveryReader));
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

            return deliveries;
        }

        public static Delivery GetDeliveryByID(int deliveryID)
        {
            string sqlDelivery = "SELECT * FROM delivery WHERE deliveryID = @deliveryID";
            return GetDelivery(sqlDelivery, new MySqlParameter("@deliveryID", deliveryID));
        }

        private static Delivery GetDelivery(string sqlQuery, params MySqlParameter[] parameters)
        {
            Delivery delivery = null;
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdDelivery = new MySqlCommand(sqlQuery, conn);
                cmdDelivery.Parameters.AddRange(parameters);

                using (MySqlDataReader reader = cmdDelivery.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        delivery = CreateDelivery(reader);
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

            return delivery;
        }

        private static Delivery CreateDelivery(MySqlDataReader reader)
        {
            int deliveryID = Convert.ToInt32(reader["deliveryID"]);
            decimal distanceCost = Convert.ToDecimal(reader["distanceCost"]);
            string vehicleType = Convert.ToString(reader["vehicleType"]);
            string notes = reader["notes"] == DBNull.Value ? null : Convert.ToString(reader["notes"]);

            return new Delivery(deliveryID, distanceCost, vehicleType, notes);
        }
    }
}
