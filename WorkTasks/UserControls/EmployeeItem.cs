using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Runtime.Serialization;
using WorkTasks.Forms;
using WorkTasks.Classes;

namespace WorkTasks.UserControls
{
    public partial class EmployeeItem : UserControl
    {
        private TaskItem taskItem;
        private int id;
        private string ssn;
        private string firstName;
        private string lastName;
        private string gender;
        private string streetName;
        private int streetNumber;
        private string zipcode;
        private string city;
        private string email;
        private string department;
        private HelperFuncitons hf = new HelperFuncitons();
        public EmployeeItem(bool showButton, TaskItem taskItem)
        {
            InitializeComponent();
            if (!showButton)
            {
                Add_btn.Visible = false;
            }
            this.taskItem = taskItem;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee
            {
                Id = id,
                Ssn = ssn,
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                StreetName = streetName,
                StreetNumber = streetNumber,
                Zipcode = zipcode,
                City = city,
                Email = email,
                Department = department
            };
            //get the TaskClass object we need to update( because we cant use the TaskItem object)
            TaskClass taskToUpdate = hf.FindTaskByTitle(taskItem.Name);

            if (Add_btn.Text == "Add")
            {
                taskToUpdate.AddEmployeeToList(newEmployee);
                taskItem.AddEmployee(newEmployee);
                //update the xml file wit the updated task object
                hf.UpdateTaskInXML(taskToUpdate);
                //refresh the listbox so we see the change
                taskItem.RefreshListbox();
                Add_btn.BackColor = Color.Red;
                Add_btn.Text = "Remove";
            }
            else
            {

                if (taskItem.RemoveEmployee(newEmployee) && taskToUpdate.RemoveEmployeeFromList(newEmployee))
                {
                    //update the xml file wit the updated task object
                    hf.UpdateTaskInXML(taskToUpdate);
                    //refresh the listbox so we see the change
                    taskItem.RefreshListbox();
                    Add_btn.BackColor = Color.LightGreen;
                    Add_btn.Text = "Add";
                }

            }
        }

        private bool TaskContainsEmployee(TaskClass taskToUpdate)
        {
            if (taskToUpdate != null)
            {
                foreach (Employee emp in taskToUpdate.Employees)
                {
                    if (emp.FirstName == firstNameLabel.Text)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

    
        private void EmployeeItem_Load(object sender, EventArgs e)
        {
            //get the TaskClass object we need to update( because we cant use the TaskItem object)
            TaskClass taskToUpdate = hf.FindTaskByTitle(taskItem.Name);

            if (!TaskContainsEmployee(taskToUpdate))
            {
                Add_btn.BackColor = Color.LightGreen;
                Add_btn.Text = "Add";
            }
            else
            {
                Add_btn.BackColor = Color.Red;
                Add_btn.Text = "Remove";
            }
        }

        //getters and setters

        public int Id
        {
            get { return id; }
            set { id = value; idLabel.Text = value.ToString(); }
        }

        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; ssnLabel.Text = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; firstNameLabel.Text = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; lastNameLabel.Text = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; genderLabel.Text = value; }
        }

        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        public int StreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }

        public string Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; emialLabel.Text = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; departmentLabel.Text = value; }
        }
    }
}
