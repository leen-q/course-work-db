using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Forms;

namespace CourseWork
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet11.workdatahistory". При необходимости она может быть перемещена или удалена.
            this.workdatahistoryTableAdapter1.Fill(this.enterpriseDataSet11.workdatahistory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet10.personaldatahistory". При необходимости она может быть перемещена или удалена.
            this.personaldatahistoryTableAdapter1.Fill(this.enterpriseDataSet10.personaldatahistory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet2.workdatahistory". При необходимости она может быть перемещена или удалена.
            this.workdatahistoryTableAdapter.Fill(this.enterpriseDataSet2.workdatahistory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet1.personaldatahistory". При необходимости она может быть перемещена или удалена.
            this.personaldatahistoryTableAdapter.Fill(this.enterpriseDataSet1.personaldatahistory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.logintable". При необходимости она может быть перемещена или удалена.
            this.logintableTableAdapter.Fill(this.enterpriseDataSet.logintable);

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.Show();
        }

        private void buttonRefreshUsers_Click(object sender, EventArgs e)
        {
            this.logintableTableAdapter.Fill(this.enterpriseDataSet.logintable);
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUserForm form = new DeleteUserForm();
            form.Show();
        }
    }
}
