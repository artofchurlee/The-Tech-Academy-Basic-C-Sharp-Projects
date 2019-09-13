using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomTemp = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi " + name + ", what is the temperature where you are at?");
            int currentTemp = Convert.ToInt32(Console.ReadLine());

            //int currentTemp = 80;
            //int roomTemp = 70;
            //string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp";
        }
    }
}
