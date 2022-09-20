namespace Lesson1
{
    public class Fruit
    {
        private bool isSpoiled = false;
        protected string Taste { get; set; }

        public Fruit()
        {
            Console.WriteLine("constructor fruit");
        }

        public Fruit(bool isSpoiled)
        {
            Console.WriteLine($"constructor fruit with parametr isSpoiled - {isSpoiled}");
            this.isSpoiled = isSpoiled;
        }

        public void Eat()
        {
            if (isSpoiled)
            {
                Console.WriteLine("fruit is spoiled you can't eat it");
            }
            else
            {
                Console.WriteLine($"You eat fruit sucessefull with taste {Taste}");

            }
        }

        public void Spoil()
        {
            isSpoiled = true;
        }
    }
}