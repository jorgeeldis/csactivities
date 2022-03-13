using System;

namespace Quiz
{
    class Program
    {
        class Temp
        {
            public int num = 2;
            public Temp() { num++; }
            ~Temp() { num++; }
        }
        static void Main(string[] args)
        {
            Temp t = new Temp();
            Console.WriteLine(t.num);
            int[] arr = { 8, 5, 4 };
            Array.Reverse(arr);
            double x = Math.Pow(arr[0], 2);
            Console.WriteLine(x);
        }

    }
}
