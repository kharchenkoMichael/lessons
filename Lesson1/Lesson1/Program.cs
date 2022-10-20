using System.Reflection;
using Lesson1;

var myClass = new Class1();
Type type = typeof(Class1);
PropertyInfo[] properties = type.GetProperties();
foreach (var property in properties)
{
    Console.WriteLine(property.Name);
    Console.WriteLine(property.PropertyType);
    if (property.GetIndexParameters().Length > 0)
    {
        Console.WriteLine(property.GetValue(myClass, new object[] { 4 }));
    }
    else
    {
        Console.WriteLine(property.GetValue(myClass));
    }
}
var fields = type.GetFields(BindingFlags.NonPublic |
                         BindingFlags.Instance | BindingFlags.Public);
foreach (var field in fields)
{
    Console.WriteLine(field.Name);
    Console.WriteLine(field.GetValue(myClass));
    Console.WriteLine(field.FieldType);
    Console.WriteLine(field.MemberType);
}
myClass.ShowInfo();
var methods = type.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
foreach (var method in methods)
{
    Console.WriteLine(method.Name);
    Console.WriteLine(method.ReturnType);
    Console.WriteLine(method.GetParameters().Length);
}
EventInfo[] events = type.GetEvents();
foreach (var e in events)
{
    Console.WriteLine(e.Name);
    Console.WriteLine(e.EventHandlerType);
}
var constructors = type.GetConstructors();
foreach (var constructor in constructors)
{
    Console.WriteLine(constructor.Name);
}
var members = type.GetMembers(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
foreach (var member in members)
{
    Console.WriteLine($"{member.Name} - {member.MemberType}");
}


