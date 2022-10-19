using System.IO;

var drives = DriveInfo.GetDrives();
foreach (var item in drives)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.DriveType);
    Console.WriteLine(item.VolumeLabel);
    Console.WriteLine(item.TotalFreeSpace);
    Console.WriteLine(item.TotalSize);
    Console.WriteLine(item.DriveFormat);
    Console.WriteLine(item.IsReady);
    Console.WriteLine(item.RootDirectory);
}