namespace MiserableParodyOfACalculator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Miserable Parody of a Calculator");
        if (args.Length > 0)
        {
            Console.WriteLine(Calculator(args[0]));
        }
        else
        {
            Console.WriteLine("No expression provided");
        }
    }

    public static double Calculator(string expression)
    {
        double result = 0;
        // no brackets, no mathematical functions, no gaps
        // get length of string
        int length = expression.Length;

        List<double> numbers = new List<double>();
        List<string> operators = new List<string>();
        string currentNumber = "";

        // iterate through string
        for (int i = 0; i < length; i++)
        {
            // if char is number, add to number
            if (char.IsDigit(expression[i]))
            {
                currentNumber += expression[i];
                if (i == length - 1)
                {
                    numbers.Add(double.Parse(currentNumber));
                }
            }
            else
            {
                numbers.Add(double.Parse(currentNumber));
                currentNumber = "";
                // if char is operator, add to operators
                operators.Add(expression[i].ToString());
            }   
        }
        PrintIt(numbers, operators);

        // perform * and / first
        while (operators.Contains("*") || operators.Contains("/"))
        {
            int i = 0;
            while (i < operators.Count)
            {
                Console.WriteLine("i: " + i);
                if (operators[i] == "*" || operators[i] == "/")
                {
                    double temp;
                    if (operators[i] == "*")
                    {
                        temp = numbers[i] * numbers[i + 1];
                    }
                    else // division
                    {
                        temp = numbers[i] / numbers[i + 1];
                    }
                    numbers[i] = temp;
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    PrintIt(numbers, operators);
                }
                else
                {
                    i++;
                }
                PrintIt(numbers, operators);
            }
            PrintIt(numbers, operators);
        }
        PrintIt(numbers, operators);
        /*
        "13+2-5*2"
        numbers: [13, 2, 5, 2]
        operators: ["+", "-", "*"]

        result = 13
        
        - 3rd operator is *, at i = 2
        - numbers[i] = numbers[i] * numbers[i+1]
        - operators.RemoveAt(i)
        - numbers.RemoveAt(i+1)

        numbers: [13, 2, 10]
        operators: ["+", "-"]
        */
        result = numbers[0];
        for (int i = 0; i < operators.Count; i++)
        {
            Console.WriteLine("i: " + i);
            if (operators[i] == "+")
            {
                result += numbers[i + 1];
            }
            else if (operators[i] == "-")
            {
                result -= numbers[i + 1];
            }
        }
        return result;
    }

    private static void PrintIt(List<double> numbers, List<string> operators)
    {
        Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Operators: " + string.Join(", ", operators));
    }
}
