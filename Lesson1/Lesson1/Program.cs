int[] array = { 2, 5, 8, 10, 15,20,25 };
int index = 1;
int count = 5;
int[] SubArray(int[] array, int index, int count)
{
    int[] result = new int[count];
    for (int i=0; i< count; i++)
    {
        result[i] = array[index+i];
    }
    return result;
}
int[] result = SubArray(array, index, count);
for(int i = 0;i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
   







