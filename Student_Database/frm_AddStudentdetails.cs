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

namespace EEEmployee_Mgt_frame
{
    public partial class frm_AddStudentDetails : Form
    {
        public frm_AddStudentDetails()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-OQ5RLJA;Initial Catalog=Student;Integrated Security=True");   //   Connection Control  

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();

            }
        }
        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Clear_Controls()   
        {
           
            txt_Mobile_Number.Clear();
            txt_Name.Clear();
            dpt_DateTimePicker.Text = "8-6-2023";
            cmb_Course.SelectedIndex = -1;

            txt_Id.Focus();
        }

        void Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Student_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = " Select Max (Id) from Student_Details ";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                txt_Id.Text = Convert.ToString(Cnt + 1);

            }
            else
            {
               Cnt = 1;
               txt_Id.Text = Convert.ToString(Cnt + 1);

            }
            Con_Close();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            

            if(txt_Id.Text !="" && txt_Name.Text !="" && txt_Mobile_Number.Text !="" && cmb_Course.Text !="")
            {
                SqlCommand Obj = new SqlCommand();
                Obj.Connection = Con;
                Obj.CommandText = "Insert into Student_Details Values(@Id,@Name,@Mobile_Number,@Date,@Course)";

                Obj.Parameters.Add("Id", SqlDbType.Int).Value = txt_Id.Text;
                Obj.Parameters.Add("Name", SqlDbType.VarChar).Value = txt_Name.Text;
                Obj.Parameters.Add("Mobile_Number", SqlDbType.Decimal).Value = txt_Mobile_Number.Text;
                Obj.Parameters.Add("Date", SqlDbType.Date).Value = dpt_DateTimePicker.Value.Date;
                Obj.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                 Obj.ExecuteNonQuery();

                MessageBox.Show(" Mission Completely ...","success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                Auto_Incr();   //  After saving current   data it will automatically increaments Id by ' One ' . 
                Clear_Controls();     
                            
            }
            else
            {
                MessageBox.Show(" Please Fill All Information ","Commplete", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            Con.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Student_Form Obj = new Student_Form();
            Obj.Show();
            this.Hide();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            frm_Studentenquiry Obj =  new frm_Studentenquiry();
            Obj.Show();
            this.Hide();
        }

        private void frm_AddStudentDetails_Load(object sender, EventArgs e)
        {
            Auto_Incr();
            tb_Username.Text = Share_Class.Username;   // Username(Name) on the top textbox e.g : Admin 

        }

        private void pb_Back1_Click(object sender, EventArgs e)
        {
            Student_Form Obj = new Student_Form();
            Obj.Show();
            this.Hide();   
        }
    }
}
