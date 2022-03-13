using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string YourName;
            Console.WriteLine("What is your name?");

            YourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", YourName);

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your are {0} years old", age);
        }
    }
}
