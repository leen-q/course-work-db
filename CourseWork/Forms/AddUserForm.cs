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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void buttonConfirmAdd_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            db.AddUser(newUserLogin.Text, newUserPassword.Text, newUserRole.Text);
            int id = db.GetUserId(newUserLogin.Text, newUserPassword.Text);
            db.AddPersonalData(id);
            db.AddWorkData(id);
            this.Close();
        }
    }
}
