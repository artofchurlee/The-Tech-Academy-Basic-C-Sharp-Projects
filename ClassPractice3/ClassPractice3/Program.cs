using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MethInt.AddInt(14));
            Console.WriteLine(MethInt.AddInt(1.1));
            Console.WriteLine(MethInt.AddInt("19.0"));

            Console.ReadLine();
        }
    }
}
