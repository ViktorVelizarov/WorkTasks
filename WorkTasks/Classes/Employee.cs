using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WorkTasks.Classes
{
    [Serializable]
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
        public int Id { get; set; }
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
