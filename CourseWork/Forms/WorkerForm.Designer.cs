
namespace CourseWork.Forms
{
    partial class WorkerForm
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
            this.buttonShowProfile = new System.Windows.Forms.Button();
            this.buttonShowMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowProfile
            // 
            this.buttonShowProfile.Location = new System.Drawing.Point(208, 214);
            this.buttonShowProfile.Name = "buttonShowProfile";
            this.buttonShowProfile.Size = new System.Drawing.Size(175, 63);
            this.buttonShowProfile.TabIndex = 0;
            this.buttonShowProfile.Text = "Переглянути профіль";
            this.buttonShowProfile.UseVisualStyleBackColor = true;
            this.buttonShowProfile.Click += new System.EventHandler(this.buttonShowProfile_Click);
            // 
            // buttonShowMessage
            // 
            this.buttonShowMessage.Location = new System.Drawing.Point(469, 214);
            this.buttonShowMessage.Name = "buttonShowMessage";
            this.buttonShowMessage.Size = new System.Drawing.Size(175, 63);
            this.buttonShowMessage.TabIndex = 1;
            this.buttonShowMessage.Text = "Оголошення";
            this.buttonShowMessage.UseVisualStyleBackColor = true;
            this.buttonShowMessage.Click += new System.EventHandler(this.buttonShowMessage_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 504);
            this.Controls.Add(this.buttonShowMessage);
            this.Controls.Add(this.buttonShowProfile);
            this.Name = "WorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Працівник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkerForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowProfile;
        private System.Windows.Forms.Button buttonShowMessage;
    }
}