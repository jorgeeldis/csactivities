using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int k = 0; k < 10; k++)
            {
                a[k] = k * 2;
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(a[k]);
            }
        }
    }
}