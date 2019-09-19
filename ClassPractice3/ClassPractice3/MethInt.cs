using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice3
{
    public class MethInt
    {
        public static int AddInt(int v)
        {
            int num1 = v + 12;
            Console.WriteLine("Your number plus 12 is : " + num1);
            return num1;
        }
        public static double AddInt(double v)
        {
            double num2 = v - 1.0;
            Console.WriteLine("Your number minus 1 is : " + num2);
            return num2;
        }
        public static string AddInt(string v)
        {
            double num3 = Convert.ToDouble(v);
            double num4 = num3 * 5;
            Console.WriteLine("Your number times 5 is : " + num4);

            return Convert.ToString(num4);
        }
    }
}
