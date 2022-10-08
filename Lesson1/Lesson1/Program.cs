
IEnumerable<int> Method(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            yield return array[i];
        }
    }
}
foreach (var item in Method(new int[] { -1, -99, 2, 6, 10, -101, 1111, 55, -77 }))
{
    Console.WriteLine(item);
}
