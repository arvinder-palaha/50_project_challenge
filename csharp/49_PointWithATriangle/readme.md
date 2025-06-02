# challenge 49: Point with a Triangle

## Description

Create a function that takes four integer arrays of 2 elements.
The first three are (x, y) coordinates of three corners of a triangle.
Return True if the fourth array — the (x, y) coordinates of a test point — lies within the triangle, False if it doesn't.

## Examples

```csharp
WithinTriangle((1, 4), (5, 6), (6, 1), (4, 5)) ➞ True
WithinTriangle((1, 4), (5, 6), (6, 1), (3, 2)) ➞ False
WithinTriangle((-6, 2), (-2, -2), (8, 4), (4, 2)) ➞ True
```
