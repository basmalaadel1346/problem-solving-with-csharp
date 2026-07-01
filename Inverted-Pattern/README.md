# Number Patterns (C#)

## Overview

This console application prints two common number patterns using nested loops:

- Inverted Number Pattern
- Ascending Number Pattern

The program reads a positive integer from the user and displays both patterns.

---

## Features

- Input validation
- Inverted number pattern
- Ascending number pattern
- Simple nested loop implementation

---

## Example

Input

5

Output

Inverted Pattern

55555
4444
333
22
1

Number Pattern

1
22
333
4444
55555

---

## Algorithms

### Inverted Pattern

Starts from `N` and decreases to `1`.

Each row prints the current number exactly that many times.

### Number Pattern

Starts from `1` and increases to `N`.

Each row prints the current number exactly that many times.

---

## Complexity

| Pattern | Time | Space |
|---------|------|-------|
| Inverted Pattern | O(n²) | O(1) |
| Number Pattern | O(n²) | O(1) |

---

## Technologies

- C#
- .NET
- Console Application