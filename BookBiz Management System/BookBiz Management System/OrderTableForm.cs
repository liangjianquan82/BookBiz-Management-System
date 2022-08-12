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
    public partial class OrderTableForm : Form
    {
        public OrderTableForm()
        {
            InitializeComponent();
        }
        public static int order_id = 0;
        public static string order_serial_number = "";
        public static int client_id = 0;
        public static int state = 0;
        private void OrderTable_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btsubmit, "Submit completed order!");
            toolTip.SetToolTip(bt_save, "Save the order, unfulfilled orders will not reduce inventory!");
            


            dgv_client.AutoGenerateColumns = false;
            dgv_booklist.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            tb_OSNB.Text = order_serial_number;
            DataSet ds = new DataSet();
            OrderTable ot = new OrderTable();

            Books bk = new Books();
            DataSet dsbook = new DataSet();
            dsbook = bk.listbooks1();
            dgv_booklist.DataSource = dsbook.Tables[0];
            
            BookType bt = new BookType();
            cob_booktype.DisplayMember = "book_type_name";
            cob_booktype.ValueMember = "book_type_id";
            cob_booktype.DataSource = bt.Listboktype().Tables[0];

            ds = ot.Listorderbyorder_serial_number(order_serial_number);
            if (state==0){
                client_id = 0;
                //dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["order_time"].ToString());
                tb_time.Text = ds.Tables[0].Rows[0]["order_time"].ToString();
                tb_client.Text = "";


            }
            else 
            {
                
                client_id = Convert.ToInt32(ds.Tables[0].Rows[0]["enterprise_id"].ToString());
                tb_time.Text = ds.Tables[0].Rows[0]["order_time"].ToString();
                tb_client.Text = ds.Tables[0].Rows[0]["name"].ToString();
                tb_credit_limit.Text = ds.Tables[0].Rows[0]["credit_limit"].ToString();
                tb_totleprice.Text = Convert.ToDecimal( ds.Tables[0].Rows[0]["totalprice"].ToString()).ToString("f2");
                OrderBook ob = new OrderBook();
                dataGridView2.DataSource = ob.listSelectedbooksbyorderid(order_id).Tables[0];

                if (state == 2)
                {
                    btsubmit.Visible = false;
                    bt_save.Visible = false;
                    dgv_client.Columns[1].Visible = false;
                    dgv_booklist.Columns[4].Visible = false;
                    dataGridView2.Columns[4].Visible = false;
                    btRefresh.Visible = false;
                    bt_clor.Visible = true;
                    button2.Text = "Close";
                }
                else if(state == 3)
                {
                    bt_clor.Visible = false;
                    button2.Text = "Close";
                }
            }
            DataSet dsc = new DataSet();
            Clients cl = new Clients();
            dgv_client.DataSource = cl.listClents1().Tables[0];

            
        }

        private void dgv_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_client.Columns[e.ColumnIndex].Name == "coladdclient")
            {
                client_id = Convert.ToInt32(dgv_client.Rows[e.RowIndex].Cells["colenterprise_id"].Value.ToString());
                tb_client.Text = dgv_client.Rows[e.RowIndex].Cells["colname"].Value.ToString();
                tb_credit_limit.Text = dgv_client.Rows[e.RowIndex].Cells["colcredit_limit"].Value.ToString();
            }
        }
        public bool cheackAll()
        {
            bool sta = false;
            if(tb_client.Text==""|| tb_client.Text == null)
            {
                MessageBox.Show("Select a client!");
            }
            else if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Select a book!");
            }
            else if(dataGridView2.Rows.Count > 0)
            {
                sta = counttotalprice();
            }
            else
            {
                sta = true;
            }
            return sta;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            OrderTable ot = new OrderTable();
            
            this.Close();
        }

        private void bt_searchbook_Click(object sender, EventArgs e)
        {
            Books bk = new Books();
            if (cob_booktype.Text != "--Choose--")
            {
                if (tb_search.Text == null || tb_search.Text == "")
                {
                    dgv_booklist.DataSource = bk.Listbook_typeid1(cob_booktype.SelectedValue.ToString()).Tables[0];
                }
                else
                {
                    dgv_booklist.DataSource = bk.Listbook_typeid_serach1(cob_booktype.SelectedValue.ToString(), tb_search.Text).Tables[0];
                }
            }
            else
            {
                if (tb_search.Text == null || tb_search.Text == "")
                {


                    dgv_booklist.DataSource = bk.listbooks1().Tables[0];
                }
                else
                {
                    dgv_booklist.DataSource=bk.Listbook_serach1(tb_search.Text).Tables[0];
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "scoldelect")
            {
                OrderBook ob = new OrderBook();
                ob.OrderBookId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["scolorder_book_id"].Value.ToString());
                ob.delectbyOrderBookId();
                dataGridView2.DataSource = ob.listSelectedbooksbyorderid(order_id).Tables[0];

                counttotalprice();
            }
        }

        private void dgv_booklist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_booklist.Columns[e.ColumnIndex].Name == "col_addbook")
            {
                OrderBook ob = new OrderBook();
                ob.Book_id = Convert.ToInt32(dgv_booklist.Rows[e.RowIndex].Cells["colbook_id"].Value.ToString());
                ob.Order_id = order_id;
                ob.Quantity = 1;
                //判断如果dataGridView2不存在这本书则添加
                bool sta = false;
                for(int i=0;i< dataGridView2.Rows.Count; i++)
                {
                    if(ob.Book_id == Convert.ToInt32(dataGridView2.Rows[i].Cells["scolbook_id"].Value.ToString()))
                    {
                        sta = true;
                    }
                    
                }
                if (sta)
                {
                    MessageBox.Show("this book has been added");
                }
                else 
                { 
                    ob.addbooktoorder();                }

                
                dataGridView2.DataSource = ob.listSelectedbooksbyorderid(order_id).Tables[0];

                counttotalprice();


            }
        }
        private bool counttotalprice()
        {
            decimal totalprice = 0;
            decimal credit = 0;
            decimal remaining_credit = 0;
            bool sta = true;
            int s = dataGridView2.Rows.Count;
            if(tb_credit_limit.Text==null|| tb_credit_limit.Text == "")
            {               
            }
            else
            {
                Clients cl = new Clients();
                credit = Convert.ToDecimal(cl.selectenterprisebyid(client_id).Tables[0].Rows[0]["credit_limit"].ToString());
            }
            if (s > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    int QOH = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolQOH"].Value.ToString());
                    decimal UnitPrice = Convert.ToDecimal(dataGridView2.Rows[i].Cells["scolUnitPrice"].Value.ToString());
                    int quantity = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolQuantity"].Value.ToString());

                    if (quantity > QOH)
                    {
                        sta = false;
                    }
                    decimal price = UnitPrice * quantity;
                    totalprice += price;
                }
                if(credit< totalprice)
                {
                    sta = false;
                    MessageBox.Show("Exceeded credit limit");
                }
                else
                {
                    remaining_credit = credit - totalprice;
                }
                if (sta)
                {
                    tb_totleprice.Text = totalprice.ToString("f2");
                    tb_credit_limit.Text = remaining_credit.ToString("f2");
                }
                else
                {
                    MessageBox.Show("Buy more than inventory! Enter number again");
                }
            }
            return sta;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            counttotalprice();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            counttotalprice();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            //保存订单信息，订单未完成（客户，状态（1））
            OrderTable ot = new OrderTable();
            ot.OrderId = order_id;
            ot.State_order = 1;
            ot.Enterprise_id = client_id;
            bool sta = ot.Updateorder();
            if (sta)
            {
                MessageBox.Show("suesseful!");
                this.Close();
            }
            else MessageBox.Show("failed!");
        }
        private void btsubmit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm order complete!", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool sta = false;
                bool sta1 = false;
                bool sta2 = false;
                if (cheackAll())
                {
                    //更新库存
                    sta = updatebookQOH();
                    //更新客户信用额度
                    sta2 = updateCrrditlimit();
                    //更新订单信息（总价，客户，状态（2））

                    sta1 = updateorder_complete(2);
                }
                if (sta && sta1)
                {
                    MessageBox.Show("suesseful!");
                    this.Close();
                }
                else MessageBox.Show("failed!");
            }                     
        }
        private bool updateCrrditlimit()
        {
            bool sta = true;
            Clients ps = new Clients();
            ps.EnterpriseId = client_id;
            ps.CreditLimit = Convert.ToDecimal(tb_credit_limit.Text);
            sta = ps.Updateenterprise_CreditLimit();
            return sta;
        }
        private bool updateorder_complete(int state_order)
        {
            bool sta = true;
            OrderTable ot = new OrderTable();
            ot.OrderId = order_id;
            ot.Totalprice = Convert.ToDecimal(tb_totleprice.Text);
            ot.State_order = state_order;
            ot.Enterprise_id = client_id;
            ot.Updateorder_complete_order();
            return sta;
        }
        private bool updatebookQOH()
        {
            decimal totalprice = 0;
            bool sta = true;
            bool sta1 = true;
            int s = dataGridView2.Rows.Count;
            if (s > 0)
            {
                for (int i = 0; i < s; i++)
                {
                    int QOH = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolQOH"].Value.ToString());
                    decimal UnitPrice = Convert.ToDecimal(dataGridView2.Rows[i].Cells["scolUnitPrice"].Value.ToString());
                    int quantity = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolQuantity"].Value.ToString());
                    int QOH_now = 0; 
                    if (quantity > QOH)
                    {
                        sta = false;
                    }
                    else
                    {
                        QOH_now = QOH - quantity;
                        OrderBook ob = new OrderBook();
                        ob.OrderBookId = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolorder_book_id"].Value.ToString());
                        ob.Quantity = quantity;
                        sta1 = ob.updatequ();

                        Books books = new Books();
                        books.Qoh = QOH_now;
                        books.BookId = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolbook_id"].Value.ToString());
                        sta = books.Updatebook_QOH();

                    }
                    decimal price = UnitPrice * quantity;
                    totalprice += price;
                }
                if (sta&&sta1)
                {
                    tb_totleprice.Text = totalprice.ToString("f2");
                }
                else
                {
                    //MessageBox.Show("Buy more than inventory! Enter number again");
                }
            }
            return sta;
        }

        private void bt_clor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm order complete!", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool sta = false;
                bool sta1 = false;
                bool sta2 = false;
                if (cheackAll())
                {
                    //更新库存
                    sta = updatebookQOH1();
                    //更新客户信用额度
                    sta2 = updateCrrditlimit1();
                    //更新订单信息（总价，客户，状态（3））

                    sta1 = updateorder_complete(3);
                }
                if (sta && sta1)
                {
                    MessageBox.Show("suesseful!");
                    this.Close();
                }
                else MessageBox.Show("failed!");
            }
        }

        private bool updatebookQOH1()
        {
            decimal totalprice = 0;
            bool sta = true;
            bool sta1 = true;
            int s = dataGridView2.Rows.Count;
            if (s > 0)
            {
                for (int i = 0; i < s; i++)
                {
                    int QOH = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolQOH"].Value.ToString());
                    decimal UnitPrice = Convert.ToDecimal(dataGridView2.Rows[i].Cells["scolUnitPrice"].Value.ToString());
                    int quantity = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolQuantity"].Value.ToString());
                    int QOH_now = 0;
                    
                        QOH_now = QOH + quantity;
                        OrderBook ob = new OrderBook();
                        ob.OrderBookId = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolorder_book_id"].Value.ToString());
                        ob.Quantity = 0;
                        sta1 = ob.updatequ();

                        Books books = new Books();
                        books.Qoh = QOH_now;
                        books.BookId = Convert.ToInt32(dataGridView2.Rows[i].Cells["scolbook_id"].Value.ToString());
                        sta = books.Updatebook_QOH();

                    
                    decimal price = UnitPrice * quantity;
                    totalprice += price;
                }
                if (sta && sta1)
                {
                    tb_totleprice.Text = totalprice.ToString("f2");
                }
                else
                {
                    //MessageBox.Show("Buy more than inventory! Enter number again");
                }
            }
            return sta;
        }
        private bool updateCrrditlimit1()
        {
            decimal credit_limit = Convert.ToDecimal(tb_credit_limit.Text);
            decimal totleprice = Convert.ToDecimal(tb_totleprice.Text);
            bool sta = true;
            Clients ps = new Clients();
            credit_limit = Convert.ToDecimal(ps.selectenterprisebyid(client_id).Tables[0].Rows[0]["credit_limit"].ToString());

            ps.EnterpriseId = client_id;
            ps.CreditLimit = credit_limit + totleprice;
            sta = ps.Updateenterprise_CreditLimit();
            return sta;
        }
    }
}
