using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.DB;

namespace CourseWork.Forms
{
    public partial class WorkerInfoForm : Form
    {
        public WorkerInfoForm()
        {
            InitializeComponent();
            DBCommands db = new DBCommands();
            workerNameInfo.Text = db.GetUserName(ID.findId);
            workerSurnameInfo.Text = db.GetUserSurname(ID.findId);
            workerEmailInfo.Text = db.GetUserEmail(ID.findId);
            workerDepartmentInfo.Text = db.GetUserDepartment(ID.findId);
            workerPostInfo.Text = db.GetUserPost(ID.findId);
            workerSalaryInfo.Text = (db.GetUserSalary(ID.findId) + db.GetUserSalary(ID.findId) * db.GetUserEducationAdd(db.GetUserEducation(ID.findId))).ToString();
            workerEducationInfo.Text = db.GetUserEducation(ID.findId);
            workerIdentCodeInfo.Text = db.GetUserIdentCode(ID.findId);
        }

        private void buttonChangePersonalData_Click(object sender, EventArgs e)
        {
            if (ID.Role == "worker")
            {
                ChangePersonalDataForm form = new ChangePersonalDataForm();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Недостатньо прав!");
            }
        }

        private void buttonChangeWorkData_Click(object sender, EventArgs e)
        {
            if (ID.Role == "director")
            {
                ChangeWorkDataForm form = new ChangeWorkDataForm();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Недостатньо прав!");
            }
        }

        private void buttonWorkBook_Click(object sender, EventArgs e)
        {
            WorkBookForm form = new WorkBookForm();
            form.Show();
        }
    }
}
