# Digit Frequency Counter

## Problem

Write a C# console application that counts how many times each digit (0–9) appears in an integer.

The solution should process the number using arithmetic operations without converting it to a string.

---

## Features

- Counts the frequency of every digit.
- Supports positive numbers.
- Supports negative numbers.
- Correctly handles zero.
- Uses a single pass through the number.
- No string conversion.

---

## Example

### Input

```text
1223344555
```

### Output

```text
Digit 1 appears 1 times.
Digit 2 appears 2 times.
Digit 3 appears 2 times.
Digit 4 appears 2 times.
Digit 5 appears 3 times.
```

---

### Input

```text
-10025
```

### Output

```text
Digit 0 appears 2 times.
Digit 1 appears 1 times.
Digit 2 appears 1 times.
Digit 5 appears 1 times.
```

---

### Input

```text
0
```

### Output

```text
Digit 0 appears 1 times.
```

---

## Solution Approach

1. Convert the number to its absolute value.
2. Create an array of size 10 to store the frequency of each digit.
3. Extract digits using the modulus operator (`%`).
4. Increment the corresponding array element.
5. Remove the last digit using integer division (`/`).
6. Repeat until all digits have been processed.

A `do...while` loop is used to ensure that the number `0` is processed correctly.

---

## Algorithm

```text
number = abs(number)

do
    digit = number % 10
    frequency[digit]++
    number /= 10
while number != 0
```

---

## Complexity

- **Time Complexity:** `O(d)`
- **Space Complexity:** `O(1)`

Where `d` is the number of digits in the input number.

The frequency array always contains exactly 10 elements.

---

## Project Structure

| Method | Responsibility |
|---------|----------------|
| `AskForNumber()` | Reads and validates user input. |
| `CalculateDigitFrequency()` | Calculates the frequency of each digit. |
| `PrintDigitFrequency()` | Displays the frequency table. |

---

## Concepts Used

- Arrays
- Methods
- Loops (`do...while`)
- Arithmetic operators (`%`, `/`)
- Input validation
- Integer manipulation

---

## Future Improvements

- Display digits sorted by frequency.
- Return the most and least frequent digits.
- Add unit tests.