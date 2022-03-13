using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 42;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 10);
        }
    }
}
