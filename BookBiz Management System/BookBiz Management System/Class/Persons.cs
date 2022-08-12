// File:    Persons.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class Persons

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class Persons
    {
        public bool Addperson()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@roleid", roleid);
            com.Parameters.AddWithValue("@first_name", firstName);
            com.Parameters.AddWithValue("@last_name", lastName);
            com.Parameters.AddWithValue("@email", email);
            com.Parameters.AddWithValue("@phonenb", phonenb);
            com.CommandText = "INSERT INTO Persons "+
           "(roleid,first_name,last_name,email,phonenb)"+
            " VALUES (@roleid,@first_name,@last_name,@email,@phonenb)";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.add(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
            //select SCOPE_IDENTITY() as id
        }

        /// <summary>
        ///  Return_IDENTITY_ID
        /// </summary>
        /// <returns>IDENTITY_ID</returns>
        public int Addperson_return_IDENTITY_ID()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@roleid", roleid);
            com.Parameters.AddWithValue("@first_name", firstName);
            com.Parameters.AddWithValue("@last_name", lastName);
            com.Parameters.AddWithValue("@email", email);
            com.Parameters.AddWithValue("@phonenb", phonenb);
            com.CommandText = "INSERT INTO Persons " +
           "(roleid,first_name,last_name,email,phonenb)" +
            " VALUES (@roleid,@first_name,@last_name,@email,@phonenb) select SCOPE_IDENTITY() as id";
            Sqlconnect cnn = new Sqlconnect();
            int x = Convert.ToInt32(cnn.select(com).Tables[0].Rows[0]["id"].ToString());
            return x;
            //select SCOPE_IDENTITY() as id
        }

        public bool Updateperson()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@roleid", roleid);
            com.Parameters.AddWithValue("@first_name", firstName);
            com.Parameters.AddWithValue("@last_name", lastName);
            com.Parameters.AddWithValue("@email", email);
            com.Parameters.AddWithValue("@phonenb", phonenb);
            com.Parameters.AddWithValue("@person_id", personId);
            com.CommandText = " UPDATE [dbo].[Persons] SET " +
           " roleid = @roleid,first_name = @first_name,last_name= @last_name,email=@email,phonenb=@phonenb where person_id = @person_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Deleteperson()
        {
            throw new NotImplementedException();
        }

        public bool Removepersonbyid()
        {
            SqlCommand com = new SqlCommand();
           
            com.Parameters.AddWithValue("@person_id", personId);
            com.CommandText = " UPDATE [dbo].[Persons] SET " +
           " state='1' where person_id = @person_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public DataSet ListAllperson()
        {
            string sql = "SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,'view' as bt  FROM  Persons ps  " +
                "inner join role rl on rl.roleid = ps.roleid   where rl.roleid!=1003 and ps.state is null " +
                "order by ps.person_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet ListAllperson(string search)
        {
            string sql = " SELECT pp.* FROM " +
                "(SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,'view' as bt  FROM  Persons ps  " +
                "inner join role rl on rl.roleid = ps.roleid   " +
                " where rl.roleid!=1003 and ps.state is null ) as pp " +
                " where ( first_name like '%" + search + "%' " +
                " or  last_name like '%" + search + "%' " +
                " or  email like '%" + search + "%') " +
                " order by person_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        /// <summary>
        /// select all User(can login in system) 
        /// </summary>
        /// <returns></returns>
        public DataSet ListAllUser()
        {
            string sql = "SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,'view' as bt  FROM  Persons ps  " +
                " inner join role rl on rl.roleid = ps.roleid " +
                " where rl.roleid!=1003 and rl.roleid!=5 and rl.roleid!=1002 and ps.state is null " +
                " order by ps.person_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet ListAllUser(string search)
        {
            string sql = "SELECT pp.* FROM " +
                "(SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,'view' as bt " +
                " FROM  Persons ps  " +
                " inner join role rl on rl.roleid = ps.roleid " +
                " where rl.roleid!=1003 and rl.roleid!=5 and rl.roleid!=1002 and ps.state is null) as pp " +
                 " where ( first_name like '%" + search + "%' " +
                " or  last_name like '%" + search + "%' " +
                " or  email like '%" + search + "%') " +
                " order by person_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        /// <summary>
        /// select all Employee 
        /// </summary>
        /// <returns></returns>
        public DataSet ListAllEmployee()
        {
            string sql = "SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,'view' as bt  FROM  Persons ps  " +
                " inner join role rl on rl.roleid = ps.roleid " +
                " where rl.roleid!=1003 and rl.roleid!=5 and ps.state is null " +
                " order by ps.person_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet ListAllEmployee(string search)
        {
            string sql = " SELECT pp.* FROM " +
                "(SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,'view' as bt  FROM  Persons ps  " +
                "inner join role rl on rl.roleid = ps.roleid   " +
                " where (rl.roleid!=1003 and rl.roleid!=5 and ps.state is null)) as pp " +
                " where ( first_name like '%" + search + "%' " +
                " or  last_name like '%" + search + "%' " +
                " or  email like '%" + search + "%') " +
                " order by person_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        /// <summary>
        /// select by person_id
        /// </summary>
        /// <param name="person_id">person_id</param>
        /// <returns></returns>
        public DataSet Listpersonbyperson_id(int person_id)
        {
            string sql = "SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,rl.roleid  FROM  Persons ps  inner join role rl on rl.roleid = ps.roleid  where person_id = " + person_id;
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        /// <summary>
        ///  Select roles queries
        /// </summary>
        /// <param name="roleid"></param>
        /// <returns></returns>
        public DataSet Listperson(string roleid)
        {
            string sql = "SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,rl.roleid,'view' as bt  FROM  Persons ps  inner join role rl on rl.roleid = ps.roleid  where rl.roleid = '" + roleid + "' and ps.state is null ";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        /// <summary>
        /// fuzzy field queries
        /// </summary>
        /// <param name="search">search field</param>
        /// <returns></returns>
        public DataSet Listpersonsearch(string search)
        {
            string sql = "SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,rl.roleid,'view' as bt  " +
                " FROM  Persons ps  " +
                "inner join role rl on rl.roleid = ps.roleid  " +
                "where rl.roleid!=1003 and ps.state is null and ( ps.first_name like '%" + search + "%' " +
                "or  ps.last_name like '%" + search + "%' " +
                "or  ps.email like '%" + search + "%')";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        /// <summary>
        /// Select roles and search field queries
        /// </summary>
        /// <param name="search">search field</param>
        /// <param name="roleid">roleID</param>
        /// <returns></returns>
        public DataSet Listpersonsearch(string search, string roleid)
        {
            string sql = "SELECT ps.first_name,ps.last_name,rl.rolename,ps.phonenb,ps.email,ps.person_id,rl.roleid,'view' as bt  " +
                "FROM  Persons ps  inner join role rl on rl.roleid = ps.roleid  " +
                "where rl.roleid = '" + roleid + "' and ps.state is null " +
                "and (ps.first_name like '%" + search + "%' " +
                "or  ps.last_name like '%" + search + "%' " +
                "or  ps.email like '%" + search + "%' )";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        private int personId;
        private string firstName;
        private string lastName;
        private string email;
        private string phonenb;
        private int roleid;

        public System.Collections.Generic.List<OrderTable> orderTable;

        /// <summary>
        /// Property for collection of OrderTable
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<OrderTable> OrderTable
        {
            get
            {
                if (orderTable == null)
                    orderTable = new System.Collections.Generic.List<OrderTable>();
                return orderTable;
            }
            set
            {
                RemoveAllOrderTable();
                if (value != null)
                {
                    foreach (OrderTable oOrderTable in value)
                        AddOrderTable(oOrderTable);
                }
            }
        }

        /// <summary>
        /// Add a new OrderTable in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddOrderTable(OrderTable newOrderTable)
        {
            if (newOrderTable == null)
                return;
            if (this.orderTable == null)
                this.orderTable = new System.Collections.Generic.List<OrderTable>();
            if (!this.orderTable.Contains(newOrderTable))
            {
                this.orderTable.Add(newOrderTable);
                newOrderTable.Persons = this;
            }
        }

        /// <summary>
        /// Remove an existing OrderTable from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveOrderTable(OrderTable oldOrderTable)
        {
            if (oldOrderTable == null)
                return;
            if (this.orderTable != null)
                if (this.orderTable.Contains(oldOrderTable))
                {
                    this.orderTable.Remove(oldOrderTable);
                    oldOrderTable.Persons = null;
                }
        }

        /// <summary>
        /// Remove all instances of OrderTable from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllOrderTable()
        {
            if (orderTable != null)
            {
                System.Collections.ArrayList tmpOrderTable = new System.Collections.ArrayList();
                foreach (OrderTable oldOrderTable in orderTable)
                    tmpOrderTable.Add(oldOrderTable);
                orderTable.Clear();
                foreach (OrderTable oldOrderTable in tmpOrderTable)
                    oldOrderTable.Persons = null;
                tmpOrderTable.Clear();
            }
        }
        public System.Collections.Generic.List<BookAuthor> bookAuthor;

        /// <summary>
        /// Property for collection of BookAuthor
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<BookAuthor> BookAuthor
        {
            get
            {
                if (bookAuthor == null)
                    bookAuthor = new System.Collections.Generic.List<BookAuthor>();
                return bookAuthor;
            }
            set
            {
                RemoveAllBookAuthor();
                if (value != null)
                {
                    foreach (BookAuthor oBookAuthor in value)
                        AddBookAuthor(oBookAuthor);
                }
            }
        }

        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phonenb { get => phonenb; set => phonenb = value; }
        public int Roleid { get => roleid; set => roleid = value; }

        /// <summary>
        /// Add a new BookAuthor in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddBookAuthor(BookAuthor newBookAuthor)
        {
            if (newBookAuthor == null)
                return;
            if (this.bookAuthor == null)
                this.bookAuthor = new System.Collections.Generic.List<BookAuthor>();
            if (!this.bookAuthor.Contains(newBookAuthor))
            {
                this.bookAuthor.Add(newBookAuthor);
                newBookAuthor.Persons = this;
            }
        }

        /// <summary>
        /// Remove an existing BookAuthor from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveBookAuthor(BookAuthor oldBookAuthor)
        {
            if (oldBookAuthor == null)
                return;
            if (this.bookAuthor != null)
                if (this.bookAuthor.Contains(oldBookAuthor))
                {
                    this.bookAuthor.Remove(oldBookAuthor);
                    oldBookAuthor.Persons = null;
                }
        }

        /// <summary>
        /// Remove all instances of BookAuthor from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllBookAuthor()
        {
            if (bookAuthor != null)
            {
                System.Collections.ArrayList tmpBookAuthor = new System.Collections.ArrayList();
                foreach (BookAuthor oldBookAuthor in bookAuthor)
                    tmpBookAuthor.Add(oldBookAuthor);
                bookAuthor.Clear();
                foreach (BookAuthor oldBookAuthor in tmpBookAuthor)
                    oldBookAuthor.Persons = null;
                tmpBookAuthor.Clear();
            }
        }
        public User[] user;
        public Authors[] authors;

    }
}