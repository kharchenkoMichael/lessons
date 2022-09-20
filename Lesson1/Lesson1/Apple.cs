namespace Lesson1
{
    class Apple : Fruit
    {
        public Apple()
            : base()
        {
            Console.WriteLine("constructor Apple default");
            Taste = "sour";
        }
        public Apple(bool isSpoiled)
            : base(isSpoiled)
        {
            Console.WriteLine($"constructor Apple with parametr {isSpoiled}");
        }

        public void MethodForApple()
        {
            Console.WriteLine("some info from apple");
        }
    }
}