﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {

            Number number = new Number()
            {
                Amount = 3.5m
            };

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
