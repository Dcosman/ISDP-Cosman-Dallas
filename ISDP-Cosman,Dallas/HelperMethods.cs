using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ISDP_Cosman_Dallas
{
    public static class HelperMethods
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;
        private static byte[] empKey, empIV;

        public static Employee CreateEmployee(MySqlDataReader empReader)
        {
            Employee theEmployee = new Employee
            (
                empReader.GetInt32("employeeID"),
                empReader["password"].ToString(),
                empReader.GetString("firstname"),
                empReader.GetString("lastname"),
                empReader.GetString("email"),
                empReader.GetBoolean("active"),
                empReader.GetInt32("siteID"),
                empReader.GetString("username"),
                empReader.GetBoolean("locked"),
                empReader.GetInt32("positionID"),
                empReader.GetInt32("loginAttempts"),
                empReader.IsDBNull("notes") ? null : empReader.GetString("Notes")

            );
            return theEmployee;
        }

        public static OrderInventory CreateOrderInventory(MySqlDataReader reader)
        {
            OrderInventory orderInventory = new OrderInventory
            (
                reader.GetInt32("itemID"),
                reader.GetInt32("quantity"),
                reader.GetString("name"),
                reader.GetInt32("caseSize")
            );
            return orderInventory;
        }

        public static Transaction CreateTransaction(MySqlDataReader reader)
        {
            Transaction transaction = new Transaction
            (
                reader.GetInt32("txnID"),
                reader.GetInt32("siteIDTo"),
                reader.GetInt32("siteIDFrom"),
                reader.GetString("status"),
                reader.GetDateTime("shipDate"),
                reader.GetString("txnType"),
                reader.GetString("barCode"),
                reader.GetDateTime("createdDate"),
                reader.IsDBNull("deliveryID") ? null : reader.GetInt32("deliveryID"),
                reader.IsDBNull("emergencyDelivery") ? null : reader.GetBoolean("emergencyDelivery"),
                reader.IsDBNull("notes") ? null : reader.GetString("notes")
            );

            return transaction;
        }

        public static Position CreatePosition(MySqlDataReader posnReader)
        {
            Position posn = new Position
            (
                posnReader.GetInt32("positionID"),
                posnReader.GetString("permissionLevel")
            );
            return posn;
        }

        public static Site CreateSite(MySqlDataReader siteReader)
        {
            Site site = new Site(
                siteReader.GetInt32("SiteID"),
                siteReader.GetString("Name"),
                siteReader.GetString("ProvinceID"),
                siteReader.GetString("Address"),
                siteReader.GetString("City"),
                siteReader.GetString("Country"),
                siteReader.GetString("PostalCode"),
                siteReader.GetString("Phone"),
                siteReader.GetInt32("DistanceFromWH"),
                siteReader.IsDBNull("DayOfWeek") ? null : siteReader.GetString("DayOfWeek"),
                siteReader.IsDBNull("Address2") ? null : siteReader.GetString("Address2"),
                siteReader.IsDBNull("Notes") ? null : siteReader.GetString("Notes")
            );
            return site;
        }

        public static Item CreateItem(MySqlDataReader itemReader)
        {
            Item item = new Item(
                itemReader.GetInt32("ItemID"),
                itemReader.GetString("Name"),
                itemReader.GetString("SKU"),
                itemReader.GetString("Category"),
                itemReader.GetDecimal("Weight"),
                itemReader.GetInt32("CaseSize"),
                itemReader.GetDecimal("CostPrice"),
                itemReader.GetDecimal("RetailPrice"),
                itemReader.GetInt32("SupplierID"),
                itemReader.GetBoolean("Active"),
                itemReader.IsDBNull("Description") ? null : itemReader.GetString("Description"),
                itemReader.IsDBNull("Notes") ? null : itemReader.GetString("Notes")
            );
            return item;
        }

        public static Supplier CreateSupplier(MySqlDataReader supplierReader)
        {
            Supplier supplier = new Supplier(
                supplierReader.GetInt32("SupplierID"),
                supplierReader.GetString("Name"),
                supplierReader.GetString("Address1"),
                supplierReader.GetString("City"),
                supplierReader.GetString("Country"),
                supplierReader.GetString("Province"),
                supplierReader.GetString("PostalCode"),
                supplierReader.GetString("Phone"),
                supplierReader.IsDBNull("Address2") ? null : supplierReader.GetString("Address2"),
                supplierReader.IsDBNull("Contact") ? null : supplierReader.GetString("Contact"),
                supplierReader.IsDBNull("Notes") ? null : supplierReader.GetString("Notes")
            );
            return supplier;
        }

        public static Inventory CreateInventory(MySqlDataReader reader)
        {
            int itemID = Convert.ToInt32(reader["itemID"]);
            int siteID = Convert.ToInt32(reader["siteID"]);
            int quantity = Convert.ToInt32(reader["quantity"]);
            string itemLocation = reader["itemLocation"].ToString();
            int optimumThreshold = Convert.ToInt32(reader["optimumThreshold"]);
            int? reorderThreshold = reader["reorderThreshold"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["reorderThreshold"]);
            string notes = reader["notes"].ToString();

            return new Inventory(itemID, siteID, quantity, itemLocation, optimumThreshold, reorderThreshold, notes);
        }

        public static void EncryptEmpPasswords()
        {
            List<Employee> allEmployees = EmployeeAccessor.GetAllEmployees();
            MySqlConnection conn = new MySqlConnection(connStr);
            foreach (Employee emp in allEmployees)
            {
                string ePassword = HelperMethods.EncryptPassword(emp.Password, -1);
                string sql = $"insert into passwordEncrypt (employeeID, passwordKey, passwordIV) values ({emp.EmployeeID}, '{Convert.ToBase64String(empKey)}', '{Convert.ToBase64String(empIV)}');";
                string updateSql = $"update employee set password = '{ePassword}' where employeeID = {emp.EmployeeID}";
                EmployeeAccessor.AddUpdateEmployee(updateSql);
                try
                {
                    conn.Open();
                    using (MySqlCommand insertCmd = new MySqlCommand(sql, conn))
                    {
                        insertCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        public static bool EncryptExists(int empID)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            string decryptSql = "SELECT employeeID FROM passwordEncrypt WHERE employeeID = @empID";
            bool success;
            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(decryptSql, conn))
                {
                    cmd.Parameters.AddWithValue("@empID", empID);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in EncryptExists: {ex.Message}");
                success = false;
            }
            finally
            {
                conn.Close();
            }
            return success;
        }


        public static string EncryptPassword(string password, int empID)
        {
            string encryptedPassword = "";
            byte[] passwordKey, passwordIV;

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                passwordKey = new byte[32];
                rng.GetBytes(passwordKey);
                passwordIV = new byte[16];
                rng.GetBytes(passwordIV);
                empKey = passwordKey;
                empIV = passwordIV;
            }

            using (Aes aesPassword = Aes.Create())
            {
                aesPassword.Key = passwordKey;
                aesPassword.IV = passwordIV;

                ICryptoTransform encryptor = aesPassword.CreateEncryptor(aesPassword.Key, aesPassword.IV);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(passwordBytes, 0, passwordBytes.Length);
                encryptedPassword = Convert.ToBase64String(encryptedBytes);
                if (EncryptExists(empID))
                {
                    string updateSql = "UPDATE passwordEncrypt SET passwordKey = @empKey, passwordIV = @empIV WHERE employeeID = @empID";
                    MySqlParameter[] updateParameters = {
                        new MySqlParameter("@empKey", Convert.ToBase64String(empKey)),
                        new MySqlParameter("@empIV", Convert.ToBase64String(empIV)),
                        new MySqlParameter("@empID", empID)
                    };
                    EmployeeAccessor.AddUpdateEmployee(updateSql, updateParameters);

                    updateSql = "UPDATE employee SET locked = 0 WHERE employeeID = @empID";
                    MySqlParameter[] updateLockedParameters = {
                        new MySqlParameter("@empID", empID)
                    };
                    EmployeeAccessor.AddUpdateEmployee(updateSql, updateLockedParameters);
                }
                else if (empID != -1)
                {
                    string addSql = "INSERT INTO passwordEncrypt (employeeID, passwordKey, passwordIV) VALUES(@empID, @empKey, @empIV)";
                    MySqlParameter[] addParameters = {
                        new MySqlParameter("@empID", empID),
                        new MySqlParameter("@empKey", Convert.ToBase64String(empKey)),
                        new MySqlParameter("@empIV", Convert.ToBase64String(empIV))
                    };
                    EmployeeAccessor.AddUpdateEmployee(addSql, addParameters);

                    string updateSql = "UPDATE employee SET password = @encryptedPassword WHERE employeeID = @empID";
                    MySqlParameter[] updateParameters = {
                        new MySqlParameter("@encryptedPassword", encryptedPassword),
                        new MySqlParameter("@empID", empID)
                    };
                    EmployeeAccessor.AddUpdateEmployee(updateSql, updateParameters);
                }
            }

            return encryptedPassword;
        }

        public static string DecryptPassword(string password, string empKey, string empIV)
        {

            string decryptedPassword = "";
            byte[] key = Convert.FromBase64String(empKey);
            byte[] iv = Convert.FromBase64String(empIV);

            using (Aes aesPassword = Aes.Create())
            {
                aesPassword.Key = key;
                aesPassword.IV = iv;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesPassword.CreateDecryptor(aesPassword.Key, aesPassword.IV);

                // Convert the base64-encoded string back to encrypted bytes.
                byte[] encryptedBytes = Convert.FromBase64String(password);

                // Decrypt the password bytes.
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                // Convert the decrypted bytes back to a string.
                decryptedPassword = Encoding.UTF8.GetString(decryptedBytes);
            }

            return decryptedPassword;
        }

        //verify password meets the password criteria
        public static string VerifyNewPassword(string newPassword, string confirmPassword)
        {
            bool valid = false;
            string errorMsg = "";
            //check if passwords match
            if (newPassword.Equals(confirmPassword))
            {
                //special character regex
                string pattern = @"[!@#$%^&*]";
                Regex passwordRegex = new Regex(pattern);

                //check if at least 8 characters
                if (confirmPassword.Length < 8)
                {
                    errorMsg = "Password must contain at least 8 characters.";
                    valid = false;
                }
                //check if contains a special character
                else if (!passwordRegex.IsMatch(confirmPassword))
                {
                    errorMsg = "Password must contain at least one special character. (!@#$%^&*)";
                    valid = false;
                }
                //check if contains a number
                else if (!Regex.IsMatch(confirmPassword, @"\d"))
                {
                    errorMsg = "Password must contain at least one number.";
                    valid = false;
                }
                //check if contains an uppercase
                else
                {
                    int count = 1;
                    foreach (char c in confirmPassword)
                    {
                        if (char.IsUpper(c))
                        {
                            errorMsg = "";
                            valid = true;
                            break;
                        }
                        else if (count == confirmPassword.Length)
                        {
                            errorMsg = "Password must contain at least one uppercase letter";
                        }
                        count++;
                    }
                }
            }
            //error message if passwords do not match
            else
            {
                errorMsg = "Passwords do not match.";
            }

            //if there is no error, update password


            //return msg
            return errorMsg;
        }

        public static int GetNewID(string sql)
        {
            int newID = -1;

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        newID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return newID + 1;
        }

        //Hides columns that are not needed to display.
        public static void HideDataGridColumn(DataGridView dgv, string columnName, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name.ToLower() == columnName.ToLower())
            {
                dgv.Columns[columnName].Visible = false;
            }
        }

        public static List<T> FilterData<T>(List<T> objects, Control inFilter, DataGridView dataGridView, Func<T, string> searchMethod)
        {
            List<T> searchResults = new List<T>();

            if (!string.IsNullOrEmpty(inFilter.Text) && inFilter is TextBox)
            {
                foreach (T obj in objects)
                {
                    string searchField = searchMethod(obj).ToLower();

                    if (searchField.Contains(inFilter.Text.ToLower()))
                    {
                        searchResults.Add(obj);
                    }
                }
            }
            else if (!inFilter.Text.Contains("All"))
            {
                foreach (T obj in objects)
                {
                    if (searchMethod(obj).ToLower().Contains(inFilter.Text.ToLower()))
                    {
                        searchResults.Add(obj);
                    }

                }
            }
            else
            {
                searchResults.AddRange(objects);
            }

            return searchResults;
        }

        public static void UpdateQuantity(int quantity, int itemID, int siteID)
        {
            string updateInventorySql = @"
                    UPDATE inventory
                    SET
                        quantity = @quantity
                    WHERE
                        itemID = @itemID AND siteID = @siteID";


            MySqlParameter[] parameters = {
                    new MySqlParameter("@quantity", quantity),
                    new MySqlParameter("@itemID", itemID),
                    new MySqlParameter("@siteID", siteID)
                    };

            InventoryAccessor.AddUpdateInventory(updateInventorySql, parameters);
        }

        public static int GetAuditID()
        {
            int? auditID = GetNewID("select max(txnAuditID) from txnAudit");
            if (!auditID.HasValue)
                auditID = 1;
            return auditID.Value;
        }

        public static int GetItemQuantity(string inValue)
        {
            string pattern = @"^(\d+)";
            Match match = Regex.Match(inValue, pattern);
            int qMatch = int.Parse(match.Groups[1].Value);

            return qMatch;
        }
    }
}
