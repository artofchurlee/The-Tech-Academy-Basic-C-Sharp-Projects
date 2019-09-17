using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numlist = new List<int>(10) { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            try
            {
                Console.WriteLine("Please enter a number to divide by. It will be rounded.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numlist)
                {

                    Console.WriteLine(num + " divided by " + num2 + " is " + num / num2);
                  
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for your input!");
                Console.ReadLine();
            }
            




            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick another number.");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");
            //    int num3 = num1 / num2;
            //    Console.WriteLine(num1 + " divided by " + num2 + " equals " + num3);
            //    Console.ReadLine();

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //}
            //catch (DivideByZeroException ez)
            //{
            //    Console.WriteLine("Please don't divide by zero");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}
            
        }
    }
}
