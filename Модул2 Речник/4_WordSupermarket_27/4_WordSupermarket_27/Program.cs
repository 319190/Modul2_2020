﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_WordSupermarket_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>> market = new Dictionary<string, List<double>>();
            double S = 0;
            while (true)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                var stoka = linia[0];
                if (stoka=="stocked")
                {
                    break;
                }

                double price = double.Parse(linia[1]);
                double quantity = double.Parse(linia[2]);

                if (market.ContainsKey(stoka))
                {
                    for (int i = 0; i < market[stoka].Count; i++)
                    {
                        if (market[stoka][0]!=price)
                        {
                            market[stoka][0] = price;
                        }
                        market[stoka][1] = market[stoka][1] + quantity;
                    }
                }
                else
                {
                    List<double> spisyk = new  List<double>();
                    spisyk.Add(price);
                    spisyk.Add(quantity);
                    market.Add(stoka, spisyk);
                }
               

            }
            foreach (var item in market)
            {
                Console.WriteLine($"{item.Key}: ${item.Value[0]:f2}*{item.Value[1]}=${item.Value[0]}*{item.Value[1]:f2}");
               S +=  item.Value[0] * item.Value[1];
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine($"GrandTotal:{S}");
        }
    }
}
