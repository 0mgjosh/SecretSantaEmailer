namespace SecretSantaMailer
{
    public class Person
    {
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
    public class Plist
    {
        public string Name { get; set; }
        public List<Person> Members { get; set; } = new List<Person>();
        public Plist() { }
        public Plist(Plist plist)
        {
            Name = plist.Name;
            Members = plist.Members;
        }
    }
}
