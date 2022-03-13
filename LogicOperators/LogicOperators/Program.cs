using System;

namespace LogicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 8;
            int grade = 75;
            int score = 85;
            double money = 540;
            if (age > 18 && money > 100)
            {
                Console.WriteLine("Welcome");
            }
            if (age > 18 && age < 80 && grade > 50)
            {
                Console.WriteLine("Hey There!");
            }
            if (age > 20 && score > 50)
            {
                Console.WriteLine("Welcome!");
            }
            if (!(age > 20))
            {
                Console.WriteLine("Less than 16!");
            }
        }
    }
}
