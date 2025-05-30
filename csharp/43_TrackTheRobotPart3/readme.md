# 43 Track The Robot

## Description

A robot moves around a 2D grid. At the start, it is at [0, 0], facing east. It is controlled by a sequence of instructions:

    . means take one step forwards in the current direction.
    < means turn 90 degrees anticlockwise.
    > means turn 90 degrees clockwise.

Your job is to process the instructions and return the final position of the robot.

## Examples

For example, if the robot is given the sequence of instructions ..<.<., then:

    Step 1: . It still faces east, and is at [1, 0].
    Step 2: . It still faces east, and is at [2, 0].
    Step 3: < It now faces north, and is still at [2, 0].
    Step 4: . It still faces north, and is at [2, 1].
    Step 5: < It now faces west, and is still at [2, 1].
    Step 6: . It still faces west, and is now at [1, 1].

So, TrackRobot("..<.<.") returns [1, 1].

## Notes

The string will only ever contain the three control characters, and may or may not be empty.