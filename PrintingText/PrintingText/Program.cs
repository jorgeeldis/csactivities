using System;

namespace PrintingText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Class1.Imprimir();

            var miclase = new Class2();
            miclase.Imprimir();

            Console.ReadKey();

        }
    }
}
