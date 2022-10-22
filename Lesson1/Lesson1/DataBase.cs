using System.Text.Json;

namespace Lesson1
{
    internal class DataBase
    {
        private const string path = "database.json";
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<Basket> Baskets { get; set; } = new List<Basket>();

        public void InitDataBase()
        {
            if (File.Exists(path))
            {
                string json = "";
                using (var reader = new StreamReader(new FileStream(path, FileMode.OpenOrCreate)))
                {
                    json = reader.ReadToEnd();
                }
                var item = JsonSerializer.Deserialize<DataBase>(json);
                Users = item.Users;
                Products = item.Products;
                Baskets = item.Baskets;
                return;
            }
            Users.Add(new User() { Name = "Misha", Age = 24, City = "Kremechuk" });
            Users.Add(new User() { Name = "Sasha", Age = 26, City = "Kharkiv" });
            Users.Add(new User() { Name = "Masha", Age = 23, City = "Lviv" });
            Users.Add(new User() { Name = "Kate", Age = 21, City = "Odesa" });

            Products.Add(new Product() { Name = "Apple", Price = 20, Category = "Fruits" });
            Products.Add(new Product() { Name = "PineApple", Price = 90, Category = "Fruits" });
            Products.Add(new Product() { Name = "Tomat", Price = 80, Category = "Vegetables" });
            Products.Add(new Product() { Name = "Potato", Price = 70, Category = "Vegetables" });
            Products.Add(new Product() { Name = "Chiken meat", Price = 80, Category = "Meat" });
            Products.Add(new Product() { Name = "Cow meat", Price = 120, Category = "Meat" });
            Products.Add(new Product() { Name = "Cheese", Price = 40, Category = "Milk products" });
            Products.Add(new Product() { Name = "Milk", Price = 50, Category = "Milk products" });
            Products.Add(new Product() { Name = "Vine", Price = 200, Category = "Alcohol" });
        }

        public void Save()
        {
            string jsonString = JsonSerializer.Serialize(this);
            using (var writer = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate)))
            {
                writer.Write(jsonString);
            }
        }
    }
}