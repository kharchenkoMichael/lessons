Console.WriteLine("Введите высоту триугольника");
int height = int.Parse(Console.ReadLine());
for (int i = 0; i < height; i++)
{
    Console.WriteLine();
    for (int j = 0;j <= i; j++)
    {
        Console.Write("*");
    }   
}




