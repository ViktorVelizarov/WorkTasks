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
            GetEmployeesFromFile();
            PopulateUserControls();
        }

        public void GetEmployeesFromFile()
        {
            string filePath = "MOCK_EMPLOYEE_DATA.csv";

            List<string> targetDepartments = new List<string> { "Human Resources", "Marketing", "Sales", "Support", "Research and Development" };


            // Use TextFieldParser to read the CSV file
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(","); // Set the delimiter to ,

                // Skip the header row
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    // Check if the department is in the target departments
                    if (targetDepartments.Contains(fields[10]))
                    {
                        // Create an Employee object and populate its properties
                        Employee employee = new Employee
                        {
                            Id = int.Parse(fields[0]),
                            Ssn = fields[1],
                            FirstName = fields[2],
                            LastName = fields[3],
                            Gender = fields[4],
                            StreetName = fields[5],
                            StreetNumber = int.Parse(fields[6]),
                            Zipcode = fields[7],
                            City = fields[8],
                            Email = fields[9],
                            Department = fields[10],
                            IsAdmin = false
                        };

                        // Add the Employee object to the list
                        employees.Add(employee);
                    }
                }
            }
        }
        public void PopulateUserControls()
        {
            EmployeesFlowLayout.Controls.Clear();
            foreach (Employee emp in employees)
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
