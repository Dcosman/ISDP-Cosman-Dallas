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
    public static class EmployeeAccessor
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;

        private static List<Employee> EmployeeByField(int empID, string empUsername)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            List<Employee> theEmployees = new List<Employee>();
            string sqlEmp;

            if (empID > 0)
            {
                sqlEmp = "SELECT * FROM employee WHERE employeeID = @empID";
            }
            else if (!string.IsNullOrEmpty(empUsername))
            {
                sqlEmp = "SELECT * FROM employee WHERE username = @empUsername";
            }
            else
            {
                sqlEmp = "SELECT * FROM employee";
            }

            try
            {
                conn.Open();
                MySqlCommand cmdEmp = new MySqlCommand(sqlEmp, conn);

                // Add parameters based on conditions
                if (empID > 0)
                {
                    cmdEmp.Parameters.AddWithValue("@empID", empID);
                }
                else if (!string.IsNullOrEmpty(empUsername))
                {
                    cmdEmp.Parameters.AddWithValue("@empUsername", empUsername);
                }

                using (MySqlDataReader empReader = cmdEmp.ExecuteReader())
                {
                    while (empReader.Read())
                    {
                        theEmployees.Add(HelperMethods.CreateEmployee(empReader));
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

            return theEmployees;
        }
        public static Employee GetEmployeeByUsername(string empUsername)
        {
            List<Employee> employees = EmployeeByField(-1, empUsername);
            if (employees.Count > 0)
                return employees[0];
            else
                return null;
        }

        public static Employee GetEmployeeByID(int empID)
        {
            List<Employee> employees = EmployeeByField(empID, "");
            if (employees.Count > 0)
                return employees[0];
            else
                return null;
        }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> theEmployess = EmployeeByField(-1, "");

            return theEmployess;
        }

        public static bool AddUpdateEmployee(string sql, List<MySqlParameter> parameters)
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
                    MessageBox.Show($"Error: Employee update was unsuccessful\n{ex.Message}");
                    success = false;
                }
            }

            return success;
        }

        public static bool AddUpdateEmployee(string sql, params MySqlParameter[] parameters)
        {
            return AddUpdateEmployee(sql, parameters.ToList());
        }
    }
}
