using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            //record user information
            /*     
            */
            if(tb_username.Text==""|| tb_username.Text == null)
            {
                MessageBox.Show("Please Enter username!");
            }
            else if(tb_password.Text == "" || tb_password.Text == null)
            {
                MessageBox.Show("Please Enter password!");
            }
            else
            {
                LoginInfo log = new LoginInfo();
                DataSet ds = new DataSet();
                ds = log.loginCheack(tb_username.Text, tb_password.Text);
                int x = ds.Tables[0].Rows.Count;
                if (x == 0)
                {
                    MessageBox.Show("username or password is incorrect,Please re-enter!");
                    tb_username.Text = "";
                    tb_password.Text = "";
                }
                else
                {
                    LoginInfo.CurrentUser.Rolename1 = ds.Tables[0].Rows[0]["rolename"].ToString();
                    LoginInfo.CurrentUser.Username1 = ds.Tables[0].Rows[0]["username"].ToString();
                    LoginInfo.CurrentUser.Person_id1 = ds.Tables[0].Rows[0]["person_id"].ToString();
                    this.DialogResult = DialogResult.OK;
                }
            }
            

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
