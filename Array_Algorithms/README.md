# C# Array Algorithms

A collection of fundamental array algorithms implemented in **C#**. This project focuses on strengthening problem-solving skills, writing clean code, and practicing reusable algorithm implementations without relying on built-in LINQ methods.

## Features

### Input & Utility
- Read validated integer input
- Generate random arrays within a specified range
- Generic operation display helper
- Array display formatting

### Array Operations
- Copy an array
- Reverse an array (new array)
- Reverse an array in-place
- Zip two arrays (element-wise sum)
- Find distinct elements

### Searching
- Linear Search (Find Index)

### Mathematical Operations
- Find minimum and maximum
- Calculate sum
- Calculate average
- Absolute value
- Absolute values of an entire array

### Number Classification
- Separate odd and even numbers
- Count:
  - Odd numbers
  - Even numbers
  - Positive numbers
  - Negative numbers
- Prime number detection
- Find all prime numbers
- Palindrome check

## Concepts Practiced

- Arrays
- IReadOnlyList<T>
- IReadOnlyCollection<T>
- Tuples
- Generic Methods
- HashSet<T>
- List<T>
- Helper Methods
- Method Reusability
- DRY (Don't Repeat Yourself)
- Time & Space Complexity Analysis
- Single-pass Algorithms
- Defensive Programming
- Input Validation

## Time Complexity

| Algorithm | Time | Space |
|-----------|------|-------|
| Find Min/Max | O(n) | O(1) |
| Calculate Sum | O(n) | O(1) |
| Copy Array | O(n) | O(n) |
| Reverse Array | O(n) | O(n) |
| Reverse In Place | O(n) | O(1) |
| Find Distinct | O(n) | O(n) |
| Find Primes | O(n√m) | O(k) |
| Find Odd/Even Numbers | O(n) | O(n) |
| Get Number Statistics | O(n) | O(1) |
| Find Absolute Values | O(n) | O(n) |
| Linear Search | O(n) | O(1) |
| Zip Two Arrays | O(n) | O(n) |
| Palindrome Check | O(n) | O(1) |

> *m = maximum value in the array, k = number of prime numbers.*

## Learning Objectives

This project was built to practice:

- Writing reusable algorithms
- Improving code readability
- Reducing duplication using helper methods
- Understanding algorithm complexity
- Designing methods using read-only interfaces
- Building a solid foundation before studying LINQ and advanced .NET topics

## Technologies

- C#
- .NET
- Console Application

## Future Improvements

- Sorting Algorithms
  - Bubble Sort
  - Selection Sort
  - Insertion Sort
- Binary Search
- Array Rotation
- Frequency Counting
- Merge Arrays
- Split Arrays
- Refactor into multiple classes:
  - ArrayAlgorithms
  - NumberAlgorithms
  - ConsoleHelper