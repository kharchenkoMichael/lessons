using Lesson1;
var figure = new Figure(new Point(3, 2, ".a"),new Point(4,5,".b"),new Point(6,8,".c"),new Point(-2,-5,"d"));
figure.PerimeterCalculator();
var result = figure.LengthSide(new Point(1,2,"a"),new Point(-1,-3,"b"));
Console.WriteLine(result);