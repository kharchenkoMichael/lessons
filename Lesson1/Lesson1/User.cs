
namespace Lesson1
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        { 
            var type = GetType();
            return type.GetProperties().Select(property => property.GetValue(this)?.ToString()).Aggregate((prop1, prop2) => $"{prop1}, {prop2}"); 
        }
    }
}
