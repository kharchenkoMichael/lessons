//int[] array = { 2, 5, 8, 10, 15,20,25 };
//int index = 2;
//int count = 3;
//int[] SubArray(int[] array, int index, int count);
//for (int i = 0; i > array.Length; i++)
//{

//}


int[] array = { 1, 2, 3, 4, 5 };
int[] result = Reverse(array);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

int[] Reverse(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}