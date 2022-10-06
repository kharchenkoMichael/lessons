
namespace Lesson1
{
    public class ArrayList
    {
        private object[] array = new object[0];




        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public object this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public void Add(object value)
        {
            var newArray = new object[array.Length + 1];
            for(int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length-1] = value;
            array = newArray;
        }
        public void Show()
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
