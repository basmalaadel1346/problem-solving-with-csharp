# Sum of Digits

## Problem

Write a C# console application that calculates the sum of all digits in an integer using arithmetic operations.

---

## Example

### Input

```text
12345
```

### Output

```text
The sum of the digits of 12345 is: 15
```

---

## Solution Approach

The algorithm processes the number one digit at a time:

1. Extract the last digit using the modulus operator (`%`).
2. Add the extracted digit to the running sum.
3. Remove the last digit using integer division (`/`).
4. Repeat until the number becomes zero.

---

## Algorithm

```text
sum = 0

while number > 0
    digit = number % 10
    sum += digit
    number /= 10
```

---

## Complexity

- **Time Complexity:** `O(d)`
- **Space Complexity:** `O(1)`

Where `d` is the number of digits in the input number.

---

## Concepts Used

- Methods
- Loops (`while`)
- Arithmetic operators (`%`, `/`)
- Input validation
- Integer manipulation

---

## Project Structure

| Method | Responsibility |
|---------|----------------|
| `GetNumber()` | Reads and validates user input. |
| `SumOfDigits()` | Calculates the sum of all digits. |
| `PrintSumOfDigits()` | Displays the final result. |

---

## Notes

- The solution uses arithmetic operations only.
- No string conversion is performed.
- Uses constant extra memory.

---

## Future Improvements

- Support negative numbers.
- Calculate additional digit statistics (count, average, largest digit, smallest digit).
- Add unit tests.