

namespace Lesson1
{
    public static class Object
    {
        public static string MyToString(this object obj)
        {
            var type = obj.GetType();
            return type.GetProperties().Select(property => property.GetValue(obj)?.ToString()).Aggregate((prop1, prop2) => $"{prop1}, {prop2}");

        }
    }
}
