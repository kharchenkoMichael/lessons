namespace Lesson1
{
    public class Class1<T> : Object
    {
        private T[] array;
        private int lenght;

        public int Length
        {
            get
            {
                return lenght;
            }
        }

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

        public Class1()
        {
            lenght = 0;
            array = new T[1];
        }

        public void Add(T newValue)
        {
            if (lenght < array.Length)
            {
                array[lenght++] = newValue;
                return;
            }

            var newArray = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[lenght++] = newValue;
            array = newArray;
        }

        public void Remove(T value)
        {
            var index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                return;
            }
            RemoveAtIndex(index);
        }

        public void RemoveAtIndex(int index)
        {
            for (int i = index + 1; i < lenght; i++)
            {
                array[i - 1] = array[i];
            }
            lenght--;
        }

        public void ShowElements()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
