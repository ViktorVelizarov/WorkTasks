using WorkTasks.Forms;

namespace WorkTasks
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void TasksPage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new TaskPage();
            temp.Show();
        }

        private void EmployeesPage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new EmployeePage();
            temp.Show();
        }
    }
}