using Lesson1;


List<Client> clients = new List<Client>
{
    new Client() {Name = "Katya", Phone = "black", Date = new DateTime(2022,7,15,17,0,0), Price = 350},
    new Client() {Name = "Juli", Phone = "white", Date = new DateTime(2022,5,17,13,0,0), Price = 400},
    new Client() {Name = "Anna", Phone = "black", Date = new DateTime(2022,11,22,14,0,0), Price = 200},
    new Client() {Name = "Nastya", Phone = "grey", Date = new DateTime(2022,9,1,11,0,0), Price = 150},
    new Client() {Name = "Mia", Phone = "yellow", Date = new DateTime(2022,8,2,16,30,0), Price = 800},
    new Client() {Name = "Marina", Phone = "white", Date = new DateTime(2022,3,29,12,45,0), Price = 900},
    new Client() {Name = "Ksusha", Phone = "pink", Date = new DateTime(2022,12,16,19,15,0), Price = 500} 
};
var result = clients.Where(item => item.Price >= 500);
foreach (var item in result)
{
    Console.WriteLine($"{item.Name}, {item.Phone}, {item.Date}, {item.Price}");
}