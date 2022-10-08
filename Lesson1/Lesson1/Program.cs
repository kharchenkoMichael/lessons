using Lesson1;

var store = new Store();
foreach (Product product in store)
{
    Console.Write(product.Name);
    Console.Write(" ");
    Console.Write(product.Price);
    Console.WriteLine();
}