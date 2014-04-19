namespace WindowsFormsApplication1
{
    partial class frmBranch
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
            this.txtB_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB_address = new System.Windows.Forms.TextBox();
            this.btn_pevious = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lblposition = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtB_id
            // 
            this.txtB_id.Location = new System.Drawing.Point(106, 59);
            this.txtB_id.Name = "txtB_id";
            this.txtB_id.Size = new System.Drawing.Size(100, 20);
            this.txtB_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Branch Name";
            // 
            // txtB_name
            // 
            this.txtB_name.Location = new System.Drawing.Point(106, 95);
            this.txtB_name.Name = "txtB_name";
            this.txtB_name.Size = new System.Drawing.Size(100, 20);
            this.txtB_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // txtB_phone
            // 
            this.txtB_phone.Location = new System.Drawing.Point(106, 137);
            this.txtB_phone.MaxLength = 14;
            this.txtB_phone.Name = "txtB_phone";
            this.txtB_phone.Size = new System.Drawing.Size(100, 20);
            this.txtB_phone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // txtB_address
            // 
            this.txtB_address.Location = new System.Drawing.Point(106, 176);
            this.txtB_address.Name = "txtB_address";
            this.txtB_address.Size = new System.Drawing.Size(191, 20);
            this.txtB_address.TabIndex = 6;
            // 
            // btn_pevious
            // 
            this.btn_pevious.Location = new System.Drawing.Point(36, 258);
            this.btn_pevious.Name = "btn_pevious";
            this.btn_pevious.Size = new System.Drawing.Size(75, 23);
            this.btn_pevious.TabIndex = 8;
            this.btn_pevious.Text = "Previous";
            this.btn_pevious.UseVisualStyleBackColor = true;
            this.btn_pevious.Click += new System.EventHandler(this.btn_pevious_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(179, 258);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 9;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Location = new System.Drawing.Point(117, 263);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(35, 13);
            this.lblposition.TabIndex = 10;
            this.lblposition.Text = "label5";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(36, 218);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(120, 218);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(201, 218);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(249, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 337);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pevious);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_id);
            this.Name = "frmBranch";
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.frmBranch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB_address;
        private System.Windows.Forms.Button btn_pevious;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btnSave;
    }
}