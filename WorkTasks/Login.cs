using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;
using WorkTasks.Classes;
using WorkTasks.Forms;

namespace WorkTasks
{
    public partial class HomePage : Form
    {
        public Company company = new Company("");

        public HomePage(Company myCompany)
        {
            InitializeComponent();
            this.company = myCompany;
            Employee admin = new Employee
            {
                Id = 1234,
                Ssn = "1234",
                FirstName = "admin",
                LastName = "admin",
                Gender = "male",
                StreetName = "test",
                StreetNumber = 1,
                Zipcode = "test",
                City = "test",
                Email = "test",
                Department = "test",
                IsAdmin = true
            };
            company.AddEmployee(admin);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string loginName = NameBox.Text;
            string loginEmail = EmailBox.Text;
            Employee loggedEmployee = company.FindEmployee(loginName, loginEmail);
            if (loggedEmployee != null)
            {
                if(loggedEmployee.IsAdmin)
                {
                    this.Hide();
                    var temp = new AdminMainPage(company, loggedEmployee);
                    temp.Show();
                }
                else
                {
                    this.Hide();
                    var temp = new UserMainPage(company, loggedEmployee);
                    temp.Show();
                }
               
            }
            else
            {
                MessageBox.Show("incorrect info :/");
            }

        }
    }
}