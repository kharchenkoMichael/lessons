
namespace Lesson1
{
    public class Chair : Furniture
    {
        public Chair()
        {
            Console.WriteLine("construktor Chair default");
            Appointment = "sit";
        }
        public Chair(bool isCrashed)
        {
            Console.WriteLine($"construktor Chair with parametr {isCrashed}");
        }
        public void MethodForChair()
        {
            Console.WriteLine("some info from chair");
        }
       
    }
}
