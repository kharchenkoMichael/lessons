using Lesson1;
var store = new Store(new Article[] 
{ new Article("ковбаса", "АТБ", 25.70), 
    new Article("морозиво", "МакДональдс", 30.50), 
    new Article("хліб", "МаркетОпт", 14.25) });
Console.WriteLine(store["шоколад"]);
