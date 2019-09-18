using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice2
{
    class Program
    {
        public static void Main(string[] args)
        {

            //   #2-3
            int a = 15;
            int b = 25;
            ClassMethod.Para(a, b);


            //   #4
            ClassMethod.Para(a: 15, b: 25);

            Console.ReadLine();
        }
    }
}
