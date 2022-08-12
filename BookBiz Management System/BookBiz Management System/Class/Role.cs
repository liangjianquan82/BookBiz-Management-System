// File:    Role.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class Role

using System;
using System.Data;

namespace BookBiz_Management_System
{
    public class Role
    {
        private int roleid;
        private string rolename;

        public int Roleid { get => roleid; set => roleid = value; }
        public string Rolename { get => rolename; set => rolename = value; }

        public DataSet listroleforuser()
        {
            string sql = " SELECT  Role.* FROM Role where rolename != 'Author' and rolename != 'Staff' order by roleid DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public DataSet listAllroleforuser()
        {
            string sql = " SELECT  Role.* FROM Role order by roleid DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet listemployroleforuser()
        {
            string sql = " SELECT  Role.* FROM Role where rolename != 'Author' order by roleid DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
        public DataSet listAuthor()
        {
            string sql = " SELECT  Role.* FROM Role where rolename = 'Author' order by roleid DESC";
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }
    }
}