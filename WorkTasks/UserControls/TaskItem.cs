using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTasks.UserControls
{
    public partial class TaskItem : UserControl
    {
        public TaskItem()
        {
            InitializeComponent();
        }

        //fields
        private string name;
        private string departments;
        private string deadline;
        private string status;
        private string byUser;
        private string description;

      
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
        public string ByUser
        {
            get { return byUser; }
            set { byUser = value; byUserLabel.Text = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; dLabel.Text = value; }
        }
    }
}

