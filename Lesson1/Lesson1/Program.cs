﻿int[] arrays = { 1, 2, 3, 2, 3 };
int ellement = 5;
int [] Method(int[] arrays, int ellement)
{
    int[] result = new int[arrays.Length + 1];
    for (int i = 0; i < arrays.Length; i++)
    {
        result[i + 1] = arrays[i];
    }
    result[0] = ellement;
    return result;
}
int[] result = Method(arrays, ellement);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}