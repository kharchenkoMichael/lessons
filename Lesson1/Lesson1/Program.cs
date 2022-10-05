using Lesson1;
MyList<int> myList = new MyList<int>();
myList.Add(5);
myList.Add(8);
myList.Add(11);
myList.Add(72);
myList.Add(99);
var array = myList.GetArray();
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}


