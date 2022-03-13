using System;

namespace OptionalArguments
{
    class Program
    {
        static int Pow(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        static int Area(int h, int w)
        {
            return h * w;
        }
        static void Main(string[] args)
        {
            int res = Area(w: 54, h: 65);
            Console.WriteLine(Pow(6, 3));
            Console.WriteLine(Pow(3, 4));
            Console.WriteLine(res);
        }
    }
}
