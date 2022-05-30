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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowProfile_Click(object sender, EventArgs e)
        {
            ID.findId = ID.Id;
            WorkerInfoForm form = new WorkerInfoForm();
            form.Show();
        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            MessageForm form = new MessageForm();
            form.Show();
        }
    }
}
