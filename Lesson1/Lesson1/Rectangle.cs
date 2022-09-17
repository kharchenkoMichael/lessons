

using System.Security.Cryptography.X509Certificates;

namespace Lesson1
{
    public class Rectangle
    {
        private double _side1;
        private double _side2;
        public double Area
        {
            get
            {
                return _side1 * _side2;
            }
        }
        public double Perimetr
        {
            get
            {
                return 2 * (_side1 + _side2);
            }
        }

        public Rectangle(double side1, double side2)
        {
           _side1 = side1;
           _side2 = side2;
        }
        public double AreaCalculator()
        {
            return _side1 * _side2;
        }
        public double PerimetrCalculator()
        {
            return 2 * (_side1 + _side2);
        }
    }
}
