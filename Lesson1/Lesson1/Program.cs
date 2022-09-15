string color = "red";
Console.WriteLine("Угадай цвет");
bool trueColor = false;
for (int i = 0; i < 5; i++)
{
    string tryColor = Console.ReadLine();
    if(color == tryColor)
    {
        Console.WriteLine("Угадал");
        trueColor = true;
        break;
    }
    else
    {
        Console.WriteLine("Не угадал");
    }
}
if (!trueColor)
{
    Console.WriteLine("Не угадал,закончились жизни");
}




