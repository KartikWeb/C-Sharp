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
    public partial class frm_Student_Update : Form
    {
        public frm_Student_Update()
        {
            InitializeComponent();
        }

          SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-OQ5RLJA;Initial Catalog=Student;Integrated Security=True");

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

        void Clear_Controls()
        {
            txt_Id.Clear();
            txt_Mobile_Number.Clear();
            txt_Name.Clear();
            cmb_Course.SelectedIndex = -1;
            dpt_DateTimePicker.Text = "6-12-2023";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Studentenquiry Obj = new frm_Studentenquiry();
            Obj.Show();
            this.Hide();
        }

        private void pb_Back1_Click(object sender, EventArgs e)
        {
            frm_Studentenquiry Obj = new frm_Studentenquiry();
            Obj.Show();
            this.Hide();
        }

        void Enable_Controls()
        {
            txt_Id.Enabled = false;
            txt_Mobile_Number.Enabled = true;
            txt_Name.Enabled = true;
            dpt_DateTimePicker.Enabled = true;
            cmb_Course.Enabled = true;
        }

        void Disable_Controls()
        {
            txt_Id.Enabled = true;
            txt_Mobile_Number.Enabled = false;
            txt_Name.Enabled = false;
            dpt_DateTimePicker.Enabled = false;
            cmb_Course.Enabled = false;

        }

        private void btn_Sreach_Click(object sender, EventArgs e)
        {
            Con_Open();

            
            if(txt_Id.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Select* From Student_Details where Id =@Id ";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = txt_Id.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    txt_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    txt_Mobile_Number.Text = (Dr["Mobile_Number"].ToString());
                    dpt_DateTimePicker.Text = (Dr["Date"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));

                    Enable_Controls();

                }
                else
                {
                    MessageBox.Show(" No student matches the provided Roll_No ", "Invalid",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txt_Id.Clear();
                    txt_Id.Focus();
                }
            }
            else
            {
                MessageBox.Show(" It is must to Enter Id Number .", " Incomplete Info ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            } 
            
            Con_Close();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(txt_Name.Text !="" && txt_Mobile_Number.Text != "" && cmb_Course.Text != "" )
            {
                SqlCommand pop = new SqlCommand();

                pop.Connection = Con;

                pop.CommandText = " Update Student_Details Set Name =@Nm, Date =@Date, Mobile_Number =@Mo_No, Course =@Course Where Id =@Id";

                pop.Parameters.Add("Id", SqlDbType.Int).Value = txt_Id.Text;

                pop.Parameters.Add("Nm", SqlDbType.VarChar).Value = txt_Name.Text;
                pop.Parameters.Add("Date", SqlDbType.Date).Value =  dpt_DateTimePicker.Value.Date;
                pop.Parameters.Add("Mo_No", SqlDbType.Decimal).Value = txt_Mobile_Number.Text;
                pop.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                pop.ExecuteNonQuery();

                MessageBox.Show(" Record Update Successfully  "," Complete ", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                
                Clear_Controls();
                Disable_Controls();
            }
            else
            {
                MessageBox.Show(" First Fill All Fields ");
            }


            Con_Close();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            frm_Studentenquiry Obj = new frm_Studentenquiry();
            Obj.Show();
            this.Hide();
        }

        private void frm_Student_Update_Load(object sender, EventArgs e)
        {
            tb_Username.Text = Share_Class.Username;
        }
    }
}
