
namespace CourseWork.Forms
{
    partial class DirectorForm
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
            this.buttonShowAllWorkers = new System.Windows.Forms.Button();
            this.buttonShowMessage = new System.Windows.Forms.Button();
            this.buttonPostDep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowAllWorkers
            // 
            this.buttonShowAllWorkers.Location = new System.Drawing.Point(194, 206);
            this.buttonShowAllWorkers.Name = "buttonShowAllWorkers";
            this.buttonShowAllWorkers.Size = new System.Drawing.Size(197, 65);
            this.buttonShowAllWorkers.TabIndex = 0;
            this.buttonShowAllWorkers.Text = "Переглянути список робітників";
            this.buttonShowAllWorkers.UseVisualStyleBackColor = true;
            this.buttonShowAllWorkers.Click += new System.EventHandler(this.buttonShowAllWorkers_Click);
            // 
            // buttonShowMessage
            // 
            this.buttonShowMessage.Location = new System.Drawing.Point(489, 206);
            this.buttonShowMessage.Name = "buttonShowMessage";
            this.buttonShowMessage.Size = new System.Drawing.Size(197, 65);
            this.buttonShowMessage.TabIndex = 1;
            this.buttonShowMessage.Text = "Оголошення";
            this.buttonShowMessage.UseVisualStyleBackColor = true;
            this.buttonShowMessage.Click += new System.EventHandler(this.buttonShowMessage_Click);
            // 
            // buttonPostDep
            // 
            this.buttonPostDep.Location = new System.Drawing.Point(341, 302);
            this.buttonPostDep.Name = "buttonPostDep";
            this.buttonPostDep.Size = new System.Drawing.Size(197, 65);
            this.buttonPostDep.TabIndex = 2;
            this.buttonPostDep.Text = "Відділи та посади";
            this.buttonPostDep.UseVisualStyleBackColor = true;
            this.buttonPostDep.Click += new System.EventHandler(this.buttonPostDep_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 487);
            this.Controls.Add(this.buttonPostDep);
            this.Controls.Add(this.buttonShowMessage);
            this.Controls.Add(this.buttonShowAllWorkers);
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Директор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectorForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowAllWorkers;
        private System.Windows.Forms.Button buttonShowMessage;
        private System.Windows.Forms.Button buttonPostDep;
    }
}