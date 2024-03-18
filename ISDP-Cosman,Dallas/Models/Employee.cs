using MySql.Data.MySqlClient;
using System.Configuration;

namespace ISDP_Cosman_Dallas.Models
{
    public class Employee
    {

        // Private Fields with Properties
        private int employeeID;
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private bool active;
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        private int siteID;
        public int SiteID
        {
            get { return siteID; }
            set { siteID = value; }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private bool locked;
        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }

        private int positionID;
        public int PositionID
        {
            get { return positionID; }
            set { positionID = value; }
        }

        private int loginAttempts;
        public int LoginAttempts
        {
            get { return loginAttempts; }
            set { loginAttempts = value; }
        }

        private string? notes;
        public string? Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        // Constructor
        public Employee(int employeeID, string password, string firstName, string lastName, string email, bool active, int siteID, string username, bool locked, int positionID, int loginAttempts, string notes)
        {
            EmployeeID = employeeID;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Active = active;
            SiteID = siteID;
            Username = username;
            Locked = locked;
            PositionID = positionID;
            LoginAttempts = loginAttempts;
            Notes = notes;
        }

        public Employee() { }

        // Additional methods or properties can be added as needed

    }

}

