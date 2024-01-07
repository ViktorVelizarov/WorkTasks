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
    public partial class UserMainPage : Form
    {
        private Company company;
        private Employee loggedEmployee;
        public UserMainPage(Company currentCompany, Employee loggedEmployee)
        {
            InitializeComponent();
            this.company = currentCompany;
            this.loggedEmployee = loggedEmployee;
            LoggedAs.Text = "logged in as " + loggedEmployee.FirstName;
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new HomePage(company);
            temp.Show();
        }
    }
}
