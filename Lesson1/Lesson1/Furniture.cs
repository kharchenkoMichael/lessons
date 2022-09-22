


namespace Lesson1
{
    public class Furniture
    {
        private bool isCrashed = false;
        protected string Appointment { get; set; }
      



        public void Use()
        {
            Console.WriteLine("construktor Furniture");
        }
        public void Use(bool isCrashed)
        {
            Console.WriteLine($"construktor Furniture with parametr isCrashed - {isCrashed}");
            this.isCrashed = isCrashed;
        }
        public void FurnitureCrashed()
        {
            if (isCrashed)
            {
                Console.WriteLine("furniture crashed");
            }
            else
            {
                Console.WriteLine($"you can use furniture {Appointment}");
            }
         
        }
        public void Broke()
        {
            isCrashed = true;
        }
    }
}
