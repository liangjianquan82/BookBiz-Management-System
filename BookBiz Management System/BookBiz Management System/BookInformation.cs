using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;

namespace BookBiz_Management_System
{
    public partial class BookInformation : Form
    {
        public BookInformation()
        {
            InitializeComponent();
        }
        public static int state = 0;
        public static int book_id = 0;
        private void BookInformation_Load(object sender, EventArgs e)
        {
            //dgv_publishers.ColumnHeadersDefaultCellStyleChanged
            dgv_publishers.AutoGenerateColumns = false;
            dgv_authors.AutoGenerateColumns = false;

            // DataGridViewColumn checkcol = new DataGridViewCheckBoxColumn();
            //dgv_authors.Columns.Add(checkcol);

            ToolTip tt = new ToolTip();
            tt.SetToolTip(lbyear, "Year Published");
            tt.SetToolTip(cmb_type, "Book Type");
            tt.SetToolTip(lbQOH, "Inventory quantity");
            tt.SetToolTip(btsubmit, "Submit all data");

            BookType bt = new BookType();
            cmb_type.DisplayMember = "book_type_name";
            cmb_type.ValueMember = "book_type_id";
            cmb_type.DataSource = bt.Listboktype().Tables[0];
            Publishers ph = new Publishers();
            dgv_publishers.DataSource = ph.listPublisher_name().Tables[0];
            Authors ah = new Authors();
            dgv_authors.DataSource = ah.LisAuthors_for_selecttobook().Tables[0];
            if (state == 0)//新增
            {
                              
            }
            //DataGridViewColumn checkcol = new DataGridViewCheckBoxColumn();
            //dgv_authors.Columns.Add(checkcol);
            else//更新
            {
                btreset.Enabled = false;
                btsubmit.Text = "Update";
                Books bk = new Books();
                DataSet ds = new DataSet();
                DataSet dsbt = new DataSet();
                ds = bk.Listbook_bybookid(book_id);
                tb_bookname.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                tb_ISBN.Text = ds.Tables[0].Rows[0]["ISBN"].ToString();
                tb_uprice.Text = ds.Tables[0].Rows[0]["UnitPrice"].ToString();
                dateTimePicker_pu.Value = Convert.ToDateTime( ds.Tables[0].Rows[0]["YearPublished"].ToString());
                tb_QOH.Text = ds.Tables[0].Rows[0]["QOH"].ToString();
                cmb_type.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0]["book_type_id"].ToString());
                lb_en_id.Text = ds.Tables[0].Rows[0]["enterprise_id"].ToString();
                Publishers bh = new Publishers();
                dsbt = bh.listPublisher_by_id(lb_en_id.Text);
                tb_selPub.Text = dsbt.Tables[0].Rows[0]["name"].ToString();

                BookAuthor ba = new BookAuthor();
                DataSet daba = new DataSet();
                daba = ba.list_book_author(book_id);
                for(int i =0; i<daba.Tables[0].Rows.Count ; i++)
                {
                    LBauthor.Items.Add(daba.Tables[0].Rows[i]["author_ID"].ToString() );
                }
            }

        }

        private void dgv_publishers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_publishers.Columns[e.ColumnIndex].Name == "coladd")
            {
                tb_selPub.Text = dgv_publishers.Rows[e.RowIndex].Cells["colName"].Value.ToString();
                lb_en_id.Text = dgv_publishers.Rows[e.RowIndex].Cells["colenterprise_id"].Value.ToString();
                //dgv_publishers.Columns[1].Visible = false;

            }
        }
        private bool cheackAll()
        {
            bool cheackstate = false;
            int num = 0;
            decimal price = 0;
            if (tb_bookname.Text == "" || tb_bookname.Text == null)
            {
                MessageBox.Show("Please Enter Book name!");
            }
            else if (tb_ISBN.Text == "" || tb_ISBN.Text == null)
            {
                MessageBox.Show("Please Enter ISBN!");
            }

            else if (cmb_type.Text == "--Choose--")
            {
                MessageBox.Show("Please choose a type!");
            }
            else if (!decimal.TryParse(tb_uprice.Text, out price))
            {
                MessageBox.Show("Please Enter unit price!");                
            }
            else if (!int.TryParse(tb_QOH.Text, out num))
            {                
                MessageBox.Show("Please Enter quantity!");               
            }
            else if (tb_selPub.Text == "" || tb_selPub.Text == null)
            {
                MessageBox.Show("Please select a Publisher!");
            }
            else if (LBauthor.Items.Count == 0)
            {
                MessageBox.Show("Please select a Author!");
            }
            else { cheackstate = true; }

            return cheackstate;
        }
        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (cheackAll())
            {
                Books bk = new Books();
                bool sta = false;
                bk.Title = tb_bookname.Text;
                bk.Isbn = tb_ISBN.Text;
                bk.YearPublished = dateTimePicker_pu.Value;
                bk.UnitPrice = Convert.ToDecimal(tb_uprice.Text);
                bk.Qoh = Convert.ToInt32(tb_QOH.Text.ToString());
                bk.EnterpriseId1 = Convert.ToInt32(lb_en_id.Text.ToString());
                bk.BookTypeId1 = Convert.ToInt32(cmb_type.SelectedValue.ToString());
                if (book_id == 0)
                {
                    BookAuthor ba = new BookAuthor();
                    ba.BookId1=bk.Addbook_return_IDENTITY_ID();
                    for(int i = 0; i < LBauthor.Items.Count; i++)
                    {
                        ba.AuthorId1 = LBauthor.Items[i].ToString();
                        sta = ba.addboook_author();
                    }
                    //sta = us.AddUser();
                }
                else
                {
                    bk.BookId = book_id;
                    sta = bk.Updatebook();//更新书内容
                    BookAuthor ba = new BookAuthor();
                    ba.BookId1 = book_id;
                    ba.removebybookid(book_id);//删除现有作者
                    //从新添加作者
                    for (int i = 0; i < LBauthor.Items.Count; i++)
                    {
                        ba.AuthorId1 = LBauthor.Items[i].ToString();
                        
                        sta = ba.addboook_author();
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

        private void dgv_authors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_authors.Columns[e.ColumnIndex].Name == "colbt_add")
            {
                try
                {
                    string colauthor_ID = dgv_authors.Rows[e.RowIndex].Cells["colauthor_ID"].Value.ToString();
                    bool bb = true;
                    for (int i = 0; i < LBauthor.Items.Count; i++)
                    {
                        if (LBauthor.Items[i].ToString().Equals(colauthor_ID))
                        {
                            bb = false;
                            MessageBox.Show("Author has been added");

                        }
                    }
                    if (bb)
                    {
                        LBauthor.Items.Add(colauthor_ID);
                    }
                }
                catch{

                }
               
                //dgv_authors.Rows[e.RowIndex].Cells["colperson_id"].Value.ToString();
                //dgv_publishers.Columns[1].Visible = false;                
            }
           
        }

        private void dgv_authors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgv_authors.Rows[e.RowIndex].Cells["colbt_add"];
            //.ReadOnly = false;


        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            int count = LBauthor.SelectedItems.Count;//判断选中了几个
            List<string> itemValues = new List<string>();

            if (count == 0)
            {
                //如果所选项个数为0，则进行提示
                MessageBox.Show("Plesae select one!");
            }
            else
            {
                //将选中项的内容添加到字符串列表中
                for (int i = 0; i < count; i++)
                {
                    itemValues.Add(LBauthor.SelectedItems[i].ToString());
                }
                //按照内容从列表框中移除数据
                foreach (string item in itemValues)
                {
                    LBauthor.Items.Remove(item);
                }
                MessageBox.Show("Delete successful!");
            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            LBauthor.Items.Clear();
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tb_bookname.Text = "";
            tb_ISBN.Text = "";
            tb_uprice.Text = "0";
            tb_QOH.Text = "0";
            LBauthor.Items.Clear();
            lb_en_id.Text = "";
            tb_selPub.Text = "";
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            Authors ah = new Authors();
            dgv_authors.DataSource = ah.LisAuthors_for_selecttobook().Tables[0];
        }

        private void bt_addau_Click(object sender, EventArgs e)
        {
            Authorinformation.state = 0;
            Authorinformation.person_id = 0;
            Authorinformation af = new Authorinformation();
            af.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Publishers ph = new Publishers();
            dgv_publishers.DataSource = ph.listPublisher_name().Tables[0];
        }

        private void btadden_Click(object sender, EventArgs e)
        {
            ClientPublisherInfomation.state = 0;
            ClientPublisherInfomation.enterprise_id = 0;
            ClientPublisherInfomation.type = 2;
            ClientPublisherInfomation cbi = new ClientPublisherInfomation();
            cbi.ShowDialog();
        }

        private void dgv_authors_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
