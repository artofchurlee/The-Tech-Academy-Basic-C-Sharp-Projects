using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            int w = Convert.ToInt32(Console.ReadLine());
            VoidMethod.Div(v, w);

            Console.ReadLine();
        }
    }
}
