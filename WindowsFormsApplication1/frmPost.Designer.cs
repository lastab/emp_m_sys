namespace WindowsFormsApplication1
{
    partial class frmPost
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtP_salary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtP_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(218, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(170, 178);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(89, 178);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(5, 178);
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
            this.lblposition.Location = new System.Drawing.Point(86, 223);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(35, 13);
            this.lblposition.TabIndex = 25;
            this.lblposition.Text = "label5";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(148, 218);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 24;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pevious
            // 
            this.btn_pevious.Location = new System.Drawing.Point(5, 218);
            this.btn_pevious.Name = "btn_pevious";
            this.btn_pevious.Size = new System.Drawing.Size(75, 23);
            this.btn_pevious.TabIndex = 23;
            this.btn_pevious.Text = "Previous";
            this.btn_pevious.UseVisualStyleBackColor = true;
            this.btn_pevious.Click += new System.EventHandler(this.btn_pevious_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Salary(Rs.)";
            // 
            // txtP_salary
            // 
            this.txtP_salary.Location = new System.Drawing.Point(75, 97);
            this.txtP_salary.MaxLength = 22;
            this.txtP_salary.Name = "txtP_salary";
            this.txtP_salary.Size = new System.Drawing.Size(100, 20);
            this.txtP_salary.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Post Name";
            // 
            // txtP_name
            // 
            this.txtP_name.Location = new System.Drawing.Point(75, 55);
            this.txtP_name.Name = "txtP_name";
            this.txtP_name.Size = new System.Drawing.Size(100, 20);
            this.txtP_name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Post ID";
            // 
            // txtP_id
            // 
            this.txtP_id.Location = new System.Drawing.Point(75, 19);
            this.txtP_id.Name = "txtP_id";
            this.txtP_id.Size = new System.Drawing.Size(100, 20);
            this.txtP_id.TabIndex = 15;
            // 
            // frmPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 295);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pevious);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtP_salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP_id);
            this.Name = "frmPost";
            this.Text = "frm_Post";
            this.Load += new System.EventHandler(this.frmPost_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtP_salary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtP_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP_id;
    }
}