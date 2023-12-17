﻿using System;
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
        private string deadline;
        private Employee employee;

        //getters
        public string Title
        {
            get { return title; }
        }
        public string Departments
        {
            get { return string.Join(" ", departments.Select(d => d.ToString())); }
        }
        public string Status
        {
            get { return status.ToString(); }
        }
        public string Description
        {
            get { return description; }
        }
        public string Deadline
        {
            get { return deadline; }
        }

        //constructor
        public TaskClass(string title, StatusEnum status,  string description) 
        {
            this.title = title;
            this.departments = new List<DepartmentsEnum>();
            this.status = status;
            this.description = description;
            this.deadline = "bruh";
        }  

        //methods
        public void AddDepartmentToList(DepartmentsEnum department)
        {
            this.departments.Add(department);
        }

        public string GetInfo()
        {
            return "Name: " + title + " | Departments: " + departments + " | Status: " + 
            status + " | desctiption: " + description;
        }
    }
}
