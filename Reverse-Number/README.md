# Reverse Number

## Problem

Write a C# console application that reverses the digits of an integer using arithmetic operations without converting the number to a string.

---

## Example

### Input

```text
12345
```

### Output

```text
54321
```

---

## Solution Approach

The algorithm reverses the number digit by digit:

1. Extract the last digit using the modulus operator (`%`).
2. Append the extracted digit to the reversed number.
3. Remove the last digit from the original number using integer division (`/`).
4. Repeat until the original number becomes zero.

---

## Algorithm

```text
reversed = 0

while number != 0
    digit = number % 10
    reversed = reversed * 10 + digit
    number = number / 10
```

---

## Complexity

- **Time Complexity:** `O(d)`
- **Space Complexity:** `O(1)`

Where `d` is the number of digits in the input number.

---

## Concepts Used

- Loops (`while`)
- Arithmetic operators (`%`, `/`)
- Integer manipulation
- Variables
- Methods

---

## Notes

- The solution avoids converting the number to a string.
- Uses constant extra memory.
- Efficient for integers of any valid size within the `int` range.

---

## Future Improvements

- Read the number from user input.
- Support negative numbers.
- Detect integer overflow when reversing very large numbers.
- Add automated unit tests.