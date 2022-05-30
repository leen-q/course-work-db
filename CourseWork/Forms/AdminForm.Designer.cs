
namespace CourseWork
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRefreshUsers = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridViewLoginTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logintableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet = new CourseWork.enterpriseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewPersonalHistory = new System.Windows.Forms.DataGridView();
            this.personaldatahistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet1 = new CourseWork.enterpriseDataSet1();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewWorkHistory = new System.Windows.Forms.DataGridView();
            this.workdatahistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet2 = new CourseWork.enterpriseDataSet2();
            this.logintableTableAdapter = new CourseWork.enterpriseDataSetTableAdapters.logintableTableAdapter();
            this.enterpriseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaldatahistoryTableAdapter = new CourseWork.enterpriseDataSet1TableAdapters.personaldatahistoryTableAdapter();
            this.workdatahistoryTableAdapter = new CourseWork.enterpriseDataSet2TableAdapters.workdatahistoryTableAdapter();
            this.enterpriseDataSet10 = new CourseWork.enterpriseDataSet10();
            this.personaldatahistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personaldatahistoryTableAdapter1 = new CourseWork.enterpriseDataSet10TableAdapters.personaldatahistoryTableAdapter();
            this.changedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olddataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newdataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterpriseDataSet11 = new CourseWork.enterpriseDataSet11();
            this.workdatahistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workdatahistoryTableAdapter1 = new CourseWork.enterpriseDataSet11TableAdapters.workdatahistoryTableAdapter();
            this.changedateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olddataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newdataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logintableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonalHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaldatahistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workdatahistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaldatahistoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workdatahistoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1190, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRefreshUsers);
            this.tabPage1.Controls.Add(this.buttonDeleteUser);
            this.tabPage1.Controls.Add(this.buttonAddUser);
            this.tabPage1.Controls.Add(this.dataGridViewLoginTable);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1182, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Користувачі";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshUsers
            // 
            this.buttonRefreshUsers.Location = new System.Drawing.Point(265, 519);
            this.buttonRefreshUsers.Name = "buttonRefreshUsers";
            this.buttonRefreshUsers.Size = new System.Drawing.Size(175, 38);
            this.buttonRefreshUsers.TabIndex = 4;
            this.buttonRefreshUsers.Text = "Обновити";
            this.buttonRefreshUsers.UseVisualStyleBackColor = true;
            this.buttonRefreshUsers.Click += new System.EventHandler(this.buttonRefreshUsers_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(485, 475);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(177, 38);
            this.buttonDeleteUser.TabIndex = 3;
            this.buttonDeleteUser.Text = "Видалити користувача";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(265, 475);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(175, 38);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Додати користувача";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dataGridViewLoginTable
            // 
            this.dataGridViewLoginTable.AllowUserToAddRows = false;
            this.dataGridViewLoginTable.AllowUserToDeleteRows = false;
            this.dataGridViewLoginTable.AutoGenerateColumns = false;
            this.dataGridViewLoginTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLoginTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLoginTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewLoginTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userloginDataGridViewTextBoxColumn,
            this.userpasswordDataGridViewTextBoxColumn});
            this.dataGridViewLoginTable.DataSource = this.logintableBindingSource;
            this.dataGridViewLoginTable.Location = new System.Drawing.Point(166, 50);
            this.dataGridViewLoginTable.Name = "dataGridViewLoginTable";
            this.dataGridViewLoginTable.ReadOnly = true;
            this.dataGridViewLoginTable.RowHeadersVisible = false;
            this.dataGridViewLoginTable.RowHeadersWidth = 51;
            this.dataGridViewLoginTable.RowTemplate.Height = 24;
            this.dataGridViewLoginTable.Size = new System.Drawing.Size(724, 402);
            this.dataGridViewLoginTable.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // userloginDataGridViewTextBoxColumn
            // 
            this.userloginDataGridViewTextBoxColumn.DataPropertyName = "user_login";
            this.userloginDataGridViewTextBoxColumn.HeaderText = "Логін";
            this.userloginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userloginDataGridViewTextBoxColumn.Name = "userloginDataGridViewTextBoxColumn";
            this.userloginDataGridViewTextBoxColumn.ReadOnly = true;
            this.userloginDataGridViewTextBoxColumn.Width = 200;
            // 
            // userpasswordDataGridViewTextBoxColumn
            // 
            this.userpasswordDataGridViewTextBoxColumn.DataPropertyName = "user_password";
            this.userpasswordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.userpasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userpasswordDataGridViewTextBoxColumn.Name = "userpasswordDataGridViewTextBoxColumn";
            this.userpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.userpasswordDataGridViewTextBoxColumn.Width = 200;
            // 
            // logintableBindingSource
            // 
            this.logintableBindingSource.DataMember = "logintable";
            this.logintableBindingSource.DataSource = this.enterpriseDataSet;
            // 
            // enterpriseDataSet
            // 
            this.enterpriseDataSet.DataSetName = "enterpriseDataSet";
            this.enterpriseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(357, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список користувачів";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewPersonalHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1182, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Історія змін персональної інформації";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPersonalHistory
            // 
            this.dataGridViewPersonalHistory.AllowUserToAddRows = false;
            this.dataGridViewPersonalHistory.AllowUserToDeleteRows = false;
            this.dataGridViewPersonalHistory.AllowUserToResizeColumns = false;
            this.dataGridViewPersonalHistory.AllowUserToResizeRows = false;
            this.dataGridViewPersonalHistory.AutoGenerateColumns = false;
            this.dataGridViewPersonalHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPersonalHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPersonalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.changedateDataGridViewTextBoxColumn,
            this.user_id,
            this.olddataDataGridViewTextBoxColumn,
            this.newdataDataGridViewTextBoxColumn});
            this.dataGridViewPersonalHistory.DataSource = this.personaldatahistoryBindingSource1;
            this.dataGridViewPersonalHistory.Location = new System.Drawing.Point(25, 18);
            this.dataGridViewPersonalHistory.Name = "dataGridViewPersonalHistory";
            this.dataGridViewPersonalHistory.ReadOnly = true;
            this.dataGridViewPersonalHistory.RowHeadersVisible = false;
            this.dataGridViewPersonalHistory.RowHeadersWidth = 51;
            this.dataGridViewPersonalHistory.RowTemplate.Height = 24;
            this.dataGridViewPersonalHistory.Size = new System.Drawing.Size(1384, 509);
            this.dataGridViewPersonalHistory.TabIndex = 3;
            // 
            // personaldatahistoryBindingSource
            // 
            this.personaldatahistoryBindingSource.DataMember = "personaldatahistory";
            this.personaldatahistoryBindingSource.DataSource = this.enterpriseDataSet1;
            // 
            // enterpriseDataSet1
            // 
            this.enterpriseDataSet1.DataSetName = "enterpriseDataSet1";
            this.enterpriseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewWorkHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1182, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Історія зміни робочії інформації";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWorkHistory
            // 
            this.dataGridViewWorkHistory.AllowUserToAddRows = false;
            this.dataGridViewWorkHistory.AllowUserToDeleteRows = false;
            this.dataGridViewWorkHistory.AllowUserToResizeColumns = false;
            this.dataGridViewWorkHistory.AllowUserToResizeRows = false;
            this.dataGridViewWorkHistory.AutoGenerateColumns = false;
            this.dataGridViewWorkHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewWorkHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewWorkHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.changedateDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.olddataDataGridViewTextBoxColumn1,
            this.newdataDataGridViewTextBoxColumn1});
            this.dataGridViewWorkHistory.DataSource = this.workdatahistoryBindingSource1;
            this.dataGridViewWorkHistory.Location = new System.Drawing.Point(25, 18);
            this.dataGridViewWorkHistory.Name = "dataGridViewWorkHistory";
            this.dataGridViewWorkHistory.ReadOnly = true;
            this.dataGridViewWorkHistory.RowHeadersVisible = false;
            this.dataGridViewWorkHistory.RowHeadersWidth = 51;
            this.dataGridViewWorkHistory.RowTemplate.Height = 24;
            this.dataGridViewWorkHistory.Size = new System.Drawing.Size(1300, 523);
            this.dataGridViewWorkHistory.TabIndex = 0;
            // 
            // workdatahistoryBindingSource
            // 
            this.workdatahistoryBindingSource.DataMember = "workdatahistory";
            this.workdatahistoryBindingSource.DataSource = this.enterpriseDataSet2;
            // 
            // enterpriseDataSet2
            // 
            this.enterpriseDataSet2.DataSetName = "enterpriseDataSet2";
            this.enterpriseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logintableTableAdapter
            // 
            this.logintableTableAdapter.ClearBeforeFill = true;
            // 
            // enterpriseDataSetBindingSource
            // 
            this.enterpriseDataSetBindingSource.DataSource = this.enterpriseDataSet;
            this.enterpriseDataSetBindingSource.Position = 0;
            // 
            // personaldatahistoryTableAdapter
            // 
            this.personaldatahistoryTableAdapter.ClearBeforeFill = true;
            // 
            // workdatahistoryTableAdapter
            // 
            this.workdatahistoryTableAdapter.ClearBeforeFill = true;
            // 
            // enterpriseDataSet10
            // 
            this.enterpriseDataSet10.DataSetName = "enterpriseDataSet10";
            this.enterpriseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaldatahistoryBindingSource1
            // 
            this.personaldatahistoryBindingSource1.DataMember = "personaldatahistory";
            this.personaldatahistoryBindingSource1.DataSource = this.enterpriseDataSet10;
            // 
            // personaldatahistoryTableAdapter1
            // 
            this.personaldatahistoryTableAdapter1.ClearBeforeFill = true;
            // 
            // changedateDataGridViewTextBoxColumn
            // 
            this.changedateDataGridViewTextBoxColumn.DataPropertyName = "change_date";
            this.changedateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.changedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changedateDataGridViewTextBoxColumn.Name = "changedateDataGridViewTextBoxColumn";
            this.changedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.changedateDataGridViewTextBoxColumn.Width = 125;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "ID користувача";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Width = 125;
            // 
            // olddataDataGridViewTextBoxColumn
            // 
            this.olddataDataGridViewTextBoxColumn.DataPropertyName = "old_data";
            this.olddataDataGridViewTextBoxColumn.HeaderText = "Змінена інформація";
            this.olddataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.olddataDataGridViewTextBoxColumn.Name = "olddataDataGridViewTextBoxColumn";
            this.olddataDataGridViewTextBoxColumn.ReadOnly = true;
            this.olddataDataGridViewTextBoxColumn.Width = 350;
            // 
            // newdataDataGridViewTextBoxColumn
            // 
            this.newdataDataGridViewTextBoxColumn.DataPropertyName = "new_data";
            this.newdataDataGridViewTextBoxColumn.HeaderText = "Нова інформація";
            this.newdataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newdataDataGridViewTextBoxColumn.Name = "newdataDataGridViewTextBoxColumn";
            this.newdataDataGridViewTextBoxColumn.ReadOnly = true;
            this.newdataDataGridViewTextBoxColumn.Width = 350;
            // 
            // enterpriseDataSet11
            // 
            this.enterpriseDataSet11.DataSetName = "enterpriseDataSet11";
            this.enterpriseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workdatahistoryBindingSource1
            // 
            this.workdatahistoryBindingSource1.DataMember = "workdatahistory";
            this.workdatahistoryBindingSource1.DataSource = this.enterpriseDataSet11;
            // 
            // workdatahistoryTableAdapter1
            // 
            this.workdatahistoryTableAdapter1.ClearBeforeFill = true;
            // 
            // changedateDataGridViewTextBoxColumn1
            // 
            this.changedateDataGridViewTextBoxColumn1.DataPropertyName = "change_date";
            this.changedateDataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.changedateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.changedateDataGridViewTextBoxColumn1.Name = "changedateDataGridViewTextBoxColumn1";
            this.changedateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.changedateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID користувача";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // olddataDataGridViewTextBoxColumn1
            // 
            this.olddataDataGridViewTextBoxColumn1.DataPropertyName = "old_data";
            this.olddataDataGridViewTextBoxColumn1.HeaderText = "Змінена інформація";
            this.olddataDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.olddataDataGridViewTextBoxColumn1.Name = "olddataDataGridViewTextBoxColumn1";
            this.olddataDataGridViewTextBoxColumn1.ReadOnly = true;
            this.olddataDataGridViewTextBoxColumn1.Width = 350;
            // 
            // newdataDataGridViewTextBoxColumn1
            // 
            this.newdataDataGridViewTextBoxColumn1.DataPropertyName = "new_data";
            this.newdataDataGridViewTextBoxColumn1.HeaderText = "Нова інформація";
            this.newdataDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.newdataDataGridViewTextBoxColumn1.Name = "newdataDataGridViewTextBoxColumn1";
            this.newdataDataGridViewTextBoxColumn1.ReadOnly = true;
            this.newdataDataGridViewTextBoxColumn1.Width = 350;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 618);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адміністратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logintableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonalHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaldatahistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workdatahistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaldatahistoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workdatahistoryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewLoginTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private enterpriseDataSet enterpriseDataSet;
        private System.Windows.Forms.BindingSource logintableBindingSource;
        private enterpriseDataSetTableAdapters.logintableTableAdapter logintableTableAdapter;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.BindingSource enterpriseDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPersonalHistory;
        private enterpriseDataSet1 enterpriseDataSet1;
        private System.Windows.Forms.BindingSource personaldatahistoryBindingSource;
        private enterpriseDataSet1TableAdapters.personaldatahistoryTableAdapter personaldatahistoryTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewWorkHistory;
        private enterpriseDataSet2 enterpriseDataSet2;
        private System.Windows.Forms.BindingSource workdatahistoryBindingSource;
        private enterpriseDataSet2TableAdapters.workdatahistoryTableAdapter workdatahistoryTableAdapter;
        private System.Windows.Forms.Button buttonRefreshUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpasswordDataGridViewTextBoxColumn;
        private enterpriseDataSet10 enterpriseDataSet10;
        private System.Windows.Forms.BindingSource personaldatahistoryBindingSource1;
        private enterpriseDataSet10TableAdapters.personaldatahistoryTableAdapter personaldatahistoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn olddataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newdataDataGridViewTextBoxColumn;
        private enterpriseDataSet11 enterpriseDataSet11;
        private System.Windows.Forms.BindingSource workdatahistoryBindingSource1;
        private enterpriseDataSet11TableAdapters.workdatahistoryTableAdapter workdatahistoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn olddataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn newdataDataGridViewTextBoxColumn1;
    }
}