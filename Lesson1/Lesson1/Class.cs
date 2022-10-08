
using System.ComponentModel;

namespace Lesson1
{
    public static class Class
    {
        public static IEnumerable<int> Filter(this IEnumerable<int> collection, Func<int, bool> filter)
        {
            foreach(var item in collection)
            {
                if(filter(item))
                {
                    yield return item;
                }
            }
        }
    }
}
