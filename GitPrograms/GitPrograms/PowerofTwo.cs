﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPrograms
{
    internal class PowerofTwo
    {
        public static void FindPowerofTwo()
        {
            Console.WriteLine("Enter a number to get power of two");
            int number = Convert.ToInt32(Console.ReadLine());

            int powOfTwo = 0;
            for (int i = 1; i <= number; i++)
            {
                powOfTwo = (int)Math.Pow(2, i);
            }
            Console.WriteLine("Power of given number: " + powOfTwo);
        }
    }
}
