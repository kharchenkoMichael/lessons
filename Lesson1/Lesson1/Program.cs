int[] array = new int[] { 12, 24, 31, 42, 57, 66, 77, 81 };
int Method(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 && array[i] < 10)
        {
            return array[i];
        }
    }
    return 0;
}
Console.WriteLine(Method(array));




