using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BookBiz_Management_System
{
    public class LoginInfo
    {
        
        private string Username ;
        public string Username1 { get { return Username; } set { Username = value; } }

        private string Person_id;
        public string Person_id1 { get => Person_id; set => Person_id = value; }

        private string Rolename ;
        public string Rolename1 { get { return Rolename; } set { Rolename = value; } }

        private static LoginInfo _CurrentUser = null;
        
        //应用单件模式，保存用户登录状态
        public static LoginInfo CurrentUser
        {
            get
            {
                if (_CurrentUser == null)
                    _CurrentUser = new LoginInfo();
                return _CurrentUser;
            }
        }

        

        public DataSet loginCheack(string username,string password)
        {
            //select Persons.*,[User].*,Role.* from[User]
            //inner join Persons on Persons.person_id = [user].person_id
            //inner join Role on Role.roleid = Persons.roleid
            //where username = 'Peter12' and password = 789
            string sql = " select * from [User] " +
                " inner join Persons on Persons.person_id = [user].person_id "+
                " inner join Role on Role.roleid = Persons.roleid " +
                " where Persons.state is null and Role.roleid in (1,2,3,4,1003) and username ='" + username + "' and password='"+ password+"'";
            DataSet ds = new DataSet();
            Sqlconnect cnn = new Sqlconnect();
            ds = cnn.select(sql);
            //int x = ds.Tables[0].Rows.Count;           
            return ds;
        }
        
    }
}
