// File:    BookType.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class BookType


using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class BookType
    {
        private int bookTypeId;
        private string bookTypeName;

        public DataSet Listboktype()
        {
            string sql = "SELECT * FROM Book_Type" ;
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet selectbooktype_id(string typeid)
        {
            string sql = "SELECT * FROM Book_Type where book_type_id ="+ typeid;
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
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

        public int BookTypeId { get => bookTypeId; set => bookTypeId = value; }
        public string BookTypeName { get => bookTypeName; set => bookTypeName = value; }

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
                newBooks.BookType = this;
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
                    oldBooks.BookType = null;
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
                    oldBooks.BookType = null;
                tmpBooks.Clear();
            }
        }

    }
}