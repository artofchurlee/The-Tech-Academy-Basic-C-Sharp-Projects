using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;
            Console.WriteLine("Right now it is " + timeNow);
            
            Console.WriteLine("Please provide a number to be added to the hour.");
            int addhr = Convert.ToInt32(Console.ReadLine());
            TimeSpan totalTime = new TimeSpan(addhr, 0, 0);
            DateTime newTime = timeNow.Add(totalTime);
            Console.WriteLine("The time in " + addhr + "hours will be " + newTime);

            Console.ReadLine();

        }
    }
}
