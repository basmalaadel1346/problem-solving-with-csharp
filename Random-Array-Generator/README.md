# Fill Array With Random Numbers

A C# console application that generates an array of random integers within a user-defined range, displays the generated values, and efficiently finds the minimum and maximum values using a single traversal.

## Features

- Generate an array of random integers.
- User-defined array size.
- User-defined random number range.
- Automatic normalization of reversed ranges.
- Input validation with re-prompting for invalid values.
- Display all generated numbers.
- Find the minimum and maximum values in a single pass.
- Clean separation between input, generation, processing, and output.

## Technologies

- C#
- .NET Console Application

## Example

```text
Please enter number of elements
10

Please enter minimum value for range
5

Please enter max value for range
20

17
8
5
12
20
9
16
6
14
11

Min : 5
Max : 20
```

> **Note:** The generated numbers are random, so the output will differ each time the program runs.

## Project Structure

```
Program.cs
├── InvalidMessage()
├── ReadNumber()
├── NumberOfElements()
├── ReadRange()
├── GenerateRandomNumbers()
├── ShowRandomNumbers()
├── FindMinAndMaxRandom()
├── ShowMinAndMaxRandom()
└── Main()
```

## Solution Overview

| Method | Responsibility |
|---------|----------------|
| `InvalidMessage()` | Displays an invalid input message. |
| `ReadNumber()` | Reads and validates a non-negative integer. |
| `NumberOfElements()` | Reads the desired array size. |
| `ReadRange()` | Reads and normalizes the minimum and maximum values. |
| `GenerateRandomNumbers()` | Generates random integers within the specified range. |
| `ShowRandomNumbers()` | Displays the generated numbers. |
| `FindMinAndMaxRandom()` | Finds the minimum and maximum values using a single traversal. |
| `ShowMinAndMaxRandom()` | Displays the minimum and maximum values. |

## Algorithm

### Random Number Generation

1. Read the number of elements.
2. Read the minimum and maximum values.
3. Normalize the range if entered in reverse order.
4. Generate random integers within the inclusive range.
5. Store the generated values in an array.

### Min/Max Search

1. Initialize both `min` and `max` with the first array element.
2. Traverse the array once.
3. Update `min` whenever a smaller value is found.
4. Update `max` whenever a larger value is found.
5. Return both values as a named tuple.

## Complexity

| Operation | Time Complexity | Space Complexity |
|----------|----------------:|-----------------:|
| Generate Random Numbers | **O(n)** | **O(n)** |
| Display Numbers | **O(n)** | **O(1)** |
| Find Min & Max | **O(n)** | **O(1)** |
| Overall Program | **O(n)** | **O(n)** |

Where **n** is the number of generated elements.

## Concepts Practiced

- Arrays
- Methods
- Loops
- Tuples
- Random Class
- Input Validation
- Linear Search
- Time Complexity Analysis
- Clean Code
- Separation of Concerns

## Engineering Notes

- Implemented a single shared `Random` instance to ensure efficient random number generation.
- Used named tuples to improve readability when returning multiple values.
- Found the minimum and maximum values in a single traversal for optimal **O(n)** time complexity.
- Organized the program into small, reusable methods following the **Single Responsibility Principle (SRP)**.
- Normalized the user-defined range to support input in any order.
```