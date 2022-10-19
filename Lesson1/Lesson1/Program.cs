using System.IO;

var drives = DriveInfo.GetDrives();
foreach (var item in drives)
{
    var directory = new DirectoryInfo(item.Name);
    var files = directory.GetFiles();
    foreach (var file in files)
    {
        Console.WriteLine(file.FullName);
        Console.WriteLine(file.Name);
        Console.WriteLine(file.Length);
        Console.WriteLine(file.LinkTarget);
        Console.WriteLine(file.CreationTime);
        Console.WriteLine(file.DirectoryName);
        Console.WriteLine(file.Exists);
        Console.WriteLine(file.Extension);
        Console.WriteLine(file.IsReadOnly);
        Console.WriteLine(file.LastAccessTime);
        Console.WriteLine(file.LastWriteTime);
        Console.WriteLine("--------------");
    }
}