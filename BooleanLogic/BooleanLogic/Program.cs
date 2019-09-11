using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageint = Convert.ToInt32(age);
            bool agebool = ageint > 15;
            Console.WriteLine("Have you ever had a DUI? Please answer true or false");
            string dui = Console.ReadLine();
            bool duibool = "false" == dui;
            Console.WriteLine("How many speeding tickets do you have?");
            string tix = Console.ReadLine();
            int tixint = Convert.ToInt32(tix);
            bool tixbool = tixint < 3;
            Console.WriteLine("Qualified?");
            bool result = (agebool && duibool && tixbool);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
