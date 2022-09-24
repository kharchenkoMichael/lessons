using Lesson1;
using System.Xml.Serialization;

var xmlHandler = new XMLHandler();
var docHandler = new DOCHandler();
var txtHandler = new TXTHandler();

AbstractHandler[] array = new AbstractHandler[] {xmlHandler, docHandler, txtHandler};
for(int i = 0; i < array.Length; i++)
{
    array[i].Open();
    array[i].Create();
    array[i].Change();
    array[i].Save();
    Console.WriteLine("----------");

}
