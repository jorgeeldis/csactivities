// Created by MrDevEzeoke


using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[]{
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };
            List<string> names = new List<string>();
            string letter = Console.ReadLine();

            foreach (var t in words)
            {
                if (t.Contains(letter))
                {
                    names.Add(t);
                }
            }
            if (names.Count > 0)
                names.ForEach(delegate (String name) { Console.WriteLine(name); });
            else
                Console.WriteLine("NO MATCH");


        }

    }
}