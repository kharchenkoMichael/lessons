
namespace Lesson1
{
    public static class ExtationString
    {
        public static string SubString(this string str,int index,int cout)
        {
            string result = "";
            for(int i = index; i < index + cout; i++)
            {
                result = result + str[i];
            } 
            return result;
        }
    }
}
