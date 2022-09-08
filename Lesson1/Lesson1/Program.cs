int.TryParse(Console.ReadLine(), out int count);
int[] rates = new int[count];
for (int i = 0; i < rates.Length; i++)
{
    rates[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < rates.Length; i++)
{
  sum = sum + rates[i];
}
Console.WriteLine((double) sum / rates.Length);