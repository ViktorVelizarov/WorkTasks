using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTasks.Classes;

namespace WorkTasks.Forms
{
    public partial class AdminMainPage : Form
    {
        private Company company;
        private Employee loggedEmployee;
        public AdminMainPage(Company currentCompany, Employee loggedEmployee)
        {
            InitializeComponent();
            this.company = currentCompany;
            this.loggedEmployee = loggedEmployee;
            loggedAs.Text = "logged in as " + loggedEmployee.FirstName;
        }


        private void EmployeesPage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new EmployeePage(company, loggedEmployee);
            temp.Show();
        }

        private void TasksPage_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new TaskPage(company, loggedEmployee);
            temp.Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new HomePage(company);
            temp.Show();
        }
    }
}
