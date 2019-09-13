using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            //WHILE LOOP

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool canBuy = age >= 21;
            while (!canBuy)
            {
                Console.WriteLine("You cannot purchase alcohol.");
                break;
            }
            if (canBuy)
            {
                Console.WriteLine("You can purchase alcohol.");
            }

            Console.ReadLine();

            //DO WHILE LOOP
            Console.WriteLine("How many more days until your birthday?");
            int bday = Convert.ToInt32(Console.ReadLine());
            bool isBday = bday == 0;

            do
            {
                switch (bday)
                {
                    default:
                        Console.WriteLine("Sorry, come back in " + bday + " days!");
                        Console.ReadLine();
                        break;
                        

                    case 1:
                        Console.WriteLine("Wow, it's almost your birthday!");
                        Console.ReadLine();
                        break;

                    case 0:
                        Console.WriteLine("Happy Birthday!");

                        break;

                }

            } while (!isBday);
            

            Console.Read();
            
        }   
    }
}
