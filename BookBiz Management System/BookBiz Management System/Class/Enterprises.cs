// File:    Enterprises.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class Enterprises

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public abstract class Enterprises
    {
       
        public bool Addenterprise()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@enterprise_type_id", EnterprisetypeId);
            com.Parameters.AddWithValue("@name", Name);
            com.Parameters.AddWithValue("@street", Street);
            com.Parameters.AddWithValue("@city", city);
            com.Parameters.AddWithValue("@zip_code", ZipCode);
            com.Parameters.AddWithValue("@enterprise_email", EnterpriseEmail);
            com.Parameters.AddWithValue("@enterprise_phone", EnterprisePhone);
            com.Parameters.AddWithValue("@enterprise_fax", EnterpriseFax);
            com.Parameters.AddWithValue("@credit_limit", CreditLimit);
            com.CommandText = "INSERT INTO Enterprises " +
           "(enterprise_type_id,name,street,city,zip_code,enterprise_email,enterprise_phone,enterprise_fax,credit_limit)" +
            " VALUES " +
            "(@enterprise_type_id,@name,@street,@city,@zip_code,@enterprise_email," +
            "@enterprise_phone,@enterprise_fax,@credit_limit)";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.add(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Updateenterprise()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@enterprise_type_id", EnterprisetypeId);
            com.Parameters.AddWithValue("@name", Name);
            com.Parameters.AddWithValue("@street", Street);
            com.Parameters.AddWithValue("@city", city);
            com.Parameters.AddWithValue("@zip_code", ZipCode);
            com.Parameters.AddWithValue("@enterprise_email", EnterpriseEmail);
            com.Parameters.AddWithValue("@enterprise_phone", EnterprisePhone);
            com.Parameters.AddWithValue("@enterprise_fax", EnterpriseFax);
            com.Parameters.AddWithValue("@credit_limit", CreditLimit);
            com.Parameters.AddWithValue("@enterprise_id", EnterpriseId);
            com.CommandText = " UPDATE [dbo].[Enterprises] SET " +
           " enterprise_type_id = @enterprise_type_id," +
           " name = @name," +
           " street= @street," +
           " city=@city," +
           " zip_code=@zip_code, " +
           " enterprise_email=@enterprise_email, " +
           " enterprise_phone=@enterprise_phone, " +
           " enterprise_fax=@enterprise_fax, " +
           " credit_limit=@credit_limit " +
           "where enterprise_id = @enterprise_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Updateenterprise_CreditLimit()
        {
            SqlCommand com = new SqlCommand();
           
            com.Parameters.AddWithValue("@credit_limit", CreditLimit);
            com.Parameters.AddWithValue("@enterprise_id", EnterpriseId);
            com.CommandText = " UPDATE [dbo].[Enterprises] SET " +          
           " credit_limit=@credit_limit " +
           "where enterprise_id = @enterprise_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Deletenterprise()
        {
            SqlCommand com = new SqlCommand();
           
            com.Parameters.AddWithValue("@enterprise_id", EnterpriseId);
            com.CommandText = " UPDATE [dbo].[Enterprises] SET " +          
           " state='1' " +
           " where enterprise_id = @enterprise_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public DataSet selectenterprisebyid(int enterprise_id)
        {
            string sql = "SELECT *  FROM  Enterprises  " +
                " where  enterprise_id = " + enterprise_id + " ";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        private int enterpriseId;
        private string name;
        private string street;
        private string city;
        private string zipCode;
        private string enterpriseEmail;
        private string enterprisePhone;
        private string enterpriseFax;
        private decimal creditLimit;
        private int enterprisetypeId;

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
                newOrderTable.Enterprises = this;
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
                    oldOrderTable.Enterprises = null;
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
                    oldOrderTable.Enterprises = null;
                tmpOrderTable.Clear();
            }
        }
        public System.Collections.Generic.List<Books> books;

        /// <summary>
        /// Property for collection of Books
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Books> Books
        {
            get
            {
                if (books == null)
                    books = new System.Collections.Generic.List<Books>();
                return books;
            }
            set
            {
                RemoveAllBooks();
                if (value != null)
                {
                    foreach (Books oBooks in value)
                        AddBooks(oBooks);
                }
            }
        }

        /// <summary>
        /// Add a new Books in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddBooks(Books newBooks)
        {
            if (newBooks == null)
                return;
            if (this.books == null)
                this.books = new System.Collections.Generic.List<Books>();
            if (!this.books.Contains(newBooks))
            {
                this.books.Add(newBooks);
                newBooks.Enterprises = this;
            }
        }

        /// <summary>
        /// Remove an existing Books from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveBooks(Books oldBooks)
        {
            if (oldBooks == null)
                return;
            if (this.books != null)
                if (this.books.Contains(oldBooks))
                {
                    this.books.Remove(oldBooks);
                    oldBooks.Enterprises = null;
                }
        }

        /// <summary>
        /// Remove all instances of Books from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllBooks()
        {
            if (books != null)
            {
                System.Collections.ArrayList tmpBooks = new System.Collections.ArrayList();
                foreach (Books oldBooks in books)
                    tmpBooks.Add(oldBooks);
                books.Clear();
                foreach (Books oldBooks in tmpBooks)
                    oldBooks.Enterprises = null;
                tmpBooks.Clear();
            }
        }
        public EnterpriseType enterpriseType;

        /// <summary>
        /// Property for EnterpriseType
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public EnterpriseType EnterpriseType
        {
            get
            {
                return enterpriseType;
            }
            set
            {
                if (this.enterpriseType == null || !this.enterpriseType.Equals(value))
                {
                    if (this.enterpriseType != null)
                    {
                        EnterpriseType oldEnterpriseType = this.enterpriseType;
                        this.enterpriseType = null;
                        oldEnterpriseType.RemoveEnterprises(this);
                    }
                    if (value != null)
                    {
                        this.enterpriseType = value;
                        this.enterpriseType.AddEnterprises(this);
                    }
                }
            }
        }

        public int EnterpriseId { get => enterpriseId; set => enterpriseId = value; }
        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string EnterpriseEmail { get => enterpriseEmail; set => enterpriseEmail = value; }
        public string EnterprisePhone { get => enterprisePhone; set => enterprisePhone = value; }
        public string EnterpriseFax { get => enterpriseFax; set => enterpriseFax = value; }
        public decimal CreditLimit { get => creditLimit; set => creditLimit = value; }
        public int EnterprisetypeId { get => enterprisetypeId; set => enterprisetypeId = value; }
    }
}