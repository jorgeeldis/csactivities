using System;

namespace Class
{
    class Program
    {
        class Person
        {
            int age;
            string name;
            public void SayHi()
            {
                Console.WriteLine("Hi");
            }
        }
        class Dog
        {
            public string name;
            public int age;
        }
        static void Main(string[] args)
        {
            Dog bob = new Dog();
            bob.name = "Bobby";
            bob.age = 3;
            Console.WriteLine(bob.age);
            Person p1 = new Person();
            p1.SayHi();
        }
    }
}
