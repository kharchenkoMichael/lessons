





namespace Lesson1
{
    public class Date
    {
        private int day;
        private int month;
        private int year;



        public Date(int day , int month, int year)
        {
            this.day = day%30;
            this.month = (month + day / 30) % 12;
            this.year = year + (month + day / 30) / 12;
        }
        public static int operator -(Date a, Date b)
        {
            return a.day - b.day + (a.month - b.month) * 30 + (a.year - b.year) * 365;
        }
        public static Date operator +(Date a, int day)
        {
            return new Date(a.day + day, a.month, a.year);
        }
        public override string ToString()
        {
            return $"{day}.{month}.{year}";
        }
    }
}
