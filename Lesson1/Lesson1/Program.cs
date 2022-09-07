//double pi = 3.14;
//Console.WriteLine("input r");
//Console.WriteLine("input h");
//int r = int.Parse(Console.ReadLine());
//int h = int.Parse(Console.ReadLine());
//Console.WriteLine($"V={pi * r * r * h}");
//Console.WriteLine($"S={2 * pi * r*(r + h)}");



bool isChating = true;
while (isChating)
{
    string input = (Console.ReadLine());
    switch (input)
    {
        case "дождь":
            Console.WriteLine("Rain");
            break;
        case "солнце":
            Console.WriteLine("Sun");
            break;
        case "снег":
            Console.WriteLine("Snow");
            break;
        case "ураган":
            Console.WriteLine("Hurricane");
            break;
        case "наводнение":
            Console.WriteLine("Flood");
            break;
        case "ветер":
            Console.WriteLine("Wind");
            break;
        case "холодно":
            Console.WriteLine("Cold");
            break;
        case "тепло":
            Console.WriteLine("Warm");
            break;
        case "тучи":
            Console.WriteLine("cloud");
            break;
        case "землетрясение":
            Console.WriteLine("earthquake");
            break;
        default:
            Console.WriteLine("i'm not understand you");
            break;
    }
}



















