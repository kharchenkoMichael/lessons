Console.WriteLine("размеры стаканчиков кофе: 1 = маленький, 2 = средний, 3 = большой");
int small = 25;
int medium = 50;
int large = 100;
int result = 0;
bool exit = false;
while (!exit)
{
    Console.Write("пожалуйста, сделайте свой выбор: ");
    string coffeesize = Console.ReadLine();
    switch (coffeesize)
    {
        case "1":
            result += small;
            break;
        case "2":
            result += medium;
            break;
        case "3":
            result += large;
            break;
        case "exit":
            exit = true;
            break;
        default:
            Console.WriteLine("Такого в меню нету");
            break;
    }
}
Console.WriteLine(result);










