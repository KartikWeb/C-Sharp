using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEEmployee_Mgt_frame
{
    public partial class frm_MDI : Form
    {
        public frm_MDI()
        {
            InitializeComponent();
        }

        private void addStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddStudentDetails Obj = new frm_AddStudentDetails();
            Obj.MdiParent = this;
            Obj.Show();

        }

        private void studentEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Studentenquiry Obj = new frm_Studentenquiry();
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void studentUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Student_Update Obj = new frm_Student_Update();
            Obj.MdiParent = this;
            Obj.Show();
        }

        /* private void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
{
frm_Login obj = new frm_Login();
obj.Show();
} */
    }
}
