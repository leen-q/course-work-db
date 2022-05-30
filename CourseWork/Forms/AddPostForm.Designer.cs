
namespace CourseWork.Forms
{
    partial class AddPostForm
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
            this.textPostName = new System.Windows.Forms.TextBox();
            this.textPostSalary = new System.Windows.Forms.TextBox();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPostName
            // 
            this.textPostName.Location = new System.Drawing.Point(173, 142);
            this.textPostName.Name = "textPostName";
            this.textPostName.Size = new System.Drawing.Size(313, 22);
            this.textPostName.TabIndex = 0;
            this.textPostName.Text = "Назва посади...";
            // 
            // textPostSalary
            // 
            this.textPostSalary.Location = new System.Drawing.Point(173, 190);
            this.textPostSalary.Name = "textPostSalary";
            this.textPostSalary.Size = new System.Drawing.Size(313, 22);
            this.textPostSalary.TabIndex = 1;
            this.textPostSalary.Text = "Зарплата...";
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.Location = new System.Drawing.Point(251, 249);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(135, 42);
            this.buttonAddPost.TabIndex = 2;
            this.buttonAddPost.Text = "Додати";
            this.buttonAddPost.UseVisualStyleBackColor = true;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // AddPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 374);
            this.Controls.Add(this.buttonAddPost);
            this.Controls.Add(this.textPostSalary);
            this.Controls.Add(this.textPostName);
            this.Name = "AddPostForm";
            this.Text = "AddPostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPostName;
        private System.Windows.Forms.TextBox textPostSalary;
        private System.Windows.Forms.Button buttonAddPost;
    }
}