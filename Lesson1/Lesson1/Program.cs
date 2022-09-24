using Lesson1;
string str = Console.ReadLine();
DocumentWorker worker;
switch (str)
{
    case "pro":
        worker = new ProDocumentWorker();
        break;
    case "exp":
        worker = new ExpertDocumentWorker();
        break ;
    default:
        worker = new DocumentWorker();
        break;
}
worker.OpenDocument();
worker.SaveDocument();
worker.EditDocument();