

namespace Lesson1
{
    public class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Документ изменем в формате DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Документ создан в формате DOC"); 
        }

        public override void Open()
        {
            Console.WriteLine("Документ открыт в формате DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Документ сохранент в формате DOC");
        }
    }
}
