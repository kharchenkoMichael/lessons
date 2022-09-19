namespace Lesson1
{
    class Book
    {
        public Autor Autor { get; set; }
        public Title Title { get; set; }
        public Content Content { get; set; }

        public void Show()
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Autor.Show();
            Console.Write(' ');
            Console.ForegroundColor = ConsoleColor.Red;
            Title.Show();
            Console.Write(' ');
            Console.ForegroundColor = ConsoleColor.Green;
            Content.Show();
            Console.ForegroundColor = defaultColor;
            Console.WriteLine();
        }
    }
}

