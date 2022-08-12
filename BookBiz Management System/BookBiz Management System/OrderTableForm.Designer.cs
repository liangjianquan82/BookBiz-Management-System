namespace BookBiz_Management_System
{
    partial class OrderTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_booklist = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbtitleauthorinfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_totleprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_OSNB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btsubmit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cob_booktype = new System.Windows.Forms.ComboBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_searchbook = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQOH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_addbook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colbook_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scolBook_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scolQOH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scolQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scolUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoldelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.scolorder_book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scolbook_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_credit_limit = new System.Windows.Forms.TextBox();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladdclient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colcredit_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colenterprise_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_clor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_booklist
            // 
            this.dgv_booklist.AllowUserToAddRows = false;
            this.dgv_booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_booklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colISBN,
            this.colUnitPrice,
            this.colQOH,
            this.col_addbook,
            this.colbook_id});
            this.dgv_booklist.Location = new System.Drawing.Point(399, 120);
            this.dgv_booklist.Name = "dgv_booklist";
            this.dgv_booklist.Size = new System.Drawing.Size(524, 197);
            this.dgv_booklist.TabIndex = 0;
            this.dgv_booklist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_booklist_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scolBook_name,
            this.scolQOH,
            this.scolQuantity,
            this.scolUnitPrice,
            this.scoldelect,
            this.scolorder_book_id,
            this.scolbook_id});
            this.dataGridView2.Location = new System.Drawing.Point(399, 364);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(524, 170);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // lbtitleauthorinfo
            // 
            this.lbtitleauthorinfo.AutoSize = true;
            this.lbtitleauthorinfo.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitleauthorinfo.Location = new System.Drawing.Point(372, 9);
            this.lbtitleauthorinfo.Name = "lbtitleauthorinfo";
            this.lbtitleauthorinfo.Size = new System.Drawing.Size(182, 25);
            this.lbtitleauthorinfo.TabIndex = 41;
            this.lbtitleauthorinfo.Text = "Order Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Total Price";
            // 
            // tb_totleprice
            // 
            this.tb_totleprice.Enabled = false;
            this.tb_totleprice.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_totleprice.Location = new System.Drawing.Point(17, 436);
            this.tb_totleprice.Name = "tb_totleprice";
            this.tb_totleprice.ReadOnly = true;
            this.tb_totleprice.Size = new System.Drawing.Size(162, 31);
            this.tb_totleprice.TabIndex = 43;
            this.tb_totleprice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "OSNB";
            // 
            // tb_OSNB
            // 
            this.tb_OSNB.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_OSNB.Location = new System.Drawing.Point(86, 40);
            this.tb_OSNB.Name = "tb_OSNB";
            this.tb_OSNB.ReadOnly = true;
            this.tb_OSNB.Size = new System.Drawing.Size(295, 31);
            this.tb_OSNB.TabIndex = 45;
            this.tb_OSNB.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Select a client";
            // 
            // dgv_client
            // 
            this.dgv_client.AllowUserToAddRows = false;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colname,
            this.coladdclient,
            this.colcredit_limit,
            this.colenterprise_id});
            this.dgv_client.Location = new System.Drawing.Point(17, 120);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.Size = new System.Drawing.Size(364, 135);
            this.dgv_client.TabIndex = 47;
            this.dgv_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_client_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Select a client";
            // 
            // tb_client
            // 
            this.tb_client.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_client.Location = new System.Drawing.Point(17, 300);
            this.tb_client.Name = "tb_client";
            this.tb_client.ReadOnly = true;
            this.tb_client.Size = new System.Drawing.Size(364, 31);
            this.tb_client.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Time";
            // 
            // btsubmit
            // 
            this.btsubmit.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btsubmit.Location = new System.Drawing.Point(17, 499);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(100, 35);
            this.btsubmit.TabIndex = 53;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(281, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 55;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Books List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Selected books";
            // 
            // cob_booktype
            // 
            this.cob_booktype.FormattingEnabled = true;
            this.cob_booktype.Location = new System.Drawing.Point(584, 48);
            this.cob_booktype.Name = "cob_booktype";
            this.cob_booktype.Size = new System.Drawing.Size(337, 21);
            this.cob_booktype.TabIndex = 58;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_search.Location = new System.Drawing.Point(399, 80);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(299, 31);
            this.tb_search.TabIndex = 59;
            // 
            // bt_searchbook
            // 
            this.bt_searchbook.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_searchbook.Location = new System.Drawing.Point(821, 79);
            this.bt_searchbook.Name = "bt_searchbook";
            this.bt_searchbook.Size = new System.Drawing.Size(100, 35);
            this.bt_searchbook.TabIndex = 60;
            this.bt_searchbook.Text = "Search";
            this.bt_searchbook.UseVisualStyleBackColor = true;
            this.bt_searchbook.Click += new System.EventHandler(this.bt_searchbook_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btRefresh.Location = new System.Drawing.Point(821, 323);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(100, 35);
            this.btRefresh.TabIndex = 61;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // tb_time
            // 
            this.tb_time.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_time.Location = new System.Drawing.Point(17, 368);
            this.tb_time.Name = "tb_time";
            this.tb_time.ReadOnly = true;
            this.tb_time.Size = new System.Drawing.Size(162, 31);
            this.tb_time.TabIndex = 62;
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_save.Location = new System.Drawing.Point(147, 499);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(100, 35);
            this.bt_save.TabIndex = 63;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            // 
            // colISBN
            // 
            this.colISBN.DataPropertyName = "ISBN";
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "UPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colQOH
            // 
            this.colQOH.DataPropertyName = "QOH";
            this.colQOH.HeaderText = "QOH";
            this.colQOH.Name = "colQOH";
            // 
            // col_addbook
            // 
            this.col_addbook.DataPropertyName = "bt";
            this.col_addbook.HeaderText = "";
            this.col_addbook.Name = "col_addbook";
            this.col_addbook.Width = 80;
            // 
            // colbook_id
            // 
            this.colbook_id.DataPropertyName = "book_id";
            this.colbook_id.HeaderText = "book_id";
            this.colbook_id.Name = "colbook_id";
            this.colbook_id.Visible = false;
            // 
            // scolBook_name
            // 
            this.scolBook_name.DataPropertyName = "Title";
            this.scolBook_name.HeaderText = "BookName";
            this.scolBook_name.Name = "scolBook_name";
            this.scolBook_name.Width = 150;
            // 
            // scolQOH
            // 
            this.scolQOH.DataPropertyName = "QOH";
            this.scolQOH.HeaderText = "QOH";
            this.scolQOH.Name = "scolQOH";
            this.scolQOH.ReadOnly = true;
            this.scolQOH.Width = 80;
            // 
            // scolQuantity
            // 
            this.scolQuantity.DataPropertyName = "Quantity";
            this.scolQuantity.HeaderText = "Quantity";
            this.scolQuantity.Name = "scolQuantity";
            this.scolQuantity.Width = 80;
            // 
            // scolUnitPrice
            // 
            this.scolUnitPrice.DataPropertyName = "UnitPrice";
            this.scolUnitPrice.HeaderText = "UnitPrice";
            this.scolUnitPrice.Name = "scolUnitPrice";
            // 
            // scoldelect
            // 
            this.scoldelect.DataPropertyName = "btdelet";
            this.scoldelect.HeaderText = "";
            this.scoldelect.Name = "scoldelect";
            this.scoldelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scoldelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.scoldelect.Width = 70;
            // 
            // scolorder_book_id
            // 
            this.scolorder_book_id.DataPropertyName = "order_book_id";
            this.scolorder_book_id.HeaderText = "order_book_id";
            this.scolorder_book_id.Name = "scolorder_book_id";
            this.scolorder_book_id.Visible = false;
            // 
            // scolbook_id
            // 
            this.scolbook_id.DataPropertyName = "book_id";
            this.scolbook_id.HeaderText = "book_id";
            this.scolbook_id.Name = "scolbook_id";
            this.scolbook_id.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 64;
            this.label8.Text = "credit_limit";
            // 
            // tb_credit_limit
            // 
            this.tb_credit_limit.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_credit_limit.Location = new System.Drawing.Point(211, 368);
            this.tb_credit_limit.Name = "tb_credit_limit";
            this.tb_credit_limit.ReadOnly = true;
            this.tb_credit_limit.Size = new System.Drawing.Size(170, 31);
            this.tb_credit_limit.TabIndex = 65;
            // 
            // colname
            // 
            this.colname.DataPropertyName = "name";
            this.colname.HeaderText = "Name";
            this.colname.Name = "colname";
            this.colname.Width = 250;
            // 
            // coladdclient
            // 
            this.coladdclient.DataPropertyName = "bt";
            this.coladdclient.HeaderText = "";
            this.coladdclient.Name = "coladdclient";
            this.coladdclient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coladdclient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.coladdclient.Width = 70;
            // 
            // colcredit_limit
            // 
            this.colcredit_limit.DataPropertyName = "credit_limit";
            this.colcredit_limit.HeaderText = "credit_limit";
            this.colcredit_limit.Name = "colcredit_limit";
            this.colcredit_limit.Visible = false;
            // 
            // colenterprise_id
            // 
            this.colenterprise_id.DataPropertyName = "enterprise_id";
            this.colenterprise_id.HeaderText = "enterprise_id";
            this.colenterprise_id.Name = "colenterprise_id";
            this.colenterprise_id.Visible = false;
            // 
            // bt_clor
            // 
            this.bt_clor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_clor.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_clor.Location = new System.Drawing.Point(696, 4);
            this.bt_clor.Name = "bt_clor";
            this.bt_clor.Size = new System.Drawing.Size(225, 35);
            this.bt_clor.TabIndex = 66;
            this.bt_clor.Text = "Cancel order";
            this.bt_clor.UseVisualStyleBackColor = false;
            this.bt_clor.Visible = false;
            this.bt_clor.Click += new System.EventHandler(this.bt_clor_Click);
            // 
            // OrderTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 569);
            this.Controls.Add(this.bt_clor);
            this.Controls.Add(this.tb_credit_limit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.bt_searchbook);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.cob_booktype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_OSNB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_totleprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtitleauthorinfo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgv_booklist);
            this.Name = "OrderTableForm";
            this.Text = "OrderTableForm";
            this.Load += new System.EventHandler(this.OrderTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_booklist;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbtitleauthorinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_totleprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_OSNB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_client;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cob_booktype;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_searchbook;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQOH;
        private System.Windows.Forms.DataGridViewButtonColumn col_addbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbook_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn scolBook_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn scolQOH;
        private System.Windows.Forms.DataGridViewTextBoxColumn scolQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn scolUnitPrice;
        private System.Windows.Forms.DataGridViewButtonColumn scoldelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn scolorder_book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn scolbook_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_credit_limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewButtonColumn coladdclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcredit_limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenterprise_id;
        private System.Windows.Forms.Button bt_clor;
    }
}