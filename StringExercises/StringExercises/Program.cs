using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Shirley";
            string lname = "Wu";
            string intro = "Hello, my name is ";
            Console.WriteLine(intro + fname + " " + lname + ".");
            string fnameupper = fname.ToUpper();
            Console.WriteLine("Please, call me " + fnameupper + ".");
            StringBuilder mySib = new StringBuilder("I am the oldest of 4 children. ");
            mySib.Append("My siblings names are Katrina, Andy, and Anna. ");
            mySib.Append("Katrina is the next oldest. ");
            mySib.Append("Andy and Anna are twins. ");
            mySib.Append("Katrina started college this year and we are all very proud of her. ");
            mySib.Append("Andy will start college next year, but Anna isn't sure what she wants to do. ");
            mySib.Append("We are all very close despite our difference in ages. ");
            Console.WriteLine(mySib);
            Console.ReadLine();

        }
    }
}
