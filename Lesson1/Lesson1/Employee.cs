
namespace Lesson1
{
   public class Employee
    {
        private readonly string name;
        private readonly string lastName;
        public string JobTitle { get; set; }
        public int YearsInCompany { get; set; }

        public Employee(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public int CalculateSallary()
        {
            int sallary = 0;
            switch (JobTitle)
            {
                case "junior":
                    sallary = 200 + YearsInCompany * 50;
                    break;
                case "middle":
                    sallary = 1500 + YearsInCompany * 100;
                    break;
                case "senior":
                    sallary = 4000 + YearsInCompany * 200;
                    break;
              
            }
            return sallary;
        }
        public void ShowInfo()
        {
            var sallary = CalculateSallary();
            Console.WriteLine($"ім'я  {name}, прізвище {lastName}, посада {JobTitle}, зарплатня {sallary}, податок {sallary / 100 * 5}");
        }
    }
}
