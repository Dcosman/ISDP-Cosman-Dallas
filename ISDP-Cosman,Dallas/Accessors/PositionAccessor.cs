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
    public static class PositionAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        public static List<Position> GetAllPositions()
        {
            List<Position> positions = new List<Position>();
            string sqlPosn = "select * from posn";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();
                MySqlCommand cmdPosn = new MySqlCommand(sqlPosn, conn);

                using (MySqlDataReader posnReader = cmdPosn.ExecuteReader())
                {
                    while (posnReader.Read())
                    {
                        positions.Add(HelperMethods.CreatePosition(posnReader));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return positions;
        }

        public static Position GetPositionByName(string posnName)
        {
            string sqlPosn = "SELECT * FROM posn WHERE permissionLevel = @posnName";
            return GetPosition(sqlPosn, new MySqlParameter("@posnName", posnName));
        }

        public static Position GetPositionByID(int posnID)
        {
            string sqlPosn = "SELECT * FROM posn WHERE positionID = @posnID";
            return GetPosition(sqlPosn, new MySqlParameter("@posnID", posnID));
        }

        private static Position GetPosition(string sqlQuery, params MySqlParameter[] parameters)
        {
            Position posn = new Position();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmdPosn = new MySqlCommand(sqlQuery, conn);
                cmdPosn.Parameters.AddRange(parameters);

                using (MySqlDataReader reader = cmdPosn.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        posn = HelperMethods.CreatePosition(reader);
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

            return posn;
        }

    }
}
