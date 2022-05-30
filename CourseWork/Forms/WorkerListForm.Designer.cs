
namespace CourseWork.Forms
{
    partial class WorkerListForm
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
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaldataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet3 = new CourseWork.enterpriseDataSet3();
            this.personaldataTableAdapter = new CourseWork.enterpriseDataSet3TableAdapters.personaldataTableAdapter();
            this.buttonShowWorkerInfo = new System.Windows.Forms.Button();
            this.textOpenProfile = new System.Windows.Forms.TextBox();
            this.textFindWorker = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.depSort = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet5 = new CourseWork.enterpriseDataSet5();
            this.departmentTableAdapter = new CourseWork.enterpriseDataSet5TableAdapters.departmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaldataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet5)).BeginInit();
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
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.usersurnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personaldataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 626);
            this.dataGridView1.TabIndex = 0;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Width = 80;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 260;
            // 
            // usersurnameDataGridViewTextBoxColumn
            // 
            this.usersurnameDataGridViewTextBoxColumn.DataPropertyName = "user_surname";
            this.usersurnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.usersurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersurnameDataGridViewTextBoxColumn.Name = "usersurnameDataGridViewTextBoxColumn";
            this.usersurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersurnameDataGridViewTextBoxColumn.Width = 260;
            // 
            // personaldataBindingSource
            // 
            this.personaldataBindingSource.DataMember = "personaldata";
            this.personaldataBindingSource.DataSource = this.enterpriseDataSet3;
            // 
            // enterpriseDataSet3
            // 
            this.enterpriseDataSet3.DataSetName = "enterpriseDataSet3";
            this.enterpriseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaldataTableAdapter
            // 
            this.personaldataTableAdapter.ClearBeforeFill = true;
            // 
            // buttonShowWorkerInfo
            // 
            this.buttonShowWorkerInfo.Location = new System.Drawing.Point(512, 672);
            this.buttonShowWorkerInfo.Name = "buttonShowWorkerInfo";
            this.buttonShowWorkerInfo.Size = new System.Drawing.Size(145, 34);
            this.buttonShowWorkerInfo.TabIndex = 1;
            this.buttonShowWorkerInfo.Text = "Відкрити профіль";
            this.buttonShowWorkerInfo.UseVisualStyleBackColor = true;
            this.buttonShowWorkerInfo.Click += new System.EventHandler(this.buttonShowWorkerInfo_Click);
            // 
            // textOpenProfile
            // 
            this.textOpenProfile.Location = new System.Drawing.Point(512, 644);
            this.textOpenProfile.Name = "textOpenProfile";
            this.textOpenProfile.Size = new System.Drawing.Size(145, 22);
            this.textOpenProfile.TabIndex = 2;
            this.textOpenProfile.Text = "ID...";
            // 
            // textFindWorker
            // 
            this.textFindWorker.Location = new System.Drawing.Point(33, 644);
            this.textFindWorker.Name = "textFindWorker";
            this.textFindWorker.Size = new System.Drawing.Size(205, 22);
            this.textFindWorker.TabIndex = 4;
            this.textFindWorker.Text = "Ім\'я чи прізвище...";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(65, 672);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(134, 34);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Знайти робітника";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(681, 672);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(145, 34);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Оновити";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(307, 672);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(134, 43);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Відсортувати по відділу";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // depSort
            // 
            this.depSort.DataSource = this.departmentBindingSource;
            this.depSort.DisplayMember = "department_name";
            this.depSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depSort.FormattingEnabled = true;
            this.depSort.Location = new System.Drawing.Point(273, 642);
            this.depSort.Name = "depSort";
            this.depSort.Size = new System.Drawing.Size(205, 24);
            this.depSort.TabIndex = 7;
            this.depSort.ValueMember = "id";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.enterpriseDataSet5BindingSource;
            // 
            // enterpriseDataSet5BindingSource
            // 
            this.enterpriseDataSet5BindingSource.DataSource = this.enterpriseDataSet5;
            this.enterpriseDataSet5BindingSource.Position = 0;
            // 
            // enterpriseDataSet5
            // 
            this.enterpriseDataSet5.DataSetName = "enterpriseDataSet5";
            this.enterpriseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // WorkerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 722);
            this.Controls.Add(this.depSort);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textFindWorker);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textOpenProfile);
            this.Controls.Add(this.buttonShowWorkerInfo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WorkerListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerList";
            this.Load += new System.EventHandler(this.WorkerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaldataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private enterpriseDataSet3 enterpriseDataSet3;
        private System.Windows.Forms.BindingSource personaldataBindingSource;
        private enterpriseDataSet3TableAdapters.personaldataTableAdapter personaldataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonShowWorkerInfo;
        private System.Windows.Forms.TextBox textOpenProfile;
        private System.Windows.Forms.TextBox textFindWorker;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox depSort;
        private System.Windows.Forms.BindingSource enterpriseDataSet5BindingSource;
        private enterpriseDataSet5 enterpriseDataSet5;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private enterpriseDataSet5TableAdapters.departmentTableAdapter departmentTableAdapter;
    }
}