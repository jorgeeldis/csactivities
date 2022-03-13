using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4; int y = 9;
            x = (y % x != 0) ? y / x : y;
            Console.WriteLine(x);
        }
    }
}
