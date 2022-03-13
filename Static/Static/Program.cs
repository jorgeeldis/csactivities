using System;

namespace Static
{
    class Program
    {
        class Cat
        {
            public static int count = 0;
            public Cat()
            {
                count++;
            }
        }
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Cat c2 = new Cat();
            Console.WriteLine(Cat.count);
        }
    }
}
