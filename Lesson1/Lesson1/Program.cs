


var Add = (int x, int y) => x + y;
var Sub = (int x, int y) => x - y;
var Mul = (int x, int y) => x * y;
var Div = (int x, int y) => x / y;
var Method = (Func<int, int, int> Function, int x, int y) => Function(x, y);
Console.WriteLine(Method(Div,5,8));
