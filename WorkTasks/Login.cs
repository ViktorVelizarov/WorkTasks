using WorkTasks.Forms;

namespace WorkTasks
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new AdminMainPage();
            temp.Show();
        }
    }
}