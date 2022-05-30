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
    public partial class ChangePersonalDataForm : Form
    {
        public ChangePersonalDataForm()
        {
            InitializeComponent();
            DBCommands db = new DBCommands();
            textNewName.Text = db.GetUserName(ID.findId);
            textNewSurname.Text = db.GetUserSurname(ID.findId);
            textNewEmail.Text = db.GetUserEmail(ID.findId);
        }

        private void buttonSaveChange_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            db.ChangePersonalData(textNewName.Text, textNewSurname.Text, textNewEmail.Text, ID.Id);
            this.Close();
        }
    }
}
