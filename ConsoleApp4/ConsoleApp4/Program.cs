using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "George", "John", "Jason", "John", "Thomas" };

            Employee<int> ID = new Employee<int>();
            ID.Things = new List<int>() {  1, 2, 3, 5, 8 };

            for (int i = 0; i < ID.Things.Count; i++)
            {
                Console.WriteLine(employee.Things[i]);
                Console.WriteLine(ID.Things[i]);
            }

            Console.ReadLine();
        }
    }
}
