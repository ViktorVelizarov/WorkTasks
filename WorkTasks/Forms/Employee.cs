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
using Microsoft.VisualBasic.FileIO;
using WorkTasks.UserControls;

namespace WorkTasks.Forms
{
    public partial class EmployeePage : Form
    {
        public List<Employee> employees = new List<Employee>();
        private Company company;
        private Employee loggedEmployee;
        public EmployeePage(Company currentCompany, Employee loggedEmployee)
        {
            InitializeComponent();
            this.company = currentCompany;
            this.loggedEmployee = loggedEmployee;
            PopulateUserControls();
        }
        
        //creating the EmployeeItem user controls for each employee object in the company
        public void PopulateUserControls()
        {
            EmployeesFlowLayout.Controls.Clear();
            foreach (Employee emp in company.employees)
            {
                TaskItem taskItem = new TaskItem();
                EmployeeItem employeeItem = new EmployeeItem(false, taskItem);
                employeeItem.Id = emp.Id;
                employeeItem.Ssn = emp.Ssn;
                employeeItem.FirstName = emp.FirstName;
                employeeItem.LastName = emp.LastName;
                employeeItem.Gender = emp.Gender;
                employeeItem.StreetName = emp.StreetName;
                employeeItem.StreetNumber = emp.StreetNumber;
                employeeItem.Zipcode = emp.Zipcode;
                employeeItem.City = emp.City;
                employeeItem.Email = emp.Email;
                employeeItem.Department = emp.Department;
                EmployeesFlowLayout.Controls.Add(employeeItem);
            }

        }

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new AdminMainPage(company, loggedEmployee);
            temp.Show();
        }
    }
}
