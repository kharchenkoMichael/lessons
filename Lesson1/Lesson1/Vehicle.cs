

namespace Lesson1
{
    public class Vehicle
    {
        protected int x;
        protected int y;

        protected int price;
        protected double speed;
        protected int year;

        public Vehicle(int x, int y, int price, double speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"координаты х - {x}, координаты y {y}");
            Console.WriteLine($"цена - {price}, скорость - {speed}, год - {year}");
        }

    }
}
