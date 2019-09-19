using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide another number. This is optional. Press enter to skip.");
            if
                (int.TryParse(Console.ReadLine(), out int b))
                    {
                TwoPara.Addition(a, b);
            }
            else
            {

                TwoPara.Addition(a);
            }

            Console.ReadLine();
        }
    }
}
