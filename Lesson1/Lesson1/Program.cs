int[,,] array = new int[5, 4, 2];

array[2, 3, 1] = 1;

for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
    {
        for (int k = 0; k < array.GetUpperBound(2) + 1; k++)
        {
            Console.Write(array[i, j, k]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}