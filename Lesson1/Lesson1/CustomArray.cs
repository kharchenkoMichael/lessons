

namespace Lesson1
{
    class CustomArray
    {
        private int[] array1;
        private int[] array2;

        public int this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                else if (index < array1.Length)
                {
                    return array1[index];
                }
                else if (index < array1.Length + array2.Length)
                {
                    return array2[index - array1.Length];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                else if (index < array1.Length)
                {
                    array1[index] = value;
                }
                else if (index < array1.Length + array2.Length)
                {
                    array2[index - array1.Length] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        public int Lenght
        {
            get
            {
                return array1.Length + array2.Length;
            }
        }

        public CustomArray(int[] array1, int[] array2)
        {
            this.array1 = array1;
            this.array2 = array2;
        }
    }
}


