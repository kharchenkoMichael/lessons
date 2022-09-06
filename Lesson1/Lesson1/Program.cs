


using System.Runtime.InteropServices;

int a = 20;
int b = 30;
int c = 40;
int d = 100;
while (true)
{
    string input = Console.ReadLine();
    switch (input)
    {
        case "coffee":
            a++;
            break;
        case "cheesecake":
            b--;
            break;
        case "macrones":
            c--;
            break;
        case "hookah":
            d--;
            break;
        default:
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(a + b + c + d);
            break;

    }
}


























