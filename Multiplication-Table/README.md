# Multiplication Table

## Problem

Print a multiplication table from **1 to 10** in a well-formatted tabular layout.

Example:

```
      1   2   3 ...
1 |   1   2   3 ...
2 |   2   4   6 ...
```

---

## Concepts Used

- Nested Loops
- Console Formatting
- String Interpolation
- Constant Values
- Method Decomposition

---

## Engineering Notes

- Used method decomposition to separate the header and body.
- Used string interpolation alignment (`{value,10}`) instead of manually adding spaces.
- Avoided magic numbers by introducing a `TableSize` constant.
- Generated the separator dynamically to support future table size changes.

---

## Complexity

Time Complexity:

```
O(n²)
```

Space Complexity:

```
O(1)
```

---

## Possible Improvements

- Allow the user to choose the table size.
- Export the table to a text file.
- Add colors for better readability.
