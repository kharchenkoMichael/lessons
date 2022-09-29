
using Lesson1;
Train[] trains = new Train[3];
for (int i = 0; i < trains.Length; i++)
{
    Console.WriteLine($"Введите данные {i + 1}");
    Console.WriteLine("Введите название пункта назначения:");
    string destination = Console.ReadLine();

    Console.WriteLine("Введите номер поезда:");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите дату отправления:");
    DateTime departure = DateTime.Parse(Console.ReadLine());

    trains[i] = new Train(destination, number, departure);
}
Console.WriteLine("Введите номер поезда который вам нужен");
var serchNumber = int.Parse(Console.ReadLine());
bool IsFoundSearch = false;
for(int i = 0; i < trains.Length;i++)
{
    if (trains[i].NumberTrain == serchNumber)
    {
        trains[i].ShowInfo();
        IsFoundSearch = true;
        break;
    }
}
if (!IsFoundSearch)
{
    Console.WriteLine("Такого поезда не существует");
}