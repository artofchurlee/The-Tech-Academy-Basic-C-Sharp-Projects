using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please provide your age in years");
                int yearsOld = Convert.ToInt32(Console.ReadLine());
                if (yearsOld == 0) throw new CustomException();
                if (yearsOld < 0) throw new CustomException2();
                int yearBorn = 2019 - yearsOld;
                Console.WriteLine("You were born in " + yearBorn);
                Console.ReadLine();
               
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid whole number.");
                Console.ReadLine();
                return;
            }
            catch(CustomException)
            {
                Console.WriteLine("We all know babies can't run this program.");
                Console.ReadLine();
                return;
            }
            catch(CustomException2)
            {
                Console.WriteLine("Hello time traveler. Our code only works for people born in the past");
                Console.ReadLine();
                return;
            }
            catch(Exception)
            {
                Console.WriteLine("An Error has occured. Please try again later.");
                Console.ReadLine();
                return;
            }



        }
    }
}
