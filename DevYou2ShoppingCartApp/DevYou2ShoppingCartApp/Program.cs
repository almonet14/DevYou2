using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            List<double> prices = new List<double>();
            List<double> total = new List<double>() { 0, 0, 0, 0 };
            int quantity;
            int userInput = -1;


            products.Add("Product A");
            products.Add("Prodcut B");
            products.Add("Product C");
            products.Add("Product D");

            prices.Add(13.98);
            prices.Add(32.87);
            prices.Add(50.45);
            prices.Add(25.68);

            bool flag = true;
            int v = 1;

            while (flag == true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the corresponding number to the product you would like to add to your cart:");
                Console.WriteLine();

                foreach (var i in products)
                {
                    Console.WriteLine($"{v}. {i}");
                    v++;
                }

                int productCount = products.Count;

                userInput = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine();



                if (userInput > productCount || userInput <= 0)
                {
                    Console.WriteLine("That is an unavailable product number, please try again.");
                    v = 1;
                    continue;
                }


                Console.WriteLine("How many would you like?");
                quantity = Convert.ToInt32(Console.ReadLine());


                switch (userInput)
                {
                    case 1:
                        total[0] += prices.ElementAt(0) * quantity;
                        break;
                    case 2:
                        total[1] += prices.ElementAt(1) * quantity;
                        break;
                    case 3:
                        total[2] += prices.ElementAt(2) * quantity;
                        break;
                    case 4:
                        total[3] += prices.ElementAt(3) * quantity;
                        break;
                    default:
                        Console.WriteLine("I'm sorry, Dave.  I'm afraid I can't do that.");
                        break;

                }

                Console.WriteLine("Would you like to select another item?");
                string answer = Convert.ToString(Console.ReadLine());
                answer = answer.ToLower();

                if (answer == "yes" || answer == "y")
                {
                    flag = true;
                    v = 1;
                }
                else
                {
                    flag = false;
                }
            }


            double grandTotal = total.Sum(Convert.ToDouble);

            Console.Clear();
            Console.WriteLine($"Your total for {products[0]} is: {total.ElementAt(0),2}");
            Console.WriteLine($"Your total for {products[1]} is: {total.ElementAt(1),2}");
            Console.WriteLine($"Your total for {products[2]} is: {total.ElementAt(2),2}");
            Console.WriteLine($"Your total for {products[3]} is: {total.ElementAt(3),2}");
            Console.WriteLine($"Making your total for all products {grandTotal,2}");







            Console.ReadLine();
        }
    }
}