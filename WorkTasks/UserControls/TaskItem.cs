using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTasks.Forms;

namespace WorkTasks.UserControls
{
    public partial class TaskItem : UserControl
    {
        private TaskPage taskPage;

        public TaskItem(TaskPage taskPage)
        {
            InitializeComponent();
            this.taskPage = taskPage;
        }

        //fields
        private string name;
        private string departments;
        private string deadline;
        private string status;
        private string byUser;
        private string description;

        private void DeleteTask_btn_Click(object sender, EventArgs e)
        {
            DeleteTaskFromCSV(name);
            taskPage.PopulateUserControls();
        }

        private void DeleteTaskFromCSV(string titleToDelete)
        {
            string csvFilePath = "tasks.csv";

            try
            {
                // Read all lines from the CSV file
                List<string> lines = File.ReadAllLines(csvFilePath).ToList();

                // Find the line that contains the task to delete based on its title
                string lineToDelete = lines.FirstOrDefault(line => line.StartsWith(titleToDelete));

                if (lineToDelete != null)
                {
                    // Remove the line containing the task to delete
                    lines.Remove(lineToDelete);

                    // Write the updated lines back to the CSV file
                    File.WriteAllLines(csvFilePath, lines);
                }
                else
                {
                    MessageBox.Show("Task not found in CSV file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting from CSV: " + ex.Message);
            }
        }

        private void UpdateTask_btn_Click(object sender, EventArgs e)
        {
            var temp = new TaskUpdate(this);
            temp.Show();
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

