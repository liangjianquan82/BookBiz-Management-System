// File:    BookAuthor.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class BookAuthor

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class BookAuthor
    {
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
                        oldBooks.RemoveBookAuthor(this);
                    }
                    if (value != null)
                    {
                        this.books = value;
                        this.books.AddBookAuthor(this);
                    }
                }
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
                        oldPersons.RemoveBookAuthor(this);
                    }
                    if (value != null)
                    {
                        this.persons = value;
                        this.persons.AddBookAuthor(this);
                    }
                }
            }
        }
        public Authors authors;

        /// <summary>
        /// Property for Persons
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Authors Authors
        {
            get
            {
                return authors;
            }
            set
            {
                if (this.authors == null || !this.persons.Equals(value))
                {
                    if (this.authors != null)
                    {
                        Authors oldAuthors = this.authors;
                        this.authors = null;
                        oldAuthors.RemoveBookAuthor(this);
                    }
                    if (value != null)
                    {
                        this.authors = value;
                        this.authors.AddBookAuthor(this);
                    }
                }
            }
        }

        public int BookId1 { get => BookId; set => BookId = value; }
        public string AuthorId1 { get => AuthorId; set => AuthorId = value; }

        private int BookId;
        private string AuthorId;

        public bool addboook_author()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@BookId", BookId1);
            com.Parameters.AddWithValue("@AuthorId", AuthorId1);           
            com.CommandText = "INSERT INTO  book_author " +
           "(book_id, person_id)" +
            " VALUES (@BookId, (select person_id from authors where author_ID = @AuthorId))";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.add(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
            
        }
        public DataSet list_book_author(int book_id )
        {
            string sql = "SELECT ah.author_ID  from book_author ba" +
                " inner join authors ah on ah.person_id =  ba.person_id where  ba.book_id = " + book_id;
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public bool removebybookid(int book_id)
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@BookId", book_id);
            com.CommandText = "DELETE FROM Book_Author where  book_id = @BookId ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.delete(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

    }
}