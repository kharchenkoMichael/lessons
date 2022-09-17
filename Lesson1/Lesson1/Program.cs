using Lesson1;
Adress adress = new Adress();
adress.Index = 20;
adress.Country = "Ukraine";
adress.City = "Kremenchug";
adress.Street = "Soborna";
adress.House = 15;
adress.Apartment = 50;
Console.WriteLine($"индекс {adress.Index}, страна {adress.Country}, город {adress.City}, улица {adress.Street}, дом {adress.House}, квартира {adress.Apartment}");