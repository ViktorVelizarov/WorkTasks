using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTasks.Classes
{
    [Serializable]
    public class TaskClass
    {
        //fields
        private string title;
        private List<DepartmentsEnum> departments;
        private StatusEnum status;
        private string description;
        private Employee employee;

        //constructor
        public TaskClass(string title, StatusEnum status,  string description) 
        {
            this.title = title;
            this.departments = new List<DepartmentsEnum>();
            this.status = status;
            this.description = description;
        }  

        //methods
        public void AddDepartmentToList(DepartmentsEnum department)
        {
            this.departments.Add(department);
        }
    }
}
