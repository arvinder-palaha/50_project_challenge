# working 9 to 5

## Description

Write a function that calculates overtime and pay associated with overtime.

    Working 9 to 5: regular hours
    After 5pm is overtime

Your function gets an array with 4 values:

    Start of working day, in decimal format, (24-hour day notation)
    End of working day. (Same format)
    Hourly rate
    Overtime multiplier

Your function should spit out:

    $ + earned that day (rounded to the nearest hundreth)

## Examples

```csharp
OverTime([9, 17, 30, 1.5]) ➞ "$240.00"

OverTime([16, 18, 30, 1.8]) ➞ "$84.00"

OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"
```