
namespace CourseWork.Forms
{
    partial class ChangePersonalDataForm
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
            this.textNewName = new System.Windows.Forms.TextBox();
            this.textNewSurname = new System.Windows.Forms.TextBox();
            this.textNewEmail = new System.Windows.Forms.TextBox();
            this.buttonSaveChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNewName
            // 
            this.textNewName.Location = new System.Drawing.Point(228, 191);
            this.textNewName.Name = "textNewName";
            this.textNewName.Size = new System.Drawing.Size(319, 22);
            this.textNewName.TabIndex = 0;
            // 
            // textNewSurname
            // 
            this.textNewSurname.Location = new System.Drawing.Point(228, 235);
            this.textNewSurname.Name = "textNewSurname";
            this.textNewSurname.Size = new System.Drawing.Size(319, 22);
            this.textNewSurname.TabIndex = 1;
            // 
            // textNewEmail
            // 
            this.textNewEmail.Location = new System.Drawing.Point(228, 277);
            this.textNewEmail.Name = "textNewEmail";
            this.textNewEmail.Size = new System.Drawing.Size(319, 22);
            this.textNewEmail.TabIndex = 2;
            // 
            // buttonSaveChange
            // 
            this.buttonSaveChange.Location = new System.Drawing.Point(305, 352);
            this.buttonSaveChange.Name = "buttonSaveChange";
            this.buttonSaveChange.Size = new System.Drawing.Size(167, 53);
            this.buttonSaveChange.TabIndex = 3;
            this.buttonSaveChange.Text = "Зберегти";
            this.buttonSaveChange.UseVisualStyleBackColor = true;
            this.buttonSaveChange.Click += new System.EventHandler(this.buttonSaveChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ім\'я:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Прізвище:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // ChangePersonalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveChange);
            this.Controls.Add(this.textNewEmail);
            this.Controls.Add(this.textNewSurname);
            this.Controls.Add(this.textNewName);
            this.Name = "ChangePersonalDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePersonalDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNewName;
        private System.Windows.Forms.TextBox textNewSurname;
        private System.Windows.Forms.TextBox textNewEmail;
        private System.Windows.Forms.Button buttonSaveChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}