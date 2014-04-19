namespace WindowsFormsApplication1
{
    partial class frmEmployee
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lblposition = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pevious = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtE_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtE_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtE_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtE_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBranch = new System.Windows.Forms.ComboBox();
            this.cbo_Post = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lblB_address = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblB_phone = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtE_sex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(297, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(297, 156);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(297, 127);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(297, 95);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Location = new System.Drawing.Point(154, 415);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(35, 13);
            this.lblposition.TabIndex = 25;
            this.lblposition.Text = "label5";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(216, 410);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 24;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pevious
            // 
            this.btn_pevious.Location = new System.Drawing.Point(73, 410);
            this.btn_pevious.Name = "btn_pevious";
            this.btn_pevious.Size = new System.Drawing.Size(75, 23);
            this.btn_pevious.TabIndex = 23;
            this.btn_pevious.Text = "Previous";
            this.btn_pevious.UseVisualStyleBackColor = true;
            this.btn_pevious.Click += new System.EventHandler(this.btn_pevious_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Address";
            // 
            // txtE_address
            // 
            this.txtE_address.Location = new System.Drawing.Point(154, 230);
            this.txtE_address.Name = "txtE_address";
            this.txtE_address.Size = new System.Drawing.Size(191, 20);
            this.txtE_address.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Phone Number";
            // 
            // txtE_phone
            // 
            this.txtE_phone.Location = new System.Drawing.Point(154, 191);
            this.txtE_phone.MaxLength = 14;
            this.txtE_phone.Name = "txtE_phone";
            this.txtE_phone.Size = new System.Drawing.Size(100, 20);
            this.txtE_phone.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Employee_name";
            // 
            // txtE_name
            // 
            this.txtE_name.Location = new System.Drawing.Point(154, 98);
            this.txtE_name.Name = "txtE_name";
            this.txtE_name.Size = new System.Drawing.Size(100, 20);
            this.txtE_name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee_ID";
            // 
            // txtE_ID
            // 
            this.txtE_ID.Location = new System.Drawing.Point(154, 62);
            this.txtE_ID.Name = "txtE_ID";
            this.txtE_ID.Size = new System.Drawing.Size(100, 20);
            this.txtE_ID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Branch";
            // 
            // cboBranch
            // 
            this.cboBranch.FormattingEnabled = true;
            this.cboBranch.Location = new System.Drawing.Point(152, 335);
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(121, 21);
            this.cboBranch.TabIndex = 35;
            // 
            // cbo_Post
            // 
            this.cbo_Post.FormattingEnabled = true;
            this.cbo_Post.Location = new System.Drawing.Point(154, 273);
            this.cbo_Post.Name = "cbo_Post";
            this.cbo_Post.Size = new System.Drawing.Size(121, 21);
            this.cbo_Post.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Post";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Salary";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Location = new System.Drawing.Point(151, 306);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(36, 13);
            this.lbl_Salary.TabIndex = 40;
            this.lbl_Salary.Text = "Salary";
            // 
            // lblB_address
            // 
            this.lblB_address.AutoSize = true;
            this.lblB_address.Location = new System.Drawing.Point(151, 362);
            this.lblB_address.Name = "lblB_address";
            this.lblB_address.Size = new System.Drawing.Size(36, 13);
            this.lblB_address.TabIndex = 42;
            this.lblB_address.Text = "Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Branch Address";
            // 
            // lblB_phone
            // 
            this.lblB_phone.AutoSize = true;
            this.lblB_phone.Location = new System.Drawing.Point(150, 384);
            this.lblB_phone.Name = "lblB_phone";
            this.lblB_phone.Size = new System.Drawing.Size(36, 13);
            this.lblB_phone.TabIndex = 44;
            this.lblB_phone.Text = "Salary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Branch Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Gender";
            // 
            // txtE_sex
            // 
            this.txtE_sex.Location = new System.Drawing.Point(154, 134);
            this.txtE_sex.Name = "txtE_sex";
            this.txtE_sex.Size = new System.Drawing.Size(100, 20);
            this.txtE_sex.TabIndex = 45;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 437);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtE_sex);
            this.Controls.Add(this.lblB_phone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblB_address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_Post);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboBranch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pevious);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtE_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtE_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtE_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtE_ID);
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pevious;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtE_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtE_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtE_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtE_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.ComboBox cbo_Post;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lblB_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblB_phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtE_sex;
    }
}