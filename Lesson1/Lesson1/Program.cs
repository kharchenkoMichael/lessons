using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;
var folderPath = Console.ReadLine();
var directory = new DirectoryInfo(folderPath);
var fileName = Console.ReadLine();
bool ConteinFileInFolder (DirectoryInfo directory, string fileName)
{
    if(directory.GetFiles().Any(file => file.Name == fileName))
    {
        return true;
    }
    foreach(var item in directory.GetDirectories())
    {
        var result = ConteinFileInFolder(item, fileName);
        if (result)
        {
            return true;
        }
    }
    return false;
}
var result = ConteinFileInFolder(directory, fileName);
Console.WriteLine(result);

