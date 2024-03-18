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
    public static class SiteAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        public static List<Site> GetAllSites()
        {
            List<Site> sites = new List<Site>();
            string sqlSite = "SELECT * FROM site";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdSite = new MySqlCommand(sqlSite, conn);

                using (MySqlDataReader siteReader = cmdSite.ExecuteReader())
                {
                    while (siteReader.Read())
                    {
                        sites.Add(HelperMethods.CreateSite(siteReader));
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

            return sites;
        }

        public static Site GetSiteByName(string siteName)
        {
            string sqlSite = "SELECT * FROM site WHERE name = @siteName";
            return GetSite(sqlSite, new MySqlParameter("@siteName", siteName));
        }

        public static Site GetSiteByID(int siteID)
        {
            string sqlSite = "SELECT * FROM site WHERE siteid = @siteID";
            return GetSite(sqlSite, new MySqlParameter("@siteID", siteID));
        }

        private static Site GetSite(string sqlQuery, params MySqlParameter[] parameters)
        {
            Site site = new Site();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdSite = new MySqlCommand(sqlQuery, conn);
                cmdSite.Parameters.AddRange(parameters);

                using (MySqlDataReader reader = cmdSite.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        site = HelperMethods.CreateSite(reader);
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

            return site;
        }

        public static bool AddUpdateSite(string sql, List<MySqlParameter> parameters)
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
                    MessageBox.Show($"Error: Site update was unsuccessful\n{ex.Message}");
                    success = false;
                }
            }

            return success;
        }

        public static bool AddUpdateSite(string sql, params MySqlParameter[] parameters)
        {
            return AddUpdateSite(sql, parameters.ToList());
        }

    }
}
