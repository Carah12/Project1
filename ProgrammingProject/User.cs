using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProgrammingProject
{
    class User
    {
        private int userID;
        private string name;
        private string surname;
        private int age;
        private string rank;
        private string idNumber;
        private string username;
        private string password;
        private bool isAdmin;

        public int UserID { get => userID; set => userID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public string Rank { get => rank; set => rank = value; }
        public string IdNumber { get => idNumber; set => idNumber = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        public User(int userID, string name, string surname, int age, string rank, string idNumber, string username, string password, bool isAdmin)
        {
            this.userID = userID;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.rank = rank;
            this.idNumber = idNumber;
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public User()
        {

        }

        public List<User> PopulateUsers()
        {
            List<User> user = new List<User>();
            DataSet rawData = new DataSet();
            DBAccess dba = new DBAccess();

            rawData = dba.ReadData("btlUser");
            foreach (DataRow item in rawData.Tables["btlUser"].Rows)
            {
                user.Add(new User(int.Parse(item["UserID"].ToString()), item["Name"].ToString(), item["Surname"].ToString(), int.Parse(item["Age"].ToString()), item["Rank"].ToString(), item["IDNumber"].ToString(), item["Username"].ToString(), item["Password"].ToString(), bool.Parse(item["IsAdmin"].ToString())));

            }
            return user;
        }
    }
}
