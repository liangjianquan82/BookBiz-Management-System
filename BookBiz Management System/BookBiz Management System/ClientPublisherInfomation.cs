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
    public partial class ClientPublisherInfomation : Form
    {
        public static int state = 0;
        public static int type = 0;
        public static int enterprise_id = 0;
        public ClientPublisherInfomation()
        {
            InitializeComponent();
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (cheackAll())
            {

                bool sta = false;
                Clients cls = new Clients();

                cls.City = tb_city.Text ;
                cls.CreditLimit = Convert.ToDecimal(tb_creditlimit.Text);
                cls.EnterpriseEmail = tb_email.Text ;
                cls.EnterpriseFax = tb_fax.Text ;
                cls.Name = tb_name.Text ;
                cls.EnterprisePhone = tb_phone.Text ;
                cls.Street = tb_street.Text ;
                cls.ZipCode = tb_zipcode.Text ;
                cls.EnterprisetypeId = Convert.ToInt32(cmb_type.SelectedValue.ToString());

                if (enterprise_id == 0)//add
                {

                    sta = cls.Addenterprise();
                }


                else//update
                {
                    cls.EnterpriseId = enterprise_id;
                    sta = cls.Updateenterprise();
                    
                }

                if (sta)
                {
                    MessageBox.Show("suesseful!");
                    this.Close();
                }
                else MessageBox.Show("failed!");
            }
        }
        private bool cheackAll()
        {
            bool cheackstate = false;
            int num;

            if (tb_name.Text == "" || tb_name.Text == null)
            {
                MessageBox.Show("Please Enter Name!");
            }
            else if (tb_street.Text == "" || tb_street.Text == null)
            {
                MessageBox.Show("Please Enter street!");
            }
            else if (tb_city.Text == "" || tb_city.Text == null)
            {
                MessageBox.Show("Please Enter city!");
            }
            else if (tb_phone.Text == "" || tb_phone.Text == null)
            {
                MessageBox.Show("Please Enter Phone Number!");
            }
            else if (tb_email.Text == "" || tb_email.Text == null)
            {
                MessageBox.Show("Please Enter email!");
            }
            else if (int.TryParse(tb_creditlimit.Text, out num))
            {
                MessageBox.Show("Please Enter number!");
            }
            else if (tb_fax.Text == "" || tb_fax.Text == null)
            {
                MessageBox.Show("Please Enter fax!");
            }
            else if (tb_zipcode.Text == "" || tb_zipcode.Text == null)
            {
                MessageBox.Show("Please Enter zip code!");
            }
            else { cheackstate = true; }

           



            return cheackstate;
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tb_city.Text = "";
            tb_creditlimit.Text = "0";
            tb_email.Text = "";
            tb_fax.Text = "";
            tb_name.Text = "";
            tb_phone.Text = "";
            tb_street.Text = "";
            tb_zipcode.Text = "";
            
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientPublisherInfomation_Load(object sender, EventArgs e)
        {
            EnterpriseType et = new EnterpriseType();
            cmb_type.DisplayMember = "enterprise_type_name";
            cmb_type.ValueMember = "enterprise_type_id";
            cmb_type.DataSource = et.ListEnterpriseType().Tables[0];
            cmb_type.SelectedValue = type;


            if (state == 0) //add new user
            {
                tb_creditlimit.Text = "0";
                if (type == 1)
                {
                    lb_titile.Text = "add Client Information";
                }
                else 
                {
                    lb_titile.Text = "add Publisher Information";
                }
                btremoveclient.Visible = false;
            }
            else if (state == 1)
            {
                btremoveclient.Visible = true;
                if (type == 1)
                {
                    lb_titile.Text = "Update Client Information";
                }
                else
                {
                    lb_titile.Text = "Update Publisher Information";
                }
                btreset.Enabled = false;
                btsubmit.Text = "Update";
                Clients cls = new Clients();
                DataSet ds = new DataSet();
                ds = cls.selectenterprisebyid(enterprise_id);
                tb_name.Text = ds.Tables[0].Rows[0]["name"].ToString();
                tb_street.Text = ds.Tables[0].Rows[0]["street"].ToString();
                tb_email.Text = ds.Tables[0].Rows[0]["enterprise_email"].ToString();
                tb_phone.Text = ds.Tables[0].Rows[0]["enterprise_phone"].ToString();
                tb_fax.Text = ds.Tables[0].Rows[0]["enterprise_fax"].ToString();
                tb_creditlimit.Text = ds.Tables[0].Rows[0]["credit_limit"].ToString();
                tb_city.Text = ds.Tables[0].Rows[0]["city"].ToString();
                tb_zipcode.Text = ds.Tables[0].Rows[0]["zip_code"].ToString();
                cmb_type.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0]["enterprise_type_id"].ToString());

            }
        }

        private void btremoveclient_Click(object sender, EventArgs e)
        {
            bool sta = false;
            Clients cls = new Clients();
            cls.EnterpriseId = enterprise_id;
            sta = cls.Deletenterprise();

            if (sta)
            {
                MessageBox.Show("suesseful!");
                this.Close();
            }
            else MessageBox.Show("failed!");
        }
    }
}
