using System;

namespace DevYou2RoomAreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string run = "y";

            while (run == "y")
            {
                Console.Clear();
                Console.WriteLine("Please enter the length of your room.");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the width of your room.");
                int width = Convert.ToInt32(Console.ReadLine());

                int area = length * width;
                int perimeter = (2 * length) + (2 * width);

                Console.WriteLine($"The area of your room is {area}");
                Console.WriteLine($"The perimeter of your room is {perimeter}");
                Console.WriteLine();
                Console.WriteLine("Would you like to calculate another room?  Enter 'y' if yes.");
                run = Console.ReadLine();
            }


            Console.ReadLine();
        }
    }
}
