// File:    OrderBook.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class OrderBook

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class OrderBook
    {
        private int orderBookId;
        private int quantity;
        private int order_id;
        private int book_id;

        public bool delectbyOrderBookId()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@order_book_id", OrderBookId);
            com.CommandText = "DELETE FROM order_book where  order_book_id = @order_book_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.delete(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool updatequ()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@order_book_id", OrderBookId);
            com.Parameters.AddWithValue("@quantity", Quantity);
            com.CommandText = "update order_book set quantity = @quantity   " +
                "where  order_book_id = @order_book_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }
        public DataSet listSelectedbooks()
        {
            string sql = "SELECT bk.book_id,bk.ISBN,bk.Title,bk.UnitPrice,bk.QOH,ob.quantity,'delete' as btdelet " +
                " FROM dbo.Books bk inner join order_book ob on ob.book_id = bk.book_id " +
                " order by bk.book_id desc";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public DataSet listSelectedbooksbyorderid(int order_id)
        {
            string sql = "SELECT bk.book_id,bk.Title,bk.UnitPrice,bk.QOH,ob.quantity,'delete' as btdelet , ob.order_book_id " +
                " FROM dbo.Books bk inner join order_book ob on ob.book_id = bk.book_id where ob.order_id=" + order_id ;
          
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public bool addbooktoorder()
        {
            SqlCommand com = new SqlCommand();
            //com.Parameters.AddWithValue("@OrderBookId", OrderBookId);
            com.Parameters.AddWithValue("@Order_id", Order_id);
            com.Parameters.AddWithValue("@Quantity", Quantity);
            com.Parameters.AddWithValue("@Book_id", Book_id);
            com.CommandText = "INSERT INTO order_book " +
           "(Order_id,Quantity,Book_id)" +
            " VALUES " +
            "(@Order_id,@Quantity,@Book_id)";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.add(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }


        public OrderTable orderTable;

        /// <summary>
        /// Property for OrderTable
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public OrderTable OrderTable
        {
            get
            {
                return orderTable;
            }
            set
            {
                if (this.orderTable == null || !this.orderTable.Equals(value))
                {
                    if (this.orderTable != null)
                    {
                        OrderTable oldOrderTable = this.orderTable;
                        this.orderTable = null;
                        oldOrderTable.RemoveOrderBook(this);
                    }
                    if (value != null)
                    {
                        this.orderTable = value;
                        this.orderTable.AddOrderBook(this);
                    }
                }
            }
        }
        public Books books;

        /// <summary>
        /// Property for Books
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Books Books
        {
            get
            {
                return books;
            }
            set
            {
                if (this.books == null || !this.books.Equals(value))
                {
                    if (this.books != null)
                    {
                        Books oldBooks = this.books;
                        this.books = null;
                        oldBooks.RemoveOrderBook(this);
                    }
                    if (value != null)
                    {
                        this.books = value;
                        this.books.AddOrderBook(this);
                    }
                }
            }
        }

        public int OrderBookId { get => orderBookId; set => orderBookId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Order_id { get => order_id; set => order_id = value; }
        public int Book_id { get => book_id; set => book_id = value; }
    }
}