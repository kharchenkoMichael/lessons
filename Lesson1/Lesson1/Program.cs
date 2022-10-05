using Lesson1;


MyDictionary <int,string> myDictionary = new MyDictionary<int, string> ();
myDictionary.Add(15, "hello");
myDictionary.Add(22, "bye bye");
myDictionary.Add(66, "qweqwe");
myDictionary.Add(77, "treuyuiuo");
myDictionary.Add(53, "kghjkjl");
myDictionary.Show();
myDictionary[22] = "hello hello";
myDictionary.Show();


