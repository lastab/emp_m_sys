using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPost : Form
    {
        public frmPost()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtP_id.Enabled == false)
            {
                //function to insert data to database
            }
            else 
            {
                //function to update data to database
            }


            modify_complete();
        }



        private void modify()
        {
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            btn_add.Enabled = false;
            btn_next.Enabled = false;
            btn_pevious.Enabled = false;
            //disable textbox here

            txtP_name.Enabled = true;
            txtP_salary .Enabled = true;   

        }
        private void modify_complete()
        {
            btnSave.Enabled = false;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_add.Enabled = true;
            btn_next.Enabled = true;
            btn_pevious.Enabled = true;
            //Enable text box here
            txtP_name.Enabled = false;
            txtP_id .Enabled = false;
            txtP_salary .Enabled = false;
        }

        private void frmPost_Load(object sender, EventArgs e)
        {
            modify_complete();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            modify();
            txtP_id.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            modify();
        }
    }
}
