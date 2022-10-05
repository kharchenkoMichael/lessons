
namespace Lesson1
{
    public class MyDictionary <TKey,TValue>
    {
        private Element<TKey, TValue>[] array = new Element<TKey, TValue>[0];


        public int Lenght
        {
            get
            {
                return array.Length;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                for(int i = 0;i < array.Length; i++)
                {
                    if (array[i].Key .Equals(key))
                    {
                        return array[i].Value;
                    }
                }
                throw new IndexOutOfRangeException();
            }
            set
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Key.Equals(key))
                    {
                       array[i].Value = value;
                        return;
                    } 
                }
            }
        }
        public void Add(TKey key, TValue value)
        {

            var newArray = new Element<TKey, TValue>[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = new Element<TKey, TValue>();
            newArray[newArray.Length - 1].Key = key;
            newArray[newArray.Length - 1].Value = value;
            array = newArray;

        }
        public void Show()
        {
            for(var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i].Key} {array[i].Value}");
            }
            Console.WriteLine("------------");
        }
    }
}
