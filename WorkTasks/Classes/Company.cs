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

        //getters
        public List<TaskClass> Tasks()
        {
            return tasks;
        }

        //constructor
        public Company(string name)
        {
            this.name = name;
            this.tasks = new List<TaskClass>();
        }

        //methods
        public void AddTask(TaskClass task)
        { 
            tasks.Add(task);
        }
    }
}
