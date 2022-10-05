
namespace Lesson1
{
    public static class Extantion
    {
        public static T[] GetArray<T>(this MyList<T> myList)
        {
            var array = new T[myList.Lenght];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = myList[i];
            }
            return array;
        }
    }
}
