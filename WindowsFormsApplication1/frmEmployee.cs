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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
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

            txtE_address .Enabled = true;
            txtE_name .Enabled = true;
            txtE_phone.Enabled = true;
            cboBranch.Enabled = true;
            cbo_Post.Enabled = true;

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
            txtE_name.Enabled = false;
            txtE_ID.Enabled = false;
            txtE_address.Enabled = false;
            txtE_phone.Enabled = false;
            cbo_Post.Enabled = false;
            cboBranch.Enabled = false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtE_ID.Enabled == true)
            {
                //function to insert data here
            }
            else
            { 
                //function to update data here
            }
            modify_complete ();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            modify_complete();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txtE_ID.Enabled = true;
            modify();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            modify();
        }
    }
}
