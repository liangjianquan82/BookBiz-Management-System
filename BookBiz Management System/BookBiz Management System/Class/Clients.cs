// File:    Clients.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class Clients

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class Clients : Enterprises
    {
        public DataSet Searchclients(string search)
        {
            string sql = "SELECT * ,'view' as bt FROM  Enterprises  " +
               " where state is null and enterprise_type_id = 1 " +
               " and name like '%" + search + "%' " +
               " order by enterprise_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet listClents()
        {
            string sql = "SELECT [enterprise_id]" +
                ",[enterprise_type_id],[name]" +
                ",[street],[city],[zip_code]" +
                ",[enterprise_email],[enterprise_phone]" +
                ",[enterprise_fax],[credit_limit]" +
                ",[state],'view' as bt FROM  Enterprises  " +
                " where state is null and enterprise_type_id = 1 " +
                "order by enterprise_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public DataSet listClents1()
        {
            string sql = "SELECT * ,'add' as bt FROM  Enterprises  " +
                " where state is null and enterprise_type_id = 1 " +
                "order by enterprise_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
    }
}