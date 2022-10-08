using System.Collections;

namespace Lesson1
{
    public class Store : IEnumerable<Product>, IEnumerable
    {

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Product> GetEnumerator()
        {
            yield return new Product() { Name = "огірки", Price = 40 };
            yield return new Product() { Name = "помідори", Price = 50 };
            yield return new Product() { Name = "яблука", Price = 70 };
            yield return new Product() { Name = "груши", Price = 30 };
            yield return new Product() { Name = "банани", Price = 80 };
            yield break;
        }
    }
}
