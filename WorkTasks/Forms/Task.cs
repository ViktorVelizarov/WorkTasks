﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WorkTasks.Classes;
using WorkTasks.UserControls;

namespace WorkTasks.Forms
{
    public partial class TaskPage : Form
    {
        private string nameFilter;
        private string statusFilter;
        private string departmentFilter;
        private Company company;
        private Employee loggedEmployee;
        private HelperFuncitons hf = new HelperFuncitons();
        public TaskPage(Company currentCompany, Employee loggedEmployee)
        {
            InitializeComponent();
            company = currentCompany;
            this.loggedEmployee = loggedEmployee;
            LoadAllTasks();
        }


        //creating a taskItem user control for each task in the file
        public void PopulateUserControls()
        {
            TasksFlowLayout.Controls.Clear();
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
                        // Apply filters
                        bool nameMatches = string.IsNullOrEmpty(nameFilter) || task.Title.IndexOf(nameFilter, StringComparison.OrdinalIgnoreCase) >= 0;
                        bool statusMatches = string.IsNullOrEmpty(statusFilter) || task.Status.ToString().Equals(statusFilter, StringComparison.OrdinalIgnoreCase);
                        // Check if department filter matches any department in the list
                        bool departmentMatches = string.IsNullOrEmpty(departmentFilter) ||
                            task.Departments.Any(department => department.ToString().Trim().Equals(departmentFilter, StringComparison.OrdinalIgnoreCase));

                        // Check if all filters match
                        if (nameMatches && statusMatches && departmentMatches)
                        {
                            // Create a TaskItem and populate it with data from the XML
                            TaskItem taskItem = new TaskItem(this);
                            taskItem.Name = task.Title;
                            taskItem.Status = task.Status.ToString();
                            taskItem.Description = task.Description;
                            taskItem.Deadline = task.Deadline;
                            taskItem.Employees = task.Employees;
                            taskItem.Departments = string.Join(" | ", task.Departments.Select(department => department.ToString()));

                            // Add the TaskItem to the flow layout
                            TasksFlowLayout.Controls.Add(taskItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading from XML: " + ex.Message);
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
                    createdTask.AddDepartmentToList(DepartmentsEnum.ResearchandDevelopment);
                }

                company.AddTask(createdTask);
                MessageBox.Show("Task created succesfully!");
                hf.SaveTaskToXML(createdTask);
                LoadAllTasks();
            }
            catch
            {
                MessageBox.Show("Error :/");
            }

        }

        private void LoadAllTasks()
        {
            nameFilter = "";
            statusFilter = "";
            departmentFilter = "";
            NameBox.Text = "";
            StatusCombo.Text = "";
            DepartmentCombo.Text = "";
            PopulateUserControls();
        }

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new AdminMainPage(company, loggedEmployee);
            temp.Show();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            string nameText = NameBox.Text;
            nameFilter = nameText;
            PopulateUserControls();
        }

        private void StatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = StatusCombo.Text;
            statusFilter = selectedStatus;
            PopulateUserControls();
        }

        private void DepartmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = DepartmentCombo.Text;
            departmentFilter = selectedDepartment;
            PopulateUserControls();
        }
    }
}
