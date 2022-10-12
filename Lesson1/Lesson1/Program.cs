
using Lesson1;

var prices = new Price[2];
for (int i = 0; i < prices.Length; i++)
{
    var nameItem = Console.ReadLine();
    var nameMagazine = Console.ReadLine();
    var price = double.Parse(Console.ReadLine());
    try
    {
        prices[i] = new Price(nameItem, nameMagazine, price);
    }
    catch
    {
        prices[i] = new Price(nameItem, nameMagazine, 1);
        Console.WriteLine("Цена не может быть меньше 1");
    }
}
var magazine = Console.ReadLine();
bool IsMagazine = false;
for(int i = 0; i < prices.Length; i++)
{
    if (prices[i].NameMagazine == magazine)
    {
        prices[i].ShowInfo();
        IsMagazine = true;
    }
}
if (!IsMagazine)
{
    throw new Exception();
}



