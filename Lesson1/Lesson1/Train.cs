

namespace Lesson1
{
    public struct Train
    {
        private string destination;
        private int numberTrain;
        private DateTime departure;

        public int NumberTrain
        {
            get
            {
                return numberTrain;
            }
        }

        public Train(string destination, int numberTrain, DateTime departure)
        {
            this.destination = destination;
            this.numberTrain = numberTrain; 
            this.departure = departure;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"названия пункта - {destination}, номер поезда - {numberTrain}, время - {departure}");
        }


    }

}
