﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            //char ch = 'a';
            for (char i = 'a'; i < 'z'; i++)
            {
                Console.WriteLine($"{i}={(int)i}");
            }

          
        }

    }
}
