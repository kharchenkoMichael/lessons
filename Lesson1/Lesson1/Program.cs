

string login = "zamler";
string password = "12345";
Console.WriteLine("Введите свой логин");
string newLogin = Console.ReadLine();
if (newLogin == login)
{
    Console.WriteLine("Введите пароль");
    string newPassword = Console.ReadLine();
    if(newPassword == password)
    {
        Console.WriteLine("Welcome");
    }
    else
    {
        Console.WriteLine("Не правильный пароль");
    }
    
}
else
{
    Console.WriteLine("Не верный логин");
}















