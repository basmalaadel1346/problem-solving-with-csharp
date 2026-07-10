# CSharp-Array-Algorithms
A C# console application that generates random integer arrays based on user-defined input and demonstrates a variety of fundamental array algorithms and programming techniques.

The project covers array generation, searching, mathematical operations, copying, prime number detection, array merging, and different approaches to reversing arrays.

## Features

- Generate an array of random integers.
- User-defined array size.
- User-defined random number range.
- Automatic handling of reversed ranges (min/max).
- Robust input validation.
- Display arrays in a formatted layout.
- Find the minimum and maximum values.
- Calculate the sum of all elements.
- Calculate the average value.
- Create a deep copy of an array.
- Detect prime numbers using the optimized **6k ± 1** algorithm.
- Generate a second random array.
- Zip two arrays by summing corresponding elements.
- Reverse an array by creating a new reversed copy.
- Reverse an array in-place using the two-pointer swapping technique.
- Generic method for displaying calculated operations.

## Concepts Practiced

- Arrays
- Loops
- Methods
- Tuples
- Generic Methods
- `List<T>`
- `IEnumerable<T>`
- Input Validation
- Random Number Generation
- Algorithm Optimization
- Passing Parameters by Reference (`ref`)
- Time Complexity Basics

## Algorithms Used

| Operation | Time Complexity | Space Complexity |
|-----------|-----------------|------------------|
| Generate Random Array | O(n) | O(n) |
| Find Min & Max | O(n) | O(1) |
| Calculate Sum | O(n) | O(1) |
| Calculate Average | O(1) | O(1) |
| Copy Array | O(n) | O(n) |
| Find Prime Numbers | O(n√m) | O(k) |
| Zip Two Arrays | O(n) | O(n) |
| Reverse (New Array) | O(n) | O(n) |
| Reverse In Place | O(n) | O(1) |

> **n** = number of array elements  
> **m** = value being tested for primality  
> **k** = number of prime numbers found

## Example

```text
Please enter number of elements
5

Please enter minimum value for range
1

Please enter max value for range
10

Random Numbers:

         3         7         2         9         5

**************************************************

Min : 2 and Max : 9

Sum : 26

Average : 5.2

Copy of Random Numbers:

         3         7         2         9         5

**************************************************

Prime Numbers:

         3         7         2         5

**************************************************

Random Numbers 2:

         9         8         4         9         6

**************************************************

Zipped Array (Sum of Two Arrays):

        12        15         6        18        11

**************************************************

Reversed Array:

         5         9         2         7         3

**************************************************

Reversed Array In Place:

         5         9         2         7         3

**************************************************
```

## Project Structure

```
Program.cs
│
├── Input Validation
│   ├── ReadNumber()
│   ├── NumberOfElements()
│   └── ReadRange()
│
├── Array Generation
│   └── GenerateRandomNumbers()
│
├── Mathematical Operations
│   ├── FindMinAndMax()
│   ├── CalculateSum()
│   └── CalculateAverage()
│
├── Array Utilities
│   ├── CopyArray()
│   ├── ZipTwoArrays()
│   ├── ReverseArray()
│   ├── ReverseArrayInPlace()
│   └── Swap()
│
├── Prime Numbers
│   ├── IsPrime()
│   └── FindPrimes()
│
└── Display Helpers
    ├── ShowArray()
    ├── ShowOperation()
    └── ShowMinAndMax()
```

## Learning Objectives

This project demonstrates:

- Writing reusable methods
- Separating program logic into small functions
- Working with arrays and collections
- Implementing common array algorithms
- Using tuples for multiple return values
- Using generic methods
- Optimizing primality testing
- Understanding the difference between creating a new array and modifying an existing one
- Improving code readability and maintainability

## Technologies

- C#
- .NET Console Application
- Visual Studio