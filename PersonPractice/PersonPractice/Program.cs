using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ID = 1;


            Employee employee2 = new Employee();
            employee2.ID = 1;


            if(employee == employee2)
            {

            }

            Console.ReadLine();

        }
    }
}
