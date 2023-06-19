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
    public partial class frm_Studentenquiry : Form
    {
        public frm_Studentenquiry()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_AddStudentDetails Obj = new frm_AddStudentDetails();
            Obj.Show();
            this.Hide();

        }

        private void pb_Back1_Click(object sender, EventArgs e)
        {
            frm_AddStudentDetails Obj = new frm_AddStudentDetails();
            Obj.Show();
            this.Hide();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Username1.Text = Share_Class.Username;

        }

      

        private void frm_Studentenquiry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter3.Fill(this.studentDataSet1.Student_Details);
            tb_Username1.Text = Share_Class.Username;

        }

        private void btn_Sreach_Click(object sender, EventArgs e)
        {
            frm_Student_Update Obj = new frm_Student_Update();
            Obj.Show();
            this.Hide();
        }
    }
}
