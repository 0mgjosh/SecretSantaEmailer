using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSantaMailer
{
    public class Person
    {
        public static List<Person> Members = new List<Person>();
        public static List<Person> Members_Remaining = new List<Person>();

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Person? AssignedPerson { get; set; }

        public Person(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
