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
    public partial class TaskPage : Form
    {
        Company myCompany = new Company("company1");
        public TaskPage()
        {
            InitializeComponent();
        }

        private void CreateTask_btn_Click(object sender, EventArgs e)
        {
            string taskName = nameTextbox.Text;
            string taskDescription = descTextbox.Text;
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

            TaskClass createdTask = new TaskClass(taskName, taskStatus, taskDescription);

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
        }

        private void LoadAllTasks_btn_Click(object sender, EventArgs e)
        {
            TasksListbox.Items.Clear();
            foreach (TaskClass task in myCompany.Tasks())
            {
                TasksListbox.Items.Add(task);
            }
        }
    }
}
