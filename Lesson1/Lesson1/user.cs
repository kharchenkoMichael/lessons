

using Lesson1;

namespace Lesson1
{
    public class User
    {
        public string login = "jakson";
        public string name = "Jeka";
        public string surname = "Murashov";
        public int age = 27;
        DateTime date = DateTime.Now;



        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
    }
}
