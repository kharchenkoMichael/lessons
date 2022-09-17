using Lesson1;
double side1 = double.Parse(Console.ReadLine());
double side2 = double.Parse(Console.ReadLine());
Rectangle rectangle = new Rectangle(side1, side2);
Console.WriteLine(rectangle.AreaCalculator());
Console.WriteLine(rectangle.PerimetrCalculator());