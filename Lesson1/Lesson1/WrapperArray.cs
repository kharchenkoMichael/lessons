
namespace Lesson1
{
    public class WrapperArray
    {
        private int[] array;
        private int[] array2;
        private int[] array3;


        public int this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                else if (index < array.Length)
                {
                    return array[index];
                }
                else if (index < array.Length + array2.Length)
                {
                    return array2[index - array.Length];
                }
                else if (index < array.Length + array2.Length + array3.Length)
                {
                    return array3[index - (array.Length + array2.Length)];
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
                else if (index < array.Length)
                {
                    array[index] = value;
                }
                else if (index < array.Length + array2.Length)
                {
                    array2[index - array.Length] = value;
                }
                else if (index < array.Length + array2.Length + array3.Length)
                {
                    array3[index - (array.Length + array2.Length)] = value; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index");
                }
            }
        }
        public int Length
        {
            get
            {
                return array.Length + array2.Length + array3.Length;
            }
        }


        public WrapperArray(int[] array, int[] array2, int[] array3)
        {
            this.array = array;
            this.array2 = array2;
            this.array3 = array3;
        }
        public int Max()
        {
            var max = int.MinValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }
            for(int i = 0; i < array2.Length; i++)
            {
                if(array2[i] > max)
                {
                    max = array2[i];
                }
            }
            for(var i = 0; i < array3.Length; i++)
            {
                if (array3[i] > max)
                {
                    max = array3[i];
                }
            }
            return max;
        }
        public int Min()
        {
            var min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min)
                {
                    min = array[i];
                }
            }
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] < min)
                {
                    min = array2[i];
                }
            }
            for (var i = 0; i < array3.Length; i++)
            {
                if (array3[i] < min)
                {
                    min = array3[i];
                }
            }
            return min;
        }
        public int Sum()
        {

            var sum = 0;
            for(int i = 0; i < Length; i++)
            {
                sum += this[i];
            }
            return sum;
        }
        public void ShowOdd()
        {
            for(int i = 0; i < Length; i++)
            {
                if (this[i] % 2 != 0)
                {
                    Console.WriteLine(this[i]);
                }
            }
        }
    }
}
