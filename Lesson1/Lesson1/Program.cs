using Lesson1;


using Lesson1;

var dataBase = new DataBase();
dataBase.InitDataBase();

while (true)
{
    Console.WriteLine("Enter your name");
    var name = Console.ReadLine();
    if (name == "exit")
    {
        break;
    }
    var user = dataBase.Users.FirstOrDefault(x => x.Name == name);
    if (user == null)
    {
        continue;
    }
    while (true)
    {
        Console.WriteLine("write comand");
        Console.WriteLine("1 - show all products");
        Console.WriteLine("2 - show full basket");
        Console.WriteLine("3 - add product to basket");
        var command = Console.ReadLine();
        switch (command)
        {
            case "1":
                ShowAllProducts(dataBase);
                break;
            case "2":
                ShowFullBasket(dataBase, user);
                break;
            case "3":
                AddProductToBasket(dataBase, user);
                break;
            default:
                Console.WriteLine("There are not this command!");
                break;
        }
    }
}
Console.WriteLine("See you soon!");

void ShowAllProducts(DataBase dataBase)
{
    foreach (var product in dataBase.Products)
    {
        Console.WriteLine($"{product.Name} {product.Category} - {product.Price}");
    }
    Console.WriteLine("---------------------------");
}

void ShowFullBasket(DataBase dataBase, User user)
{
    var baskets = dataBase.Baskets.Where(item => item.UserName == user.Name);
    if (baskets.Count() == 0)
    {
        Console.WriteLine("You have nothing in basket");
    }
    else
    {
        foreach (var basket in baskets)
        {
            Console.WriteLine($"{basket.ProductName} - {basket.ProductCount}");
        }
    }
}

void AddProductToBasket(DataBase dataBase, User user)
{
    while (true)
    {
        Console.WriteLine("Enter product name");
        var productName = Console.ReadLine();
        var product = dataBase.Products.FirstOrDefault(item => item.Name == productName);
        if (product == null)
        {
            continue;
        }
        int productCount;
        while (true)
        {
            Console.WriteLine("Enter count products");
            var count = Console.ReadLine();
            if (int.TryParse(count, out productCount))
            {
                break;
            }
            Console.WriteLine("You write not correct format/ write please a number");
        }
        dataBase.Baskets.Add(new Basket() { UserName = user.Name, ProductName = product.Name, ProductCount = productCount });
        dataBase.Save();
        break;
    }
}