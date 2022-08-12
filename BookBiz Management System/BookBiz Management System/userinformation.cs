using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz_Management_System
{
    public partial class userinformation : Form
    {
        public userinformation()
        {
            InitializeComponent();
        }
        public static int state = 0;
        public static int person_id = 0;
        private void userinformation_Load(object sender, EventArgs e)
        {
            Role role = new Role();
            cmb_role.DisplayMember = "rolename";
            cmb_role.ValueMember = "roleid";
            if (LoginInfo.CurrentUser.Rolename1.Equals("--Choose--"))
            {
                cmb_role.DataSource = role.listAllroleforuser().Tables[0];
            }
            else if (LoginInfo.CurrentUser.Rolename1.Equals("MIS Manager"))
            {
                cmb_role.DataSource = role.listemployroleforuser().Tables[0];
            }

            if (state == 0) //add new user
            {
                lbtitleuserinfo.Text = "Add User information";
                btremoveperson.Visible = false;
            }
            else if (state == 1) //update  user
            {
                btremoveperson.Visible = true;
                lbtitleuserinfo.Text = "Update User information";
                btreset.Enabled = false;
                btsubmit.Text = "Update";
                Persons ps = new Persons();
                DataSet ds = new DataSet();
                ds=ps.Listpersonbyperson_id(person_id);
                tb_firstname.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
                tb_lastname.Text = ds.Tables[0].Rows[0]["last_name"].ToString();
                tb_email.Text = ds.Tables[0].Rows[0]["email"].ToString();
                tb_phone.Text = ds.Tables[0].Rows[0]["phonenb"].ToString();
                cmb_role.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0]["roleid"].ToString());
                if (cmb_role.SelectedValue.ToString() != "5" && cmb_role.SelectedValue.ToString() != "1002")
                {
                    DataSet dsuser = new DataSet();
                    User us = new User();
                    dsuser = us.SearchUser(person_id);
                    tb_username.Text = dsuser.Tables[0].Rows[0]["username"].ToString();
                    tb_password.Text = dsuser.Tables[0].Rows[0]["password"].ToString();
                }
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tb_firstname.Text = "";
            tb_lastname.Text = "";
            tb_email.Text = "";
            tb_phone.Text = "";
            tb_username.Text = "";
            tb_password.Text = "";

        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_role.Text);
            if (cmb_role.Text.Equals("Author") || cmb_role.Text.Equals("Staff")|| cmb_role.Text.Equals("--Choose--"))
            {
                tb_username.Enabled = false;
                tb_password.Enabled = false;
            }
            else
            {
                tb_username.Enabled = true;
                tb_password.Enabled = true;
            }
        }
        private bool cheackAll()
        {
            bool cheackstate= false;
           
            if (cmb_role.Text == "--Choose--")
            {
                MessageBox.Show("Please choose a Role");
            }
            else if (tb_firstname.Text == "" || tb_firstname.Text == null)
            {
                MessageBox.Show("Please Enter First name!");
            }
            else if (tb_lastname.Text == "" || tb_lastname.Text == null)
            {
                MessageBox.Show("Please Enter Last name!");
            }
            else if (tb_email.Text == "" || tb_email.Text == null)
            {
                MessageBox.Show("Please Enter email!");
            }
            else if (tb_phone.Text == "" || tb_phone.Text == null)
            {
                MessageBox.Show("Please Enter Phone Number!");
            }
            else { cheackstate = true; }

            if (tb_username.Enabled)
            {
                if(tb_username.Text == "" || tb_username.Text == null)
                {
                    MessageBox.Show("Please Enter Username!");
                    cheackstate = false;
                }
                else if(tb_password.Text == "" || tb_password.Text == null)
                {
                    MessageBox.Show("Please Enter Password!");
                    cheackstate = false;
                }
                else { cheackstate = true; }
            }
           


                return cheackstate;
        }
        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (cheackAll())
            {

                bool sta = false;
                Persons ps = new Persons();
                ps.FirstName = tb_firstname.Text;
                ps.LastName = tb_lastname.Text;
                ps.Email = tb_email.Text;
                ps.Phonenb = tb_phone.Text;
                ps.Roleid = Convert.ToInt32(cmb_role.SelectedValue.ToString());
                if (person_id == 0)//add
                {
                    if (cmb_role.Text.ToString() == "Author" || cmb_role.Text.ToString() == "Staff")
                    {
                        sta = ps.Addperson();
                    }
                    else
                    {
                        User us = new User();
                        person_id = ps.Addperson_return_IDENTITY_ID();
                        us.PersonId = person_id;
                        us.Username = tb_username.Text;
                        us.Password = tb_password.Text;
                        sta = us.AddUser();
                    }
                }
                else//update
                {
                    if (cmb_role.Text.ToString() == "Author" || cmb_role.Text.ToString() == "Staff")
                    {
                        ps.PersonId = person_id;
                        sta = ps.Updateperson();
                    }
                    else
                    {
                        ps.PersonId = person_id;
                        sta = ps.Updateperson();
                        User us = new User();
                        us.PersonId = person_id;
                        us.Username = tb_username.Text;
                        us.Password = tb_password.Text;

                        if (us.SelectUserbyps_id().Tables[0].Rows.Count > 0)
                        {
                            sta = us.UpdateUser();
                        }
                        else
                        {
                            sta = us.AddUser();
                        }
                    }
                }               

                if (sta)
                {
                    MessageBox.Show("suesseful!");
                    this.Close();
                }
                else MessageBox.Show("failed!");
            }
        }

        private void tb_username_MouseClick(object sender, MouseEventArgs e)
        {
            tb_username.Text = tb_firstname.Text;
        }

        private void btremoveperson_Click(object sender, EventArgs e)
        {
            bool sta = false;
            Persons ps = new Persons();
            ps.PersonId = person_id;
            sta = ps.Removepersonbyid();
            if (sta)
            {
                MessageBox.Show("suesseful!");
                this.Close();
            }
            else MessageBox.Show("failed!");
        }
    }
}
