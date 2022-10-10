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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
             if ((tb_Username.Text == "Akanksha") && (tb_Password.Text == "AK07"))
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Student Obj = new frm_Add_New_Student();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Invalid Username Or Password";
                lbl_Error.ForeColor = Color.Red;
            }
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            tb_Username.Focus();

        

        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            tb_Password.Enabled = true;


        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;


        }


    }
}
