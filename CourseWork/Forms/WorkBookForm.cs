using System.Windows.Forms;
using CourseWork.DB;

namespace CourseWork.Forms
{
    public partial class WorkBookForm : Form
    {
        public WorkBookForm()
        {
            InitializeComponent();
            DBCommands db = new DBCommands();
            dataGridView1.DataSource = db.GetWorkBook(ID.findId);
        }
    }
}
