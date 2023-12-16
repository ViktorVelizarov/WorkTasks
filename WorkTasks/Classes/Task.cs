using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTasks.Classes
{
    public class Task
    {
        //fields
        private string title;
        private List<DepartmentsEnum> departments;
        private StatusEnum status;
        private string description;
        private Employee employee;

        //constructor
        public Task(string title, string description) 
        {
            this.title = title;
            this.description = description;
        }  
    }
}
