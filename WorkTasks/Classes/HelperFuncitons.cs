using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WorkTasks.Classes
{
    public class HelperFuncitons
    {
        //field
        public Company company = new Company("comp1");

        //empty constructor
        public HelperFuncitons()
        {

        }

        //constructor
        public HelperFuncitons(Company currentCompany) { 
            this.company = currentCompany;
            GetEmployeesFromFile();
        }

        //methods
        public void UpdateTaskInXML(TaskClass updatedTask)
        {
            string xmlFilePath = "tasks.xml"; // Specify the path for your XML file

            try
            {
                List<TaskClass> existingTasks;
                if (File.Exists(xmlFilePath))
                {
                    // Read existing tasks from the XML file
                    using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
                    {
                        // Create a DataContractSerializer for TaskClass
                        DataContractSerializer serializer = new DataContractSerializer(typeof(List<TaskClass>));

                        // Deserialize the XML content into a List<TaskClass>
                        existingTasks = (List<TaskClass>)serializer.ReadObject(fs);
                    }
                }
                else
                {
                    // If the file doesn't exist, create a new list of tasks
                    existingTasks = new List<TaskClass>();
                }

                // Find the index of the task to update based on its title
                int indexToUpdate = existingTasks.FindIndex(task => task.Title.Equals(updatedTask.Title, StringComparison.OrdinalIgnoreCase));

                if (indexToUpdate != -1)
                {
                    // Update the task at the specified index
                    existingTasks[indexToUpdate] = updatedTask;

                    // Write the updated list back to the XML file
                    using (FileStream fs = new FileStream(xmlFilePath, FileMode.Create))
                    {
                        // Create a DataContractSerializer for List<TaskClass>
                        DataContractSerializer listSerializer = new DataContractSerializer(typeof(List<TaskClass>));

                        // Serialize the list of tasks to the XML file
                        using (XmlWriter writer = XmlWriter.Create(fs))
                        {
                            listSerializer.WriteObject(writer, existingTasks);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Task not found in XML file for updating.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating task in XML: " + ex.Message);
            }
        }

        public TaskClass FindTaskByTitle(string titleToFind)
        {
            string xmlFilePath = "tasks.xml"; // Specify the path for your XML file

            try
            {
                List<TaskClass> existingTasks;

                // Check if the file exists
                if (File.Exists(xmlFilePath))
                {
                    // Read existing tasks from the XML file
                    using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
                    {
                        // Create a DataContractSerializer for TaskClass
                        DataContractSerializer serializer = new DataContractSerializer(typeof(List<TaskClass>));

                        // Deserialize the XML content into a List<TaskClass>
                        existingTasks = (List<TaskClass>)serializer.ReadObject(fs);
                    }
                }
                else
                {
                    // If the file doesn't exist, create a new list of tasks
                    existingTasks = new List<TaskClass>();
                }

                // Find the task based on its title
                TaskClass foundTask = existingTasks.FirstOrDefault(task => task.Title.Equals(titleToFind, StringComparison.OrdinalIgnoreCase));

                if (foundTask != null)
                {
                    // Task found, you can return it or do further processing
                    return foundTask;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding task in XML: " + ex.Message);
                return null;
            }
        }

        public void GetEmployeesFromFile()
        {
            string filePath = "MOCK_EMPLOYEE_DATA.csv";

            List<string> targetDepartments = new List<string> { "Human Resources", "Marketing", "Sales", "Support", "Research and Development" };


            // Use TextFieldParser to read the CSV file
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(","); // Set the delimiter to ,

                // Skip the header row
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    // Check if the department is in the target departments
                    if (targetDepartments.Contains(fields[10]))
                    {
                        // Create an Employee object and populate its properties
                        Employee employee = new Employee
                        {
                            Id = int.Parse(fields[0]),
                            Ssn = fields[1],
                            FirstName = fields[2],
                            LastName = fields[3],
                            Gender = fields[4],
                            StreetName = fields[5],
                            StreetNumber = int.Parse(fields[6]),
                            Zipcode = fields[7],
                            City = fields[8],
                            Email = fields[9],
                            Department = fields[10],
                            IsAdmin = false
                        };

                        // Add the Employee object to the company list
                        company.AddEmployee(employee);
                    }
                }
            }
        }
    }
}
