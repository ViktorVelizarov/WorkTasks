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
using WorkTasks.Forms;

namespace WorkTasks.UserControls
{
    public partial class TaskItem2 : UserControl
    {
        //fields
        private string name;
        private string departments;
        private string deadline;
        private string status;
        private List<Employee> employees;
        private string description;
        private TaskPage taskPage;
        private HelperFuncitons hf = new HelperFuncitons();
        //empty constructor
        public TaskItem2()
        {
            InitializeComponent();
        }
        //constructor
        public TaskItem2(TaskPage taskPage)
        {
            InitializeComponent();
            EmployeesListbox.Items.Clear();
            this.taskPage = taskPage;
            if (employees == null)
            {
                EmployeesListbox.Items.Add("No employees...");
            }
            else
            {
                EmployeesListbox.Items.Add(" employees...");
            }

        }
        private void UpdateTask_btn_Click(object sender, EventArgs e)
        {
            TaskClass taskToUpdate = hf.FindTaskByTitle(name);
            taskToUpdate.Status = (StatusEnum)Enum.Parse(typeof(StatusEnum), StatusCombo.Text);
            Status = StatusCombo.Text;
            hf.UpdateTaskInXML(taskToUpdate);
        }

        //getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; nameLabel.Text = value; }
        }
        public string Departments
        {
            get { return departments; }
            set { departments = value; departmentsLabel.Text = value; }
        }
        public string Deadline
        {
            get { return deadline; }
            set { deadline = value; deadlineLabel.Text = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; statusLabel.Text = value; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
            set
            {
                employees = value;
                EmployeesListbox.Items.Clear();
                foreach (Employee emp in employees)
                {
                    EmployeesListbox.Items.Add(emp.FirstName + emp.LastName + " | " + emp.Department);
                }
            }
        }
        public string Description
        {
            get { return description; }
            set { description = value; dLabel.Text = value; }
        }
    }
}
