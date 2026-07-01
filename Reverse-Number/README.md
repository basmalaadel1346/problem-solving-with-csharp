# Reverse Number & Palindrome Check (C#)

## Overview

This console application reverses an integer using arithmetic operations and determines whether the original number is a palindrome.

The implementation avoids converting the number to a string and uses only mathematical operations.

---

## Features

- Reverse an integer mathematically
- Check whether a number is a palindrome
- Display the original number
- Display the reversed number
- Print the palindrome check result

---

## Example

Input:

12321

Output:

Original Number: 12321
Reversed Number: 12321
12321 is a palindrome.

---

## Algorithm

### Reverse Number

1. Extract the last digit using `% 10`.
2. Append it to the reversed number.
3. Remove the last digit using `/ 10`.
4. Repeat until the number becomes `0`.

### Palindrome Check

- Reverse the number.
- Compare the reversed value with the original number.
- If both are equal, the number is a palindrome.

---

## Complexity

| Operation | Time | Space |
|----------|------|-------|
| Reverse Number | O(d) | O(1) |
| Palindrome Check | O(d) | O(1) |

> **d** is the number of digits.

---

## Technologies

- C#
- .NET
- Console Application