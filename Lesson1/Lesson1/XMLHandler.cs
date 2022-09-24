

namespace Lesson1
{
    public class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Документ изменем в формате XML");
        }

        public override void Create()
        {
            Console.WriteLine("Документ создан в формате XML");
        }

        public override void Open()
        {
            Console.WriteLine("Документ открыт в формате XML");
        }

        public override void Save()
        {
            Console.WriteLine("Документ сохранент в формате XML");
        }
    }
}
