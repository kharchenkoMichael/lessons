using System.IO;

using System.IO;
using System.IO.Compression;

using (var writer = new StreamWriter(new FileStream("new-file.txt", FileMode.OpenOrCreate)))
{ writer.Write("Some text"); }
using var zip = new GZipStream(new FileStream("new-file.zip", FileMode.OpenOrCreate), CompressionLevel.SmallestSize);
using var reader = (new FileStream("new-file.txt", FileMode.OpenOrCreate));
var buffer = new byte[reader.Length];
reader.Read(buffer);
zip.Write(buffer);