// File:    Authors.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class Authors

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class Authors:Persons
    {
        public bool AddAuthors()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@person_id", PersonId);
            com.Parameters.AddWithValue("@author_ID", AuthorId);          

            com.CommandText = "INSERT INTO Authors " +
           "(person_id,author_ID)" +
            " VALUES (@person_id,@author_ID)";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.add(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateAuthors()
        {
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@person_id", PersonId);
            com.Parameters.AddWithValue("@author_ID", AuthorId);
            com.CommandText = " UPDATE Authors SET " +
           " author_ID = @author_ID  where person_id = @person_id ";
            Sqlconnect cnn = new Sqlconnect();
            int x = cnn.update(com);
            if (x > 0)
            {
                return true;
            }
            else return false;
        }

        public bool DeleteAuthors()
        {
            throw new NotImplementedException();
        }

        public Array SearchAuthor()
        {
            throw new NotImplementedException();
        }
        
        private int authorid;
        private string authorId;

        private Persons persons;

        public Authors()
        {

        }
        public Authors(int authorid, string authorId, Persons persons)
        {
            this.authorid = authorid;
            this.authorId = authorId;
            this.persons = persons;
        }

        public DataSet ListAllAuthors()
        {
            string sql = "SELECT ah.authorid, ah.person_id,ah.author_ID,ps.*,rl.rolename,'view' as bt " +
                " FROM Authors ah  " +
                " inner join Persons ps on ps.person_id = ah.person_id " +
                " inner join role rl on rl.roleid = ps.roleid" +
                " where ps.state is null  " +
                "order by ah.authorid desc";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public DataSet LisAuthors_for_selecttobook()
        {
            string sql = "SELECT ah.authorid, ah.person_id,ah.author_ID,ps.*,'add' as bt " +
                " FROM Authors ah  " +
                " inner join Persons ps on ps.person_id = ah.person_id " +               
                " where ps.state is null  " +
                "order by ps.person_id desc";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public DataSet SearchcAuthors(string search)
        {
            string sql = "SELECT ah.authorid, ah.person_id,ah.author_ID,ps.*,rl.rolename,'view' as bt " +
                " FROM Authors ah  " +
                " inner join Persons ps on ps.person_id = ah.person_id " +
                " inner join role rl on rl.roleid = ps.roleid" +
                " where ps.state is null " +
                " and (ps.first_name like '%" + search + "%' " +
                " or  ps.last_name like '%" + search + "%' " +
                " order by ah.authorid desc";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public DataSet Listauthorbyperson_id(int person_id)
        {
            string sql = "SELECT ps.first_name,ps.last_name,ps.phonenb,ps.email,ps.person_id,ps.roleid,ah.*  FROM  Persons ps  " +
                "inner join Authors ah on ah.person_id = ps.person_id" +
                " where ah.person_id = " + person_id;
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public int Authorid { get => authorid; set => authorid = value; }
        public string AuthorId { get => authorId; set => authorId = value; }
        public Persons Persons { get => persons; set => persons = value; }
    }
}