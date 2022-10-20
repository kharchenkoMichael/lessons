using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var types = assembly.GetTypes();
foreach (var type in types)
{
    Console.WriteLine(type.Name);
}

