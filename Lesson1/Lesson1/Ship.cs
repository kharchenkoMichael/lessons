

namespace Lesson1
{
    public class Ship : Vehicle
    {
        private int count;
        private string port;

        public Ship(string port, int count, int x, int y, int price, double speed, int year)
         : base(x, y, price, speed, year)
        {
            this.port = port;
            this.count = count;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"порт - {port}, количество - {count}");
        }
    }
}
