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
        // get size of board
        // iterate through board
        // if knight is found
        // check all possible moves
        // if a knight is found in the possible moves, return false
        // if no knight is found in the possible moves, return true
    }
}

/*
Possible moves of a knight:

0 0 0 0 0 0 0 0
0 0 / 0 / 0 0 0
0 / 0 0 0 / 0 0
0 0 0 K 0 0 0 0
0 / 0 0 0 / 0 0
0 0 / 0 / 0 0 0
0 0 0 0 0 0 0 0
0 0 0 0 0 0 0 0

k-position: (3, 3)

possible moves:
(1, 2)
(1, 4)
(2, 1)
(2, 5)
(4, 1)
(4, 5)
(5, 2)
(5, 4)




*/