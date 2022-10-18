using Lesson1;
List<Car> cars = new List<Car>
{
    new Car() {Name = "Toyota Camry", Color = "black", Year = 2010 },
    new Car() {Name = "Audi A8", Color = "white", Year = 2018 },
    new Car() {Name = "BMW X7", Color = "black", Year = 2017 },
    new Car() {Name = "Mercedes E200", Color = "grey", Year = 2013 },
    new Car() {Name = "Nissan Juke", Color = "yellow", Year = 2011 },
    new Car() {Name = "Pegeut Taxi", Color = "white", Year = 2007 },
    new Car() {Name = "Audi A4", Color = "pink", Year = 2014 } 

};
List<Order> orders = new List<Order>
{
    new Order() {Model = "Toyota Camry", UserName = "Misha", Phone = "+380979999999" },
    new Order() {Model = "Audi A8", UserName = "Petya", Phone = "+380972131937" },
    new Order() {Model = "BMW X7", UserName = "Jenya", Phone = "+380972135555" },
    new Order() {Model = "Mercedes E200", UserName = "Katya", Phone = "+380972131231" },
    new Order() {Model = "Nissan Juke", UserName = "Igor", Phone = "+380973334444" },
    new Order() {Model = "Pegeut Taxi", UserName = "Misha", Phone = "+380972941111" },
    new Order() {Model = "Audi A4", UserName = "Stanislav", Phone = "+380972037777" }
};


var name = Console.ReadLine();
var result = orders
    .Where(item => item.UserName == name)
    .Join(cars,order => order.Model,car => car.Name,
    (order,car) => new {order.Model,order.UserName,order.Phone,car.Color,car.Year});
foreach (var item in result)
{
    Console.WriteLine($"{item.Model}, {item.UserName}, {item.Phone}, {item.Color}, {item.Year}");
}