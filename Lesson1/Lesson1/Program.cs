using System.IO;

var directory = Directory.GetCurrentDirectory();

for (int i = 0; i < 100; i++)
{
    Directory.CreateDirectory(Path.Combine(directory, $"New_Directory_{i + 1}"));
}





for (int i = 0; i < 100; i++)
{
    Directory.Delete(Path.Combine(directory, $"Folder_{i + 1}"));
}
