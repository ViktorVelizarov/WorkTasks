using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTasks.Classes
{
    public class HelperFuncitons
    {
        //field
        public Company company = new Company("comp1");

        //constructor
        public HelperFuncitons(Company currentCompany) { 
            this.company = currentCompany;
            GetEmployeesFromFile();
        }

        //methods
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
