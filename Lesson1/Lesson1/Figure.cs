
namespace Lesson1
{
   public class Figure
    {
        private Point[] points;
        
        
        public Figure(Point point1,Point point2, Point point3, Point point4, Point point5)
        {
          points = new Point[] { point1,point2,point3,point4,point5};
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }
        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }
        public double LengthSide(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y,2));
        }
        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if(i== points.Length - 1)
                {
                    perimeter += LengthSide(points[i], points[0]);
                }
                else
                {
                    perimeter += LengthSide(points[i], points[i + 1]);
                }
            }
            Console.WriteLine(perimeter);
        }
    }
}
