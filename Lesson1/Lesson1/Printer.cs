

using System.Runtime.CompilerServices;

namespace Lesson1
{
    public class Printer
    {
        protected virtual ConsoleColor Color
        {
            get { return ConsoleColor.Red; }
        }
        public void Print(string value)
        {
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(value);
            Console.ForegroundColor = temp;
        }
    }
}
