namespace ASP.NET_Core_Web_API_with_Entity_Framework.Models
{
    // An example for the standard model definition
    public class Person
    {
        public Guid Id { get; } // Its value should not be set by the program but the database
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public double Height { get; set; }
        public DateTime LastModifiedTime { get; } // Its value should not be set by the program but the database
    }
}