﻿

namespace Lesson1
{
    public class ExpertDocumentWorker :ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
