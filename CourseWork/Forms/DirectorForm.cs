using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        private void DirectorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowAllWorkers_Click(object sender, EventArgs e)
        {
            WorkerListForm form = new WorkerListForm();
            form.Show();
        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            MessageForm form = new MessageForm();
            form.Show();
        }

        private void buttonPostDep_Click(object sender, EventArgs e)
        {
            PostDepForm form = new PostDepForm();
            form.Show();
        }
    }
}
