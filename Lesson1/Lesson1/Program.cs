using Lesson1;

Printer printer;
switch (Console.ReadLine())
{
    case "yellow":
        printer = new YellowPrinter();
        break;
    case "green":
        printer = new GreenPrinter();
        break;
    default:
        printer = new Printer();
        break;
}
printer.Print("green");