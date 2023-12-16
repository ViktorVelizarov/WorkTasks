using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTasks.Classes
{
    public class Company
    {
        //fields
        private string name;
        public List <Task> tasks;

        //constructor
        public Company(string name)
        {
            this.name = name;
            this.tasks = new List<Task>();
        }
    }
}
