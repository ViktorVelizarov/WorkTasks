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
using System.Xml;
using WorkTasks.Classes;
using WorkTasks.Forms;

namespace WorkTasks.UserControls
{
    public partial class TaskItem : UserControl
    {

        //fields
        private string name;
        private string departments;
        private string deadline;
        private string status;
        private List<Employee> employees;
        private string description;
        private TaskPage taskPage;

        //constructor
        public TaskItem(TaskPage taskPage)
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
        //empty constructor
        public TaskItem() { }

        private void DeleteTask_btn_Click(object sender, EventArgs e)
        {
            DeleteTaskFromXML(name);
            taskPage.PopulateUserControls();
        }

        private void DeleteTaskFromXML(string titleToDelete)
        {
            string xmlFilePath = "tasks.xml";

            try
            {
                if (File.Exists(xmlFilePath))
                {
                    List<TaskClass> tasks;

                    // Read existing tasks from the XML file
                    using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
                    {
                        // Create a DataContractSerializer for TaskClass
                        DataContractSerializer serializer = new DataContractSerializer(typeof(List<TaskClass>));

                        // Deserialize the XML content into a List<TaskClass>
                        tasks = (List<TaskClass>)serializer.ReadObject(fs);
                    }

                    // Find the task to delete based on its title
                    TaskClass taskToDelete = tasks.FirstOrDefault(task => task.Title.Equals(titleToDelete, StringComparison.OrdinalIgnoreCase));

                    if (taskToDelete != null)
                    {
                        // Remove the task from the list
                        tasks.Remove(taskToDelete);

                        // Write the updated list back to the XML file
                        using (FileStream fs = new FileStream(xmlFilePath, FileMode.Create))
                        {
                            // Create a DataContractSerializer for List<TaskClass>
                            DataContractSerializer listSerializer = new DataContractSerializer(typeof(List<TaskClass>));

                            // Serialize the list of tasks to the XML file
                            using (XmlWriter writer = XmlWriter.Create(fs))
                            {
                                listSerializer.WriteObject(writer, tasks);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Task not found in XML file.");
                    }
                }
                else
                {
                    MessageBox.Show("XML file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting from XML: " + ex.Message);
            }
        }

        public void RefreshListbox()
        {
            EmployeesListbox.Items.Clear();
            foreach (Employee emp in employees)
            {
                EmployeesListbox.Items.Add(emp.FirstName + " " + emp.LastName + " | " + emp.Department);
            }
            if (status == "Open" && employees.Count == 0)
            {
                DeleteTask_btn.Enabled = true;
            }
            else
            {
                DeleteTask_btn.Enabled = false;
            }
        }
        private void UpdateTask_btn_Click(object sender, EventArgs e)
        {
            var temp = new TaskUpdate(this);
            temp.Show();
        }
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public bool RemoveEmployee(Employee emp)
        {
            return employees.Remove(emp);
        }

        private void TaskItem_Load(object sender, EventArgs e)
        {
            if (status == "Open" && employees.Count == 0)
            {
                DeleteTask_btn.Enabled = true;
            }
            else
            {
                DeleteTask_btn.Enabled = false;
            }
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
                    EmployeesListbox.Items.Add(emp.FirstName + " " + emp.LastName + " | " + emp.Department);
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

