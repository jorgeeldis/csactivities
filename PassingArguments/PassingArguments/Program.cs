using System;

namespace PassingArguments
{
    class Program
    {
        static void Sqr(ref int x)
        {
            x = x *  x;
        }
        static void GetValues(out int x, out int y)
        {
            x = 5;
            y = 42;
        }
        static void Main(string[] args)
        {
            /* int a = 3;
             Sqr(ref a);
             Console.WriteLine(a);*/
            int a, b;
            GetValues(out a, out b);
        }
    }
}
