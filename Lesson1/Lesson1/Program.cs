using Lesson1;

var chair = new Chair();
var table = new Table();
var sofa = new Sofa();

chair.FurnitureCrashed();
table.FurnitureCrashed();
sofa.FurnitureCrashed();

chair.Broke();
table.Broke();
sofa.Broke();

Console.WriteLine("after the fall");

chair.FurnitureCrashed();
table.FurnitureCrashed();
sofa.FurnitureCrashed();

