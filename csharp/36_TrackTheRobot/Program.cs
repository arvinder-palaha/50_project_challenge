using System.Xml.XPath;

namespace TrackTheRobot;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Track the robot");
    }

    public static int[] TrackRobot(string[] instructions)
    {
        int x = 0;
        int y = 0;
        foreach (var instruction in instructions)
        {
            var parts = instruction.Split(' ');
            var direction = parts[0];
            var distance = int.Parse(parts[1]);
            switch (direction)
            {
                case "right":
                    x += distance;
                    break;
                case "left":
                    x -= distance;
                    break;
                case "up":
                    y += distance;
                    break;
                case "down":
                    y -= distance;
                    break;
            }
        }
        return new int[] { x, y };
    }
}