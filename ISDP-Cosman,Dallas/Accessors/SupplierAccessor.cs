using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Accessors
{
    public static class SupplierAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            string sqlQuery = "SELECT * FROM supplier";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(HelperMethods.CreateSupplier(reader));
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

            return suppliers;
        }

        public static Supplier GetSupplierByID(int supplierID)
        {
            string sqlSupplier = "SELECT * FROM supplier WHERE supplierID = @supplierID";
            MySqlParameter[] parameters = {
                new MySqlParameter("@supplierID", supplierID)
            };

            return GetSupplier(sqlSupplier, parameters);
        }

        public static Supplier GetSupplierByName(string suppName)
        {
            string sqlSupplier = "SELECT * FROM supplier WHERE name = @suppName";
            MySqlParameter[] parameters = {
                new MySqlParameter("@suppName", suppName)
            };

            return GetSupplier(sqlSupplier, parameters);
        }

        private static Supplier GetSupplier(string sqlQuery, params MySqlParameter[] parameters)
        {
            Supplier supp = new Supplier();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdSupplier = new MySqlCommand(sqlQuery, conn);
                cmdSupplier.Parameters.AddRange(parameters);

                using (MySqlDataReader reader = cmdSupplier.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        supp = HelperMethods.CreateSupplier(reader);
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

            return supp;
        }

        public static bool AddUpdateSupplier(string sql, List<MySqlParameter> parameters)
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
                    MessageBox.Show($"Error: Supplier update was unsuccessful\n{ex.Message}");
                    success = false;
                }
            }

            return success;
        }

        public static bool AddUpdateSupplier(string sql, params MySqlParameter[] parameters)
        {
            return AddUpdateSupplier(sql, parameters.ToList());
        }

    }
}
