using System.Data;

Random random = new Random();
int value = random.Next(100);
Console.WriteLine("Угадай число от 0-100");
while (true)
{
    int a = int.Parse(Console.ReadLine());
    if(a < value)
    {
        Console.WriteLine($"Загаданное число больше {a}");
    }
    else if (a > value)
    {
        Console.WriteLine($"Загадонное чило меньше {a}");
    }
    else
    {
        break;
    }
}
Console.WriteLine("Ты угадал");



