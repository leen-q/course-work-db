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
    public partial class CreateNewMessageForm : Form
    {
        public CreateNewMessageForm()
        {
            InitializeComponent();
        }

        private void buttonSaveNewMessage_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            db.AddMessage(textNewMessageSubject.Text, textNewMessageText.Text);
            this.Close();
        }
    }
}
