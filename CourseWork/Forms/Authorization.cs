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
using CourseWork.Forms;

namespace CourseWork
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            string login = loginAuth.Text;
            string password = passwordAuth.Text;

            if (login == "admin" && password == "admin")
            {
                this.Hide();
                AdminForm form = new AdminForm();
                form.Show();
            }
            else
            {
                ID.Role = db.GetUserRole(login, password);
                ID.Id = db.GetUserId(login, password);

                if (ID.Role == "director")
                {
                    this.Hide();
                    DirectorForm form = new DirectorForm();
                    form.Show();
                }
                else if (ID.Role == "worker")
                {
                    this.Hide();
                    WorkerForm form = new WorkerForm();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Невірний логін чи пароль!");
                }
            }

        }
    }
}
