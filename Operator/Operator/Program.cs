using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 42;
            string msg;
            msg = (age >= 18) ? "Welcome": "Sorry";

            Console.WriteLine(msg);
        }
    }
}
