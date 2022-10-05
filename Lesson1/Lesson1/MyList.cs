
namespace Lesson1
{
    public class MyList<T>
    {
        private T[] array = new T[0];


        public T this[int index]
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

        public int Lenght
        {
            get
            {
                return array.Length;
            }
        }

        public void Add(T value)
        {
            var newArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = value;
            array = newArray;
        }
    }
}
