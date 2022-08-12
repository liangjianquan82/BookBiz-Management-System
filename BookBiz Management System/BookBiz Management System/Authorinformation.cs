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
    public partial class Authorinformation : Form
    {
        public Authorinformation()
        {
            InitializeComponent();
        }
        public static int state = 0;
        public static int person_id = 0;
        private void Authorinformation_Load(object sender, EventArgs e)
        {
            Role rl = new Role();
            cmb_role.DisplayMember = "rolename";
            cmb_role.ValueMember = "roleid";
            cmb_role.DataSource = rl.listAuthor().Tables[0];
            cmb_role.Enabled = false;


            if (state == 0) //add new Author
            {
                btremoveperson.Visible = false;
                lbtitleauthorinfo.Text = "Add Author Information";               
            }
            else if (state == 1)
            {
                btremoveperson.Visible = true;
                lbtitleauthorinfo.Text = "Update Author Information";
                btreset.Enabled = false;
                btsubmit.Text = "Update";

                Authors ah = new Authors();          
                DataSet ds = new DataSet();

                ds = ah.Listauthorbyperson_id(person_id);
                tb_firstname.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
                tb_lastname.Text = ds.Tables[0].Rows[0]["last_name"].ToString();
                tb_email.Text = ds.Tables[0].Rows[0]["email"].ToString();
                tb_phone.Text = ds.Tables[0].Rows[0]["phonenb"].ToString();
               
                tb_Author_ID.Text = ds.Tables[0].Rows[0]["author_ID"].ToString();

            }
        } 
        private void tb_Author_ID_MouseClick(object sender, MouseEventArgs e)
        {
            System.DateTime currentTime = new System.DateTime();
            tb_Author_ID.Text = tb_firstname.Text + currentTime.Date;
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tb_firstname.Text = "";
            tb_lastname.Text = "";
            tb_email.Text = "";
            tb_phone.Text = "";
            tb_Author_ID.Text = "";            
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool cheackAll()
        {
            bool cheackstate = false;                      
            if (tb_firstname.Text == "" || tb_firstname.Text == null)
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
            else if (tb_Author_ID.Text == "" || tb_Author_ID.Text == null)
            {
                MessageBox.Show("Please Enter Author_ID!");
            }
            else { cheackstate = true; }

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
                Authors ah = new Authors();
                if (person_id == 0)//add
                {
                   
                    
                    person_id = ps.Addperson_return_IDENTITY_ID();
                    ah.PersonId = person_id;
                    ah.AuthorId =tb_Author_ID.Text;
                   
                    sta = ah.AddAuthors();
                    
                }
                else//update
                {
                   
                    ps.PersonId = person_id;
                    sta = ps.Updateperson();
                    ah.PersonId = person_id;
                    ah.AuthorId = tb_Author_ID.Text;
                    sta = ah.UpdateAuthors();
                    
                }

                if (sta)
                {
                    MessageBox.Show("suesseful!");
                    this.Close();
                }
                else MessageBox.Show("failed!");
            }
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

        private void tb_Author_ID_MouseClick_1(object sender, MouseEventArgs e)
        {
            if(tb_Author_ID.Text==null|| tb_Author_ID.Text == "") 
            {
                tb_Author_ID.Text = tb_firstname.Text + DateTime.Today.ToString("d");  
            }
            
        }

        private void tb_email_MouseClick(object sender, MouseEventArgs e)
        {
            tb_email.Text = tb_firstname.Text +"@xxx.com";
        }
    }
}
