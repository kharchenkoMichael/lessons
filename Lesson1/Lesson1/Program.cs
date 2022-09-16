

bool input = int.TryParse(Console.ReadLine(), out int a);
bool input2 = int.TryParse(Console.ReadLine(), out int b);
void Method(int a,int b)
{
    if (a > b)
    {
        Console.WriteLine("a > b");
    }
    else if (a < b)
    {
        Console.WriteLine("a < b");
    }
    else if (a == b)
    {
        Console.WriteLine("a == b");
    }
}
Method(a, b);