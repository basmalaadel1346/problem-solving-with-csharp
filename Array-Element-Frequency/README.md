# Frequency of a Number in an Array

## Problem

Write a C# console application that reads an array of integers from the user, then reads another number and determines how many times that number appears in the array.

---

## Example

### Input

```text
Enter the number of elements:
6

Enter number 1:
5

Enter number 2:
3

Enter number 3:
5

Enter number 4:
7

Enter number 5:
5

Enter number 6:
9

Enter the number to check:
5
```

### Output

```text
The frequency of 5 is 3.
```

---

## Features

- Validates user input.
- Reads an array of integers.
- Searches for a specific number.
- Counts the number of occurrences.
- Separates input, processing, and output into independent methods.

---

## Concepts Used

- Methods
- Arrays
- Loops
- Input Validation
- Linear Search
- Clean Code
- Separation of Concerns

---

## Solution Structure

| Method | Responsibility |
|---------|----------------|
| `ReadNumber()` | Reads and validates a positive integer. |
| `NumberOfElements()` | Reads the array size. |
| `StoreElements()` | Reads and stores array elements. |
| `NumberToCheck()` | Reads the target number. |
| `CalculateFrequency()` | Counts the occurrences of the target number. |
| `ShowFrequencyOfNumber()` | Displays the result. |

---

## Frequency Counting Algorithm

The algorithm works as follows:

1. Read the array size.
2. Store all elements in an array.
3. Read the target number.
4. Traverse the array once.
5. Increment the counter whenever the target number is found.
6. Display the total frequency.

---

## Complexity

### CalculateFrequency()

**Time:** `O(n)`

**Space:** `O(1)`

Where **n** is the number of elements.

### Overall Program

**Time:** `O(n)`

**Space:** `O(n)`

---

## Engineering Notes

- Followed the **Single Responsibility Principle (SRP)** by separating validation, input, processing, and output.
- Reused the `ReadNumber()` method to eliminate duplicated validation logic.
- Used a linear scan, which is the optimal solution when searching for the frequency of a single value.
- Stored user input in an array for efficient traversal.