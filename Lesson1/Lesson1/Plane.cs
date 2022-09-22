

using System.Diagnostics;

namespace Lesson1
{
    public class Plane : Vehicle
    {
        private double height;
        private int count;


        public Plane(double height, int count,int x,int y,int price,double speed,int year)
            :base (x,y,price,speed,year)
        {
            this.height = height;
            this.count = count;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"высота - {height}, количество - {count}");
        }
    }
}
