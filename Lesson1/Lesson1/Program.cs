
using Lesson1;

var workers = new Worker[5];
for (int i = 0; i < workers.Length; i++)
{
    var name = Console.ReadLine();
    var nameJob = Console.ReadLine();
    var year = int.Parse(Console.ReadLine());
    try
    {
        workers[i] = new Worker(name, nameJob, year);
    }
    catch
    {
        workers[i] = new Worker(name, nameJob, DateTime.Now.Year);
        Console.WriteLine("Вы обогнали текущий год");
    }
}
var value = int.Parse(Console.ReadLine());
for(int i = 0; i < workers.Length; i++)
{
    if(DateTime.Now.Year - workers[i].Year >= value)
    {
        Console.WriteLine(workers[i].Name);
    }
}




