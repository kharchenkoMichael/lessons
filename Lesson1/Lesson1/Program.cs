//int[] array = { 1, 2, 3, 1 };
//int value = 4;


//int[] GetSum(int[] array, int value)
//{
//    int[] result = new int[2];
//    for(int i = 0; i < array.Length; i++)   
//    {
//     int temp = 
//    }
//    return result;
//}







int wholecredit = 700;
int minpayment = 100;
bool payment = int.TryParse(Console.ReadLine(), out int a);
void Credit(int a)
{
    if (a == minpayment)
    {
        int result = wholecredit - a;         
        Console.WriteLine("Ваш долг");
        Console.WriteLine(result);
    }
    else if(a > minpayment)
    {
        int overpayment = a - minpayment;
        int result = wholecredit - a;
        Console.WriteLine("Ваш долг");
        Console.WriteLine(result);
        Console.WriteLine("Ваша переплата");
        Console.WriteLine(overpayment);

    }
    else
    {
        Console.WriteLine("minimal payment 100 ua");
    }
    return;
}
Credit(a);


   






