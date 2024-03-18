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
    public static class ProvinceAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        public static List<Province> GetAllProvinces()
        {
            List<Province> provinces = new List<Province>();
            string sqlProvince = "SELECT * FROM province";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdProvince = new MySqlCommand(sqlProvince, conn);

                using (MySqlDataReader provinceReader = cmdProvince.ExecuteReader())
                {
                    while (provinceReader.Read())
                    {
                        provinces.Add(CreateProvince(provinceReader));
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

            return provinces;
        }

        public static Province GetProvinceByName(string provinceName)
        {
            string sqlProvince = "SELECT * FROM province WHERE provinceName = @provinceName";
            return GetProvince(sqlProvince, new MySqlParameter("@provinceName", provinceName));
        }

        public static Province GetProvinceByID(string provinceID)
        {
            string sqlProvince = "SELECT * FROM province WHERE provinceID = @provinceID";
            return GetProvince(sqlProvince, new MySqlParameter("@provinceID", provinceID));
        }

        private static Province GetProvince(string sqlQuery, params MySqlParameter[] parameters)
        {
            Province province = new Province();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdProvince = new MySqlCommand(sqlQuery, conn);
                cmdProvince.Parameters.AddRange(parameters);

                using (MySqlDataReader reader = cmdProvince.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        province = CreateProvince(reader);
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

            return province;
        }

        private static Province CreateProvince(MySqlDataReader reader)
        {
            string provinceID = reader["provinceID"].ToString();
            string provinceName = reader["provinceName"].ToString();
            string countryCode = reader["countryCode"].ToString();

            return new Province(provinceID, provinceName, countryCode);
        }
    }
}
