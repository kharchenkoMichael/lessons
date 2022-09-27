

namespace Lesson1
{
    public class Store
    {
        private Article[] articles;

        public Store(Article[] articles)
        {
            this.articles = articles;
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= articles.Length)
                {
                    return "Немає такого товару";
                }
                return articles[index].ShowArticle();
            }
        }
        public string this[string index]
        {
            get
            {
             for(int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].NameArticle == index)
                    {
                       return articles[i].ShowArticle();
                    }
                }
                return "Немає такого товару";
            }
        }
    }
}
