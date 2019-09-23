using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Tomato";
            employee1.ID = 1;

          

            Employee employee2 = new Employee();
            employee2.FirstName = "Joe";
            employee2.LastName = "Potato";
            employee2.ID = 2;
       

            Employee employee3 = new Employee();
            employee3.FirstName = "Joe";
            employee3.LastName = "Onion";
            employee3.ID = 3;

            Employee employee4 = new Employee();
            employee4.FirstName = "John";
            employee4.LastName = "Carrot";
            employee4.ID = 4;

            Employee employee5 = new Employee();
            employee5.FirstName = "Chad";
            employee5.LastName = "Carrot";
            employee5.ID = 5;

            Employee employee6 = new Employee();
            employee6.FirstName = "Jesus";
            employee6.LastName = "Lemon";
            employee6.ID = 6;

            Employee employee7 = new Employee();
            employee7.FirstName = "Mister";
            employee7.LastName = "Lime";
            employee7.ID = 7;

            Employee employee8 = new Employee();
            employee8.FirstName = "Julia";
            employee8.LastName = "Leek";
            employee8.ID = 8;

            Employee employee9 = new Employee();
            employee9.FirstName = "Pat";
            employee9.LastName = "Cucumber";
            employee9.ID = 9;

            Employee employee10 = new Employee();
            employee10.FirstName = "Robin";
            employee10.LastName = "Hood";
            employee10.ID = 10;

            employee.Add(employee1);
            employee.Add(employee2);
            employee.Add(employee3);
            employee.Add(employee4);
            employee.Add(employee5);
            employee.Add(employee6);
            employee.Add(employee7);
            employee.Add(employee8);
            employee.Add(employee9);
            employee.Add(employee10);



            //ALL THE JOES
            foreach (Employee name in employee)
            {

                for (int i = 0; i < employee.Count; i++)
                {
                    if (name.FirstName == "Joe")
                    {
                        Console.WriteLine(name.FirstName + " " + name.LastName);
                    }
                    break;
                }

            }


            //ALL THE JOES IN LAMBDA
            List<Employee> newList = employee.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee name in newList)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }


            //LIST OF EMPLOYEES WITH IDS > 5
            List<Employee> newList2 = employee.Where(x => x.ID > 5).ToList();
            foreach (Employee name in newList2)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }


                Console.ReadLine();

        }
                    
          
    }
}
    

