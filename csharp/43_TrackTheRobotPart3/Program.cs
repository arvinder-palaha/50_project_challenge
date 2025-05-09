using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TrackTheRobotPart3;

public class Program
{
    private const int X = 0;
    private const int Y = 1;

    public static void Main(string[] args)
    {
        Console.WriteLine("Track The Robot Part 3");
    }

    public static int[] TrackRobotPart3(string instructions)
    {
        int[] position = [0, 0];
        int[] direction = [1, 0];

        foreach (char instruction in instructions)
        {
            if (instruction == '.')
            {
                position = MoveForwards(position, direction);
            }
            else if (instruction == '<')
            {
                direction = TurnLeft(direction);
            }
            else if (instruction == '>')
            {
                direction = TurnRight(direction);
            }
        }

        return position;
    }

    private static int[] MoveForwards( int[] position, int[] direction)
    {
        return [position[X] + direction[X], position[Y] + direction[Y]];
    }

    private static int[] TurnLeft(int[] direction)
    {
        // up -> left
        // left -> down
        // down -> right
        // right -> up
        // return [direction[Y], -direction[X]];
        return direction;
    }

    private static int[] TurnRight(int[] direction)
    {
        return direction;
    }
}
