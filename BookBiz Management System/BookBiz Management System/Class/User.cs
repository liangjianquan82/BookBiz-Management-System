// File:    User.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class User

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class User : Persons
    {
        public bool AddUser()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@person_id", PersonId);
            com.Parameters.AddWithValue("@password", password);
            com.Parameters.AddWithValue("@username", username);
           
            com.CommandText = "INSERT INTO [User] " +
           "(person_id,username,password)" +
            " VALUES (@person_id,@username,@password)";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.add(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateUser()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@username", username);
            com.Parameters.AddWithValue("@password", password);           
            com.Parameters.AddWithValue("@person_id", PersonId);
            com.CommandText = " UPDATE [dbo].[User] SET " +
           " username = @username,password = @password where person_id = @person_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool DeleteUser()
        {
            throw new NotImplementedException();
        }
        public DataSet SelectUserbyps_id()
        {
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand();
            
            com.Parameters.AddWithValue("@person_id", PersonId);
            com.CommandText = " select * from [dbo].[User]  " +
           "  where [person_id] = @person_id ";
            Sqlconnect cnn = new Sqlconnect();
            ds = cnn.select(com);
           
            return ds;
        }

        public int SearchUser()
        {
            throw new NotImplementedException();
        }
        public DataSet SearchUser(int person_id)
        {
            string sql = "SELECT *  FROM  [User]  where person_id = " + person_id;
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        private int userId;
        private string password;
        private string username;

        private Persons persons;

        public int UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public Persons Persons { get => persons; set => persons = value; }
    }
}