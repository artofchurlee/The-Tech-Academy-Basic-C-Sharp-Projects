using System;


namespace MathAndComparisonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number.");
            string num1 = Console.ReadLine();
            int number1 = Convert.ToInt32(num1);
            Console.WriteLine("Your number times 50 is: " + number1 * 50);

            Console.WriteLine("Input a number.");
            string num2 = Console.ReadLine();
            int number2 = Convert.ToInt32(num2);
            int total = number2 + 25;
            Console.WriteLine("Your number plus 25 is: " + total);

            Console.WriteLine("Input a number.");
            string num3 = Console.ReadLine();
            double number3 = Convert.ToDouble(num3);
            double quotient = number3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);

            Console.WriteLine("Input a number.");
            string num4 = Console.ReadLine();
            int number4 = Convert.ToInt32(num4);
            bool isLarge = number4 > 50;
            Console.WriteLine("Is your number larger than 50?" + isLarge);

            Console.WriteLine("Input a number.");
            string num5 = Console.ReadLine();
            int number5 = Convert.ToInt32(num5);
            int remainder = number5 % 7;
            Console.WriteLine("Your number divided by 7 gives the remainder of: " + remainder);
            Console.ReadLine();
        }
    }
}
