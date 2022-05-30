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
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            int id = Int32.Parse(deleteUserID.Text);
            db.DeleteUser(id);
            this.Close();
        }
    }
}
