
namespace Lesson1
{
    class Vektor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vektor()
        {

        }
        public Vektor(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vektor operator +(Vektor a, Vektor b)
        {
            return new Vektor() { X = a.X + b.X, Y = a.Y + b.Y };
        }

        public static Vektor operator -(Vektor a, Vektor b)
        {
            return new Vektor() { X = a.X - b.X, Y = a.Y - b.Y };
        }

        public static Vektor operator *(Vektor a, int b)
        {

            return new Vektor() { X = a.X * b, Y = a.Y * b };
        }

        public static bool operator ==(Vektor a, Vektor b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator !=(Vektor a, Vektor b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
        public static implicit operator double(Vektor a)
        {
            return Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2));
        }


        public void Show(string text = "")
        {
            Console.WriteLine($"{text} : ({X}, {Y})");
        }
    }
}