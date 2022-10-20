using System.IO;

var directory = Directory.GetCurrentDirectory();


using (var file = File.Create(Path.Combine(directory, $"HELLO ITS ME.txt")))
{
    string text = "Hello its ME";
    var buffer = text.ToCharArray().Select(item => (byte)item).ToArray();
    file.Write(buffer, 0, buffer.Length);
    file.Close();
}
File.Delete(Path.Combine(directory, $"HELLO ITS ME.txt"));

