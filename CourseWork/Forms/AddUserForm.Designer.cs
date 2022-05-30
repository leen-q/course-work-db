
namespace CourseWork.Forms
{
    partial class AddUserForm
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
            this.newUserLogin = new System.Windows.Forms.TextBox();
            this.newUserPassword = new System.Windows.Forms.TextBox();
            this.buttonConfirmAdd = new System.Windows.Forms.Button();
            this.newUserRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newUserLogin
            // 
            this.newUserLogin.Location = new System.Drawing.Point(152, 106);
            this.newUserLogin.Name = "newUserLogin";
            this.newUserLogin.Size = new System.Drawing.Size(252, 22);
            this.newUserLogin.TabIndex = 0;
            // 
            // newUserPassword
            // 
            this.newUserPassword.Location = new System.Drawing.Point(152, 143);
            this.newUserPassword.Name = "newUserPassword";
            this.newUserPassword.Size = new System.Drawing.Size(252, 22);
            this.newUserPassword.TabIndex = 2;
            // 
            // buttonConfirmAdd
            // 
            this.buttonConfirmAdd.Location = new System.Drawing.Point(201, 248);
            this.buttonConfirmAdd.Name = "buttonConfirmAdd";
            this.buttonConfirmAdd.Size = new System.Drawing.Size(148, 56);
            this.buttonConfirmAdd.TabIndex = 3;
            this.buttonConfirmAdd.Text = "Додати";
            this.buttonConfirmAdd.UseVisualStyleBackColor = true;
            this.buttonConfirmAdd.Click += new System.EventHandler(this.buttonConfirmAdd_Click);
            // 
            // newUserRole
            // 
            this.newUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newUserRole.FormattingEnabled = true;
            this.newUserRole.Items.AddRange(new object[] {
            "director",
            "worker"});
            this.newUserRole.Location = new System.Drawing.Point(152, 183);
            this.newUserRole.Name = "newUserRole";
            this.newUserRole.Size = new System.Drawing.Size(252, 24);
            this.newUserRole.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логін:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Роль:";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserRole);
            this.Controls.Add(this.buttonConfirmAdd);
            this.Controls.Add(this.newUserPassword);
            this.Controls.Add(this.newUserLogin);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newUserLogin;
        private System.Windows.Forms.TextBox newUserPassword;
        private System.Windows.Forms.Button buttonConfirmAdd;
        private System.Windows.Forms.ComboBox newUserRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}