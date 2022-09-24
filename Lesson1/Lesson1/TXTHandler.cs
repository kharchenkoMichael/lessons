

namespace Lesson1
{
    public class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Документ изменем в формате TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Документ создан в формате TXT");
        }

        public override void Open()
        {
            Console.WriteLine("Документ открыт в формате TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Документ сохранент в формате TXT");
        }
    }
}
