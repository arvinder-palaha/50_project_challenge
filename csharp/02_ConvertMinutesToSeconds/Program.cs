class Program
{
    static void Main(string[] args)
    {
        float minutes = float.Parse(args[0]);
        float seconds = minutes * 60;
        Console.WriteLine($"{minutes} minutes is {seconds} seconds");
    }
}

