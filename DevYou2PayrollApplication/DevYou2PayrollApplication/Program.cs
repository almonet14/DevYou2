using System;

namespace DevYou2PayrollApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Payroll Application.");
            Console.WriteLine("Please enter your user name to begin");
            string userInput = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Welcome, {FirstName} {LastName}.");
        }
    }
}
