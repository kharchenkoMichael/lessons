
bool b = int.TryParse(Console.ReadLine(),out int a);

if (a < 15)
{
    Console.WriteLine("[0-14]");
}
else if (a < 36)
{
    Console.WriteLine("[15-35]");
}
else if (a < 51)
{
    Console.WriteLine("[36-50]");
}
else if (a < 101)
{
    Console.WriteLine("[50-100]");
}
else if (a > 100)
{
    Console.WriteLine("i'm not understand");
}
