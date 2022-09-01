Console.WriteLine("write first operand");
var input = Console.ReadLine();
int operand1 = int.Parse(input);
Console.WriteLine("write second operand");
input = Console.ReadLine();
int operand2 = int.Parse(input);
Console.WriteLine("write operation");
input = Console.ReadLine();
switch (input)
{
    case "+":
        Console.WriteLine($"operand1+operand2={operand1 + operand2}");
        break;
    case "-":
        Console.WriteLine($"operand1-operand2={operand1 - operand2}");
        break;
    case "*":
        Console.WriteLine($"operand1*operand2={operand1 * operand2}");
        break;
    case "/":
        Console.WriteLine($"operand1/operand2={operand1 / operand2}");
        break;
