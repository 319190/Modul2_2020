﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", num));
            int brchetni = 0;
            num.Sort();
            Console.WriteLine(string.Join(" ", num));
            foreach (var item in num)
            {
                if (item % 2 == 0)
                {
                    brchetni++;
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Broy na chetni:{brchetni}");



        }
    }
}
