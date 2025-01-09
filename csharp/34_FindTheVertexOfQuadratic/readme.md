# 34_FindTheVertexOfQuadratic

## Description

Every quadratic curve y = a x² + b x + c has a vertex point: the turning point where the curve stops heading down and starts going up.

Given the values a, b and c, you need to return the coordinates of the vertex. Return your answers rounded to 2 decimal places.

## Examples

```csharp
FindVertex(1, 0, 25)  ➞ [0, 25]
// The vertex of y=x²+25 is at (0, 25).

FindVertex(-1, 0, 25) ➞ [0, 25]
// The vertex of y=-x²+25 is at (0, 25).

FindVertex(1, 10, 4) ➞ [-5, -21]
// The vertex of y=x²+10x+4 is at (-5, -21).
```
