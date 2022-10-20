

using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Class1 : Object
    {
        private int qwe = 0;
        public string _q = "asd";
        public string Value { get; set; } = "qweqwe";
        public int Value2 { get; set; } = 123;
        public bool Value3 { get; set; } = true;
        public int this[int index]
        {
            get
            {
                return index % 2;
            }
            set
            {

            }
        }

        public event Action someEvent;
        public Class1()
        {

        }
        public Class1(int qwe)
        {
            this.qwe = qwe;
        }
        public void ShowInfo()
        {
            qwe = 78;
            Console.WriteLine(qwe);
        }
    }
}