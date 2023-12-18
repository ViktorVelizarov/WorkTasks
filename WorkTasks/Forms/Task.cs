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
            foreach (TaskClass task in myCompany.Tasks())
            {
                TaskItem taskItem = new TaskItem();
                taskItem.Name = task.Title;
                taskItem.Description = task.Description;
                taskItem.Status = task.Status;
                taskItem.Deadline = task.Deadline;
                taskItem.ByUser = "user1";
                taskItem.Departments = task.Departments;
                //add to flowLayout

                TasksFlowLayout.Controls.Add(taskItem);
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
            }
            catch
            {
                MessageBox.Show("Error :/");
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
