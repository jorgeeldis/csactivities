using System;
using System.Collections.Generic;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int num = 1;

            //your code goes here

            while (number >= num)
            {
                //if (number % 3 == 0)
                //Console.WriteLine(num);
            
                if (num % 3 == 0)
                {
                    Console.WriteLine("*");
                }
                else
                    Console.WriteLine(num);
                num++;
            }

        }
    }
}