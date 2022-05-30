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
    public partial class AddDepForm : Form
    {
        public AddDepForm()
        {
            InitializeComponent();
        }

        private void buttonAddDep_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            db.AddDepartment(textDepName.Text);
            this.Close();
        }
    }
}
