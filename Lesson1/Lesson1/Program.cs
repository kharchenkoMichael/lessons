using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;

var folderPath = Console.ReadLine();
var directory = new DirectoryInfo(folderPath);
var fileName = Console.ReadLine();
IEnumerable<FileInfo> ConteinFileInFolder (DirectoryInfo directory, string fileName)
{
    var result = new List<FileInfo>();
    result.AddRange(directory.GetFiles().Where(f => f.Name.Contains(fileName)));
    foreach (var item in directory.GetDirectories())
    {
        result.AddRange(ConteinFileInFolder(item, fileName));
    }
    return result;
}
var result = ConteinFileInFolder(directory, fileName);
foreach(var item in result)
{
    Console.WriteLine(item.FullName);
}


