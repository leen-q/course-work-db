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
    public partial class WorkerListForm : Form
    {
        public WorkerListForm()
        {
            InitializeComponent();
        }

        private void WorkerList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet5.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.enterpriseDataSet5.department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet3.personaldata". При необходимости она может быть перемещена или удалена.
            this.personaldataTableAdapter.Fill(this.enterpriseDataSet3.personaldata);

        }

        //Натискання клавіші відкриття профілю працівника по його id
        private void buttonShowWorkerInfo_Click(object sender, EventArgs e)
        {
            ID.findId = Int32.Parse(textOpenProfile.Text);
            WorkerInfoForm form = new WorkerInfoForm();
            form.Show();
        }

        //Натискання клавіші пошуку працівника по імені чи прізвищу
        private void buttonFind_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            dataGridView1.DataSource = db.GetUserByName(textFindWorker.Text);
        }

        //Оновлення даних в таблиці
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = enterpriseDataSet3.personaldata;
        }

        //Сортування працівників в таблиці в залнжості від обраного відділу
        private void buttonSort_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            dataGridView1.DataSource = db.GetUserByDepartment(Int32.Parse(depSort.SelectedValue.ToString()));
        }
    }
}
