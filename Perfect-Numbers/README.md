# Perfect Number Checker

## Problem

Write a C# program that reads a positive integer from the user and determines whether it is a **Perfect Number**.

A **Perfect Number** is a positive integer that is equal to the sum of all of its **proper divisors** (excluding the number itself).

---

## Example

### Input

```text
28
```

### Output

```text
Is 28 a Perfect number? : True
```

---

## Features

- Validates user input.
- Efficiently finds all proper divisors using the square root optimization.
- Calculates the sum of all proper divisors.
- Determines whether the number is perfect.
- Separates validation, divisor calculation, summation, and output into independent methods.

---

## Concepts Used

- Methods
- Lists
- IEnumerable
- Input Validation
- Mathematical Algorithms
- Square Root Optimization
- LINQ (`Sum`)
- Clean Code
- Separation of Concerns

---

## Solution Structure

| Method | Responsibility |
|---------|----------------|
| `AskUserForNumber()` | Reads and validates user input. |
| `IsDivisor()` | Checks whether a number is divisible by another. |
| `FindAllDivisors()` | Finds all proper divisors using the √n optimization. |
| `SumOfDivisors()` | Calculates the sum of all divisors. |
| `IsPerfectNumber()` | Determines whether the number is perfect. |
| `PrintPerfectNumberCheck()` | Displays the result to the user. |

---

## Algorithm

To find all proper divisors:

1. Iterate from **1** to **√n**.
2. If `i` divides the number:
   - Add `i`.
   - Compute the paired divisor `number / i`.
   - Add the paired divisor if:
     - it is different from `i`
     - it is not the number itself.
3. Sum all collected divisors.
4. Compare the sum with the original number.

---

## Complexity

### FindAllDivisors()

- **Time:** `O(√n)`
- **Space:** `O(d)`

Where **d** is the number of proper divisors.

### SumOfDivisors()

- **Time:** `O(d)`
- **Space:** `O(1)`

### Overall

- **Time:** `O(√n)`
- **Space:** `O(d)`

---

## Engineering Notes

- Used the **square root optimization** to reduce unnecessary divisor checks.
- Stored the divisors in a `List<int>` to make them reusable by other methods.
- Accepted `IEnumerable<int>` in `SumOfDivisors()` to reduce coupling.
- Followed the **Single Responsibility Principle (SRP)** by separating validation, divisor generation, summation, business logic, and presentation.

---

## Possible Improvements

- Display all divisors before printing the result.
- Support checking multiple numbers in a single execution.
- Benchmark different divisor-finding algorithms.
- Add unit tests for edge cases.

## How to Run
- Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
- Clone the repository and run `dotnet run` in the project directory.