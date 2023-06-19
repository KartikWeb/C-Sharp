
namespace EEEmployee_Mgt_frame
{
    partial class frm_Studentenquiry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Studentenquiry));
            this.dgv_Studentenquiry = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new EEEmployee_Mgt_frame.StudentDataSet1();
            this.studentDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new EEEmployee_Mgt_frame.StudentDataSet();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fork_DBDataSet2 = new EEEmployee_Mgt_frame.Fork_DBDataSet2();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fork_DBDataSet1 = new EEEmployee_Mgt_frame.Fork_DBDataSet1();
            this.btn_StudentsEnquiry = new System.Windows.Forms.Label();
            this.student_DetailsTableAdapter = new EEEmployee_Mgt_frame.Fork_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.btn_Back = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter1 = new EEEmployee_Mgt_frame.Fork_DBDataSet2TableAdapters.Student_DetailsTableAdapter();
            this.pb_Back1 = new System.Windows.Forms.PictureBox();
            this.tb_Username1 = new System.Windows.Forms.TextBox();
            this.btn_Name1 = new System.Windows.Forms.Label();
            this.student_DetailsTableAdapter2 = new EEEmployee_Mgt_frame.StudentDataSetTableAdapters.Student_DetailsTableAdapter();
            this.btn_Sreach = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter3 = new EEEmployee_Mgt_frame.StudentDataSet1TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Studentenquiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Studentenquiry
            // 
            this.dgv_Studentenquiry.AllowUserToAddRows = false;
            this.dgv_Studentenquiry.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dgv_Studentenquiry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Studentenquiry.AutoGenerateColumns = false;
            this.dgv_Studentenquiry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Studentenquiry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Studentenquiry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Studentenquiry.ColumnHeadersHeight = 30;
            this.dgv_Studentenquiry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Studentenquiry.DataSource = this.studentDetailsBindingSource3;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Studentenquiry.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Studentenquiry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgv_Studentenquiry.Location = new System.Drawing.Point(0, 171);
            this.dgv_Studentenquiry.Name = "dgv_Studentenquiry";
            this.dgv_Studentenquiry.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Studentenquiry.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Studentenquiry.RowHeadersWidth = 45;
            this.dgv_Studentenquiry.Size = new System.Drawing.Size(1113, 288);
            this.dgv_Studentenquiry.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "Mobile_Number";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile_Number";
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            this.mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource3
            // 
            this.studentDetailsBindingSource3.DataMember = "Student_Details";
            this.studentDetailsBindingSource3.DataSource = this.studentDataSet1;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource2
            // 
            this.studentDetailsBindingSource2.DataMember = "Student_Details";
            this.studentDetailsBindingSource2.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            this.studentDetailsBindingSource1.DataSource = this.fork_DBDataSet2;
            // 
            // fork_DBDataSet2
            // 
            this.fork_DBDataSet2.DataSetName = "Fork_DBDataSet2";
            this.fork_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.fork_DBDataSet1;
            // 
            // fork_DBDataSet1
            // 
            this.fork_DBDataSet1.DataSetName = "Fork_DBDataSet1";
            this.fork_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_StudentsEnquiry
            // 
            this.btn_StudentsEnquiry.AutoSize = true;
            this.btn_StudentsEnquiry.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_StudentsEnquiry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_StudentsEnquiry.Font = new System.Drawing.Font("Algerian", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentsEnquiry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_StudentsEnquiry.Location = new System.Drawing.Point(365, 9);
            this.btn_StudentsEnquiry.Name = "btn_StudentsEnquiry";
            this.btn_StudentsEnquiry.Size = new System.Drawing.Size(404, 52);
            this.btn_StudentsEnquiry.TabIndex = 1;
            this.btn_StudentsEnquiry.Text = "Student Enquiry";
            this.btn_StudentsEnquiry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Black;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(34, 493);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(96, 42);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "𝕭𝖆𝖈K";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // student_DetailsTableAdapter1
            // 
            this.student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // pb_Back1
            // 
            this.pb_Back1.BackColor = System.Drawing.Color.Red;
            this.pb_Back1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Back1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Back1.Image = ((System.Drawing.Image)(resources.GetObject("pb_Back1.Image")));
            this.pb_Back1.Location = new System.Drawing.Point(0, 493);
            this.pb_Back1.Name = "pb_Back1";
            this.pb_Back1.Size = new System.Drawing.Size(37, 42);
            this.pb_Back1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Back1.TabIndex = 29;
            this.pb_Back1.TabStop = false;
            this.pb_Back1.Click += new System.EventHandler(this.pb_Back1_Click);
            // 
            // tb_Username1
            // 
            this.tb_Username1.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_Username1.Font = new System.Drawing.Font("Tw Cen MT", 18F);
            this.tb_Username1.Location = new System.Drawing.Point(23, 69);
            this.tb_Username1.Multiline = true;
            this.tb_Username1.Name = "tb_Username1";
            this.tb_Username1.Size = new System.Drawing.Size(216, 30);
            this.tb_Username1.TabIndex = 42;
            this.tb_Username1.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // btn_Name1
            // 
            this.btn_Name1.AutoSize = true;
            this.btn_Name1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Name1.ForeColor = System.Drawing.Color.White;
            this.btn_Name1.Location = new System.Drawing.Point(43, 93);
            this.btn_Name1.Name = "btn_Name1";
            this.btn_Name1.Size = new System.Drawing.Size(161, 29);
            this.btn_Name1.TabIndex = 41;
            this.btn_Name1.Text = "╰┈►𝒩𝒶𝓂𝑒 ◄┈╯";
            // 
            // student_DetailsTableAdapter2
            // 
            this.student_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // btn_Sreach
            // 
            this.btn_Sreach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Sreach.FlatAppearance.BorderSize = 2;
            this.btn_Sreach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Sreach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Sreach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sreach.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sreach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Sreach.Location = new System.Drawing.Point(876, 493);
            this.btn_Sreach.Name = "btn_Sreach";
            this.btn_Sreach.Size = new System.Drawing.Size(150, 42);
            this.btn_Sreach.TabIndex = 43;
            this.btn_Sreach.Text = "𝔖𝔯𝔢𝔞𝔠𝔥  𝔘𝔭𝔡𝔞𝔱𝔢𝔰";
            this.btn_Sreach.UseVisualStyleBackColor = true;
            this.btn_Sreach.Click += new System.EventHandler(this.btn_Sreach_Click);
            // 
            // student_DetailsTableAdapter3
            // 
            this.student_DetailsTableAdapter3.ClearBeforeFill = true;
            // 
            // frm_Studentenquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1116, 548);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Sreach);
            this.Controls.Add(this.tb_Username1);
            this.Controls.Add(this.btn_Name1);
            this.Controls.Add(this.pb_Back1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_StudentsEnquiry);
            this.Controls.Add(this.dgv_Studentenquiry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Studentenquiry";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm3";
            this.Load += new System.EventHandler(this.frm_Studentenquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Studentenquiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Studentenquiry;
        private System.Windows.Forms.Label btn_StudentsEnquiry;
        private Fork_DBDataSet1 fork_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Fork_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private Fork_DBDataSet2 fork_DBDataSet2;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private Fork_DBDataSet2TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter1;
        private System.Windows.Forms.PictureBox pb_Back1;
        private System.Windows.Forms.TextBox tb_Username1;
        private System.Windows.Forms.Label btn_Name1;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource2;
        private StudentDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter2;
        private System.Windows.Forms.Button btn_Sreach;
        private StudentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource3;
        private StudentDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter3;
    }
}