# Inverted Number Pattern (C#)

## Overview

This console application prints an inverted number pattern based on a user-provided integer.

Each row displays the current row number repeated a number of times equal to its value, starting from the input number down to 1.

---

## Features

- Read an integer from the user
- Validate user input
- Generate an inverted number pattern
- Simple nested loop implementation

---

## Example

Input:

5

Output:

55555
4444
333
22
1

---

## Algorithm

1. Read a valid integer from the user.
2. Start an outer loop from the input number down to `1`.
3. For each row, print the current number repeatedly using an inner loop.
4. Move to the next line after each row.

---

## Complexity

| Operation | Time | Space |
|----------|------|-------|
| Pattern Generation | O(n²) | O(1) |

Where **n** is the input number.

---

## Technologies

- C#
- .NET
- Console Application