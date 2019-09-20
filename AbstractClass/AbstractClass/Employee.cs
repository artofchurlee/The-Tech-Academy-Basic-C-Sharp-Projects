using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee: Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("The employee's name is: ");
            base.SayName();
        }

        public void Quit(Person employee)
        {
            throw new NotImplementedException();
        }
    }
}
