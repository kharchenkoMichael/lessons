
namespace Lesson1
{
    public class User
    {
        public string Name { get; set; }


        private event EventHandler<UserEventArgs>? sendMessage = null;
        public event EventHandler<UserEventArgs> SendMessage
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
        public void TakeMethod(object? sender, UserEventArgs args)
        {
            if(sender == null)
            {
                return;
            }
            Console.WriteLine($"{Name} : отримав повідомлення - {args.Text} - від {((User)sender).Name}");
        }
        public void SendMethod(string text)
        {
            var args = new UserEventArgs();
            args.Text = text;
            if(sendMessage != null)
            {
                sendMessage(this,args);
            }
        }
    }
}
