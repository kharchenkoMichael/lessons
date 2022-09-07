

void Add(int a,int b)
{
    Console.WriteLine(a+b);
}
void Sub(int a,int b)
{
    Console.WriteLine(a-b);
}
void Mult(int a,int b)
{
    Console.WriteLine(a*b);
}
void Div(int a, int b)
{
    
    if (b == 0)
    {
        Console.WriteLine("на нуль дилыты не можна");
        return;
    }
    Console.WriteLine(a / b);
}
string input = Console.ReadLine();
string input1 = Console.ReadLine();
int.TryParse(input,out int a);
int.TryParse(input1, out int b);
Add(a, b);
Sub(a, b);
Mult(a, b);
Div(a, b);

















