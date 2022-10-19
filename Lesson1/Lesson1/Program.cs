using System.IO;

var directory = Directory.GetCurrentDirectory();
for (int i = 0; i < 10; i++)
{
    using (var file = File.Create(Path.Combine(directory, $"File_{i + 1}.txt")))
    {
        string text = "some text" + i;
        var buffer = text.ToCharArray().Select(item => (byte)item).ToArray();
        file.Write(buffer, 0, buffer.Length);
    }
}

for (int i = 0; i < 10; i++)
{
    File.Delete(Path.Combine(directory, $"File_{i + 1}.txt"));
}