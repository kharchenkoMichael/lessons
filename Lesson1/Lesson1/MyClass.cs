namespace MyNamespace
{
    
        public class MyClass
    {
        public static void myMethod()
        {
            Console.WriteLine("собственное пространство");
        }
    }
}


namespace MyProgram
{
    public class MyClass
    {
        public static void Main()
        {
            MyNamespace.MyClass.myMethod();
        }
    }
}
