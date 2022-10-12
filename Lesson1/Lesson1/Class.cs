
namespace Lesson1
{
    public struct Worker
    {
        private string name;
        private string nameJob;
        private int year;

        public int Year { get { return year; } }
        public string Name { get { return name; } }
        public Worker(string name,string nameJob,int year)
        {
            this.name = name;
            this.nameJob = nameJob;
            this.year = year;
            if(year > DateTime.Now.Year)
            {
                throw new Exception();
            }
        }
      
  
    }
}