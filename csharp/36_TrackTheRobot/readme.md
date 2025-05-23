# Track The Robot

## Description

A robot has been given a list of movement instructions. Each instruction is either left, right, up or down, followed by a distance to move.
The robot starts at `[0, 0]`.
You want to calculate where the robot will end up and return its final position as an array.

To illustrate, if the robot is given the following instructions:

`new string[] { "right 10", "up 50", "left 30", "down 10" }`

It will end up 20 left and 40 up from where it started, so we return `int[] { -20, 40 }.`

## Examples

```csharp
TrackRobot(new string[] { "right 10", "up 50", "left 30", "down 10" }) ➞ int[] { -20, 40 }

TrackRobot(new string[] { }) ➞ int[] { 0, 0 }
// If there are no instructions, the robot doesn't move.

TrackRobot(new string[] { "right 100", "right 100", "up 500", "up 10000" }) ➞ new int[] { 200, 10500 }
```
