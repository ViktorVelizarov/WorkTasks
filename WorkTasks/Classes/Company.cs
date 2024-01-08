using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTasks.Classes
{
    [Serializable]
    public class Company
    {
        //fields
        private string name;
        public List<TaskClass> tasks;
        public List<Employee> employees;


        //constructor
        public Company(string name)
        {
            this.name = name;
            this.tasks = new List<TaskClass>();
            this.employees = new List<Employee>();
        }

        //methods
        public void AddTask(TaskClass task)
        { 
            tasks.Add(task);
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        // Find employee by Name and Email
        public Employee FindEmployee(string name, string email)
        {
            return employees.Find(emp => emp.LastName == name && emp.Email == email);
        }
    }
}
