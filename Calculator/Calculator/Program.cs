using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.WriteLine("x= ");
                string str = Console.ReadLine();
                if (str == "exit")
                    break;

                int x = Convert.ToInt32(str);

                Console.WriteLine("y= ");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = x + y;
                Console.WriteLine("Result: {0}", sum);
            }
            while (true);
        }
    }
}
