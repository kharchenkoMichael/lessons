//int[] array = { 2, 5, 8, 10, 15,20,25 };
//int index = 2;
//int count = 3;
//int[] SubArray(int[] array, int index, int count);
//for (int i = 0; i > array.Length; i++)
//{

//}


int[] array = { 1, 2, 3, 4, 5 };
Reverse(array);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}