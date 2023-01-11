using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Addmission_System
{
    public partial class MDI_SGM_Addmission_System : Form
    {

        public MDI_SGM_Addmission_System()
        {
            InitializeComponent();
        }

        private void MDI_SGM_Addmission_System_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome  " + Shared_Class.Username;

            if (Shared_Class.Username != "Admin")
            {
                courseToolStripMenuItem.Visible = false;
                userManagementToolStripMenuItem.Visible = false;
           
            }
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();

            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Obj.Text = String.Empty;
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details Obj = new frm_Update_Student_Details();

            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Obj.Text = String.Empty;
        }

        private void searchSingleStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student Obj = new frm_Search_Student();
         
            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Obj.Text = String.Empty;
        }

        private void viewAllStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Student_List Obj = new frm_View_Student_List();

            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Obj.Text = String.Empty;
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SGM_Addmission_System.frm_Add_Course Obj = new SGM_Addmission_System.frm_Add_Course();

           Obj.MdiParent = this;
            Obj.Show();

        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }

    }
}
