using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace EEEmployee_Mgt_frame
{
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@" Data Source=DESKTOP-OQ5RLJA;Initial Catalog=Student;Integrated Security=True ");


        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();

            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }




        private void btn_btnlogin_Click(object sender, EventArgs e)
        {

            int Cnt = 0;
            Con_Open();


            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = " Select Count(*) from Login_Details Where Username =@Username and Password =@Password";
            Cmd.Parameters.Add("Username", SqlDbType.VarChar).Value = txt_Username.Text;
            Cmd.Parameters.Add("Password", SqlDbType.NVarChar).Value = txt_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {

                Share_Class.Username = txt_Username.Text;
                MessageBox.Show("Login Completely", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                frm_AddStudentDetails Obj = new frm_AddStudentDetails();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = " Invalid Password or Username";
                lbl_Error.ForeColor = Color.Lime;
            }

            Con_Close();

        }

       private void btn_Exit_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(" Are You Sure To Exit Application . ", " Error Message ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); 

            Application.Exit();

        }

        private void pic_Instagram_Click(object sender, EventArgs e)
        {

            string websiteUrl = "https://www.instagram.com"; // This is the method to redirect user to any website only changing the desired web link .
            Process.Start(websiteUrl);

        }

        private void pic_Whatsup_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://api.whatsapp.com/send?phone=1234567890";
            Process.Start(websiteUrl);
        }

        private void pic_Facebook_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.facebook.com";
            Process.Start(websiteUrl);
        }



        private void Ony_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;

            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }



    }
}