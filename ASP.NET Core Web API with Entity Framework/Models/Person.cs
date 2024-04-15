namespace ASP.NET_Core_Web_API_with_Entity_Framework.Models
{
    public class Person
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}