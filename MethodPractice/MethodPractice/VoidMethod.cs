using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    public static class VoidMethod
    {
        public static int Div(int v)
        {
            int c = v / 2;
            Console.WriteLine(c);
            return c;
        }

        public static int Div(int v, int w)
        {
            int c = v * w / 2;
            Console.WriteLine(c);
            return c;
        }
    }
}
