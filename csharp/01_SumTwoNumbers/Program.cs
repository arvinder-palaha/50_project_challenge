using System;

namespace _01_SumTwoNumbers
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Usage();
                return 1;
            }

            float number1 = float.Parse(args[0]);
            float number2 = float.Parse(args[1]);
            float sum = Sum(number1, number2);
            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + sum);

            return 0;
        }

        static float Sum(float number1, float number2)
        {
            return number1 + number2;
        }

        static void Usage()
        {
            Console.WriteLine("Usage: dotnet run <number1> <number2>");
        }
    }
}

