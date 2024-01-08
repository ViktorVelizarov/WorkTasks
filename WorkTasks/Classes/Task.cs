using System.Runtime.Serialization;
using WorkTasks.Classes;

[DataContract]
public class TaskClass
{
    //fields
    private string title;
    private List<DepartmentsEnum> departments;
    private StatusEnum status;
    private string description;
    private string deadline;
    private List<Employee> employees;

    //getters and setters
    [DataMember]
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    [DataMember]
    public List<DepartmentsEnum> Departments
    {
        get { return departments; }
        set { departments = value; }
    }

    [DataMember]
    public StatusEnum Status
    {
        get { return status; }
        set { status = value; }
    }

    [DataMember]
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    [DataMember]
    public string Deadline
    {
        get { return deadline; }
        set { deadline = value; }
    }

    [DataMember]
    public List<Employee> Employees
    {
        get { return employees; }
        set { employees = value; }
    }

    //constructor
    public TaskClass(string title, StatusEnum status, string description, string deadline)
    {
        this.title = title;
        this.departments = new List<DepartmentsEnum>();
        this.status = status;
        this.description = description;
        this.deadline = deadline;
        this.employees = new List<Employee>();
    }

    //methods
    public void AddEmployeeToList(Employee emp)
    {
        this.employees.Add(emp);
    }
    public bool RemoveEmployeeFromList(Employee emp)
    {
       return  this.employees.Remove(emp);
    }

    public void AddDepartmentToList(DepartmentsEnum department)
    {
        this.departments.Add(department);
    }
}
