using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;


IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
using IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("File1.txt", FileMode.Open, userStorage);
using var userReader = new StreamReader(userStream);
Console.WriteLine(userReader.ReadToEnd());