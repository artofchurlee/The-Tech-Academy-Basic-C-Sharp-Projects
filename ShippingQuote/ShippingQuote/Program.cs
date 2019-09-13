using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pacakge Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
            }
            else {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                float est = (width + height + length) * weight / 100.00f;
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via package express");
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + String.Format("{0:0.00}", est));
                    Console.WriteLine("Thank you");
                }

                }
            Console.ReadLine();

        }
    }
}
