using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Shirley Wu";


            var mySib = new List<string>() { "Katrina", "Andy", "Anna" };


        }

        public class Name
        {
            public Name(string name, int age)
            {
                Console.WriteLine("Your name is " + name + "and you are " + age + " years old.");
            }
            //I guess if they're too afraid to tell us their age we just fill it in with 0
            public Name(string name) : this(name, 0)
            { }
        }

    }
}
