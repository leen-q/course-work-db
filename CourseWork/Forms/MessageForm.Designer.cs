
namespace CourseWork.Forms
{
    partial class MessageForm
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
            this.messdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messsubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messtextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet4 = new CourseWork.enterpriseDataSet4();
            this.messagetableTableAdapter = new CourseWork.enterpriseDataSet4TableAdapters.messagetableTableAdapter();
            this.buttonNewMessage = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet4)).BeginInit();
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
            this.messdateDataGridViewTextBoxColumn,
            this.messsubjectDataGridViewTextBoxColumn,
            this.messtextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.messagetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1415, 600);
            this.dataGridView1.TabIndex = 0;
            // 
            // messdateDataGridViewTextBoxColumn
            // 
            this.messdateDataGridViewTextBoxColumn.DataPropertyName = "mess_date";
            this.messdateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.messdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.messdateDataGridViewTextBoxColumn.Name = "messdateDataGridViewTextBoxColumn";
            this.messdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.messdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // messsubjectDataGridViewTextBoxColumn
            // 
            this.messsubjectDataGridViewTextBoxColumn.DataPropertyName = "mess_subject";
            this.messsubjectDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.messsubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.messsubjectDataGridViewTextBoxColumn.Name = "messsubjectDataGridViewTextBoxColumn";
            this.messsubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.messsubjectDataGridViewTextBoxColumn.Width = 400;
            // 
            // messtextDataGridViewTextBoxColumn
            // 
            this.messtextDataGridViewTextBoxColumn.DataPropertyName = "mess_text";
            this.messtextDataGridViewTextBoxColumn.HeaderText = "Текст";
            this.messtextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.messtextDataGridViewTextBoxColumn.Name = "messtextDataGridViewTextBoxColumn";
            this.messtextDataGridViewTextBoxColumn.ReadOnly = true;
            this.messtextDataGridViewTextBoxColumn.Width = 800;
            // 
            // messagetableBindingSource
            // 
            this.messagetableBindingSource.DataMember = "messagetable";
            this.messagetableBindingSource.DataSource = this.enterpriseDataSet4;
            // 
            // enterpriseDataSet4
            // 
            this.enterpriseDataSet4.DataSetName = "enterpriseDataSet4";
            this.enterpriseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messagetableTableAdapter
            // 
            this.messagetableTableAdapter.ClearBeforeFill = true;
            // 
            // buttonNewMessage
            // 
            this.buttonNewMessage.Location = new System.Drawing.Point(27, 640);
            this.buttonNewMessage.Name = "buttonNewMessage";
            this.buttonNewMessage.Size = new System.Drawing.Size(191, 37);
            this.buttonNewMessage.TabIndex = 1;
            this.buttonNewMessage.Text = "Відправити оголошення";
            this.buttonNewMessage.UseVisualStyleBackColor = true;
            this.buttonNewMessage.Click += new System.EventHandler(this.buttonNewMessage_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(281, 640);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(191, 37);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Оновити";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 689);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonNewMessage);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private enterpriseDataSet4 enterpriseDataSet4;
        private System.Windows.Forms.BindingSource messagetableBindingSource;
        private enterpriseDataSet4TableAdapters.messagetableTableAdapter messagetableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn messdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messsubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messtextDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonNewMessage;
        private System.Windows.Forms.Button buttonRefresh;
    }
}