using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTasks.UserControls;

namespace WorkTasks.Forms
{
    public partial class TaskUpdate : Form
    {
        private TaskItem taskItem;
        public TaskUpdate(TaskItem taskItem)
        {
            InitializeComponent();
            this.taskItem = taskItem;
            string[] departmentsArray = taskItem.Departments.Split('|');
           
        }

        private void AddEmployee_btn_Click(object sender, EventArgs e)
        {
            label1.Text = taskItem.Departments;
        }
    }
}
