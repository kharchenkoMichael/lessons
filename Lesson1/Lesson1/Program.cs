string Str(string[] str)
{
    string result = "";
    for (int i = 0; i< str.Length; i++)
    {
        if (str[i].Length > result.Length)
        {
            result = str[i];
        }
    }
    return result;
}
string result = Str(new string[] { "abc", "sdasd", "csdsdd" });
Console.WriteLine(result);








