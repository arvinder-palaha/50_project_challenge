# 45. Knights on a Board

## Description

Write a function that returns true if the knights are placed on a chessboard such that no knight can capture another knight.
Here, 0s represent empty squares and 1s represent knights.

## Examples

```csharp
CannotCapture(new int[,] {
  { 0, 0, 0, 1, 0, 0, 0, 0 },
  { 0, 0, 0, 0, 0, 0, 0, 0 },
  { 0, 1, 0, 0, 0, 1, 0, 0 },
  { 0, 0, 0, 0, 1, 0, 1, 0 },
  { 0, 1, 0, 0, 0, 1, 0, 0 },
  { 0, 0, 0, 0, 0, 0, 0, 0 },
  { 0, 1, 0, 0, 0, 0, 0, 1 },
  { 0, 0, 0, 0, 1, 0, 0, 0 }
}) ➞ True

CannotCapture(new int[,] {
  {1, 0, 1, 0, 1, 0, 1, 0},
  {0, 1, 0, 1, 0, 1, 0, 1},
  {1, 0, 1, 0, 1, 0, 1, 0},
  {0, 0, 0, 1, 0, 1, 0, 1},
  {1, 0, 0, 0, 1, 0, 1, 0},
  {0, 0, 0, 0, 0, 1, 0, 1},
  {1, 0, 1, 0, 1, 0, 1, 0},
  {1, 0, 0, 1, 0, 0, 0, 1} 
}) ➞ False
```

## Notes

 - Knights can be present in any of the 64 squares.
 - No other pieces except knights exist.