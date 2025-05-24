namespace KnightsOnABoard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Knights on a Board");
    }
    
    public static bool CannotCapture(int[,] board)
    {
        // get size of board
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        // iterate through board
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // if knight is found
                if (board[i, j] == 1)
                {
                    // check all possible moves
                    bool result = KnightFoundInMoves(board, i, j);
                    // if a knight is found in the possible moves, return false
                    if (result)
                    {
                        return false;
                    }
                }
            }
        }
        // if no knight is found in the possible moves, return true
        return true;
    }

    public static bool KnightFoundInMoves(int[,] board, int i, int j)
    {
        // possible moves of a knight
        int[][] moves = new int[][]
        {
            new int[] {2, 1},
            new int[] {2, -1},
            new int[] {-2, 1},
            new int[] {-2, -1},
            new int[] {1, 2},
            new int[] {1, -2},
            new int[] {-1, 2},
            new int[] {-1, -2},
        };
        
        foreach (var move in moves)
        {
            int newRow = i + move[0];
            int newCol = j + move[1];

            if (newRow >= 0 && newRow < board.GetLength(0) && newCol >= 0 && newCol < board.GetLength(1))
            {
                if (board[newRow, newCol] == 1)
                {
                    return true;
                }
            }
        }
        return false;
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