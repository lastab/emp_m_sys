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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm_employee = new frmEmployee();
            frm_employee.MdiParent = this;
            frm_employee.Show();
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBranch frm_Branch = new frmBranch();
            frm_Branch.MdiParent= this;
            frm_Branch.Show();
        }

        private void postToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPost frm_Post = new frmPost();
            frm_Post.MdiParent = this;
            frm_Post.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
