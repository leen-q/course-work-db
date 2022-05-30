
namespace CourseWork.Forms
{
    partial class CreateNewMessageForm
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
            this.textNewMessageSubject = new System.Windows.Forms.TextBox();
            this.textNewMessageText = new System.Windows.Forms.TextBox();
            this.buttonSaveNewMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNewMessageSubject
            // 
            this.textNewMessageSubject.Location = new System.Drawing.Point(223, 93);
            this.textNewMessageSubject.Name = "textNewMessageSubject";
            this.textNewMessageSubject.Size = new System.Drawing.Size(539, 22);
            this.textNewMessageSubject.TabIndex = 0;
            this.textNewMessageSubject.Text = "Тема";
            // 
            // textNewMessageText
            // 
            this.textNewMessageText.Location = new System.Drawing.Point(223, 142);
            this.textNewMessageText.Multiline = true;
            this.textNewMessageText.Name = "textNewMessageText";
            this.textNewMessageText.Size = new System.Drawing.Size(539, 270);
            this.textNewMessageText.TabIndex = 1;
            this.textNewMessageText.Text = "Текст оголошення...";
            // 
            // buttonSaveNewMessage
            // 
            this.buttonSaveNewMessage.Location = new System.Drawing.Point(398, 436);
            this.buttonSaveNewMessage.Name = "buttonSaveNewMessage";
            this.buttonSaveNewMessage.Size = new System.Drawing.Size(176, 40);
            this.buttonSaveNewMessage.TabIndex = 2;
            this.buttonSaveNewMessage.Text = "Відправити";
            this.buttonSaveNewMessage.UseVisualStyleBackColor = true;
            this.buttonSaveNewMessage.Click += new System.EventHandler(this.buttonSaveNewMessage_Click);
            // 
            // CreateNewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 528);
            this.Controls.Add(this.buttonSaveNewMessage);
            this.Controls.Add(this.textNewMessageText);
            this.Controls.Add(this.textNewMessageSubject);
            this.Name = "CreateNewMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewMessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNewMessageSubject;
        private System.Windows.Forms.TextBox textNewMessageText;
        private System.Windows.Forms.Button buttonSaveNewMessage;
    }
}