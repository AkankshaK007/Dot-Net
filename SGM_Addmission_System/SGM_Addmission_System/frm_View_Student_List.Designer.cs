﻿namespace SGM_Addmission_System
{
    partial class frm_View_Student_List
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
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.dgv_View_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Addmission_System_DBDataSet = new SGM_Addmission_System.SGM_Addmission_System_DBDataSet();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.student_InformationTableAdapter = new SGM_Addmission_System.SGM_Addmission_System_DBDataSetTableAdapters.Student_InformationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Addmission_System_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.BackColor = System.Drawing.Color.LightYellow;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Century", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_View_Student_List.Location = new System.Drawing.Point(109, 30);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(562, 64);
            this.lbl_View_Student_List.TabIndex = 0;
            this.lbl_View_Student_List.Text = "View All Student List";
            // 
            // dgv_View_Student_List
            // 
            this.dgv_View_Student_List.AutoGenerateColumns = false;
            this.dgv_View_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_Student_List.DataSource = this.studentInformationBindingSource;
            this.dgv_View_Student_List.Location = new System.Drawing.Point(30, 114);
            this.dgv_View_Student_List.Name = "dgv_View_Student_List";
            this.dgv_View_Student_List.Size = new System.Drawing.Size(711, 315);
            this.dgv_View_Student_List.TabIndex = 1;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
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
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // studentInformationBindingSource
            // 
            this.studentInformationBindingSource.DataMember = "Student_Information";
            this.studentInformationBindingSource.DataSource = this.sGM_Addmission_System_DBDataSet;
            // 
            // sGM_Addmission_System_DBDataSet
            // 
            this.sGM_Addmission_System_DBDataSet.DataSetName = "SGM_Addmission_System_DBDataSet";
            this.sGM_Addmission_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(228, 446);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(298, 48);
            this.btn_Add_New_Student.TabIndex = 2;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = true;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // student_InformationTableAdapter
            // 
            this.student_InformationTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.dgv_View_Student_List);
            this.Controls.Add(this.lbl_View_Student_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student List";
            this.Load += new System.EventHandler(this.frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Addmission_System_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.DataGridView dgv_View_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private SGM_Addmission_System_DBDataSet sGM_Addmission_System_DBDataSet;
        private System.Windows.Forms.BindingSource studentInformationBindingSource;
        private SGM_Addmission_System_DBDataSetTableAdapters.Student_InformationTableAdapter student_InformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}