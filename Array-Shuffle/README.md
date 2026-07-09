# Array Shuffle

A C# console application that generates an array of sequential integers within a user-defined range and randomly shuffles its elements using the **Fisher–Yates Shuffle Algorithm**.

This project demonstrates clean code practices, modular programming, input validation, random number generation, and an efficient in-place array shuffling algorithm.

---

## Features

- Generate an array from a user-defined range.
- Validate numeric user input.
- Automatically handle reversed ranges.
- Shuffle the array using the Fisher–Yates algorithm.
- Display both the original and shuffled arrays.
- Swap elements using pass-by-reference (`ref`).
- Clean, modular, and reusable methods.

---

## Technologies

- C#
- .NET Console Application

---

## Example

```text
Welcome to the Array Shuffle Program!

Enter the start of the range:
1

Enter the end of the range:
10

Original array:
1, 2, 3, 4, 5, 6, 7, 8, 9, 10

Shuffled array:
4, 8, 2, 1, 10, 5, 9, 3, 6, 7
```

---

## Project Structure

```text
Program.cs
├── InvalidInputMessage()
├── ReadNumber()
├── ReadRange()
├── GenerateArray()
├── Swap()
├── GenerateRandomNumber()
├── ShuffleArray()
├── Run()
└── Main()
```

---

## How It Works

1. Read the start and end values of the range.
2. Generate a sequential array containing every integer in the range.
3. Iterate from the last element toward the first.
4. Select a random index between `0` and the current position.
5. Swap the two elements.
6. Display the shuffled array.

The implementation uses the **Fisher–Yates Shuffle**, which produces a uniformly random permutation in linear time.

---

## Complexity

| Operation | Time Complexity | Space Complexity |
|-----------|----------------:|-----------------:|
| Generate Array | O(n) | O(n) |
| Shuffle Array | O(n) | O(1) |
| Display Array | O(n) | O(1) |

---

## Concepts Practiced

- Arrays
- Methods
- Tuples
- Random Number Generation
- Fisher–Yates Shuffle Algorithm
- Pass by Reference (`ref`)
- Input Validation
- Loops
- Clean Code
- Algorithm Design

---

## Learning Objectives

This project was built to practice:

- Building arrays dynamically.
- Working with user input.
- Implementing an efficient shuffle algorithm.
- Separating responsibilities into reusable methods.
- Writing readable and maintainable C# code.

---
