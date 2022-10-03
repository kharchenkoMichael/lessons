var method = (Func<int>[] arrayFunc) =>
{
    var sum = 0;
    for (int i = 0; i < arrayFunc.Length; i++)
    {
        sum += arrayFunc[i]();
    }
    return sum / arrayFunc.Length;



};
Console.WriteLine(method(new Func<int>[] { () => 5, () => 7, () => { var random = new Random();
    var n = random.Next(0,100);
Console.WriteLine(n);
return n; } }));

