

namespace Lesson1
{
    public class GreenPrinter : Printer
    {
        protected override ConsoleColor Color
        {
            get { return ConsoleColor.Green; }
        }
    }
}
