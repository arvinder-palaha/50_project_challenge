namespace KnightsOnABoard;

public class Program
{
    public static void Main(int[,] board)
    {
        Console.WriteLine("Knights on a Board");
        if (board.Length > 0)
        {
            Console.WriteLine(CannotCapture(board));
        }
    }
    
    public static bool CannotCapture(int[,] board)
    {
        throw new NotImplementedException();
    }
}
