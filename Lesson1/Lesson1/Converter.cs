namespace Lesson1
{
    public class Converter
    {
      
        double usdCourse;
        double eurCourse;

        

       
        public Converter(double usd, double eur)
        {
            this.usdCourse = usd;
            this.eurCourse = eur;
        }

        
        public double GetUsdFromHrn(double hrn)
        {
            return hrn / usdCourse;
        }

        public double GetHrnFromUsd(double usd)
        {
            return usd * usdCourse;
        }
        public double GetEurFromHrn(double hrn)
        {
            return hrn / eurCourse;
        }

        public double GetHrnFromEur(double eur)
        {
            return eur * eurCourse;
        }
    }

}