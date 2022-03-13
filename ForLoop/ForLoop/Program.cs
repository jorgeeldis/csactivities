using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for ( ; x < 10 ; )
            {
                Console.WriteLine(x);
                x -= 3;
            }
        }
    }
}
