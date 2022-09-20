using Lesson1;
User user = new User();
user.Login = "jakson";
user.Name = "Jeka";
user.surname = "Murashov";
user.Age = 27;
user.Date = DateTime.Now;
Console.WriteLine($" логин - {user.Login}, имя - {user.name}, фамилия - {user.surname}, возвраст - {user.age},дата - {user.Date}");

