using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoInt
{
    public class TwoPara
    {
        public static int Addition(int a, int b = 1)
        {
            int c = a * b * 5;
            Console.WriteLine("Your input times 5 is : " + c);
            return c;
        }
    }
}
