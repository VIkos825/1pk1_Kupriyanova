﻿using System;

namespace Task_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
                /*Найти значение выражения 
               * при a = 0, b = 6, c = 2
               * 
               */
                double a = 0;
                double b = 6;
                double c = 2;

                double part1 = 5 * Math.Atan(a);
                double part2 = 0.25 * Math.Cos(a);
                double part3 = a + 3 * Math.Abs(a - b) + a * a;
                double part4 = Math.Abs(a - b) * c + a * a;

                double sol = part1 - part2 * (part3 / part4);

                Console.WriteLine(sol);

         
        }
    }
    
}
