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
            Person person = new Person();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.SayName();

            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Employee";
            employee.SayName();

            Console.ReadLine();

        }
    }
}
