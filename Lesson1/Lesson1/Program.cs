
using Lesson1;
void ClassTaker(MyClass myClass)
{
    myClass.change = "изменено";
}
void StructTaker(MyStruct myStruct)
{
    myStruct.change = "изменено";
}

var myClass = new MyClass();
var myStruct = new MyStruct();
myClass.change = "не изменено";
myStruct.change = "не изменено";
Console.WriteLine(myClass.change);
Console.WriteLine(myStruct.change);
ClassTaker(myClass);
StructTaker(myStruct);
Console.WriteLine(myClass.change);
Console.WriteLine(myStruct.change);
