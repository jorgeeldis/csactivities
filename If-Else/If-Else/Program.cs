using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int y = 3;
            int a = 8;
            int b = ++a;
            int mark = 85;

            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            if (a > 5)
            {
                b -= 3;
            }
            else
            {
                b = 9;
            }
            Console.WriteLine(b);
            if (mark < 50)
            {
                Console.WriteLine("You failed.");
                if (mark == 100)
                {
                    Console.WriteLine("Perfect!");
                }
            }
            else
            {
                Console.WriteLine("You passed");
            }
            if (x == 8)
            {
                Console.WriteLine("is 8");
            }
            else if (x == 18);
            {
                Console.WriteLine("is 18");
            }
            else if (x == 33) ;
            {
                Console.WriteLine("is 33");
            }
        }
    }
}
