int state = 0; // 0010 0000

int TurnOn(int state, int value)
{
    int mask = (int)Math.Pow(2, value - 1);
    return state | mask;
}

int TurnOff(int state, int value)
{
    int mask = ~(int)Math.Pow(2, value - 1);//0000 0001 -> 1111 1110
    return state & mask;
}

while (true)
{
    string value = Console.ReadLine();
    if (value[0] == '+')
    {
        state = TurnOn(state, int.Parse(value.Substring(1).ToString()));
    }
    else if (value[0] == '-')
    {
        state = TurnOff(state, int.Parse(value.Substring(1).ToString()));
    }
    else
    {
        Console.WriteLine("I don't understand");
    }
    Console.WriteLine($"{Convert.ToString(state, 2)}");
}


