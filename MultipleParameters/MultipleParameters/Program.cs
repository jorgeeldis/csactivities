using System;

namespace MultipleParameters
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int res = Sum(11, 42);
            Console.WriteLine(res);
        }
    }
}
