// File:    OrderTable.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class OrderTable

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class OrderTable
    {
        public bool AddOrderBook()
        {
            throw new NotImplementedException();
        }
        public int Addorderreturn_orderid()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@Person_id", Person_id);
            com.Parameters.AddWithValue("@Order_type_id", Order_type_id);
            //com.Parameters.AddWithValue("@OrderTime", OrderTime);

            com.Parameters.AddWithValue("@Totalprice", Totalprice);
            com.Parameters.AddWithValue("@OrderTime", OrderTime);
            com.Parameters.AddWithValue("@OrderSerialNumber", OrderSerialNumber);
            com.Parameters.AddWithValue("@Enterprise_id", Enterprise_id);
            com.CommandText = "INSERT INTO [dbo].[Order_table]  " +
                " ([person_id],[enterprise_id],[order_type_id] ,[totalprice]  ,[order_serial_number])" +
                " VALUES           " +
                " (@Person_id,@Enterprise_id ,@Order_type_id,@Totalprice,@OrderSerialNumber) select SCOPE_IDENTITY() as id";
            Sqlconnect cnn = new Sqlconnect();
            int x = Convert.ToInt32(cnn.select(com).Tables[0].Rows[0]["id"].ToString());
            return x;
        }

        public bool Updateorder()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@OrderId", OrderId);
            com.Parameters.AddWithValue("@State_order", State_order);
            com.Parameters.AddWithValue("@enterprise_id", Enterprise_id);

            com.CommandText = " UPDATE [dbo].[Order_table] SET " +
           " state_order = @State_order,enterprise_id =@enterprise_id   " +
           " where order_id = @OrderId ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }
        public bool Updateorder_complete_order()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@OrderId", OrderId);
            com.Parameters.AddWithValue("@State_order", State_order);
            com.Parameters.AddWithValue("@Totalprice", Totalprice);
            com.Parameters.AddWithValue("@enterprise_id", Enterprise_id);
            com.CommandText = " UPDATE [dbo].[Order_table] SET " +
           " state_order = @State_order,totalprice =@Totalprice,enterprise_id =@enterprise_id   " +
           " where order_id = @OrderId ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Deleteorder()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@order_serial_number", OrderSerialNumber);
            com.CommandText = "DELETE FROM Order_table where  order_serial_number = @order_serial_number ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.delete(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public Array Searchorder()
        {
            throw new NotImplementedException();
        }
        public DataSet Listorderbyorder_serial_number(string order_serial_number)
        {
            string sql = "SELECT ot.*,ep.name,ep.credit_limit  FROM  Order_table ot " +
                " inner join Enterprises ep on ep.enterprise_id = ot.enterprise_id  " +
                " where ot.order_serial_number = '" + order_serial_number + "'";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public Array Listorder()
        {
            throw new NotImplementedException();
        }
        public DataSet Listorder1()
        {
            String psid =  LoginInfo.CurrentUser.Person_id1;
            string sql = "SELECT ot.order_id " +
            ",ot.person_id " +
            ",ot.enterprise_id " +
            ",ot.totalprice " +
            ",ot.order_time " +
            ",ot.order_serial_number " +
            ",ot.state_order " +
            ",ep.name " +
            ",(ps.first_name + ' ' + ps.last_name) as first_name " +
            ", 'view' as bt " +
            "FROM Order_table ot  " +
            "inner join Enterprises ep on ep.enterprise_id = ot.enterprise_id " +
            "inner join Persons ps on ps.person_id = ot.person_id " +
            "where state_order = 1 and ps.person_id = '"+ psid + "'";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet Listorder2(string state)
        {
            String psid = LoginInfo.CurrentUser.Person_id1;
            string sql = "SELECT ot.order_id " +
            ",ot.person_id " +
            ",ot.enterprise_id " +
            ",ot.totalprice " +
            ",ot.order_time " +
            ",ot.order_serial_number " +
            ",ot.state_order " +
            ",ep.name " +
            ",(ps.first_name + ' ' + ps.last_name) as first_name " +
            ", 'view' as bt " +
            "FROM Order_table ot  " +
            "inner join Enterprises ep on ep.enterprise_id = ot.enterprise_id " +
            "inner join Persons ps on ps.person_id = ot.person_id " +
            "where state_order = " + state + " and ps.person_id = '" + psid + "' ";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet Listorder1(string search)
        {
            String psid = LoginInfo.CurrentUser.Person_id1;
            string sql = "SELECT ot.order_id " +
            ",ot.person_id " +
            ",ot.enterprise_id " +
            ",ot.totalprice " +
            ",ot.order_time " +
            ",ot.order_serial_number " +
            ",ot.state_order " +
            ",ep.name " +
            ",(ps.first_name + ' ' + ps.last_name) as first_name " +
            ", 'view' as bt " +
            "FROM Order_table ot  " +
            "inner join Enterprises ep on ep.enterprise_id = ot.enterprise_id " +
            "inner join Persons ps on ps.person_id = ot.person_id " +
            "where state_order = 1 and ep.name like '%"+ search+ "%' and ps.person_id = '" + psid + "'";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet Listorder1(string search,string state)
        {
            String psid = LoginInfo.CurrentUser.Person_id1;
            string sql = "SELECT ot.order_id " +
            ",ot.person_id " +
            ",ot.enterprise_id " +
            ",ot.totalprice " +
            ",ot.order_time " +
            ",ot.order_serial_number " +
            ",ot.state_order " +
            ",ep.name " +
            ",(ps.first_name + ' ' + ps.last_name) as first_name " +
            ", 'view' as bt " +
            "FROM Order_table ot  " +
            "inner join Enterprises ep on ep.enterprise_id = ot.enterprise_id " +
            "inner join Persons ps on ps.person_id = ot.person_id " +
            "where state_order = "+ state + " and ep.name like '%" + search + "%' and ps.person_id = '" + psid + "'";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        private int orderId;
        private decimal totalprice;
        private DateTime orderTime;
        private string orderSerialNumber;
        private int person_id;
        private int enterprise_id;
        private int order_type_id;
        private int state_order;


        public System.Collections.Generic.List<OrderBook> orderBook;

        /// <summary>
        /// Property for collection of OrderBook
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<OrderBook> OrderBook
        {
            get
            {
                if (orderBook == null)
                    orderBook = new System.Collections.Generic.List<OrderBook>();
                return orderBook;
            }
            set
            {
                RemoveAllOrderBook();
                if (value != null)
                {
                    foreach (OrderBook oOrderBook in value)
                        AddOrderBook(oOrderBook);
                }
            }
        }

        /// <summary>
        /// Add a new OrderBook in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddOrderBook(OrderBook newOrderBook)
        {
            if (newOrderBook == null)
                return;
            if (this.orderBook == null)
                this.orderBook = new System.Collections.Generic.List<OrderBook>();
            if (!this.orderBook.Contains(newOrderBook))
            {
                this.orderBook.Add(newOrderBook);
                newOrderBook.OrderTable = this;
            }
        }

        /// <summary>
        /// Remove an existing OrderBook from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveOrderBook(OrderBook oldOrderBook)
        {
            if (oldOrderBook == null)
                return;
            if (this.orderBook != null)
                if (this.orderBook.Contains(oldOrderBook))
                {
                    this.orderBook.Remove(oldOrderBook);
                    oldOrderBook.OrderTable = null;
                }
        }

        /// <summary>
        /// Remove all instances of OrderBook from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllOrderBook()
        {
            if (orderBook != null)
            {
                System.Collections.ArrayList tmpOrderBook = new System.Collections.ArrayList();
                foreach (OrderBook oldOrderBook in orderBook)
                    tmpOrderBook.Add(oldOrderBook);
                orderBook.Clear();
                foreach (OrderBook oldOrderBook in tmpOrderBook)
                    oldOrderBook.OrderTable = null;
                tmpOrderBook.Clear();
            }
        }
        public Persons persons;

        /// <summary>
        /// Property for Persons
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Persons Persons
        {
            get
            {
                return persons;
            }
            set
            {
                if (this.persons == null || !this.persons.Equals(value))
                {
                    if (this.persons != null)
                    {
                        Persons oldPersons = this.persons;
                        this.persons = null;
                        oldPersons.RemoveOrderTable(this);
                    }
                    if (value != null)
                    {
                        this.persons = value;
                        this.persons.AddOrderTable(this);
                    }
                }
            }
        }
        public Enterprises enterprises;

        /// <summary>
        /// Property for Enterprises
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Enterprises Enterprises
        {
            get
            {
                return enterprises;
            }
            set
            {
                if (this.enterprises == null || !this.enterprises.Equals(value))
                {
                    if (this.enterprises != null)
                    {
                        Enterprises oldEnterprises = this.enterprises;
                        this.enterprises = null;
                        oldEnterprises.RemoveOrderTable(this);
                    }
                    if (value != null)
                    {
                        this.enterprises = value;
                        this.enterprises.AddOrderTable(this);
                    }
                }
            }
        }
        public OrderType orderType;

        /// <summary>
        /// Property for OrderType
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public OrderType OrderType
        {
            get
            {
                return orderType;
            }
            set
            {
                if (this.orderType == null || !this.orderType.Equals(value))
                {
                    if (this.orderType != null)
                    {
                        OrderType oldOrderType = this.orderType;
                        this.orderType = null;
                        oldOrderType.RemoveOrderTable(this);
                    }
                    if (value != null)
                    {
                        this.orderType = value;
                        this.orderType.AddOrderTable(this);
                    }
                }
            }
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public decimal Totalprice { get => totalprice; set => totalprice = value; }
        public DateTime OrderTime { get => orderTime; set => orderTime = value; }
        public string OrderSerialNumber { get => orderSerialNumber; set => orderSerialNumber = value; }
        public int Person_id { get => person_id; set => person_id = value; }
        public int Enterprise_id { get => enterprise_id; set => enterprise_id = value; }
        public int Order_type_id { get => order_type_id; set => order_type_id = value; }
        public int State_order { get => state_order; set => state_order = value; }
    }
}