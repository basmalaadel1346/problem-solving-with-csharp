# Fill Array With Random Numbers

A C# console application that generates an array of random integers within a user-defined range and performs multiple analysis operations including finding minimum and maximum values, calculating sum and average, copying arrays, and extracting prime numbers.

## Features

- Generates an array of random integers.
- Allows the user to define:
  - Number of elements.
  - Minimum and maximum range values.
- Validates user input.
- Automatically handles reversed ranges.
- Displays generated numbers.
- Finds minimum and maximum values.
- Calculates:
  - Sum of all numbers.
  - Average value.
- Creates a copy of the generated array.
- Extracts prime numbers from the array.
- Uses the 6k ± 1 optimization for prime checking.

---

## Example

### Input

```
Please enter number of elements
10

Please enter minimum value for range
1

Please enter max value for range
50
```

### Output

```
Random Numbers:

                            7                            20                            11                            35                            2
                           18                            41                            9                            15                            29

Min : 2 and Max : 41

Sum : 187

Average : 18.7

Copy of Random Numbers:

                            7                            20                            11                            35                            2
                           18                            41                            9                            15                            29

Prime Numbers:

                            7                            11                            2                            41                            29
```

---

# Solution Structure

| Method | Responsibility |
|---|---|
| `ReadNumber()` | Validates and reads integer input. |
| `NumberOfElements()` | Gets valid array size from the user. |
| `ReadRange()` | Reads and validates the random number range. |
| `GenerateRandomNumbers()` | Creates an array containing random integers. |
| `FindMinAndMax()` | Finds minimum and maximum values using one traversal. |
| `CalculateSum()` | Calculates the total sum of array elements. |
| `CalculateAverage()` | Calculates the average value. |
| `CopyArray()` | Creates an independent copy of the array. |
| `IsPrime()` | Checks whether a number is prime using optimized algorithm. |
| `FindPrimes()` | Extracts all prime numbers from the array. |
| `ShowArray()` | Displays any collection of integers. |

---

# Prime Checking Algorithm

The solution uses the **6k ± 1 optimization**.

Instead of checking every number up to `√n`, it eliminates unnecessary divisibility checks.

Algorithm steps:

1. Reject numbers less than or equal to 1.
2. Accept 2 and 3.
3. Reject multiples of 2 and 3.
4. Test only numbers in the form:

```
6k - 1
6k + 1
```

until reaching `√n`.

This reduces the number of checks while keeping the same asymptotic complexity.

---

# Complexity Analysis

Let:

- `n` = number of elements in the array.
- `k` = number of prime numbers found.
- `m` = largest value in the array.

| Operation | Time Complexity | Space Complexity |
|---|---:|---:|
| Generate Random Numbers | O(n) | O(n) |
| Find Min & Max | O(n) | O(1) |
| Calculate Sum | O(n) | O(1) |
| Calculate Average | O(1) | O(1) |
| Copy Array | O(n) | O(n) |
| Prime Checking (`IsPrime`) | O(√m) | O(1) |
| Find Primes | O(n × √m) | O(k) |

---

# Concepts Practiced

- Arrays
- Lists
- Tuples
- Methods
- Loops
- Input Validation
- Random Number Generation
- Linear Traversal
- Collections
- Generic Methods
- IEnumerable
- Prime Number Algorithms
- Big O Analysis
- Clean Code
- Separation of Responsibilities

---

# Engineering Notes

- Used a single traversal approach for finding minimum and maximum values.
- Used `List<int>` for dynamically collecting prime numbers.
- Used `IEnumerable<int>` in `ShowArray()` to reduce coupling and support different collection types.
- Applied the Single Responsibility Principle by separating input, processing, and output operations.
- Avoided unnecessary array allocations when extracting prime numbers.
- Improved prime checking performance using the 6k ± 1 optimization.

---

## Technologies

- C#
- .NET Console Application