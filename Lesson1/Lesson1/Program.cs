int[][] array = new int[3][];
array[0] = new int[] { 1, 2, 3 };
array[1] = new int[] { 1, 2 };
array[2] = new int[] { 1, 2, 3, 4 };

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length; j++)
    {
        Console.Write(array[i][j]);
    }
    Console.WriteLine();
}