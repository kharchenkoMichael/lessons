int[,] array = new int[5, 4];

array[2, 3] = 1;

for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
    {
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}
