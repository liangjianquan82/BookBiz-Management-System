namespace BookBiz_Management_System
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.cborolename = new System.Windows.Forms.ComboBox();
            this.btAdduser = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.Colfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colrolename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colphonenb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colbutview = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Colpersonid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btsearch = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.tpEmployee = new System.Windows.Forms.TabPage();
            this.btaddemployee = new System.Windows.Forms.Button();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            this.dcolfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcollastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolrolename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolbutview = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dcolpersonid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tbsearch1 = new System.Windows.Forms.TextBox();
            this.tpClients = new System.Windows.Forms.TabPage();
            this.bt_addclient = new System.Windows.Forms.Button();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.colenterprise_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colenterprise_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colenterprise_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcredit_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_view_en = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colenterprise_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colzip_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colenterprise_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colenterprise_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btsearch_clients = new System.Windows.Forms.Button();
            this.tb_searchclient = new System.Windows.Forms.TextBox();
            this.tpPublishers = new System.Windows.Forms.TabPage();
            this.btaddPub = new System.Windows.Forms.Button();
            this.dvgpublishers = new System.Windows.Forms.DataGridView();
            this.btsearchP = new System.Windows.Forms.Button();
            this.tb_searchp = new System.Windows.Forms.TextBox();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.tpAuthor = new System.Windows.Forms.TabPage();
            this.btaddauthor = new System.Windows.Forms.Button();
            this.dgv_Author = new System.Windows.Forms.DataGridView();
            this.acolauthor_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acolfirst_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acollast_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acolemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acolphonenb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acolbt_view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.acolrolename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acolperson_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_searchauthor = new System.Windows.Forms.Button();
            this.tb_searchauthor = new System.Windows.Forms.TextBox();
            this.tpBooks = new System.Windows.Forms.TabPage();
            this.cb_booktype = new System.Windows.Forms.ComboBox();
            this.bt_addbook = new System.Windows.Forms.Button();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbook_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQOH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_view_book = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colbook_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_search_book = new System.Windows.Forms.Button();
            this.tb_sc_book = new System.Windows.Forms.TextBox();
            this.tpexit = new System.Windows.Forms.TabPage();
            this.bookBizDBDataSet = new BookBiz_Management_System.BookBizDBDataSet();
            this.bookBizDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.bt_addorder = new System.Windows.Forms.Button();
            this.tb_ordersearch = new System.Windows.Forms.TextBox();
            this.bt_searchorder = new System.Windows.Forms.Button();
            this.cob_order_state = new System.Windows.Forms.ComboBox();
            this.dcolenterprise_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolenterprise_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolenterprise_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolbt_view_en = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dcolcredit_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolenterprise_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolzip_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolstreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolenterprise_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolenterprise_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_order_serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltotalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colordertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorderhandler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vieworder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colorder_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocolstate_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocolenterprise_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocolperson_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.tpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.tpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            this.tpPublishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpublishers)).BeginInit();
            this.tpOrders.SuspendLayout();
            this.tpAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Author)).BeginInit();
            this.tpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBizDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBizDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpUsers);
            this.tabControl1.Controls.Add(this.tpEmployee);
            this.tabControl1.Controls.Add(this.tpClients);
            this.tabControl1.Controls.Add(this.tpBooks);
            this.tabControl1.Controls.Add(this.tpPublishers);
            this.tabControl1.Controls.Add(this.tpAuthor);
            this.tabControl1.Controls.Add(this.tpOrders);
            this.tabControl1.Controls.Add(this.tpexit);
            this.tabControl1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 560);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.cborolename);
            this.tpUsers.Controls.Add(this.btAdduser);
            this.tpUsers.Controls.Add(this.dgv_user);
            this.tpUsers.Controls.Add(this.btsearch);
            this.tpUsers.Controls.Add(this.tbsearch);
            this.tpUsers.Location = new System.Drawing.Point(4, 34);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(937, 522);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // cborolename
            // 
            this.cborolename.FormattingEnabled = true;
            this.cborolename.Location = new System.Drawing.Point(8, 6);
            this.cborolename.Name = "cborolename";
            this.cborolename.Size = new System.Drawing.Size(187, 33);
            this.cborolename.TabIndex = 12;
            // 
            // btAdduser
            // 
            this.btAdduser.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btAdduser.Location = new System.Drawing.Point(823, 6);
            this.btAdduser.Name = "btAdduser";
            this.btAdduser.Size = new System.Drawing.Size(105, 35);
            this.btAdduser.TabIndex = 11;
            this.btAdduser.Text = "AddUser";
            this.btAdduser.UseVisualStyleBackColor = true;
            this.btAdduser.Click += new System.EventHandler(this.btAdduser_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colfirstname,
            this.Collastname,
            this.Colrolename,
            this.Colemail,
            this.Colphonenb,
            this.Colbutview,
            this.Colpersonid});
            this.dgv_user.Location = new System.Drawing.Point(6, 52);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(920, 463);
            this.dgv_user.TabIndex = 10;
            this.dgv_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellContentClick);
            // 
            // Colfirstname
            // 
            this.Colfirstname.DataPropertyName = "first_name";
            this.Colfirstname.HeaderText = "firstname";
            this.Colfirstname.Name = "Colfirstname";
            // 
            // Collastname
            // 
            this.Collastname.DataPropertyName = "last_name";
            this.Collastname.HeaderText = "lastname";
            this.Collastname.Name = "Collastname";
            // 
            // Colrolename
            // 
            this.Colrolename.DataPropertyName = "rolename";
            this.Colrolename.HeaderText = "rolename";
            this.Colrolename.Name = "Colrolename";
            this.Colrolename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Colrolename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colrolename.Width = 150;
            // 
            // Colemail
            // 
            this.Colemail.DataPropertyName = "email";
            this.Colemail.HeaderText = "email";
            this.Colemail.Name = "Colemail";
            this.Colemail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Colemail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colemail.Width = 200;
            // 
            // Colphonenb
            // 
            this.Colphonenb.DataPropertyName = "phonenb";
            this.Colphonenb.HeaderText = "phone";
            this.Colphonenb.Name = "Colphonenb";
            this.Colphonenb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colphonenb.Width = 200;
            // 
            // Colbutview
            // 
            this.Colbutview.DataPropertyName = "bt";
            this.Colbutview.HeaderText = "";
            this.Colbutview.Name = "Colbutview";
            this.Colbutview.Text = "Check";
            this.Colbutview.Width = 120;
            // 
            // Colpersonid
            // 
            this.Colpersonid.DataPropertyName = "person_id";
            this.Colpersonid.HeaderText = "personid";
            this.Colpersonid.Name = "Colpersonid";
            this.Colpersonid.Visible = false;
            // 
            // btsearch
            // 
            this.btsearch.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btsearch.Location = new System.Drawing.Point(679, 6);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(100, 35);
            this.btsearch.TabIndex = 9;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(201, 8);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(472, 31);
            this.tbsearch.TabIndex = 5;
            // 
            // tpEmployee
            // 
            this.tpEmployee.Controls.Add(this.btaddemployee);
            this.tpEmployee.Controls.Add(this.dgv_employee);
            this.tpEmployee.Controls.Add(this.button1);
            this.tpEmployee.Controls.Add(this.tbsearch1);
            this.tpEmployee.Location = new System.Drawing.Point(4, 34);
            this.tpEmployee.Name = "tpEmployee";
            this.tpEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployee.Size = new System.Drawing.Size(937, 522);
            this.tpEmployee.TabIndex = 1;
            this.tpEmployee.Text = "Employee";
            this.tpEmployee.UseVisualStyleBackColor = true;
            // 
            // btaddemployee
            // 
            this.btaddemployee.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btaddemployee.Location = new System.Drawing.Point(778, 4);
            this.btaddemployee.Name = "btaddemployee";
            this.btaddemployee.Size = new System.Drawing.Size(148, 35);
            this.btaddemployee.TabIndex = 14;
            this.btaddemployee.Text = "AddEmployee";
            this.btaddemployee.UseVisualStyleBackColor = true;
            this.btaddemployee.Click += new System.EventHandler(this.btaddemployee_Click);
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcolfirstname,
            this.dcollastname,
            this.dcolrolename,
            this.dcolemail,
            this.dcolphone,
            this.dcolbutview,
            this.dcolpersonid});
            this.dgv_employee.Location = new System.Drawing.Point(6, 52);
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.Size = new System.Drawing.Size(920, 463);
            this.dgv_employee.TabIndex = 13;
            this.dgv_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employee_CellContentClick);
            // 
            // dcolfirstname
            // 
            this.dcolfirstname.DataPropertyName = "first_name";
            this.dcolfirstname.HeaderText = "firstname";
            this.dcolfirstname.Name = "dcolfirstname";
            // 
            // dcollastname
            // 
            this.dcollastname.DataPropertyName = "last_name";
            this.dcollastname.HeaderText = "lastname";
            this.dcollastname.Name = "dcollastname";
            // 
            // dcolrolename
            // 
            this.dcolrolename.DataPropertyName = "rolename";
            this.dcolrolename.HeaderText = "rolename";
            this.dcolrolename.Name = "dcolrolename";
            this.dcolrolename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dcolrolename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dcolrolename.Width = 150;
            // 
            // dcolemail
            // 
            this.dcolemail.DataPropertyName = "email";
            this.dcolemail.HeaderText = "email";
            this.dcolemail.Name = "dcolemail";
            this.dcolemail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dcolemail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dcolemail.Width = 200;
            // 
            // dcolphone
            // 
            this.dcolphone.DataPropertyName = "phonenb";
            this.dcolphone.HeaderText = "phone";
            this.dcolphone.Name = "dcolphone";
            this.dcolphone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dcolphone.Width = 200;
            // 
            // dcolbutview
            // 
            this.dcolbutview.DataPropertyName = "bt";
            this.dcolbutview.HeaderText = "";
            this.dcolbutview.Name = "dcolbutview";
            this.dcolbutview.Text = "Check";
            this.dcolbutview.Width = 120;
            // 
            // dcolpersonid
            // 
            this.dcolpersonid.DataPropertyName = "person_id";
            this.dcolpersonid.HeaderText = "personid";
            this.dcolpersonid.Name = "dcolpersonid";
            this.dcolpersonid.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(517, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbsearch1
            // 
            this.tbsearch1.Location = new System.Drawing.Point(8, 6);
            this.tbsearch1.Name = "tbsearch1";
            this.tbsearch1.Size = new System.Drawing.Size(494, 31);
            this.tbsearch1.TabIndex = 11;
            // 
            // tpClients
            // 
            this.tpClients.Controls.Add(this.bt_addclient);
            this.tpClients.Controls.Add(this.dgv_clients);
            this.tpClients.Controls.Add(this.btsearch_clients);
            this.tpClients.Controls.Add(this.tb_searchclient);
            this.tpClients.Location = new System.Drawing.Point(4, 34);
            this.tpClients.Name = "tpClients";
            this.tpClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpClients.Size = new System.Drawing.Size(937, 522);
            this.tpClients.TabIndex = 2;
            this.tpClients.Text = "Clients";
            this.tpClients.UseVisualStyleBackColor = true;
            // 
            // bt_addclient
            // 
            this.bt_addclient.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_addclient.Location = new System.Drawing.Point(780, 9);
            this.bt_addclient.Name = "bt_addclient";
            this.bt_addclient.Size = new System.Drawing.Size(148, 35);
            this.bt_addclient.TabIndex = 18;
            this.bt_addclient.Text = "AddClient";
            this.bt_addclient.UseVisualStyleBackColor = true;
            this.bt_addclient.Click += new System.EventHandler(this.bt_addclient_Click);
            // 
            // dgv_clients
            // 
            this.dgv_clients.AllowUserToAddRows = false;
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colenterprise_name,
            this.colcity,
            this.colenterprise_email,
            this.colenterprise_phone,
            this.colcredit_limit,
            this.colbt_view_en,
            this.colenterprise_fax,
            this.colzip_code,
            this.colstreet,
            this.colenterprise_id,
            this.colenterprise_type_id});
            this.dgv_clients.Location = new System.Drawing.Point(8, 50);
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.Size = new System.Drawing.Size(920, 463);
            this.dgv_clients.TabIndex = 17;
            this.dgv_clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clients_CellContentClick);
            // 
            // colenterprise_name
            // 
            this.colenterprise_name.DataPropertyName = "name";
            this.colenterprise_name.HeaderText = "name";
            this.colenterprise_name.Name = "colenterprise_name";
            this.colenterprise_name.Width = 200;
            // 
            // colcity
            // 
            this.colcity.DataPropertyName = "city";
            this.colcity.HeaderText = "city";
            this.colcity.Name = "colcity";
            this.colcity.Width = 150;
            // 
            // colenterprise_email
            // 
            this.colenterprise_email.DataPropertyName = "enterprise_email";
            this.colenterprise_email.HeaderText = "email";
            this.colenterprise_email.Name = "colenterprise_email";
            this.colenterprise_email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colenterprise_email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colenterprise_email.Width = 150;
            // 
            // colenterprise_phone
            // 
            this.colenterprise_phone.DataPropertyName = "enterprise_phone";
            this.colenterprise_phone.HeaderText = "phone";
            this.colenterprise_phone.Name = "colenterprise_phone";
            this.colenterprise_phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colenterprise_phone.Width = 150;
            // 
            // colcredit_limit
            // 
            this.colcredit_limit.DataPropertyName = "credit_limit";
            this.colcredit_limit.HeaderText = "credit_limit";
            this.colcredit_limit.Name = "colcredit_limit";
            this.colcredit_limit.Width = 130;
            // 
            // colbt_view_en
            // 
            this.colbt_view_en.DataPropertyName = "bt";
            this.colbt_view_en.HeaderText = "";
            this.colbt_view_en.Name = "colbt_view_en";
            this.colbt_view_en.Text = "Check";
            // 
            // colenterprise_fax
            // 
            this.colenterprise_fax.DataPropertyName = "enterprise_fax";
            this.colenterprise_fax.HeaderText = "enterprise_fax";
            this.colenterprise_fax.Name = "colenterprise_fax";
            this.colenterprise_fax.Visible = false;
            // 
            // colzip_code
            // 
            this.colzip_code.DataPropertyName = "zip_code";
            this.colzip_code.HeaderText = "zip_code";
            this.colzip_code.Name = "colzip_code";
            this.colzip_code.Visible = false;
            // 
            // colstreet
            // 
            this.colstreet.DataPropertyName = "street";
            this.colstreet.HeaderText = "street";
            this.colstreet.Name = "colstreet";
            this.colstreet.Visible = false;
            // 
            // colenterprise_id
            // 
            this.colenterprise_id.DataPropertyName = "enterprise_id";
            this.colenterprise_id.HeaderText = "enterprise_id";
            this.colenterprise_id.Name = "colenterprise_id";
            this.colenterprise_id.Visible = false;
            // 
            // colenterprise_type_id
            // 
            this.colenterprise_type_id.HeaderText = "enterprise_type_id";
            this.colenterprise_type_id.Name = "colenterprise_type_id";
            this.colenterprise_type_id.Visible = false;
            // 
            // btsearch_clients
            // 
            this.btsearch_clients.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btsearch_clients.Location = new System.Drawing.Point(509, 9);
            this.btsearch_clients.Name = "btsearch_clients";
            this.btsearch_clients.Size = new System.Drawing.Size(122, 35);
            this.btsearch_clients.TabIndex = 16;
            this.btsearch_clients.Text = "Search";
            this.btsearch_clients.UseVisualStyleBackColor = true;
            this.btsearch_clients.Click += new System.EventHandler(this.btsearch_clients_Click);
            // 
            // tb_searchclient
            // 
            this.tb_searchclient.Location = new System.Drawing.Point(10, 9);
            this.tb_searchclient.Name = "tb_searchclient";
            this.tb_searchclient.Size = new System.Drawing.Size(494, 31);
            this.tb_searchclient.TabIndex = 15;
            // 
            // tpPublishers
            // 
            this.tpPublishers.Controls.Add(this.btaddPub);
            this.tpPublishers.Controls.Add(this.dvgpublishers);
            this.tpPublishers.Controls.Add(this.btsearchP);
            this.tpPublishers.Controls.Add(this.tb_searchp);
            this.tpPublishers.Location = new System.Drawing.Point(4, 34);
            this.tpPublishers.Name = "tpPublishers";
            this.tpPublishers.Size = new System.Drawing.Size(937, 522);
            this.tpPublishers.TabIndex = 4;
            this.tpPublishers.Text = "Publishers";
            this.tpPublishers.UseVisualStyleBackColor = true;
            // 
            // btaddPub
            // 
            this.btaddPub.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btaddPub.Location = new System.Drawing.Point(780, 9);
            this.btaddPub.Name = "btaddPub";
            this.btaddPub.Size = new System.Drawing.Size(148, 35);
            this.btaddPub.TabIndex = 22;
            this.btaddPub.Text = "AddPublishers";
            this.btaddPub.UseVisualStyleBackColor = true;
            this.btaddPub.Click += new System.EventHandler(this.btaddPub_Click);
            // 
            // dvgpublishers
            // 
            this.dvgpublishers.AllowUserToAddRows = false;
            this.dvgpublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgpublishers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcolenterprise_name,
            this.dcolcity,
            this.dcolenterprise_email,
            this.dcolenterprise_phone,
            this.dcolbt_view_en,
            this.dcolcredit_limit,
            this.dcolenterprise_fax,
            this.dcolzip_code,
            this.dcolstreet,
            this.dcolenterprise_id,
            this.dcolenterprise_type_id});
            this.dvgpublishers.Location = new System.Drawing.Point(8, 50);
            this.dvgpublishers.Name = "dvgpublishers";
            this.dvgpublishers.Size = new System.Drawing.Size(920, 463);
            this.dvgpublishers.TabIndex = 21;
            this.dvgpublishers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgpublishers_CellContentClick);
            // 
            // btsearchP
            // 
            this.btsearchP.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btsearchP.Location = new System.Drawing.Point(509, 9);
            this.btsearchP.Name = "btsearchP";
            this.btsearchP.Size = new System.Drawing.Size(122, 35);
            this.btsearchP.TabIndex = 20;
            this.btsearchP.Text = "Search";
            this.btsearchP.UseVisualStyleBackColor = true;
            this.btsearchP.Click += new System.EventHandler(this.btsearchP_Click);
            // 
            // tb_searchp
            // 
            this.tb_searchp.Location = new System.Drawing.Point(10, 9);
            this.tb_searchp.Name = "tb_searchp";
            this.tb_searchp.Size = new System.Drawing.Size(494, 31);
            this.tb_searchp.TabIndex = 19;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.cob_order_state);
            this.tpOrders.Controls.Add(this.bt_searchorder);
            this.tpOrders.Controls.Add(this.tb_ordersearch);
            this.tpOrders.Controls.Add(this.bt_addorder);
            this.tpOrders.Controls.Add(this.dgv_order);
            this.tpOrders.Location = new System.Drawing.Point(4, 34);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Size = new System.Drawing.Size(937, 522);
            this.tpOrders.TabIndex = 3;
            this.tpOrders.Text = "Orders";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // tpAuthor
            // 
            this.tpAuthor.Controls.Add(this.btaddauthor);
            this.tpAuthor.Controls.Add(this.dgv_Author);
            this.tpAuthor.Controls.Add(this.bt_searchauthor);
            this.tpAuthor.Controls.Add(this.tb_searchauthor);
            this.tpAuthor.Location = new System.Drawing.Point(4, 34);
            this.tpAuthor.Name = "tpAuthor";
            this.tpAuthor.Size = new System.Drawing.Size(937, 522);
            this.tpAuthor.TabIndex = 5;
            this.tpAuthor.Text = "Author";
            this.tpAuthor.UseVisualStyleBackColor = true;
            // 
            // btaddauthor
            // 
            this.btaddauthor.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btaddauthor.Location = new System.Drawing.Point(780, 9);
            this.btaddauthor.Name = "btaddauthor";
            this.btaddauthor.Size = new System.Drawing.Size(148, 35);
            this.btaddauthor.TabIndex = 18;
            this.btaddauthor.Text = "AddAuthor";
            this.btaddauthor.UseVisualStyleBackColor = true;
            this.btaddauthor.Click += new System.EventHandler(this.btaddauthor_Click);
            // 
            // dgv_Author
            // 
            this.dgv_Author.AllowUserToAddRows = false;
            this.dgv_Author.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Author.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acolauthor_ID,
            this.acolfirst_name,
            this.acollast_name,
            this.acolemail,
            this.acolphonenb,
            this.acolbt_view,
            this.acolrolename,
            this.acolperson_id});
            this.dgv_Author.Location = new System.Drawing.Point(8, 50);
            this.dgv_Author.Name = "dgv_Author";
            this.dgv_Author.Size = new System.Drawing.Size(920, 463);
            this.dgv_Author.TabIndex = 17;
            this.dgv_Author.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Author_CellContentClick);
            // 
            // acolauthor_ID
            // 
            this.acolauthor_ID.DataPropertyName = "author_ID";
            this.acolauthor_ID.HeaderText = "ID";
            this.acolauthor_ID.Name = "acolauthor_ID";
            this.acolauthor_ID.Width = 150;
            // 
            // acolfirst_name
            // 
            this.acolfirst_name.DataPropertyName = "first_name";
            this.acolfirst_name.HeaderText = "firstname";
            this.acolfirst_name.Name = "acolfirst_name";
            // 
            // acollast_name
            // 
            this.acollast_name.DataPropertyName = "last_name";
            this.acollast_name.HeaderText = "lastname";
            this.acollast_name.Name = "acollast_name";
            // 
            // acolemail
            // 
            this.acolemail.DataPropertyName = "email";
            this.acolemail.HeaderText = "email";
            this.acolemail.Name = "acolemail";
            this.acolemail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acolemail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.acolemail.Width = 200;
            // 
            // acolphonenb
            // 
            this.acolphonenb.DataPropertyName = "phonenb";
            this.acolphonenb.HeaderText = "phone";
            this.acolphonenb.Name = "acolphonenb";
            this.acolphonenb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.acolphonenb.Width = 200;
            // 
            // acolbt_view
            // 
            this.acolbt_view.DataPropertyName = "bt";
            this.acolbt_view.HeaderText = "";
            this.acolbt_view.Name = "acolbt_view";
            this.acolbt_view.Text = "Check";
            this.acolbt_view.Width = 120;
            // 
            // acolrolename
            // 
            this.acolrolename.DataPropertyName = "rolename";
            this.acolrolename.HeaderText = "rolename";
            this.acolrolename.Name = "acolrolename";
            this.acolrolename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acolrolename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.acolrolename.Visible = false;
            this.acolrolename.Width = 150;
            // 
            // acolperson_id
            // 
            this.acolperson_id.DataPropertyName = "person_id";
            this.acolperson_id.HeaderText = "personid";
            this.acolperson_id.Name = "acolperson_id";
            this.acolperson_id.Visible = false;
            // 
            // bt_searchauthor
            // 
            this.bt_searchauthor.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_searchauthor.Location = new System.Drawing.Point(509, 9);
            this.bt_searchauthor.Name = "bt_searchauthor";
            this.bt_searchauthor.Size = new System.Drawing.Size(122, 35);
            this.bt_searchauthor.TabIndex = 16;
            this.bt_searchauthor.Text = "Search";
            this.bt_searchauthor.UseVisualStyleBackColor = true;
            this.bt_searchauthor.Click += new System.EventHandler(this.bt_searchauthor_Click);
            // 
            // tb_searchauthor
            // 
            this.tb_searchauthor.Location = new System.Drawing.Point(10, 9);
            this.tb_searchauthor.Name = "tb_searchauthor";
            this.tb_searchauthor.Size = new System.Drawing.Size(494, 31);
            this.tb_searchauthor.TabIndex = 15;
            // 
            // tpBooks
            // 
            this.tpBooks.Controls.Add(this.cb_booktype);
            this.tpBooks.Controls.Add(this.bt_addbook);
            this.tpBooks.Controls.Add(this.dgv_books);
            this.tpBooks.Controls.Add(this.bt_search_book);
            this.tpBooks.Controls.Add(this.tb_sc_book);
            this.tpBooks.Location = new System.Drawing.Point(4, 34);
            this.tpBooks.Name = "tpBooks";
            this.tpBooks.Size = new System.Drawing.Size(937, 522);
            this.tpBooks.TabIndex = 6;
            this.tpBooks.Text = "Books";
            this.tpBooks.UseVisualStyleBackColor = true;
            // 
            // cb_booktype
            // 
            this.cb_booktype.FormattingEnabled = true;
            this.cb_booktype.Location = new System.Drawing.Point(8, 7);
            this.cb_booktype.Name = "cb_booktype";
            this.cb_booktype.Size = new System.Drawing.Size(310, 33);
            this.cb_booktype.TabIndex = 23;
            // 
            // bt_addbook
            // 
            this.bt_addbook.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_addbook.Location = new System.Drawing.Point(780, 5);
            this.bt_addbook.Name = "bt_addbook";
            this.bt_addbook.Size = new System.Drawing.Size(148, 35);
            this.bt_addbook.TabIndex = 22;
            this.bt_addbook.Text = "AddBook";
            this.bt_addbook.UseVisualStyleBackColor = true;
            this.bt_addbook.Click += new System.EventHandler(this.bt_addbook_Click);
            // 
            // dgv_books
            // 
            this.dgv_books.AllowUserToAddRows = false;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colISBN,
            this.colTitle,
            this.colbook_type_name,
            this.colYearPublished,
            this.colQOH,
            this.colUnitPrice,
            this.bt_view_book,
            this.colbook_id});
            this.dgv_books.Location = new System.Drawing.Point(8, 50);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.Size = new System.Drawing.Size(920, 463);
            this.dgv_books.TabIndex = 21;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            // 
            // colISBN
            // 
            this.colISBN.DataPropertyName = "ISBN";
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.Width = 150;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 150;
            // 
            // colbook_type_name
            // 
            this.colbook_type_name.DataPropertyName = "book_type_name";
            this.colbook_type_name.HeaderText = "Type";
            this.colbook_type_name.Name = "colbook_type_name";
            this.colbook_type_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbook_type_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colbook_type_name.Width = 200;
            // 
            // colYearPublished
            // 
            this.colYearPublished.DataPropertyName = "YearPublished";
            this.colYearPublished.HeaderText = "Year";
            this.colYearPublished.Name = "colYearPublished";
            this.colYearPublished.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colYearPublished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colYearPublished.Width = 80;
            // 
            // colQOH
            // 
            this.colQOH.DataPropertyName = "QOH";
            this.colQOH.HeaderText = "QOH";
            this.colQOH.Name = "colQOH";
            this.colQOH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "UPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // bt_view_book
            // 
            this.bt_view_book.DataPropertyName = "bt";
            this.bt_view_book.HeaderText = "";
            this.bt_view_book.Name = "bt_view_book";
            this.bt_view_book.Text = "Check";
            // 
            // colbook_id
            // 
            this.colbook_id.DataPropertyName = "book_id";
            this.colbook_id.HeaderText = "book_id";
            this.colbook_id.Name = "colbook_id";
            this.colbook_id.Visible = false;
            // 
            // bt_search_book
            // 
            this.bt_search_book.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_search_book.Location = new System.Drawing.Point(626, 5);
            this.bt_search_book.Name = "bt_search_book";
            this.bt_search_book.Size = new System.Drawing.Size(122, 35);
            this.bt_search_book.TabIndex = 20;
            this.bt_search_book.Text = "Search";
            this.bt_search_book.UseVisualStyleBackColor = true;
            this.bt_search_book.Click += new System.EventHandler(this.bt_search_book_Click);
            // 
            // tb_sc_book
            // 
            this.tb_sc_book.Location = new System.Drawing.Point(324, 7);
            this.tb_sc_book.Name = "tb_sc_book";
            this.tb_sc_book.Size = new System.Drawing.Size(296, 31);
            this.tb_sc_book.TabIndex = 19;
            // 
            // tpexit
            // 
            this.tpexit.Location = new System.Drawing.Point(4, 34);
            this.tpexit.Name = "tpexit";
            this.tpexit.Size = new System.Drawing.Size(937, 522);
            this.tpexit.TabIndex = 7;
            this.tpexit.Text = "Exit";
            this.tpexit.UseVisualStyleBackColor = true;
            // 
            // bookBizDBDataSet
            // 
            this.bookBizDBDataSet.DataSetName = "BookBizDBDataSet";
            this.bookBizDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBizDBDataSetBindingSource
            // 
            this.bookBizDBDataSetBindingSource.DataSource = this.bookBizDBDataSet;
            this.bookBizDBDataSetBindingSource.Position = 0;
            // 
            // dgv_order
            // 
            this.dgv_order.AllowUserToAddRows = false;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClientName,
            this.col_order_serial_number,
            this.coltotalprice,
            this.colordertime,
            this.colorderhandler,
            this.col_vieworder,
            this.colorder_id,
            this.ocolstate_order,
            this.ocolenterprise_id,
            this.ocolperson_id});
            this.dgv_order.Location = new System.Drawing.Point(8, 53);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.Size = new System.Drawing.Size(920, 462);
            this.dgv_order.TabIndex = 0;
            this.dgv_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellContentClick);
            // 
            // bt_addorder
            // 
            this.bt_addorder.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_addorder.Location = new System.Drawing.Point(806, 7);
            this.bt_addorder.Name = "bt_addorder";
            this.bt_addorder.Size = new System.Drawing.Size(122, 35);
            this.bt_addorder.TabIndex = 13;
            this.bt_addorder.Text = "New Order";
            this.bt_addorder.UseVisualStyleBackColor = true;
            this.bt_addorder.Click += new System.EventHandler(this.bt_addorder_Click);
            // 
            // tb_ordersearch
            // 
            this.tb_ordersearch.Location = new System.Drawing.Point(180, 9);
            this.tb_ordersearch.Name = "tb_ordersearch";
            this.tb_ordersearch.Size = new System.Drawing.Size(467, 31);
            this.tb_ordersearch.TabIndex = 14;
            // 
            // bt_searchorder
            // 
            this.bt_searchorder.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_searchorder.Location = new System.Drawing.Point(663, 7);
            this.bt_searchorder.Name = "bt_searchorder";
            this.bt_searchorder.Size = new System.Drawing.Size(122, 35);
            this.bt_searchorder.TabIndex = 15;
            this.bt_searchorder.Text = "Search";
            this.bt_searchorder.UseVisualStyleBackColor = true;
            this.bt_searchorder.Click += new System.EventHandler(this.bt_searchorder_Click);
            // 
            // cob_order_state
            // 
            this.cob_order_state.FormattingEnabled = true;
            this.cob_order_state.Location = new System.Drawing.Point(8, 9);
            this.cob_order_state.Name = "cob_order_state";
            this.cob_order_state.Size = new System.Drawing.Size(166, 33);
            this.cob_order_state.TabIndex = 16;
            // 
            // dcolenterprise_name
            // 
            this.dcolenterprise_name.DataPropertyName = "name";
            this.dcolenterprise_name.HeaderText = "name";
            this.dcolenterprise_name.Name = "dcolenterprise_name";
            this.dcolenterprise_name.Width = 250;
            // 
            // dcolcity
            // 
            this.dcolcity.DataPropertyName = "city";
            this.dcolcity.HeaderText = "city";
            this.dcolcity.Name = "dcolcity";
            this.dcolcity.Width = 150;
            // 
            // dcolenterprise_email
            // 
            this.dcolenterprise_email.DataPropertyName = "enterprise_email";
            this.dcolenterprise_email.HeaderText = "email";
            this.dcolenterprise_email.Name = "dcolenterprise_email";
            this.dcolenterprise_email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dcolenterprise_email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dcolenterprise_email.Width = 150;
            // 
            // dcolenterprise_phone
            // 
            this.dcolenterprise_phone.DataPropertyName = "enterprise_phone";
            this.dcolenterprise_phone.HeaderText = "phone";
            this.dcolenterprise_phone.Name = "dcolenterprise_phone";
            this.dcolenterprise_phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dcolenterprise_phone.Width = 150;
            // 
            // dcolbt_view_en
            // 
            this.dcolbt_view_en.DataPropertyName = "bt";
            this.dcolbt_view_en.HeaderText = "";
            this.dcolbt_view_en.Name = "dcolbt_view_en";
            this.dcolbt_view_en.Text = "Check";
            // 
            // dcolcredit_limit
            // 
            this.dcolcredit_limit.DataPropertyName = "credit_limit";
            this.dcolcredit_limit.HeaderText = "credit_limit";
            this.dcolcredit_limit.Name = "dcolcredit_limit";
            this.dcolcredit_limit.Visible = false;
            this.dcolcredit_limit.Width = 130;
            // 
            // dcolenterprise_fax
            // 
            this.dcolenterprise_fax.DataPropertyName = "enterprise_fax";
            this.dcolenterprise_fax.HeaderText = "enterprise_fax";
            this.dcolenterprise_fax.Name = "dcolenterprise_fax";
            this.dcolenterprise_fax.Visible = false;
            // 
            // dcolzip_code
            // 
            this.dcolzip_code.DataPropertyName = "zip_code";
            this.dcolzip_code.HeaderText = "zip_code";
            this.dcolzip_code.Name = "dcolzip_code";
            this.dcolzip_code.Visible = false;
            // 
            // dcolstreet
            // 
            this.dcolstreet.DataPropertyName = "street";
            this.dcolstreet.HeaderText = "street";
            this.dcolstreet.Name = "dcolstreet";
            this.dcolstreet.Visible = false;
            // 
            // dcolenterprise_id
            // 
            this.dcolenterprise_id.DataPropertyName = "enterprise_id";
            this.dcolenterprise_id.HeaderText = "enterprise_id";
            this.dcolenterprise_id.Name = "dcolenterprise_id";
            this.dcolenterprise_id.Visible = false;
            // 
            // dcolenterprise_type_id
            // 
            this.dcolenterprise_type_id.DataPropertyName = "enterprise_type_id";
            this.dcolenterprise_type_id.HeaderText = "enterprise_type_id";
            this.dcolenterprise_type_id.Name = "dcolenterprise_type_id";
            this.dcolenterprise_type_id.Visible = false;
            // 
            // colClientName
            // 
            this.colClientName.DataPropertyName = "name";
            this.colClientName.HeaderText = "ClientName";
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            this.colClientName.Width = 200;
            // 
            // col_order_serial_number
            // 
            this.col_order_serial_number.DataPropertyName = "order_serial_number";
            this.col_order_serial_number.HeaderText = "OSNB";
            this.col_order_serial_number.Name = "col_order_serial_number";
            this.col_order_serial_number.ReadOnly = true;
            this.col_order_serial_number.Width = 250;
            // 
            // coltotalprice
            // 
            this.coltotalprice.DataPropertyName = "totalprice";
            this.coltotalprice.HeaderText = "Price";
            this.coltotalprice.Name = "coltotalprice";
            this.coltotalprice.ReadOnly = true;
            // 
            // colordertime
            // 
            this.colordertime.DataPropertyName = "order_time";
            this.colordertime.HeaderText = "OrderTime";
            this.colordertime.Name = "colordertime";
            this.colordertime.ReadOnly = true;
            this.colordertime.Width = 140;
            // 
            // colorderhandler
            // 
            this.colorderhandler.DataPropertyName = "first_name";
            this.colorderhandler.HeaderText = "Handler";
            this.colorderhandler.Name = "colorderhandler";
            this.colorderhandler.ReadOnly = true;
            // 
            // col_vieworder
            // 
            this.col_vieworder.DataPropertyName = "bt";
            this.col_vieworder.HeaderText = "View";
            this.col_vieworder.Name = "col_vieworder";
            this.col_vieworder.ReadOnly = true;
            this.col_vieworder.Width = 80;
            // 
            // colorder_id
            // 
            this.colorder_id.DataPropertyName = "order_id";
            this.colorder_id.HeaderText = "order_id";
            this.colorder_id.Name = "colorder_id";
            this.colorder_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colorder_id.Visible = false;
            // 
            // ocolstate_order
            // 
            this.ocolstate_order.DataPropertyName = "state_order";
            this.ocolstate_order.HeaderText = "state_order";
            this.ocolstate_order.Name = "ocolstate_order";
            this.ocolstate_order.Visible = false;
            // 
            // ocolenterprise_id
            // 
            this.ocolenterprise_id.DataPropertyName = "enterprise_id";
            this.ocolenterprise_id.HeaderText = "enterprise_id";
            this.ocolenterprise_id.Name = "ocolenterprise_id";
            this.ocolenterprise_id.Visible = false;
            // 
            // ocolperson_id
            // 
            this.ocolperson_id.DataPropertyName = "person_id";
            this.ocolperson_id.HeaderText = "person_id";
            this.ocolperson_id.Name = "ocolperson_id";
            this.ocolperson_id.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.tpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.tpEmployee.ResumeLayout(false);
            this.tpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.tpClients.ResumeLayout(false);
            this.tpClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            this.tpPublishers.ResumeLayout(false);
            this.tpPublishers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpublishers)).EndInit();
            this.tpOrders.ResumeLayout(false);
            this.tpOrders.PerformLayout();
            this.tpAuthor.ResumeLayout(false);
            this.tpAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Author)).EndInit();
            this.tpBooks.ResumeLayout(false);
            this.tpBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBizDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBizDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.TabPage tpEmployee;
        private System.Windows.Forms.TabPage tpClients;
        private System.Windows.Forms.TabPage tpPublishers;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.TabPage tpAuthor;
        private System.Windows.Forms.TabPage tpBooks;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.BindingSource bookBizDBDataSetBindingSource;
        private BookBizDBDataSet bookBizDBDataSet;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbsearch1;
        private System.Windows.Forms.ComboBox cborolename;
        private System.Windows.Forms.Button btAdduser;
        private System.Windows.Forms.TabPage tpexit;
        private System.Windows.Forms.DataGridView dgv_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colfirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colrolename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colphonenb;
        private System.Windows.Forms.DataGridViewButtonColumn Colbutview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colpersonid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolfirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcollastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolrolename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolphone;
        private System.Windows.Forms.DataGridViewButtonColumn dcolbutview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolpersonid;
        private System.Windows.Forms.Button btaddemployee;
        private System.Windows.Forms.Button bt_addclient;
        private System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.Button btsearch_clients;
        private System.Windows.Forms.TextBox tb_searchclient;
        private System.Windows.Forms.Button btaddPub;
        private System.Windows.Forms.DataGridView dvgpublishers;
        private System.Windows.Forms.Button btsearchP;
        private System.Windows.Forms.TextBox tb_searchp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenterprise_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenterprise_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenterprise_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcredit_limit;
        private System.Windows.Forms.DataGridViewButtonColumn colbt_view_en;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenterprise_fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colzip_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenterprise_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenterprise_type_id;
        private System.Windows.Forms.Button btaddauthor;
        private System.Windows.Forms.DataGridView dgv_Author;
        private System.Windows.Forms.Button bt_searchauthor;
        private System.Windows.Forms.TextBox tb_searchauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn acolauthor_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn acolfirst_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn acollast_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn acolemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn acolphonenb;
        private System.Windows.Forms.DataGridViewButtonColumn acolbt_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn acolrolename;
        private System.Windows.Forms.DataGridViewTextBoxColumn acolperson_id;
        private System.Windows.Forms.ComboBox cb_booktype;
        private System.Windows.Forms.Button bt_addbook;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Button bt_search_book;
        private System.Windows.Forms.TextBox tb_sc_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbook_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYearPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQOH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewButtonColumn bt_view_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbook_id;
        private System.Windows.Forms.Button bt_searchorder;
        private System.Windows.Forms.TextBox tb_ordersearch;
        private System.Windows.Forms.Button bt_addorder;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.ComboBox cob_order_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolenterprise_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolenterprise_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolenterprise_phone;
        private System.Windows.Forms.DataGridViewButtonColumn dcolbt_view_en;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolcredit_limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolenterprise_fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolzip_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolstreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolenterprise_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolenterprise_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_order_serial_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltotalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colordertime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorderhandler;
        private System.Windows.Forms.DataGridViewButtonColumn col_vieworder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorder_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocolstate_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocolenterprise_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocolperson_id;
    }
}