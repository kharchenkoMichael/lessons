
int Calculation(string str)
{
    int result = 0;
    string op1 = "";
    string op2 = "";
    bool isOp1 = true;
    char operation = ' ';
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i]== '+' || str[i]== '-' || str[i]== '*' || str[i] == '/')
        {
            isOp1 = false;
            operation = str[i];
        }
        else 
        {
            if (isOp1)
            {
                op1 += str[i];
            }
            else
            {
                op2 += str[i];
            }
        }
    }
    int value1 = int.Parse(op1);
    int value2 = int.Parse(op2);
   switch (operation)
    {
        case '+':
            result = value1 + value2;
            break;
        case '-':
            result = value1 - value2;
            break;
        case '*':
            result = value1 * value2;
            break;
        case '/':
            result = value1 / value2;
            break;
    }
    return result;
}
while (true)
{
    int result = Calculation(Console.ReadLine());
    Console.WriteLine(result);
}











