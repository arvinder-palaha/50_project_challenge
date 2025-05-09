using System;

namespace TrackTheRobotPart3;

public class Program
{
    private const int X = 0;
    private const int Y = 1;

    public static void Main(string[] args)
    {
        Console.WriteLine("Track The Robot Part 3");
        if (args.Length == 1)
        {
            Console.WriteLine(TrackRobotPart3(args[0]));
        }
    }

    public static int[] TrackRobotPart3(string instructions)
    {
        int[] position = [0, 0];
        int[] direction = [1, 0];

        Console.WriteLine($"Initial position: {position[X]}, {position[Y]}");
        Console.WriteLine($"Initial direction: {direction[X]}, {direction[Y]}");
        Console.WriteLine("Instructions: " + instructions);

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
        int[] result = [position[X] + direction[X], position[Y] + direction[Y]];
        Console.WriteLine($"Moved forwards to: {result[X]}, {result[Y]}");
        return [result[X], result[Y]];
    }

    private static int[] TurnLeft(int[] direction)
    {
        // north -> west is [0,1] -> [-1,0]
        // west -> south is [-1,0] -> [0,-1]
        // south -> east is [0,-1] -> [1,0]
        // east -> north is [1,0] -> [0,1]
        int[] result = [-direction[Y], direction[X]];
        Console.WriteLine($"Turned left to: {result[X]}, {result[Y]}");
        return [result[X], result[Y]];
    }

    private static int[] TurnRight(int[] direction)
    {
        // north -> east is [0,1] -> [1,0]
        // east -> south is [1,0] -> [0,-1]
        // south -> west is [0,-1] -> [-1,0]
        // west -> north is [-1,0] -> [0,1]
        int[] result = [direction[Y], -direction[X]];
        Console.WriteLine($"Turned right to: {result[X]}, {result[Y]}");
        return [result[X], result[Y]];
    }
}
