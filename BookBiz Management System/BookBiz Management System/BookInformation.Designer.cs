namespace BookBiz_Management_System
{
    partial class BookInformation
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
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.tb_bookname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.lbyear = new System.Windows.Forms.Label();
            this.dateTimePicker_pu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_uprice = new System.Windows.Forms.TextBox();
            this.tb_QOH = new System.Windows.Forms.TextBox();
            this.lbQOH = new System.Windows.Forms.Label();
            this.dgv_publishers = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colenterprise_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_selPub = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_en_id = new System.Windows.Forms.Label();
            this.dgv_authors = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btsubmit = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.LBauthor = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btdelete = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.bt_addau = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btadden = new System.Windows.Forms.Button();
            this.colfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colauthor_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbt_add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colperson_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_publishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_authors)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_type
            // 
            this.cmb_type.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(78, 156);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(361, 33);
            this.cmb_type.TabIndex = 35;
            // 
            // tb_bookname
            // 
            this.tb_bookname.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_bookname.Location = new System.Drawing.Point(76, 50);
            this.tb_bookname.Name = "tb_bookname";
            this.tb_bookname.Size = new System.Drawing.Size(363, 31);
            this.tb_bookname.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "ISBN";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_ISBN.Location = new System.Drawing.Point(78, 100);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(361, 31);
            this.tb_ISBN.TabIndex = 37;
            // 
            // lbyear
            // 
            this.lbyear.AutoSize = true;
            this.lbyear.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbyear.Location = new System.Drawing.Point(14, 213);
            this.lbyear.Name = "lbyear";
            this.lbyear.Size = new System.Drawing.Size(56, 25);
            this.lbyear.TabIndex = 38;
            this.lbyear.Text = "Year";
            // 
            // dateTimePicker_pu
            // 
            this.dateTimePicker_pu.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_pu.Location = new System.Drawing.Point(78, 208);
            this.dateTimePicker_pu.Name = "dateTimePicker_pu";
            this.dateTimePicker_pu.Size = new System.Drawing.Size(238, 31);
            this.dateTimePicker_pu.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "UnitPrice";
            // 
            // tb_uprice
            // 
            this.tb_uprice.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_uprice.Location = new System.Drawing.Point(141, 261);
            this.tb_uprice.Name = "tb_uprice";
            this.tb_uprice.Size = new System.Drawing.Size(175, 31);
            this.tb_uprice.TabIndex = 41;
            this.tb_uprice.Text = "0.00";
            // 
            // tb_QOH
            // 
            this.tb_QOH.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_QOH.Location = new System.Drawing.Point(141, 318);
            this.tb_QOH.Name = "tb_QOH";
            this.tb_QOH.Size = new System.Drawing.Size(175, 31);
            this.tb_QOH.TabIndex = 43;
            this.tb_QOH.Text = "0";
            // 
            // lbQOH
            // 
            this.lbQOH.AutoSize = true;
            this.lbQOH.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQOH.Location = new System.Drawing.Point(12, 318);
            this.lbQOH.Name = "lbQOH";
            this.lbQOH.Size = new System.Drawing.Size(60, 25);
            this.lbQOH.TabIndex = 42;
            this.lbQOH.Text = "QOH";
            // 
            // dgv_publishers
            // 
            this.dgv_publishers.AllowUserToAddRows = false;
            this.dgv_publishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_publishers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.coladd,
            this.colenterprise_id});
            this.dgv_publishers.Location = new System.Drawing.Point(476, 78);
            this.dgv_publishers.Name = "dgv_publishers";
            this.dgv_publishers.Size = new System.Drawing.Size(243, 150);
            this.dgv_publishers.TabIndex = 44;
            this.dgv_publishers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_publishers_CellContentClick);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // coladd
            // 
            this.coladd.DataPropertyName = "bt";
            this.coladd.HeaderText = "";
            this.coladd.Name = "coladd";
            // 
            // colenterprise_id
            // 
            this.colenterprise_id.DataPropertyName = "enterprise_id";
            this.colenterprise_id.HeaderText = "enterprise_id";
            this.colenterprise_id.Name = "colenterprise_id";
            this.colenterprise_id.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Publishers List";
            // 
            // tb_selPub
            // 
            this.tb_selPub.Enabled = false;
            this.tb_selPub.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_selPub.Location = new System.Drawing.Point(769, 158);
            this.tb_selPub.Name = "tb_selPub";
            this.tb_selPub.Size = new System.Drawing.Size(280, 31);
            this.tb_selPub.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(816, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Selected Publisher";
            // 
            // lb_en_id
            // 
            this.lb_en_id.AutoSize = true;
            this.lb_en_id.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_en_id.Location = new System.Drawing.Point(961, 9);
            this.lb_en_id.Name = "lb_en_id";
            this.lb_en_id.Size = new System.Drawing.Size(133, 25);
            this.lb_en_id.TabIndex = 49;
            this.lb_en_id.Text = "enterprise_id";
            this.lb_en_id.Visible = false;
            // 
            // dgv_authors
            // 
            this.dgv_authors.AllowUserToAddRows = false;
            this.dgv_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_authors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colfirstname,
            this.collastname,
            this.colauthor_ID,
            this.colbt_add,
            this.colperson_id});
            this.dgv_authors.Location = new System.Drawing.Point(476, 283);
            this.dgv_authors.Name = "dgv_authors";
            this.dgv_authors.Size = new System.Drawing.Size(424, 219);
            this.dgv_authors.TabIndex = 50;
            this.dgv_authors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_authors_CellContentClick);
            this.dgv_authors.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_authors_CellEndEdit);
            this.dgv_authors.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_authors_CellValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Authors List";
            // 
            // btsubmit
            // 
            this.btsubmit.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btsubmit.Location = new System.Drawing.Point(76, 467);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(100, 35);
            this.btsubmit.TabIndex = 52;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // btcancel
            // 
            this.btcancel.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btcancel.Location = new System.Drawing.Point(348, 467);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(100, 35);
            this.btcancel.TabIndex = 54;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btreset
            // 
            this.btreset.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btreset.Location = new System.Drawing.Point(216, 467);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(100, 35);
            this.btreset.TabIndex = 53;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // LBauthor
            // 
            this.LBauthor.FormattingEnabled = true;
            this.LBauthor.Location = new System.Drawing.Point(918, 283);
            this.LBauthor.Name = "LBauthor";
            this.LBauthor.Size = new System.Drawing.Size(176, 134);
            this.LBauthor.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(924, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Choose Authors";
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btdelete.Location = new System.Drawing.Point(918, 446);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(80, 35);
            this.btdelete.TabIndex = 57;
            this.btdelete.Text = "delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btclear
            // 
            this.btclear.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btclear.Location = new System.Drawing.Point(1017, 446);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(77, 35);
            this.btclear.TabIndex = 58;
            this.btclear.Text = "clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // bt_addau
            // 
            this.bt_addau.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_addau.Location = new System.Drawing.Point(786, 236);
            this.bt_addau.Name = "bt_addau";
            this.bt_addau.Size = new System.Drawing.Size(114, 35);
            this.bt_addau.TabIndex = 59;
            this.bt_addau.Text = "addauthor";
            this.bt_addau.UseVisualStyleBackColor = true;
            this.bt_addau.Click += new System.EventHandler(this.bt_addau_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_refresh.Location = new System.Drawing.Point(678, 236);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(87, 35);
            this.bt_refresh.TabIndex = 60;
            this.bt_refresh.Text = "refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(786, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 62;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btadden
            // 
            this.btadden.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btadden.Location = new System.Drawing.Point(929, 56);
            this.btadden.Name = "btadden";
            this.btadden.Size = new System.Drawing.Size(138, 35);
            this.btadden.TabIndex = 61;
            this.btadden.Text = "addpublish";
            this.btadden.UseVisualStyleBackColor = true;
            this.btadden.Click += new System.EventHandler(this.btadden_Click);
            // 
            // colfirstname
            // 
            this.colfirstname.DataPropertyName = "first_name";
            this.colfirstname.HeaderText = "firstname";
            this.colfirstname.Name = "colfirstname";
            // 
            // collastname
            // 
            this.collastname.DataPropertyName = "last_name";
            this.collastname.HeaderText = "lastname";
            this.collastname.Name = "collastname";
            // 
            // colauthor_ID
            // 
            this.colauthor_ID.DataPropertyName = "author_ID";
            this.colauthor_ID.HeaderText = "author_ID";
            this.colauthor_ID.Name = "colauthor_ID";
            // 
            // colbt_add
            // 
            this.colbt_add.DataPropertyName = "bt";
            this.colbt_add.HeaderText = "";
            this.colbt_add.Name = "colbt_add";
            this.colbt_add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbt_add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colperson_id
            // 
            this.colperson_id.DataPropertyName = "person_id";
            this.colperson_id.HeaderText = "person_id";
            this.colperson_id.Name = "colperson_id";
            this.colperson_id.Visible = false;
            // 
            // BookInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btadden);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.bt_addau);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LBauthor);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_authors);
            this.Controls.Add(this.lb_en_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_selPub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_publishers);
            this.Controls.Add(this.tb_QOH);
            this.Controls.Add(this.lbQOH);
            this.Controls.Add(this.tb_uprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_pu);
            this.Controls.Add(this.lbyear);
            this.Controls.Add(this.tb_ISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.tb_bookname);
            this.Controls.Add(this.label3);
            this.Name = "BookInformation";
            this.Text = "bookinformation";
            this.Load += new System.EventHandler(this.BookInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_publishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_authors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.TextBox tb_bookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Label lbyear;
        private System.Windows.Forms.DateTimePicker dateTimePicker_pu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_uprice;
        private System.Windows.Forms.TextBox tb_QOH;
        private System.Windows.Forms.Label lbQOH;
        private System.Windows.Forms.DataGridView dgv_publishers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_selPub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_en_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewButtonColumn coladd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenterprise_id;
        private System.Windows.Forms.DataGridView dgv_authors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.ListBox LBauthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button bt_addau;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btadden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn collastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colauthor_ID;
        private System.Windows.Forms.DataGridViewButtonColumn colbt_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn colperson_id;
    }
}