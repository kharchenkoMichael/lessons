namespace Lesson1
{
    public class Account
    {
        private double money = 0;

        public event Action<string> SendNotification;

        public void Take(double count)
        {
            if (money > count)
            {
                money -= count;
                SendNotification($"Taking money success. Your account money = {money}");
            }
            else
            {
                SendNotification($"Not enought money. Your account money = {money}");
            }
        }

        public void Give(double count)
        {
            money += count;
            SendNotification($"Giving money success. Your account money = {money}");
        }
    }
}