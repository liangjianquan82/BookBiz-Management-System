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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgv_books.AutoGenerateColumns = false;
            dgv_user.AutoGenerateColumns = false;
            dgv_Author.AutoGenerateColumns = false;
            dgv_user.AutoGenerateColumns = false;
            dvgpublishers.AutoGenerateColumns = false;
            dgv_clients.AutoGenerateColumns = false;
            dgv_order.AutoGenerateColumns = false;

            if (LoginInfo.CurrentUser.Rolename1.Equals("MIS Manager"))
            {
                tpAuthor.Parent = null;
                tpBooks.Parent = null;
                tpClients.Parent = null;
                tpOrders.Parent = null;
                tpPublishers.Parent = null;
                Role role = new Role();
               
                cborolename.DisplayMember = "rolename";
                cborolename.ValueMember = "roleid";
                cborolename.DataSource = role.listroleforuser().Tables[0];
                //cborolename.Items.Insert(0, "All");

                Persons ps = new Persons();
                dgv_user.DataSource = ps.ListAllUser().Tables[0];

                dgv_employee.DataSource = ps.ListAllEmployee().Tables[0];

            }
            else if(LoginInfo.CurrentUser.Rolename1.Equals("Sales Manager"))
            {
                tpAuthor.Parent = null;
                tpBooks.Parent = null;
                tpUsers.Parent = null;
                tpOrders.Parent = null;
                tpPublishers.Parent = null;
                tpEmployee.Parent = null;
                Clients cls = new Clients();

                dgv_clients.DataSource = cls.listClents().Tables[0];

            }
            else if(LoginInfo.CurrentUser.Rolename1.Equals("Inventory Controller"))
            {
                //tpAuthor.Parent = null;
                tpClients.Parent = null;
                tpUsers.Parent = null;
                tpOrders.Parent = null;
                //tpPublishers.Parent = null;
                tpEmployee.Parent = null;
                Publishers pls = new Publishers();
                dvgpublishers.DataSource = pls.listPublishers().Tables[0];
                Authors ah = new Authors();
                dgv_Author.DataSource = ah.ListAllAuthors().Tables[0];
                Books bs = new Books();
                dgv_books.DataSource = bs.listbooks().Tables[0];

            }
            else if (LoginInfo.CurrentUser.Rolename1.Equals("Order Clerk"))
            {
                tpAuthor.Parent = null;
                tpClients.Parent = null;
                tpUsers.Parent = null;                
                tpPublishers.Parent = null;
                tpEmployee.Parent = null;
                tpBooks.Parent = null;
                cob_order_state.Items.Insert(0, "--Choose--");
                cob_order_state.Items.Insert(1, "Incomplete Orders");
                cob_order_state.Items.Insert(2, "Complete Orders");
                cob_order_state.SelectedIndex = 1;
            }
            else if(LoginInfo.CurrentUser.Rolename1.Equals("--Choose--"))
            {
                Role role = new Role();
                cborolename.DisplayMember = "rolename";
                cborolename.ValueMember = "roleid";
                cborolename.DataSource = role.listAllroleforuser().Tables[0];
                Persons ps = new Persons();
                dgv_user.DataSource = ps.ListAllperson().Tables[0];
                cob_order_state.Items.Insert(0, "--Choose--");
                cob_order_state.Items.Insert(1, "Incomplete Orders");
                cob_order_state.Items.Insert(2, "Complete Orders");
                cob_order_state.SelectedIndex = 1;


            }

           
        }



        private void btAdduser_Click(object sender, EventArgs e)
        {
            userinformation.state = 0;
            userinformation.person_id = 0;
            userinformation uf = new userinformation();
            uf.Text = "User Information";
            uf.ShowDialog();
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_user.Columns[e.ColumnIndex].Name == "Colbutview")
            {
                
               //MessageBox.Show(dgv_user.Rows[e.RowIndex].Cells["Colpersonid"].Value.ToString());
                userinformation.state = 1;
                userinformation.person_id =Convert.ToInt32(dgv_user.Rows[e.RowIndex].Cells["Colpersonid"].Value.ToString());
                userinformation uf = new userinformation();
                uf.ShowDialog();
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
           

            if (LoginInfo.CurrentUser.Rolename1.Equals("MIS Manager"))
            {               
                Persons ps = new Persons();
                dgv_user.DataSource = ps.ListAllUser().Tables[0];

                dgv_employee.DataSource = ps.ListAllEmployee().Tables[0];

            }
            else if (LoginInfo.CurrentUser.Rolename1.Equals("--Choose--"))
            {   
                Persons ps = new Persons();
                dgv_user.DataSource = ps.ListAllperson().Tables[0];
                dgv_employee.DataSource = ps.ListAllperson().Tables[0];
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Text.Equals("Exit"))
            {
                this.Close();
            }
            else if (tabControl1.SelectedTab.Text.Equals("Clients"))
            {
                Clients cls = new Clients();
                dgv_clients.DataSource = cls.listClents().Tables[0];
            }
            else if (tabControl1.SelectedTab.Text.Equals("Publishers"))
            {
                Publishers pls = new Publishers();
                dvgpublishers.DataSource = pls.listPublishers().Tables[0];
            }
            else if (tabControl1.SelectedTab.Text.Equals("Author"))
            {
                Authors ah = new Authors();
                dgv_Author.DataSource = ah.ListAllAuthors().Tables[0];
            }
            else if (tabControl1.SelectedTab.Text.Equals("Books"))
            {
                Books bk = new Books();
                dgv_books.DataSource = bk.listbooks().Tables[0];
                BookType bt = new BookType();
                cb_booktype.DisplayMember = "book_type_name";
                cb_booktype.ValueMember = "book_type_id";
                cb_booktype.DataSource = bt.Listboktype().Tables[0];
            }
            else if (tabControl1.SelectedTab.Text.Equals("Orders"))
            {
                OrderTable ot = new OrderTable();
                dgv_order.DataSource = ot.Listorder1().Tables[0];
               


            }
        }



        private void dgv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_employee.Columns[e.ColumnIndex].Name == "dcolbutview")
            {

                //MessageBox.Show(dgv_user.Rows[e.RowIndex].Cells["Colpersonid"].Value.ToString());
                userinformation.state = 1;
                userinformation.person_id = Convert.ToInt32(dgv_employee.Rows[e.RowIndex].Cells["dcolpersonid"].Value.ToString());
                userinformation uf = new userinformation();
                uf.ShowDialog();
            }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Persons ps = new Persons();
            if (tbsearch.Text == "" || tbsearch.Text == null)
            {
                if (cborolename.Text.Equals("--Choose--"))
                {
                    if (LoginInfo.CurrentUser.Rolename1.Equals("MIS Manager"))
                    {
                        //dgv_user.DataSource = ps.ListAllUser().Tables[0];
                        ds = ps.ListAllUser();
                    }
                    else
                    {
                        ds = ps.ListAllperson();
                    }
                }
                else
                {
                    ds = ps.Listperson(cborolename.SelectedValue.ToString());
                }
            }
            else
            {
                if (cborolename.Text.Equals("--Choose--"))
                {
                    if (LoginInfo.CurrentUser.Rolename1.Equals("MIS Manager"))
                    {
                        ds = ps.ListAllUser(tbsearch.Text);
                    }
                    else if (LoginInfo.CurrentUser.Rolename1.Equals("--Choose--"))
                    {
                        ds = ps.Listpersonsearch(tbsearch.Text);
                    }


                }
                else
                {
                    ds = ps.Listpersonsearch(tbsearch.Text,cborolename.SelectedValue.ToString());
                }
            }
            dgv_user.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Persons ps = new Persons();
            if (tbsearch1.Text == "" || tbsearch1.Text == null)
            {
                if (LoginInfo.CurrentUser.Rolename1.Equals("MIS Manager"))
                {
                    ds = ps.ListAllEmployee();
                }
                else if (LoginInfo.CurrentUser.Rolename1.Equals("--Choose--"))
                {
                    ds = ps.ListAllperson();
                }
                
            }
            else
            {
               
                if (LoginInfo.CurrentUser.Rolename1.Equals("MIS Manager"))
                {
                    ds = ps.ListAllEmployee(tbsearch1.Text);
                }
                else if (LoginInfo.CurrentUser.Rolename1.Equals("--Choose--"))
                {
                    ds = ps.ListAllperson(tbsearch1.Text);
                }
            }
            dgv_employee.DataSource=ds.Tables[0];
        }

        private void btaddemployee_Click(object sender, EventArgs e)
        {
            userinformation.state = 0;
            userinformation.person_id = 0;
            userinformation uf = new userinformation();
            uf.Text = "Employee Information";
            uf.ShowDialog();
        }

        private void btsearch_clients_Click(object sender, EventArgs e)
        {
            Clients cls = new Clients();
            DataSet ds = new DataSet();
            if(tb_searchclient.Text==""|| tb_searchclient.Text==null)
            {
                ds = cls.listClents();
            }
            else
            {
                ds = cls.Searchclients(tb_searchclient.Text);
            }
            
            dgv_clients.DataSource = ds.Tables[0];
        }

        private void bt_addclient_Click(object sender, EventArgs e)
        {
            ClientPublisherInfomation.state = 0;
            ClientPublisherInfomation.enterprise_id = 0;
            ClientPublisherInfomation.type = 1;
            ClientPublisherInfomation cbi = new ClientPublisherInfomation();
            cbi.ShowDialog();
        }

        private void dgv_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_clients.Columns[e.ColumnIndex].Name == "colbt_view_en")
            {
                ClientPublisherInfomation.state = 1;
                ClientPublisherInfomation.enterprise_id = Convert.ToInt32(dgv_clients.Rows[e.RowIndex].Cells["colenterprise_id"].Value.ToString()); ;
                ClientPublisherInfomation.type = 1;
                ClientPublisherInfomation cbi = new ClientPublisherInfomation();
                cbi.ShowDialog();
            }
        }

        private void btaddPub_Click(object sender, EventArgs e)
        {
            ClientPublisherInfomation.state = 0;
            ClientPublisherInfomation.enterprise_id = 0;
            ClientPublisherInfomation.type = 2;
            ClientPublisherInfomation cbi = new ClientPublisherInfomation();
            cbi.ShowDialog();
        }

        private void dvgpublishers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgpublishers.Columns[e.ColumnIndex].Name == "dcolbt_view_en")
            {
                ClientPublisherInfomation.state = 1;
                ClientPublisherInfomation.enterprise_id = Convert.ToInt32(dvgpublishers.Rows[e.RowIndex].Cells["dcolenterprise_id"].Value.ToString()); ;
                ClientPublisherInfomation.type = 2;
                ClientPublisherInfomation cbi = new ClientPublisherInfomation();
                cbi.ShowDialog();
            }
        }

        private void btsearchP_Click(object sender, EventArgs e)
        {
            Publishers cls = new Publishers();
            DataSet ds = new DataSet();
            if (tb_searchp.Text == "" || tb_searchp.Text == null)
            {
                ds = cls.listPublishers();
            }
            else
            {
                ds = cls.SearchcPublishers(tb_searchp.Text);
            }

            dvgpublishers.DataSource = ds.Tables[0];
        }

        private void btaddauthor_Click(object sender, EventArgs e)
        {
            Authorinformation.state = 0;
            Authorinformation.person_id = 0;            
            Authorinformation af = new Authorinformation();
            af.ShowDialog();
        }

        private void dgv_Author_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Author.Columns[e.ColumnIndex].Name == "acolbt_view")
            {
                Authorinformation.state = 1;
                Authorinformation.person_id = Convert.ToInt32(dgv_Author.Rows[e.RowIndex].Cells["acolperson_id"].Value.ToString()); ;

                Authorinformation af = new Authorinformation();
                af.ShowDialog();
            }
        }

        private void bt_searchauthor_Click(object sender, EventArgs e)
        {
            Authors au = new Authors();
            DataSet ds = new DataSet();
            if (tb_searchp.Text == "" || tb_searchp.Text == null)
            {
                ds = au.ListAllAuthors();
            }
            else
            {
                ds = au.SearchcAuthors(tb_searchauthor.Text);
            }

            dgv_Author.DataSource = ds.Tables[0];
        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_books.Columns[e.ColumnIndex].Name == "bt_view_book")
            {
                BookInformation.state = 1;
                BookInformation.book_id = Convert.ToInt32(dgv_books.Rows[e.RowIndex].Cells["colbook_id"].Value.ToString()); ;

                BookInformation bf = new BookInformation();
                bf.ShowDialog();
            }
        }

        private void bt_addbook_Click(object sender, EventArgs e)
        {
            BookInformation.state = 0;
            BookInformation.book_id = 0;
            BookInformation bf = new BookInformation();
            bf.ShowDialog();
        }

        private void bt_search_book_Click(object sender, EventArgs e)
        {           
            Books bk = new Books();
            if (cb_booktype.Text != "--Choose--")
            {
                if (tb_sc_book.Text == null || tb_sc_book.Text == "") 
                {
                    dgv_books.DataSource = bk.Listbook_typeid(cb_booktype.SelectedValue.ToString()).Tables[0];
                }
                else
                {
                    dgv_books.DataSource = bk.Listbook_typeid_serach(cb_booktype.SelectedValue.ToString(), tb_sc_book.Text).Tables[0];
                }
            }
            else
            {
                if (tb_sc_book.Text == null || tb_sc_book.Text == "")
                {


                    dgv_books.DataSource = bk.listbooks().Tables[0];
                }
                else
                {
                    dgv_books.DataSource = bk.Listbook_serach(tb_sc_book.Text).Tables[0];
                }
            }
        }

        private void bt_addorder_Click(object sender, EventArgs e)
        {
            //添加一张新订单
            OrderTable ot = new OrderTable();
            ot.Person_id = Convert.ToInt32(LoginInfo.CurrentUser.Person_id1);
            ot.Totalprice = 0;
            ot.Order_type_id = 1;
            ot.Enterprise_id = 2;
            ot.OrderTime = DateTime.Now;
            ot.OrderSerialNumber = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            OrderTableForm.order_id = ot.Addorderreturn_orderid();
            OrderTableForm.order_serial_number = ot.OrderSerialNumber;
            OrderTableForm.state = 0;

            OrderTableForm otf = new OrderTableForm();
            otf.ShowDialog();

        }

        private void bt_searchorder_Click(object sender, EventArgs e)
        {
            OrderTable ot = new OrderTable();
            if(cob_order_state.Text == "--Choose--"|| cob_order_state.Text == "Incomplete Orders")
            {
                if(tb_ordersearch.Text==""|| tb_ordersearch.Text == null)
                {
                    dgv_order.DataSource = ot.Listorder1().Tables[0];
                }
                else
                {
                    dgv_order.DataSource = ot.Listorder1(tb_ordersearch.Text).Tables[0];
                }
            }
            else
            {
                if (tb_ordersearch.Text == "" || tb_ordersearch.Text == null)
                {
                    dgv_order.DataSource = ot.Listorder2(cob_order_state.SelectedIndex.ToString()).Tables[0];
                }
                else
                {
                    dgv_order.DataSource = ot.Listorder1(tb_ordersearch.Text, cob_order_state.SelectedIndex.ToString()).Tables[0];
                }
            }
            
        }

        private void dgv_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_order.Columns[e.ColumnIndex].Name == "col_vieworder")
            {
                OrderTableForm.client_id = Convert.ToInt32(dgv_order.Rows[e.RowIndex].Cells["ocolenterprise_id"].Value.ToString());
                OrderTableForm.order_serial_number = dgv_order.Rows[e.RowIndex].Cells["col_order_serial_number"].Value.ToString();
                OrderTableForm.order_id = Convert.ToInt32(dgv_order.Rows[e.RowIndex].Cells["colorder_id"].Value.ToString());
                OrderTableForm.state = Convert.ToInt32(dgv_order.Rows[e.RowIndex].Cells["ocolstate_order"].Value.ToString());

                OrderTableForm otf = new OrderTableForm();
                otf.ShowDialog();
            }
        }
    }
}
