int lenght = 10, width = 5;
for (int j = 0; j < width; j++)
{
    for (int i = 0; i < lenght; i++)
    {
        if (j == 0 || j == width - 1) Console.Write("*");
        else if (i == 0 || i == lenght - 1) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}