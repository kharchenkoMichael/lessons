

namespace Lesson1
{
    public static class Calculator
    {
        public static string Reverse(this string str)
        {
            var result = "";
            for(int i = str.Length -1; i >= 0; i--)
            {
              result += str[i];
            }
          return result;
        }
    }
}
