
bool result = true;
int value = 0;

do
{
   Console.WriteLine("write number");
   string inputString = Console.ReadLine();
   result = int.TryParse(inputString, out int intValue);
   value = intValue;
} while (!result);

for (int i = 0; i <= value; i+=2)
{
    
    
        Console.WriteLine(i);
    
  
}
bool isChating = true;
while (isChating)
{
    Console.WriteLine("write something");
    string input = Console.ReadLine();
    switch (input)
    {
        case "hello":
            Console.WriteLine("Hello");
            break;
        case "how are you":
            Console.WriteLine("i'm fine");
            break;
        case "what is your name":
            Console.WriteLine("i'm console application");
            break;
        case "exit":
            isChating = false;
            break;
        default:
            Console.WriteLine("i don't understand you");
            break;

    }
}
int a = 0;
while (true)
{
    string input = Console.ReadLine();
    switch (input)
    {
        case "+":
            a++;
            break;
        case "-":
            a--;
            break;
        default:
            Console.WriteLine(a);
            break;

    }
}

   



















