using System.IO;

var drives = DriveInfo.GetDrives();
foreach (var item in drives)
{
    var directory = new DirectoryInfo(item.Name);
    var directories = directory.GetDirectories();
    foreach (var d in directories)
    {
        Console.WriteLine(d.FullName);
        Console.WriteLine(d.Name);
        Console.WriteLine(d.LinkTarget);
        Console.WriteLine(d.Parent?.Name);
        Console.WriteLine(d.CreationTime);
        Console.WriteLine(d.Exists);
        Console.WriteLine(d.Extension);
        Console.WriteLine(d.LastAccessTime);
        Console.WriteLine(d.LastWriteTime);
        Console.WriteLine(d.Root);
        Console.WriteLine("-------------------------");
    }
}