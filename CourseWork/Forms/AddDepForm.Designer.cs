
namespace CourseWork.Forms
{
    partial class AddDepForm
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
            this.textDepName = new System.Windows.Forms.TextBox();
            this.buttonAddDep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDepName
            // 
            this.textDepName.Location = new System.Drawing.Point(162, 146);
            this.textDepName.Name = "textDepName";
            this.textDepName.Size = new System.Drawing.Size(243, 22);
            this.textDepName.TabIndex = 0;
            this.textDepName.Text = "Назва відділу...";
            // 
            // buttonAddDep
            // 
            this.buttonAddDep.Location = new System.Drawing.Point(204, 201);
            this.buttonAddDep.Name = "buttonAddDep";
            this.buttonAddDep.Size = new System.Drawing.Size(141, 38);
            this.buttonAddDep.TabIndex = 1;
            this.buttonAddDep.Text = "Додати";
            this.buttonAddDep.UseVisualStyleBackColor = true;
            this.buttonAddDep.Click += new System.EventHandler(this.buttonAddDep_Click);
            // 
            // AddDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 318);
            this.Controls.Add(this.buttonAddDep);
            this.Controls.Add(this.textDepName);
            this.Name = "AddDepForm";
            this.Text = "AddDepForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDepName;
        private System.Windows.Forms.Button buttonAddDep;
    }
}