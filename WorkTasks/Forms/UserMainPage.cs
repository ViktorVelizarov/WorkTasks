using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTasks.Classes;
using WorkTasks.UserControls;

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
            PopulateUserControls(loggedEmployee.FirstName);
        }

        public void PopulateUserControls(string employeeNameFilter)
        {
            TasksFlowLayout2.Controls.Clear();
            string xmlFilePath = "tasks.xml";

            try
            {
                // Create a FileStream to read the XML file
                using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
                {
                    // Create a DataContractSerializer for TaskClass
                    DataContractSerializer serializer = new DataContractSerializer(typeof(List<TaskClass>));

                    // Deserialize the XML content into a List<TaskClass>
                    List<TaskClass> tasks = (List<TaskClass>)serializer.ReadObject(fs);

                    foreach (TaskClass task in tasks)
                    {
                        // Check if the task contains an employee with the specified name
                        bool containsEmployee = task.Employees.Any(employee => employee.FirstName.Equals(employeeNameFilter, StringComparison.OrdinalIgnoreCase));



                        // Check if all filters match, including the new employee filter
                        if (containsEmployee)
                        {
                            // Create a TaskItem and populate it with data from the XML
                            TaskItem2 taskItem = new TaskItem2();
                            taskItem.Name = task.Title;
                            taskItem.Status = task.Status.ToString();
                            taskItem.Description = task.Description;
                            taskItem.Deadline = task.Deadline;
                            taskItem.Employees = task.Employees;
                            taskItem.Departments = string.Join(" | ", task.Departments.Select(department => department.ToString()));

                            // Add the TaskItem to the flow layout
                            TasksFlowLayout2.Controls.Add(taskItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading from XML: " + ex.Message);
            }
        }


        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new HomePage(company);
            temp.Show();
        }
    }
}
