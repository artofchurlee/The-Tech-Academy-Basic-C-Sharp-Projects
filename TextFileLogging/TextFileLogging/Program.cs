using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            string num = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\XxLit\log2.txt", true))
            {
                file.WriteLine(num);
            }

            string text = File.ReadAllText(@"C:\Users\XxLit\log2.txt");
            Console.WriteLine(text);
            
            Console.ReadLine();
        }
    }
}
