using Lesson1;

var user1 = new User();
var user2 = new User();
user1.Name = "Misha";
user2.Name = "Jenya";

user1.SendMessage += user2.TakeMethod;
user2.SendMessage += user1.TakeMethod;
user1.SendMethod("привіт Женя");
user2.SendMethod("Привіт Міша");

