namespace CharactersCounterpartCharCode;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        char character = 'A';
        Console.WriteLine((int)character);
    }

    public static int CounterpartCharCode(char character)
    {
        if (char.IsUpper(character))
        {
            return (int)char.ToLower(character);
        }
        else
        {
            return (int)char.ToUpper(character);
        }
    }
}
