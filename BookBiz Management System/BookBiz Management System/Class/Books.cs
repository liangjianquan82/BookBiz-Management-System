// File:    Books.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class Books

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class Books
    {
        public bool Addbook()
        {
            throw new NotImplementedException();
        }
        public int Addbook_return_IDENTITY_ID()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@Title", Title);
            com.Parameters.AddWithValue("@Isbn", Isbn);
            com.Parameters.AddWithValue("@YearPublished", YearPublished);
            com.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            com.Parameters.AddWithValue("@Qoh", Qoh);
            com.Parameters.AddWithValue("@EnterpriseId", EnterpriseId1);
            com.Parameters.AddWithValue("@BookTypeId", BookTypeId1);
            com.CommandText = "INSERT INTO [Books] " +
           "(book_type_id,enterprise_id,ISBN,Title,UnitPrice,YearPublished,QOH)" +
            " VALUES " +
            "(@BookTypeId,@EnterpriseId,@Isbn,@Title,@UnitPrice,@YearPublished,@Qoh) select SCOPE_IDENTITY() as id";
            Sqlconnect cnn = new Sqlconnect();
            int x = Convert.ToInt32(cnn.select(com).Tables[0].Rows[0]["id"].ToString());
            return x;
        }

        public bool Updatebook()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@Title", Title);
            com.Parameters.AddWithValue("@Isbn", Isbn);
            com.Parameters.AddWithValue("@YearPublished", YearPublished);
            com.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            com.Parameters.AddWithValue("@Qoh", Qoh);
            com.Parameters.AddWithValue("@EnterpriseId", EnterpriseId1);
            com.Parameters.AddWithValue("@BookTypeId", BookTypeId1);
            com.Parameters.AddWithValue("@book_id", BookId);
            com.CommandText = " UPDATE [dbo].[Books] SET " +
           "Title = @Title," +
           "ISBN = @Isbn ," +
           "UnitPrice = @UnitPrice ," +
           "YearPublished = @YearPublished ," +
           "book_type_id = @BookTypeId ," +
           "enterprise_id = @EnterpriseId ," +
           "QOH = @Qoh " +
           " where book_id = @book_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }
        public bool Updatebook_QOH()
        {
            SqlCommand com = new SqlCommand();
            
            com.Parameters.AddWithValue("@Qoh", Qoh);           
            com.Parameters.AddWithValue("@book_id", BookId);
            com.CommandText = " UPDATE [dbo].[Books] SET " +          
           "QOH = @Qoh " +
           " where book_id = @book_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Deletbook()
        {
            throw new NotImplementedException();
        }

        public DataSet listbooks()
        {
            string sql = "SELECT bk.book_id,bk.book_type_id,bk.enterprise_id,bk.ISBN,bk.Title,bk.UnitPrice,bk.YearPublished,bk.QOH,bkt.book_type_name,'view' as bt " +
                " FROM dbo.Books bk  " +
                " inner join dbo.Book_Type bkt on bk.book_type_id = bkt.book_type_id  " +
                " order by bk.book_type_id desc";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public DataSet listbooks1()
        {
            string sql = "SELECT bk.book_id,bk.ISBN,bk.Title,bk.UnitPrice,bk.QOH,'add' as bt " +
                " FROM dbo.Books bk  " +
                " order by bk.book_id desc";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public DataSet Listbook_typeid_serach(string Book_Type_id, string search)
        {
            string sql = "SELECT bs.*,bkt.*,'view' as bt   " +
                "from Books bs " +
                "inner join book_type bkt on bs.book_type_id = bkt.book_type_id " +
                "where bs.book_type_id = " + Book_Type_id + " and bs.Title like '%" + search + "%' order by bs.book_type_id desc";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet Listbook_typeid_serach1(string Book_Type_id, string search)
        {
            string sql = "SELECT bs.*,bkt.*,'add' as bt   " +
                "from Books bs " +
                "inner join book_type bkt on bs.book_type_id = bkt.book_type_id " +
                "where bs.book_type_id = " + Book_Type_id + " and bs.Title like '%" + search + "%' order by bs.book_type_id desc";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet Listbook_typeid(string Book_Type_id)
        {
            string sql = "SELECT bs.* ,bkt.*,'view' as bt  " +
                "from Books bs " +
                "inner join book_type bkt on bs.book_type_id = bkt.book_type_id " +
                "where bs.book_type_id = " + Book_Type_id + " order by bs.book_type_id desc ";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet Listbook_typeid1(string Book_Type_id)
        {
            string sql = "SELECT bs.* ,bkt.*,'add' as bt  " +
                "from Books bs " +
                "inner join book_type bkt on bs.book_type_id = bkt.book_type_id " +
                "where bs.book_type_id = " + Book_Type_id + " order by bs.book_type_id desc ";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet Listbook_serach(string search)
        {
            string sql = " select bs.* ,bkt.*,'view' as bt " +
                " from Books bs " +
                " inner join book_type bkt on bs.book_type_id = bkt.book_type_id " +
                " where  bs.Title like '%" + search + "%' order by bs.book_type_id desc ";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet Listbook_serach1(string search)
        {
            string sql = " select bs.* ,bkt.*,'add' as bt " +
                "from Books bs " +
                "inner join book_type bkt on bs.book_type_id = bkt.book_type_id " +
                "where  bs.Title like '%" + search + "%' order by bs.book_type_id desc ";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet Listbook_bybookid(int book_id)
        {
            string sql = "SELECT *  from Books  where  book_id = "+book_id;
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        private int bookId;
        private string isbn;
        private string title;
        private decimal unitPrice;
        private DateTime yearPublished;
        private int qoh;
        private int EnterpriseId;
        private int BookTypeId;

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
                newOrderBook.Books = this;
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
                    oldOrderBook.Books = null;
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
                    oldOrderBook.Books = null;
                tmpOrderBook.Clear();
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
                newBookAuthor.Books = this;
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
                    oldBookAuthor.Books = null;
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
                    oldBookAuthor.Books = null;
                tmpBookAuthor.Clear();
            }
        }
        public BookType bookType;

        /// <summary>
        /// Property for BookType
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public BookType BookType
        {
            get
            {
                return bookType;
            }
            set
            {
                if (this.bookType == null || !this.bookType.Equals(value))
                {
                    if (this.bookType != null)
                    {
                        BookType oldBookType = this.bookType;
                        this.bookType = null;
                        oldBookType.RemoveBooks(this);
                    }
                    if (value != null)
                    {
                        this.bookType = value;
                        this.bookType.AddBooks(this);
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
                        oldEnterprises.RemoveBooks(this);
                    }
                    if (value != null)
                    {
                        this.enterprises = value;
                        this.enterprises.AddBooks(this);
                    }
                }
            }
        }

        public int BookId { get => bookId; set => bookId = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public decimal UnitPrice { get => unitPrice; set => unitPrice = value; }
        public DateTime YearPublished { get => yearPublished; set => yearPublished = value; }
        public int Qoh { get => qoh; set => qoh = value; }
        public int EnterpriseId1 { get => EnterpriseId; set => EnterpriseId = value; }
        public int BookTypeId1 { get => BookTypeId; set => BookTypeId = value; }
    }
}