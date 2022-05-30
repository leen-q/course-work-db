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
    public partial class ChangeWorkDataForm : Form
    {
        public ChangeWorkDataForm()
        {
            InitializeComponent();

        }

        private void buttonSaveChange_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            db.ChangeWorkData(Int32.Parse(textNewPost.SelectedValue.ToString()), Int32.Parse(textNewDepartment.SelectedValue.ToString()), Int32.Parse(textNewEducation.SelectedValue.ToString()), Int32.Parse(textNewIdentCode.Text), ID.findId);
            this.Close();
        }

        private void ChangeWorkDataForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet7.education". При необходимости она может быть перемещена или удалена.
            this.educationTableAdapter.Fill(this.enterpriseDataSet7.education);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet6.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.enterpriseDataSet6.post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet5.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.enterpriseDataSet5.department);
            DBCommands db = new DBCommands();
            textNewDepartment.Text = db.GetUserDepartment(ID.findId);
            textNewEducation.Text = db.GetUserEducation(ID.findId);
            textNewPost.Text = db.GetUserPost(ID.findId);
            textNewIdentCode.Text = db.GetUserIdentCode(ID.findId);

        }
    }
}
