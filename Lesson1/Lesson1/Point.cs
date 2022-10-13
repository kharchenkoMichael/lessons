

using System.Security.Cryptography.X509Certificates;

namespace Lesson1
{
    public struct Point
    {
        private int x;
        private int y;
        private int z;
        public Point(int x,int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            
        }
        public static Point operator+(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{x}, {y}, {z}");
        }

    }
}
