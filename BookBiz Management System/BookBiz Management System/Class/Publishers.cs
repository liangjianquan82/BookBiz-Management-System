// File:    Publishers.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class Publishers

using System;
using System.Data;
using System.Data.SqlClient;

namespace BookBiz_Management_System
{
    public class Publishers : Enterprises
    {
        //private Array searchpublishers;
        //private Array listpublishers;

        public DataSet SearchcPublishers(string search)
        {
            string sql = "SELECT * ,'view' as bt FROM  Enterprises  " +
               " where state is null and enterprise_type_id = 2 " +
               " and name like '%" + search + "%' " +
               " order by enterprise_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet listPublishers()
        {
            string sql = "SELECT * ,'view' as bt FROM  Enterprises  " +
                " where state is null and enterprise_type_id = 2 " +
                "order by enterprise_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet listPublisher_name()
        {
            string sql = "SELECT enterprise_id, name ,'add' as bt FROM  Enterprises  " +
                " where state is null and enterprise_type_id = 2 " +
                "order by enterprise_id DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public DataSet listPublisher_by_id(string id)
        {
            string sql = "SELECT  name  FROM  Enterprises  " +
                " where  enterprise_id = " + id;
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

    }
}