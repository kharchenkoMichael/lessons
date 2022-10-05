using System.Collections;

var arrayList = new ArrayList();
arrayList.Add(5);
arrayList.Add("String");
for(int i = 0; i < arrayList.Count; i++)
{
    var item = arrayList[i];
    Console.WriteLine(item);
}