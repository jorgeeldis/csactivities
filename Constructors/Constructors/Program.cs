using System;

namespace Constructors
{
    class Program
    {
        class Person
        {
            private int age;
            private string name;
            public Person(string nm)
            {
                name = nm;
            }
            public string GetName()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("David");
            Console.WriteLine(p.GetName());
        }
    }
}
