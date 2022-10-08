
using Lesson1;

var list = new List<int>();
list.Add(5);
list.Add(7);
list.Add(3);
list.Add(11);
list.Add(10);
list.Add(-2);
list.Add(-11);
list.Add(-7);
foreach(var item in list.Filter(x=> x%2==0))
{
    Console.WriteLine(item);
}

