# 31_IsTheDieLoaded

## Description

The Chi-Squared (χ²) goodness of fit test estimates if an empirical (observed) distribution fits a theoretical (expected) distribution within reasonable margins.
For example, to figure out if a die is loaded you could roll it many times and note the results.
Because of randomness, you can't expect to get the same frequency for all faces, but if one or more faces turn up much more frequently than some others, it is reasonable to assume the die is loaded.

## Examples

```
FairDie([44, 52, 33, 40, 41, 30]) ➞ true
(χ² = 7.75) < 11.0705

FairDie([34, 27, 23, 20, 32, 28]) ➞ true
(χ² = 1.6) < 11.0705

FairDie([10, 20, 11, 5, 19, 16]) ➞ false
(χ² = 12.556) > 11.0705
```
