using Lesson1;

var customArray = new CustomArray(new int[] { 1, 5, 23, 7, 5 }, new int[] { 2, 234, 12, -1, 43, 9 });
for (int i = 0; i < customArray.Lenght; i++)
{
    Console.Write($"{customArray[i]}, ");
    if (i % 2 == 0)
    {
        customArray[i] = -customArray[i];
    }
}
Console.WriteLine();
Console.WriteLine("----------------------");
for (int i = 0; i < customArray.Lenght; i++)
{
    Console.Write($"{customArray[i]}, ");
}
