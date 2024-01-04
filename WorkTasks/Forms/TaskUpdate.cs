using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTasks.UserControls;
using Microsoft.VisualBasic.FileIO;
using WorkTasks.Classes;

namespace WorkTasks.Forms
{
    public partial class TaskUpdate : Form
    {
        private TaskItem taskItem;
        private List<string> neededDepartments;
        public TaskUpdate(TaskItem taskItem)
        {
            InitializeComponent();
            this.taskItem = taskItem;
            string[] departmentsArray = taskItem.Departments.Split('|');
            neededDepartments = departmentsArray.Select(word => word.Trim()).ToList();
            PopulateUserControls();
        }

        public void PopulateUserControls()
        {
            AddEmployeeFlow.Controls.Clear();
            string filePath = "MOCK_EMPLOYEE_DATA.csv";

         
            List<Employee> employees = new List<Employee>();

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
                    if (neededDepartments.Contains(fields[10]))
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
                            Department = fields[10]
                        };

                        // Add the Employee object to the list
                        employees.Add(employee);
                        EmployeeItem employeeItem = new EmployeeItem(true,taskItem);
                        employeeItem.Id = int.Parse(fields[0]);
                        employeeItem.Ssn = fields[1];
                        employeeItem.FirstName = fields[2];
                        employeeItem.LastName = fields[3];
                        employeeItem.Gender = fields[4];
                        employeeItem.StreetName = fields[5];
                        employeeItem.StreetNumber = int.Parse(fields[6]);
                        employeeItem.Zipcode = fields[7];
                        employeeItem.City = fields[8];
                        employeeItem.Email = fields[9];
                        employeeItem.Department = fields[10];
                        AddEmployeeFlow.Controls.Add(employeeItem);
                    }
                }
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
