# Digit Frequency Analyzer

## Overview

A C# console application that analyzes the digits of an integer using arithmetic operations only.

The application provides an interactive menu that allows the user to:

- Calculate the frequency of each digit.
- Display the unique digits contained in the number.

The solution supports positive numbers, negative numbers, and zero without converting the number to a string.

---

## Features

- Interactive menu-driven interface
- Input validation
- Supports positive and negative integers
- Correctly handles zero
- Calculates digit frequencies
- Displays unique digits
- Modular and reusable methods

---

## Menu

```text
1. Calculate Digit Frequency
2. Show Digits
3. Exit
```

---

## Example

### Input

```text
Enter a number:
-120023
```

### Option 1 – Calculate Digit Frequency

```text
Digit 0 appears 2 times.
Digit 1 appears 1 times.
Digit 2 appears 2 times.
Digit 3 appears 1 times.
```

### Option 2 – Show Digits

```text
Digits in the number:
0, 1, 2, 3
```

---

## Solution Approach

### Calculate Digit Frequency

1. Convert the number to its absolute value.
2. Create an array of size 10 to store digit frequencies.
3. Extract each digit using the modulus operator (`%`).
4. Increment the corresponding frequency.
5. Remove the last digit using integer division (`/`).
6. Repeat until all digits have been processed.

A `do...while` loop is used so that the value `0` is handled correctly.

### Display Unique Digits

Iterate through the frequency array and collect every digit whose frequency is greater than zero.

---

## Algorithm

```text
Read number

number = abs(number)

frequency[10] = {0}

do
    digit = number % 10
    frequency[digit]++
    number /= 10
while number != 0

For each digit from 0 to 9
    if frequency[digit] > 0
        output digit
```

---

## Complexity

### CalculateDigitFrequency()

- **Time Complexity:** `O(d)`
- **Space Complexity:** `O(1)`

Where `d` is the number of digits.

### GetUniqueDigits()

- **Time Complexity:** `O(10)` → `O(1)`
- **Space Complexity:** `O(1)`

The frequency array always contains exactly 10 elements.

---

## Project Structure

| Method | Responsibility |
|---------|----------------|
| `AskForNumber()` | Reads and validates user input |
| `CalculateDigitFrequency()` | Calculates the frequency of each digit |
| `PrintDigitFrequency()` | Displays digit frequencies |
| `GetUniqueDigits()` | Returns the distinct digits found in the number |
| `ShowDigits()` | Displays the unique digits |
| `GetMenuChoice()` | Reads and validates the selected menu option |
| `HandleMenuChoice()` | Executes the selected operation |

---

## Concepts Used

- Arrays
- Lists
- Enums
- Methods
- Input validation
- Arithmetic operators (`%`, `/`)
- Menu-driven console applications
- Modular programming
- Time complexity analysis

---

## Future Improvements

- Display the most frequent digit.
- Display the least frequent digit.
- Count even and odd digits.
- Display digits sorted by frequency.
- Generate a histogram of digit frequencies.
- Add unit tests.