
namespace EEEmployee_Mgt_frame
{
    partial class frm_MDI
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MStp_MDI = new System.Windows.Forms.MenuStrip();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentEnquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.studentUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MStp_MDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MStp_MDI
            // 
            this.MStp_MDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MStp_MDI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MStp_MDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherToolStripMenuItem});
            this.MStp_MDI.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MStp_MDI.Location = new System.Drawing.Point(0, 0);
            this.MStp_MDI.Name = "MStp_MDI";
            this.MStp_MDI.Size = new System.Drawing.Size(800, 28);
            this.MStp_MDI.TabIndex = 3;
            this.MStp_MDI.Text = "Menu Strip";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // loginFormToolStripMenuItem
            // 
            this.loginFormToolStripMenuItem.Name = "loginFormToolStripMenuItem";
            this.loginFormToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loginFormToolStripMenuItem.Text = "Login Form";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // addStudentDetailsToolStripMenuItem
            // 
            this.addStudentDetailsToolStripMenuItem.Name = "addStudentDetailsToolStripMenuItem";
            this.addStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addStudentDetailsToolStripMenuItem.Text = " Add Student Details";
            this.addStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.addStudentDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // studentEnquiryToolStripMenuItem
            // 
            this.studentEnquiryToolStripMenuItem.Name = "studentEnquiryToolStripMenuItem";
            this.studentEnquiryToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentEnquiryToolStripMenuItem.Text = " Student Enquiry";
            this.studentEnquiryToolStripMenuItem.Click += new System.EventHandler(this.studentEnquiryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 6);
            // 
            // studentUpdateToolStripMenuItem
            // 
            this.studentUpdateToolStripMenuItem.Name = "studentUpdateToolStripMenuItem";
            this.studentUpdateToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentUpdateToolStripMenuItem.Text = " Student Update";
            this.studentUpdateToolStripMenuItem.Click += new System.EventHandler(this.studentUpdateToolStripMenuItem_Click);
            // 
            // frm_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.MStp_MDI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frm_MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI";
            this.MStp_MDI.ResumeLayout(false);
            this.MStp_MDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip MStp_MDI;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem studentEnquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem studentUpdateToolStripMenuItem;
    }
}