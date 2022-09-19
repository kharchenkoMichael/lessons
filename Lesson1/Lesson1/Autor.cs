namespace Lesson1
{
    class Autor
    {
        private string _autorName;
        public string AutorName
        {
            get
            {
                return _autorName;
            }
            set
            {
                _autorName = value;
            }
        }

        public void Show()
        {
            Console.Write(_autorName);
        }
    }
}
