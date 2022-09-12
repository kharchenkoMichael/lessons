int[] array = { 1, 1, 2, 3, 6, 7, 9, 12, 13, 16, 23 };
int value = 35;


int[] GetSum(int[] array, int value)
{
    int[] result = new int[2];
    int first = 0;
    int last = array.Length - 1;
    while (array[first] + array[last] != value && first != last)
    {
        if (array[first] + array[last] < value)
        {
            first++;
        }
        else
        {
            last--;
        }
    }
    if (first != last)
    {
        result[0] = array[first];
        result[1] = array[last];
    }
    return result;
}

int[] result = GetSum(array, value);
Console.WriteLine(result[0]);
Console.WriteLine(result[1]);






