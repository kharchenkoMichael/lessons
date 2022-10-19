
using System.IO;
using System.IO.Compression;

using var zip = new GZipStream(new FileStream("new-file.gzip", FileMode.Open), CompressionMode.Decompress);
using var file = new FileStream("new-file-3.txt", FileMode.OpenOrCreate);
int theByte = zip.ReadByte();
while (theByte != -1)
{
    file.WriteByte((byte)theByte);
    theByte = zip.ReadByte();
}