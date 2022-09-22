

namespace Lesson1
{
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I'm Bad Study");
        }
        public override void Read()
        {
            Console.WriteLine("I'm Bad Read");
        }
        public override void Write()
        {
            Console.WriteLine("I'm Bad Write");
        }
        public override void Relax()
        {
            Console.WriteLine("I'm a lot Relax");
        }
    }
}
