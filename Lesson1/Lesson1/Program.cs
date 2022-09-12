int[] array = { 1, 2, 3, 1,5,4,3};
int value = 9;


int[] Getsum(int[] array, int value)
{
    int[] result = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        for(int j = i+1;j < array.Length;j++ )
        {
            if (array[i] + array[j] == value)
            {
              return new int[] {array[i], array[j]};
            }
        }
    }
    return result;
}
int[] result = Getsum(array, value);
Console.WriteLine(result[0]);
Console.WriteLine(result[1]);








