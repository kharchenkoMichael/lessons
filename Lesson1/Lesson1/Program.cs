
bool IsSimple(int a)
{
    for(int i = 2; i < a; i++)
    {
        if (a % i == 0) { return false; }
    }
    return true;
}
Console.WriteLine(IsSimple(23));




