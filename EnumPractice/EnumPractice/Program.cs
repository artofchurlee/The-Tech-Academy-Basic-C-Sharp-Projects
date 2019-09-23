using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week it is.");
            string input = Console.ReadLine();
            try
            {
                Enum.Parse(typeof(DayofWeek), input, true);
                Console.WriteLine("Today is " + input);
            }

            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
