
namespace Lesson1
{
    public class User
    {
        public string Name { get; set; }


        private event Action<string>? sendMessage = null;
        public event Action<string> SendMessage
        {
            add
            {
                sendMessage += value;
            }
            remove
            {
                sendMessage -= value;
            }
        }
        public void TakeMethod(string text)
        {
            Console.WriteLine($"{Name} : отримав повідомлення - {text}");
        }
        public void SendMethod(string text)
        {
            if(sendMessage != null)
            {
                sendMessage(text);
            }
        }
    }
}
