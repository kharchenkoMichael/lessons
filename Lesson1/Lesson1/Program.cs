
using Lesson1;

var a = new Vektor() { X = 2, Y = 3 };
var b = new Vektor() { X = 5, Y = 1 };
var c = a + b;
a.Show("A");
b.Show("B");
c.Show("C");
var d = c - new Vektor(2, 2);
d.Show("D");

var e = a * 5;
e.Show("E");
var f = new Vektor(2, 3);
Console.WriteLine(a == f);
Console.WriteLine(b == f);
double lenght = a;
Console.WriteLine(lenght);



