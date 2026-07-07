# Random Array Generator

## Problem

Write a C# console application that generates an array of random integers within a user-defined range.

The program asks the user to:

- Enter the number of elements.
- Enter the minimum value.
- Enter the maximum value.

It then generates and displays the random numbers.

---

## Example

### Input

```text
Enter number of elements:
5

Enter minimum value for range:
10

Enter maximum value for range:
20
```

### Output

```text
13
20
11
18
15
```

> **Note:** The generated numbers are random, so the output will differ each time the program runs.

---

## Features

- Validates all numeric input.
- Accepts the range in any order and automatically normalizes it.
- Generates random integers within the specified inclusive range.
- Stores generated numbers in an array.
- Separates validation, generation, and output into independent methods.

---

## Concepts Used

- Methods
- Arrays
- Tuples
- Random Class
- Input Validation
- Loops
- Clean Code
- Separation of Concerns

---

## Solution Structure

| Method | Responsibility |
|---------|----------------|
| `ReadNumber()` | Reads and validates a non-negative integer. |
| `NumberOfElements()` | Reads the desired array size. |
| `ReadRange()` | Reads and normalizes the minimum and maximum values. |
| `GenerateRandomNumbers()` | Generates an array of random integers within the specified range. |
| `ShowRandomNumbers()` | Displays the generated numbers. |

---

## Random Number Generation Algorithm

The algorithm works as follows:

1. Read the number of elements.
2. Read the minimum and maximum values.
3. Normalize the range if the values are entered in reverse order.
4. Create an array of the requested size.
5. Generate a random number for each element.
6. Display all generated numbers.

---

## Complexity

### GenerateRandomNumbers()

**Time:** `O(n)`

**Space:** `O(n)`

### ShowRandomNumbers()

**Time:** `O(n)`

**Space:** `O(1)`

### Overall Program

**Time:** `O(n)`

**Space:** `O(n)`

Where **n** is the number of generated elements.

---

## Engineering Notes

- Followed the **Single Responsibility Principle (SRP)** by separating validation, range handling, random generation, and output.
- Used a single shared `Random` instance to avoid generating repeated random sequences.
- Used a named tuple to return the range values with improved readability.
- Generated numbers using an inclusive range by adjusting the upper bound when calling `Random.Next()`.
- Stored generated values in an array for efficient sequential access.