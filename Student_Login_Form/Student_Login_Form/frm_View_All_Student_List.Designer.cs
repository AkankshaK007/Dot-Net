namespace Student_Login_Form
{
    partial class frm_View_All_Student_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_All_Student_List));
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.dgv_Student_Details_List = new System.Windows.Forms.DataGridView();
            this.rollNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Login_Form_DBDataSet3 = new Student_Login_Form.Student_Login_Form_DBDataSet3();
            this.student_DetailsTableAdapter = new Student_Login_Form.Student_Login_Form_DBDataSet3TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Login_Form_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Century", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.ForeColor = System.Drawing.Color.Navy;
            this.lbl_View_Student_List.Location = new System.Drawing.Point(181, 30);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(491, 66);
            this.lbl_View_Student_List.TabIndex = 0;
            this.lbl_View_Student_List.Text = "View Student List";
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Add_New_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(279, 475);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(256, 57);
            this.btn_Add_New_Student.TabIndex = 2;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Log_Out.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(696, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(126, 52);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // dgv_Student_Details_List
            // 
            this.dgv_Student_Details_List.AutoGenerateColumns = false;
            this.dgv_Student_Details_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_Details_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_Details_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_Details_List.DataSource = this.studentDetailsBindingSource;
            this.dgv_Student_Details_List.Location = new System.Drawing.Point(34, 118);
            this.dgv_Student_Details_List.Name = "dgv_Student_Details_List";
            this.dgv_Student_Details_List.Size = new System.Drawing.Size(776, 332);
            this.dgv_Student_Details_List.TabIndex = 4;
            // 
            // rollNumberDataGridViewTextBoxColumn
            // 
            this.rollNumberDataGridViewTextBoxColumn.DataPropertyName = "Roll Number";
            this.rollNumberDataGridViewTextBoxColumn.HeaderText = "Roll Number";
            this.rollNumberDataGridViewTextBoxColumn.Name = "rollNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student Details";
            this.studentDetailsBindingSource.DataSource = this.student_Login_Form_DBDataSet3;
            // 
            // student_Login_Form_DBDataSet3
            // 
            this.student_Login_Form_DBDataSet3.DataSetName = "Student_Login_Form_DBDataSet3";
            this.student_Login_Form_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_All_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(834, 564);
            this.Controls.Add(this.dgv_Student_Details_List);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_All_Student_List";
            this.Load += new System.EventHandler(this.frm_View_All_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Login_Form_DBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.DataGridView dgv_Student_Details_List;
        private Student_Login_Form_DBDataSet3 student_Login_Form_DBDataSet3;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Login_Form_DBDataSet3TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}