

namespace Lesson1
{
    public class ClassRoom
    {
        private Pupil[] pupils;


        public ClassRoom(params Pupil[] pupils)
        {
            this.pupils = pupils;
        }
        public void ShowInfo()
        {
            for(int i = 0; i < pupils.Length; i++)
            {
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
                Console.WriteLine("----------");

            }
        }
   
    }
}
