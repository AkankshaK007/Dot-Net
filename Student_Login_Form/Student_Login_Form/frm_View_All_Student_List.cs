using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Login_Form
{
    public partial class frm_View_All_Student_List : Form
    {
        public frm_View_All_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();
            Obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form Obj = new frm_Login_Form();
            Obj.Show();
            this.Hide();

        }

        private void frm_View_All_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Login_Form_DBDataSet3.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Login_Form_DBDataSet3.Student_Details);
            
            

        }

       
       

      
       
        
    }
}
