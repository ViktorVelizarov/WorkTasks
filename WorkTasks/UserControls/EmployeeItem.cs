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

namespace WorkTasks.UserControls
{
    public partial class EmployeeItem : UserControl
    {
        private TaskItem taskItem;
        public EmployeeItem( bool showButton, TaskItem taskItem)
        {
            InitializeComponent();
            if (!showButton)
            {
                Add_btn.Visible = false;
            }
            this.taskItem = taskItem;
        }

        //fields
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

        private void Add_btn_Click(object sender, EventArgs e)
        {
          //  taskItem.AddEmployee(this.Name);
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
