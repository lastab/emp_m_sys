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
    public partial class frmBranch : Form
    {
        public frmBranch()
        {
            InitializeComponent();
        }

        private void frmBranch_Load(object sender, EventArgs e)
        {
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

            txtB_name.Enabled = true;
            txtB_address.Enabled = true;
            txtB_phone.Enabled = true;

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
            txtB_name.Enabled = false ;
            txtB_address.Enabled = false ;
            txtB_phone.Enabled = false ;
            txtB_id.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtB_id.Enabled == true)
            {
                //function to insert data in database            
            }
            else 
            {
                //function to update data in database
            }
            
            modify_complete();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txtB_id.Enabled = true;
            modify();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            modify();
        }

    }
}
