# Digit Analyzer

## Overview

A C# console application that performs multiple digit-based analyses on an integer using arithmetic operations only.

The application provides an interactive menu where users can:

- Calculate the frequency of each digit.
- Display the unique digits in a number.
- Check whether a number is a palindrome.

The implementation avoids converting numbers to strings and demonstrates modular programming with reusable methods.

---

## Features

- Interactive menu-driven interface
- Input validation
- Supports positive and negative integers
- Correctly handles zero
- Calculate digit frequencies
- Display unique digits
- Check if a number is a palindrome
- Modular and reusable design

---

## Menu

```text
1. Calculate Digit Frequency
2. Show Digits
3. Check Palindrome
4. Exit
```

---

## Example

### Input

```text
Enter a number:
12233321
```

### Option 1

```text
Digit 1 appears 2 times.
Digit 2 appears 3 times.
Digit 3 appears 3 times.
```

### Option 2

```text
Digits in the number:
1, 2, 3
```

### Option 3

```text
The number is a palindrome.
```

---

## Solution Approach

### Digit Frequency

- Convert the number to its absolute value.
- Extract digits using `% 10`.
- Store occurrences in an array of size 10.
- Continue until all digits are processed.

### Unique Digits

- Iterate through the frequency array.
- Return every digit whose frequency is greater than zero.

### Palindrome Check

- Extract all digits into a collection.
- Compare symmetric elements from both ends.
- If every pair matches, the number is a palindrome.

---

## Algorithms

### Calculate Digit Frequency

```text
number = abs(number)

do
    digit = number % 10
    frequency[digit]++
    number /= 10
while number != 0
```

### Check Palindrome

```text
Extract all digits

left = 0
right = last index

while left < right
    if digits[left] != digits[right]
        return false

    left++
    right--

return true
```

---

## Complexity

| Operation | Time | Space |
|-----------|------|-------|
| Calculate Digit Frequency | O(d) | O(1) |
| Get Unique Digits | O(10) → O(1) | O(1) |
| Check Palindrome | O(d) | O(d) |

Where **d** is the number of digits.

---

## Project Structure

| Method | Responsibility |
|---------|----------------|
| `AskForNumber()` | Reads and validates user input |
| `CalculateDigitFrequency()` | Calculates digit frequencies |
| `PrintDigitFrequency()` | Displays digit frequencies |
| `GetUniqueDigits()` | Returns the distinct digits in the number |
| `GetAllDigits()` | Extracts all digits from the number |
| `IsNumberPalindrome()` | Determines whether a number is a palindrome |
| `ShowPalindromeResult()` | Displays the palindrome result |
| `ShowDigits()` | Displays the unique digits |
| `GetMenuChoice()` | Reads and validates the selected menu option |
| `HandleMenuChoice()` | Executes the selected operation |

---

## Concepts Used

- Arrays
- Lists
- Enums
- Methods
- Loops
- Input validation
- Arithmetic operators (`%`, `/`)
- Menu-driven console applications
- Palindrome algorithm
- Modular programming
- Time complexity analysis

---

## Future Improvements

- Display the most frequent digit.
- Display the least frequent digit.
- Count even and odd digits.
- Find the largest and smallest digit.
- Calculate the sum of digits.
- Add unit tests.