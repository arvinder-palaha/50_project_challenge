namespace CountDuplicateCharacters;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Count Duplicate Characters");
    }

    public static int CountDuplicateCharacters(string str)
    {
        return str.GroupBy(c => c).Where(g => g.Count() > 1).Count();
    }
}
