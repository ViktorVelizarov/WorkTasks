using System.Runtime.Serialization;

[DataContract]
public class Employee
{
    //fields
    private int id;
    private string ssn;
    private string firstName;
    private string lastName;
    private string gender;
    private string streetName;
    private int streetNumber;
    private string zipcode;
    private string city;
    private string email;
    private string department;

    //getters and setters
    [DataMember]
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    [DataMember]
    public string Ssn
    {
        get { return ssn; }
        set { ssn = value; }
    }

    [DataMember]
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    [DataMember]
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    [DataMember]
    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    [DataMember]
    public string StreetName
    {
        get { return streetName; }
        set { streetName = value; }
    }

    [DataMember]
    public int StreetNumber
    {
        get { return streetNumber; }
        set { streetNumber = value; }
    }

    [DataMember]
    public string Zipcode
    {
        get { return zipcode; }
        set { zipcode = value; }
    }

    [DataMember]
    public string City
    {
        get { return city; }
        set { city = value; }
    }

    [DataMember]
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    [DataMember]
    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    //had to override this cause for some reason the removeFromTask function wasnt working properly
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Employee otherEmployee = (Employee)obj;

        // Compare properties for equality
        return Id == otherEmployee.Id && FirstName == otherEmployee.FirstName; // Add other properties as needed
    }

}
