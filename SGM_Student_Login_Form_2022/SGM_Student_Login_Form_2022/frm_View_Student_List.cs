using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Student_Login_Form_2022
{
    public partial class frm_View_Student_List : Form
    {
        public frm_View_Student_List()
        {
            InitializeComponent();
        }

        private void frm_View_Student_List_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'sGM_Student_Login_Form_DBDataSet.Student_Information' table. You can move, or remove it, as needed.
            this.student_InformationTableAdapter.Fill(this.sGM_Student_Login_Form_DBDataSet.Student_Information);

        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        
    }
}
