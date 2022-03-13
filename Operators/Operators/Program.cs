using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 4;
            int w = 10 / 4;
            int z = 25 % 7;
            int precedence = 4 + 3 * 2;
            Console.WriteLine(x - y);
            Console.WriteLine(w);
            Console.WriteLine(z);
            Console.WriteLine(precedence);
        }
    }
}
