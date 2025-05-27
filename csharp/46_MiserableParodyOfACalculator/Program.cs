namespace MiserableParodyOfACalculator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Miserable Parody of a Calculator");
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
        Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Operators: " + string.Join(", ", operators));
        result = numbers[0];

        for (int i = 0; i < operators.Count; i++)
        {
            if (operators[i] == "+")
            {
                result += numbers[i + 1];
            }
            else if (operators[i] == "-")
            {
                result -= numbers[i + 1];
            }
            else if (operators[i] == "*")
            {
                result *= numbers[i + 1];
            }
            else if (operators[i] == "/")
            {
                result /= numbers[i + 1];
            }
        }
        return result;
    }
}
