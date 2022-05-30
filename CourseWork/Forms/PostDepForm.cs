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
    public partial class PostDepForm : Form
    {
        public PostDepForm()
        {
            InitializeComponent();
        }

        private void PostDepForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet9.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.enterpriseDataSet9.post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet8.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.enterpriseDataSet8.department);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddDep_Click(object sender, EventArgs e)
        {
            AddDepForm form = new AddDepForm();
            form.Show();
        }

        private void buttonDelDep_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            db.DeleteDep(Int32.Parse(textDelDep.Text));
            this.departmentTableAdapter.Fill(this.enterpriseDataSet8.department);
        }

        private void buttonDelPost_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            db.DeletePost(Int32.Parse(textDelPost.Text));
            this.postTableAdapter.Fill(this.enterpriseDataSet9.post);
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            AddPostForm form = new AddPostForm();
            form.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.postTableAdapter.Fill(this.enterpriseDataSet9.post);
            this.departmentTableAdapter.Fill(this.enterpriseDataSet8.department);
        }
    }
}
