using Lesson1;

var ints = new Class1<int>();
ints.Add(2);
ints.Add(89);
ints.Add(3);
ints.Add(2);
ints.Add(3);
ints.Add(5);
ints.ShowElements();
ints.Remove(3);
ints.ShowElements();
ints.RemoveAtIndex(1);
ints.ShowElements();

ints.Remove(0);
ints.ShowElements();

var strings = new Class1<string>();
strings.Add("234adfa1");
strings.Add("aqdf243");
strings.Add("rftgyhdrt");
strings.Add("4567");
strings.Add("qwe");
strings.Add("678");
strings.ShowElements();

strings.Remove("qwe");
strings.ShowElements();
strings.RemoveAtIndex(1);
strings.ShowElements();

