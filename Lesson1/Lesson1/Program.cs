

int Add(int a,int b)
{
    return a + b;
}
 int Sub(int a,int b)
{
    return a - b;
}
int Mult(int a,int b)
{
    return a * b;
}
int Div(int a, int b)
{
    return a / b;
}
string input = Console.ReadLine();
string input1 = Console.ReadLine();
int.TryParse(input,out int a);
int.TryParse(input1, out int b);

Console.WriteLine(Add(a,b));
Console.WriteLine(Sub(a,b));
Console.WriteLine(Mult(a,b));
Console.WriteLine(Div(a,b));














