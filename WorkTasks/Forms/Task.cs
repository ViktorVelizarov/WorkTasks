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
using WorkTasks.UserControls;

namespace WorkTasks.Forms
{
    public partial class TaskPage : Form
    {
        Company myCompany = new Company("company1");
        public TaskPage()
        {
            InitializeComponent();
        }

        public void PopulateUserControls()
        {
            TasksFlowLayout.Controls.Clear();
            string csvFilePath = "tasks.csv";

            try
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(csvFilePath);

                foreach (string line in lines)
                {
                    // Split the CSV line into individual values
                    string[] values = line.Split(',');

                    // Create a TaskItem and populate it with data from the CSV
                    TaskItem taskItem = new TaskItem(this);
                    taskItem.Name = values[0]; 
                    taskItem.Status =  values[1];  
                    taskItem.Description = values[2];  
                    taskItem.Deadline = values[3]; 
                    taskItem.ByUser = values[4]; 
                    taskItem.Departments = values[5]; 

                    // Add the TaskItem to the flow layout
                    TasksFlowLayout.Controls.Add(taskItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading from CSV: " + ex.Message);
            }
        }
        private void CreateTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string taskName = nameTextbox.Text;
                string taskDescription = descTextbox.Text;
                DateTime datetime = deadlineCalendar.SelectionRange.Start;
                string taskDeadlineString = datetime.ToString("yyyy-MM-dd");
                string taskDeadline = taskDeadlineString;
                StatusEnum taskStatus = StatusEnum.Open;
                if (statusRadio1.Checked)
                {
                    taskStatus = StatusEnum.Open;
                }
                else if (statusRadio2.Checked)
                {
                    taskStatus = StatusEnum.InProgress;
                }
                else if (statusRadio3.Checked)
                {
                    taskStatus = StatusEnum.Completed;
                }
                else if (statusRadio4.Checked)
                {
                    taskStatus = StatusEnum.Blocked;
                }
                else if (statusRadio5.Checked)
                {
                    taskStatus = StatusEnum.Cancelled;
                }

                TaskClass createdTask = new TaskClass(taskName, taskStatus, taskDescription, taskDeadline);

                if (departCheck1.Checked)
                {
                    createdTask.AddDepartmentToList(DepartmentsEnum.HumanResources);
                }
                if (departCheck2.Checked)
                {
                    createdTask.AddDepartmentToList(DepartmentsEnum.Marketing);
                }
                if (departCheck3.Checked)
                {
                    createdTask.AddDepartmentToList(DepartmentsEnum.Sales);
                }
                if (departCheck4.Checked)
                {
                    createdTask.AddDepartmentToList(DepartmentsEnum.Support);
                }
                if (departCheck5.Checked)
                {
                    createdTask.AddDepartmentToList(DepartmentsEnum.ResearchAndDevelopment);
                }

                myCompany.AddTask(createdTask);
                MessageBox.Show("Task created succesfully!");
                SaveTaskToCSV(createdTask);
            }
            catch
            {
                MessageBox.Show("Error :/");
            }

        }

        private void SaveTaskToCSV(TaskClass task)
        {
            string csvFilePath = "tasks.csv"; // Specify the path for your CSV file

            try
            {
                using (StreamWriter sw = new StreamWriter(csvFilePath, true))
                {
                    // Write task details to the CSV file
                    sw.WriteLine($"{task.Title},{task.Status},{task.Description},{task.Deadline}, {task.EmployeeName} ,{string.Join(",", task.Departments)}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to CSV: " + ex.Message);
            }
        }

        private void LoadAllTasks_btn_Click(object sender, EventArgs e)
        {
            PopulateUserControls();
        }

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new HomePage();
            temp.Show();
        }
    }
}
