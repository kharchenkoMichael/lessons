


namespace Lesson1
{
    public class MyClass
    {
        private string field;
        


        public string Fieald
        {
            get
            {
                if (field != null)
                {
                    if(field == "hello world")
                    {
                        return "HELLO WORLD!";
                    }
                    return field;
                   
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                if(value == "goodbye")
                {
                    Console.WriteLine("Вы ввели недопустимое значение");
                }
                else
                {
                    field = value;
                }
            }

        }


    }
}
