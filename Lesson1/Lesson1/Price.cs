
namespace Lesson1
{
    public struct Price
    {
        private string nameItem;
        private string nameMagazine;
        private double price;

        public string NameMagazine { get { return nameMagazine; } }

        public Price(string nameItem, string nameMagazine, double price)
        {
            this.nameItem = nameItem;
            this.nameMagazine = nameMagazine;
            this.price = price;

            if(price <= 0)
            {
                throw new Exception();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{nameItem}, {nameMagazine}, {price}");
        }
  
    }
}