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


    }
}
