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
    public partial class AddPostForm : Form
    {
        public AddPostForm()
        {
            InitializeComponent();
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            DBCommands db = new DBCommands();
            db.AddPost(textPostName.Text, Int32.Parse(textPostSalary.Text));
            this.Close();
        }
    }
}
