using System;
using System.Collections.Generic;

namespace DevYou2Week2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice Arrays
            int[] integers = new int[5];
            integers[0] = 14;
            integers[1] = 12;
            integers[2] = 73;
            integers[3] = 90;
            integers[4] = 146;

            foreach (int i in integers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.ReadLine();

            Array.Reverse(integers);
            foreach (int i in integers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.ReadLine();

            int[] copycat = new int[5];
            integers.CopyTo(copycat, 0);

            foreach (int i in integers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.ReadLine();

            int sum = 0;
            for (int n = 0; n < integers.Length; n++)
            {
                sum += integers[n];
            }

            Console.WriteLine($"The sum is {sum}");

            Console.ReadLine();

            Console.Clear();

            string[] words = new string[3];
            Console.WriteLine("Please enter 3 random words");

            for (int y = 0; y < words.Length; y++)
            {
                words[y] = Console.ReadLine();
            }

            foreach (string a in words)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
            Console.Clear();

            //Practice Lists

            List<string> names = new List<string>();
            names.Add("Alpha");
            names.Add("Beta");
            names.Add("Gamma");
            names.Add("Delta");
            names.Add("Epsilon");

            foreach (string v in names)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();

            names.Add("Zeta");
            names.Add("Eta");
            names.Add("Theta");

            names.Insert(2, "Marley");

            foreach (string v in names)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();
        }
    }
}
