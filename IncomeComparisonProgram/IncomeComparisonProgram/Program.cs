using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string per1 = Console.ReadLine();
            double per1hr = Convert.ToDouble(per1);
            Console.WriteLine("Hours worked per week?");
            string per1w = Console.ReadLine();
            double per1wk = Convert.ToDouble(per1w);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string per2 = Console.ReadLine();
            double per2hr = Convert.ToDouble(per2);
            Console.WriteLine("Hours worked per week?");
            string per2w = Console.ReadLine();
            double per2wk = Convert.ToDouble(per2w);

            double per1sal = per1hr * per1wk;
            double per2sal = per2hr * per2wk;
            Console.WriteLine("Weekly Salary of Person 1:");
            Console.WriteLine(per1sal);
            Console.WriteLine("Weekly Salary of Person 2:");
            Console.WriteLine(per2sal);
            Console.WriteLine("Does person 1 make more money than person 2?");
            bool moreMoney = per1sal > per2sal;
            Console.WriteLine(moreMoney);
            Console.ReadLine();

        }
    }
}
