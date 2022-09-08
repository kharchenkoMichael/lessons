int.TryParse(Console.ReadLine(),out int count);
int[] ints = new int[count];
for(int i = 0; i < ints.Length; i++)
{
    ints[i] = int.Parse(Console.ReadLine());
}
int max = int.MinValue;
for (int i = 0; i < ints.Length; i++) 
{
    if (ints[i] > max)
    {
        max = ints[i];
    }
}
Console.WriteLine(max);