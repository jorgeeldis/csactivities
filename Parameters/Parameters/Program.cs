using System;

namespace Parameters
{
    class Program
    {
        static void Print(int x)
        {
            Console.WriteLine(x*2);
        }
        static void Main(string[] args)
        {
            Print(5);
            Print(12);
            Print(42);
        }
    }
}
