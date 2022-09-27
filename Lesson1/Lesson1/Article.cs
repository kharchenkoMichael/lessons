

namespace Lesson1
{
    public class Article
    {
        private string nameValue;
        private string nameStore;
        private double cost;



        public string NameArticle
        {
            get
            {
                return nameValue;
            }
        }
        public Article(string nameValue, string nameStore, double cost)
        {
            this.nameValue = nameValue;
            this.nameStore = nameStore;
            this.cost = cost;
        }

        public string ShowArticle()
        {
            return $"ім'я товару - {nameValue}, ім'я магазину - {nameStore}, ціна товару - {cost}";
        }
        
    }
}
