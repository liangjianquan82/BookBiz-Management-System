namespace BookBiz_Management_System
{
    partial class Authorinformation
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
            this.btremoveperson = new System.Windows.Forms.Button();
            this.lbtitleauthorinfo = new System.Windows.Forms.Label();
            this.btcancel = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btsubmit = new System.Windows.Forms.Button();
            this.tb_Author_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btremoveperson
            // 
            this.btremoveperson.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btremoveperson.Location = new System.Drawing.Point(662, 22);
            this.btremoveperson.Name = "btremoveperson";
            this.btremoveperson.Size = new System.Drawing.Size(100, 35);
            this.btremoveperson.TabIndex = 41;
            this.btremoveperson.Text = "Remove";
            this.btremoveperson.UseVisualStyleBackColor = true;
            this.btremoveperson.Visible = false;
            this.btremoveperson.Click += new System.EventHandler(this.btremoveperson_Click);
            // 
            // lbtitleauthorinfo
            // 
            this.lbtitleauthorinfo.AutoSize = true;
            this.lbtitleauthorinfo.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitleauthorinfo.Location = new System.Drawing.Point(279, 22);
            this.lbtitleauthorinfo.Name = "lbtitleauthorinfo";
            this.lbtitleauthorinfo.Size = new System.Drawing.Size(192, 25);
            this.lbtitleauthorinfo.TabIndex = 40;
            this.lbtitleauthorinfo.Text = "Author Information";
            // 
            // btcancel
            // 
            this.btcancel.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btcancel.Location = new System.Drawing.Point(552, 334);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(100, 35);
            this.btcancel.TabIndex = 39;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btreset
            // 
            this.btreset.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btreset.Location = new System.Drawing.Point(352, 334);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(100, 35);
            this.btreset.TabIndex = 38;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btsubmit
            // 
            this.btsubmit.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btsubmit.Location = new System.Drawing.Point(152, 334);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(100, 35);
            this.btsubmit.TabIndex = 37;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // tb_Author_ID
            // 
            this.tb_Author_ID.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_Author_ID.Location = new System.Drawing.Point(164, 187);
            this.tb_Author_ID.Name = "tb_Author_ID";
            this.tb_Author_ID.Size = new System.Drawing.Size(202, 31);
            this.tb_Author_ID.TabIndex = 35;
            this.tb_Author_ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Author_ID_MouseClick_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "AuthorID";
            // 
            // cmb_role
            // 
            this.cmb_role.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(584, 185);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(202, 33);
            this.cmb_role.TabIndex = 32;
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_phone.Location = new System.Drawing.Point(584, 140);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(202, 31);
            this.tb_phone.TabIndex = 31;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_email.Location = new System.Drawing.Point(584, 87);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(202, 31);
            this.tb_email.TabIndex = 30;
            this.tb_email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_email_MouseClick);
            // 
            // tb_lastname
            // 
            this.tb_lastname.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_lastname.Location = new System.Drawing.Point(164, 137);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(202, 31);
            this.tb_lastname.TabIndex = 29;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_firstname.Location = new System.Drawing.Point(164, 87);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(202, 31);
            this.tb_firstname.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "First name";
            // 
            // Authorinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btremoveperson);
            this.Controls.Add(this.lbtitleauthorinfo);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.tb_Author_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Authorinformation";
            this.Text = "Authorinformation";
            this.Load += new System.EventHandler(this.Authorinformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btremoveperson;
        private System.Windows.Forms.Label lbtitleauthorinfo;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.TextBox tb_Author_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}