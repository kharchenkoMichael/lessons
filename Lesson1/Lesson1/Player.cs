

namespace Lesson1
{
    public class Player : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Приостановить");
        }

        public void Play()
        {
            Console.WriteLine("Возобновить");
        }

        public void Record()
        {
            Console.WriteLine("Записать");
        }

        public void Stop()
        {
            Console.WriteLine("Остановить");
        }
    }

}

       






