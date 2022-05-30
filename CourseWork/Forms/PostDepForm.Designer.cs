
namespace CourseWork.Forms
{
    partial class PostDepForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet8 = new CourseWork.enterpriseDataSet8();
            this.departmentTableAdapter = new CourseWork.enterpriseDataSet8TableAdapters.departmentTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet9 = new CourseWork.enterpriseDataSet9();
            this.postTableAdapter = new CourseWork.enterpriseDataSet9TableAdapters.postTableAdapter();
            this.buttonAddDep = new System.Windows.Forms.Button();
            this.buttonDelDep = new System.Windows.Forms.Button();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.buttonDelPost = new System.Windows.Forms.Button();
            this.textDelDep = new System.Windows.Forms.TextBox();
            this.textDelPost = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.departmentnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(362, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 75;
            // 
            // departmentnameDataGridViewTextBoxColumn
            // 
            this.departmentnameDataGridViewTextBoxColumn.DataPropertyName = "department_name";
            this.departmentnameDataGridViewTextBoxColumn.HeaderText = "Відділ";
            this.departmentnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentnameDataGridViewTextBoxColumn.Name = "departmentnameDataGridViewTextBoxColumn";
            this.departmentnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.enterpriseDataSet8;
            // 
            // enterpriseDataSet8
            // 
            this.enterpriseDataSet8.DataSetName = "enterpriseDataSet8";
            this.enterpriseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.post_name,
            this.salary});
            this.dataGridView2.DataSource = this.postBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(390, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(443, 485);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // post_name
            // 
            this.post_name.DataPropertyName = "post_name";
            this.post_name.HeaderText = "Посада";
            this.post_name.MinimumWidth = 6;
            this.post_name.Name = "post_name";
            this.post_name.Width = 150;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Заробітня плата";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.Width = 150;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.enterpriseDataSet9;
            // 
            // enterpriseDataSet9
            // 
            this.enterpriseDataSet9.DataSetName = "enterpriseDataSet9";
            this.enterpriseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddDep
            // 
            this.buttonAddDep.Location = new System.Drawing.Point(33, 597);
            this.buttonAddDep.Name = "buttonAddDep";
            this.buttonAddDep.Size = new System.Drawing.Size(122, 34);
            this.buttonAddDep.TabIndex = 2;
            this.buttonAddDep.Text = "Додати";
            this.buttonAddDep.UseVisualStyleBackColor = true;
            this.buttonAddDep.Click += new System.EventHandler(this.buttonAddDep_Click);
            // 
            // buttonDelDep
            // 
            this.buttonDelDep.Location = new System.Drawing.Point(171, 597);
            this.buttonDelDep.Name = "buttonDelDep";
            this.buttonDelDep.Size = new System.Drawing.Size(122, 34);
            this.buttonDelDep.TabIndex = 3;
            this.buttonDelDep.Text = "Видалити";
            this.buttonDelDep.UseVisualStyleBackColor = true;
            this.buttonDelDep.Click += new System.EventHandler(this.buttonDelDep_Click);
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.Location = new System.Drawing.Point(485, 597);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(122, 34);
            this.buttonAddPost.TabIndex = 4;
            this.buttonAddPost.Text = "Додати";
            this.buttonAddPost.UseVisualStyleBackColor = true;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // buttonDelPost
            // 
            this.buttonDelPost.Location = new System.Drawing.Point(623, 597);
            this.buttonDelPost.Name = "buttonDelPost";
            this.buttonDelPost.Size = new System.Drawing.Size(122, 34);
            this.buttonDelPost.TabIndex = 5;
            this.buttonDelPost.Text = "Видалити";
            this.buttonDelPost.UseVisualStyleBackColor = true;
            this.buttonDelPost.Click += new System.EventHandler(this.buttonDelPost_Click);
            // 
            // textDelDep
            // 
            this.textDelDep.Location = new System.Drawing.Point(171, 569);
            this.textDelDep.Name = "textDelDep";
            this.textDelDep.Size = new System.Drawing.Size(122, 22);
            this.textDelDep.TabIndex = 6;
            this.textDelDep.Text = "ID...";
            // 
            // textDelPost
            // 
            this.textDelPost.Location = new System.Drawing.Point(623, 569);
            this.textDelPost.Name = "textDelPost";
            this.textDelPost.Size = new System.Drawing.Size(122, 22);
            this.textDelPost.TabIndex = 7;
            this.textDelPost.Text = "ID...";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(326, 597);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(122, 34);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Оновити";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // PostDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textDelPost);
            this.Controls.Add(this.textDelDep);
            this.Controls.Add(this.buttonDelPost);
            this.Controls.Add(this.buttonAddPost);
            this.Controls.Add(this.buttonDelDep);
            this.Controls.Add(this.buttonAddDep);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PostDepForm";
            this.Text = "PostDepForm";
            this.Load += new System.EventHandler(this.PostDepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private enterpriseDataSet8 enterpriseDataSet8;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private enterpriseDataSet8TableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private enterpriseDataSet9 enterpriseDataSet9;
        private System.Windows.Forms.BindingSource postBindingSource;
        private enterpriseDataSet9TableAdapters.postTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn post_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.Button buttonAddDep;
        private System.Windows.Forms.Button buttonDelDep;
        private System.Windows.Forms.Button buttonAddPost;
        private System.Windows.Forms.Button buttonDelPost;
        private System.Windows.Forms.TextBox textDelDep;
        private System.Windows.Forms.TextBox textDelPost;
        private System.Windows.Forms.Button buttonRefresh;
    }
}