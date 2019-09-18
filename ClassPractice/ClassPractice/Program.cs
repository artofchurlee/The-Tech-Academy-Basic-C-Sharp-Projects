using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int v = Convert.ToInt32(Console.ReadLine());

            int int2 = IntClass.Addition(v);

            Console.WriteLine("Your number plus 15 is: " + int2);

            int int3 = IntClass.Subtraction(v);
            Console.WriteLine("Your number minus 2 is: " + int3);

            int int4 = IntClass.Multiplication(v);
            Console.WriteLine("Your number times 2 is: " + int4);


            Console.ReadLine();
        }
    }
}
