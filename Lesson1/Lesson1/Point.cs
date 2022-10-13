

using System.Security.Cryptography.X509Certificates;

namespace Lesson1
{
    public class Block
    {
        private int a;
        private int b;
        private int c;
        private int d;


        public Block(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Block)
            {
                Block block = (Block)obj;
                return a == block.a && b == block.b && c == block.c && d == block.d;

            }
            return false;
        }
        public override string ToString()
        {
            return $"{a} - a, {b} - b, {c} - c, {d} - d";
        }

    }
}
