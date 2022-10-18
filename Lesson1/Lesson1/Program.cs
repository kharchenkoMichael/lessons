
List<User> users = new List<User>
{
    new User() {Name = "Misha", Age = 24, City = "Kremenchuk", IsMaried = true },
    new User() {Name = "Vasya", Age = 26, City = "Kremenchuk", IsMaried = false },
    new User() {Name = "Petya", Age = 22, City = "Kharkiv", IsMaried = true },
    new User() {Name = "Taras", Age = 45, City = "Kremenchuk", IsMaried = true },
    new User() {Name = "Egor", Age = 15, City = "Kyiv", IsMaried = false },
    new User() {Name = "Mykola", Age = 5, City = "Lviv", IsMaried = false },
    new User() {Name = "Styopa", Age = 21, City = "Kyiv", IsMaried = true },
    new User() {Name = "Vlad", Age = 19, City = "Kharkiv", IsMaried = false },
    new User() {Name = "Viktor", Age = 20, City = "Kharkiv", IsMaried = false },
    new User() {Name = "Valera", Age = 30, City = "Kyiv", IsMaried = true },
    new User() {Name = "Max", Age = 35, City = "Lviv", IsMaried = true },
    new User() {Name = "Olga", Age = 25, City = "Kyiv", IsMaried = true },
    new User() {Name = "Maria", Age = 28, City = "Kremenchuk", IsMaried = true },
    new User() {Name = "Oleg", Age = 60, City = "Lviv", IsMaried = true },
};
var u = users.Where(item => item.Age > 18).OrderBy(item => item.Name).Select((item, index) => new { index, item.Name, item.Age, item.City, item.IsMaried });
foreach (var item in u)
{
    Console.WriteLine($"{item.index}: {item.Name} {item.Age} {item.City} {item.IsMaried}");
}
Console.ReadKey();

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public bool IsMaried { get; set; }

    public User()
    {

    }

    public User(string name, int age, string city, bool isMaried)
    {
        Name = name;
        Age = age;
        City = city;
        IsMaried = isMaried;
    }

}