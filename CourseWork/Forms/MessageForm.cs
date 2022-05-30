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
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet4.messagetable". При необходимости она может быть перемещена или удалена.
            this.messagetableTableAdapter.Fill(this.enterpriseDataSet4.messagetable);

        }

        private void buttonNewMessage_Click(object sender, EventArgs e)
        {
            if (ID.Role == "director")
            {
                CreateNewMessageForm form = new CreateNewMessageForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Недостатньо прав!");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.messagetableTableAdapter.Fill(this.enterpriseDataSet4.messagetable);
        }
    }
}
