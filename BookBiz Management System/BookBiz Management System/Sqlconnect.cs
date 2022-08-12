using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookBiz_Management_System
{
    internal class Sqlconnect
    {        
        public string sqlconnstring = ConfigurationManager.AppSettings["DBConnection"];

        public DataSet select(string selectstatement)
        {
            DataSet ds = new DataSet();
            SqlConnection conn = null;
            conn = new SqlConnection(sqlconnstring);
            conn.Open();           
            SqlDataAdapter adapter = new SqlDataAdapter(selectstatement, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }
        public DataSet select(SqlCommand cmdtext)
        {
            DataSet ds = new DataSet();
            SqlConnection conn = null;
            conn = new SqlConnection(sqlconnstring);
            conn.Open();
            cmdtext.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(cmdtext);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        private int implement(SqlCommand cmdtext)
        {
            int i = 0;
            SqlConnection conn = null;
            conn = new SqlConnection(sqlconnstring);
            
            conn.Open();
            cmdtext.Connection = conn;
           
            //cmd = cmdtext;
            i = cmdtext.ExecuteNonQuery();
            
            
            conn.Close();
            return i;
        }

        public int update(SqlCommand updatecmd)
        {
            int x = new Sqlconnect().implement(updatecmd);           
            return x;
        }

        public int add(SqlCommand addecmd)
        {
            int x = new Sqlconnect().implement(addecmd);
            return x;
        }
        public int delete(SqlCommand deletecmd)
        {

            int x = new Sqlconnect().implement(deletecmd);
            return x;
        }

    }
}
