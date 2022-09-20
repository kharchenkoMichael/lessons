using Lesson1;
using System;

var apple = new Apple();
var banana = new Banana();

apple.Eat();
banana.Eat();

Console.WriteLine("3 days after");

apple.Spoil();
banana.Spoil();

apple.Eat();
banana.Eat();

var appleSpoiled = new Apple(true);