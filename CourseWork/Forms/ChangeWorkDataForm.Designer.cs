
namespace CourseWork.Forms
{
    partial class ChangeWorkDataForm
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
            this.buttonSaveChange = new System.Windows.Forms.Button();
            this.textNewIdentCode = new System.Windows.Forms.TextBox();
            this.textNewEducation = new System.Windows.Forms.ComboBox();
            this.educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet7 = new CourseWork.enterpriseDataSet7();
            this.textNewDepartment = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet5 = new CourseWork.enterpriseDataSet5();
            this.textNewPost = new System.Windows.Forms.ComboBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet6 = new CourseWork.enterpriseDataSet6();
            this.departmentTableAdapter = new CourseWork.enterpriseDataSet5TableAdapters.departmentTableAdapter();
            this.postTableAdapter = new CourseWork.enterpriseDataSet6TableAdapters.postTableAdapter();
            this.educationTableAdapter = new CourseWork.enterpriseDataSet7TableAdapters.educationTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveChange
            // 
            this.buttonSaveChange.Location = new System.Drawing.Point(309, 385);
            this.buttonSaveChange.Name = "buttonSaveChange";
            this.buttonSaveChange.Size = new System.Drawing.Size(167, 53);
            this.buttonSaveChange.TabIndex = 7;
            this.buttonSaveChange.Text = "Зберегти";
            this.buttonSaveChange.UseVisualStyleBackColor = true;
            this.buttonSaveChange.Click += new System.EventHandler(this.buttonSaveChange_Click);
            // 
            // textNewIdentCode
            // 
            this.textNewIdentCode.Location = new System.Drawing.Point(231, 291);
            this.textNewIdentCode.Name = "textNewIdentCode";
            this.textNewIdentCode.Size = new System.Drawing.Size(319, 22);
            this.textNewIdentCode.TabIndex = 10;
            // 
            // textNewEducation
            // 
            this.textNewEducation.DataSource = this.educationBindingSource;
            this.textNewEducation.DisplayMember = "education_name";
            this.textNewEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textNewEducation.FormattingEnabled = true;
            this.textNewEducation.Location = new System.Drawing.Point(231, 245);
            this.textNewEducation.Name = "textNewEducation";
            this.textNewEducation.Size = new System.Drawing.Size(319, 24);
            this.textNewEducation.TabIndex = 11;
            this.textNewEducation.ValueMember = "id";
            // 
            // educationBindingSource
            // 
            this.educationBindingSource.DataMember = "education";
            this.educationBindingSource.DataSource = this.enterpriseDataSet7;
            // 
            // enterpriseDataSet7
            // 
            this.enterpriseDataSet7.DataSetName = "enterpriseDataSet7";
            this.enterpriseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textNewDepartment
            // 
            this.textNewDepartment.DataSource = this.departmentBindingSource;
            this.textNewDepartment.DisplayMember = "department_name";
            this.textNewDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textNewDepartment.FormattingEnabled = true;
            this.textNewDepartment.Location = new System.Drawing.Point(231, 156);
            this.textNewDepartment.Name = "textNewDepartment";
            this.textNewDepartment.Size = new System.Drawing.Size(319, 24);
            this.textNewDepartment.TabIndex = 12;
            this.textNewDepartment.ValueMember = "id";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.enterpriseDataSet5;
            // 
            // enterpriseDataSet5
            // 
            this.enterpriseDataSet5.DataSetName = "enterpriseDataSet5";
            this.enterpriseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textNewPost
            // 
            this.textNewPost.DataSource = this.postBindingSource;
            this.textNewPost.DisplayMember = "post_name";
            this.textNewPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textNewPost.FormattingEnabled = true;
            this.textNewPost.Location = new System.Drawing.Point(231, 200);
            this.textNewPost.Name = "textNewPost";
            this.textNewPost.Size = new System.Drawing.Size(319, 24);
            this.textNewPost.TabIndex = 13;
            this.textNewPost.ValueMember = "id";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.enterpriseDataSet6;
            // 
            // enterpriseDataSet6
            // 
            this.enterpriseDataSet6.DataSetName = "enterpriseDataSet6";
            this.enterpriseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // educationTableAdapter
            // 
            this.educationTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Відділ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Посада:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Освіта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ідент. код:";
            // 
            // ChangeWorkDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNewPost);
            this.Controls.Add(this.textNewDepartment);
            this.Controls.Add(this.textNewEducation);
            this.Controls.Add(this.textNewIdentCode);
            this.Controls.Add(this.buttonSaveChange);
            this.Name = "ChangeWorkDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeWorkDataForm";
            this.Load += new System.EventHandler(this.ChangeWorkDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveChange;
        private System.Windows.Forms.TextBox textNewIdentCode;
        private System.Windows.Forms.ComboBox textNewEducation;
        private System.Windows.Forms.ComboBox textNewDepartment;
        private System.Windows.Forms.ComboBox textNewPost;
        private enterpriseDataSet5 enterpriseDataSet5;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private enterpriseDataSet5TableAdapters.departmentTableAdapter departmentTableAdapter;
        private enterpriseDataSet6 enterpriseDataSet6;
        private System.Windows.Forms.BindingSource postBindingSource;
        private enterpriseDataSet6TableAdapters.postTableAdapter postTableAdapter;
        private enterpriseDataSet7 enterpriseDataSet7;
        private System.Windows.Forms.BindingSource educationBindingSource;
        private enterpriseDataSet7TableAdapters.educationTableAdapter educationTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}