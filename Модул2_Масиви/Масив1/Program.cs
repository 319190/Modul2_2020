﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Масив1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("vyvedeteden ot sedmica kato chislo");
            int day = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday","Saturday","Sunday" };

            if (day>=1&&day<=7)
            {
                Console.WriteLine(days[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day");
            }
        }
    }
}
