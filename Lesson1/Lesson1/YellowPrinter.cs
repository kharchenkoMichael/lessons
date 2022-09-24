

namespace Lesson1
{
    public class YellowPrinter : Printer
    {
        protected override ConsoleColor Color
        {
            get { return ConsoleColor.Yellow; }
        }
    }
}
