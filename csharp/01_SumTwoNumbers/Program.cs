﻿using System;

namespace _01_SumTwoNumbers
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", args));
            Console.WriteLine("The length of the args list is: " + args.Length);
            float number1 = 1.5f;
            float number2 = 2.5f;
            float sum = Sum(number1, number2);
            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + sum);

            return 0;
        }

        static float Sum(float number1, float number2)
        {
            return number1 + number2;
        }
    }
}

