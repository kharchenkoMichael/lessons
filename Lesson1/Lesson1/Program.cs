
using Lesson1;
var block = new Block(2,5,3,6);
var block1 = new Block(2, 5, 3, 6);
var block2 = new Block(-1,7,12,14);
Console.WriteLine(block);
Console.WriteLine(block1);
Console.WriteLine(block2);
Console.WriteLine(block.Equals(block1));
Console.WriteLine(block.Equals(block2));

