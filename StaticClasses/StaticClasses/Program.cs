using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2, 3));
            int[] arr = { 9, 4, 10, 42 };
            Array.Sort(arr);
            double x = Math.Sqrt(arr[1]);
            Console.WriteLine(x);

        }
    }
}
