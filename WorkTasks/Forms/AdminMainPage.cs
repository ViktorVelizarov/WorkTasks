using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTasks.Forms
{
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }


        private void EmployeesPage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new EmployeePage();
            temp.Show();
        }

        private void TasksPage_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new TaskPage();
            temp.Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new HomePage();
            temp.Show();
        }
    }
}
