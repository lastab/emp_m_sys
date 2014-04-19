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
        //variables
        int data_number;
        int total_data;

        public frmBranch()
        {
            InitializeComponent();
        }

        private void frmBranch_Load(object sender, EventArgs e)
        {

            ////////////////////////////////////////////
            total_data = 10;
            /////////////////////////

            data_number = 1;
            Display_data();
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


        //function to display data
        private void Display_data()
        {
            lblposition.Text = data_number + " of " + total_data;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (total_data != 0)
                data_number = (data_number + 1);
            if (data_number > total_data)
                data_number = 1;
            Display_data();
        }

        private void btn_pevious_Click(object sender, EventArgs e)
        {
            if (total_data != 0)
                data_number = (data_number - 1);
            if (data_number == 0)
                data_number = total_data;
            Display_data();
        }
    }
}
