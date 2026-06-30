# Prime Numbers in a Range

## Problem

Write a C# program that reads a valid range from the user and prints all prime numbers within that range.

---

## Example

### Input

```text
Enter the starting number: 10
Enter the ending number: 50
```

### Output

```text
Prime numbers in the range:
11
13
17
19
23
29
31
37
41
43
47
```

---

## Features

- Validates user input.
- Finds all prime numbers within a specified range.
- Uses the **6k ± 1** optimization for faster primality testing.
- Separates input, processing, and output into independent methods.
- Stores the generated prime numbers in a `List<int>` for future reuse.

---

## Concepts Used

- Methods
- Tuples
- Lists
- Input Validation
- Loops
- Prime Number Algorithms
- Big O Analysis
- Clean Code
- Separation of Concerns

---

## Solution Structure

| Method | Responsibility |
|---------|----------------|
| `GetValidRange()` | Validates the user's input. |
| `AskUserForRange()` | Handles user interaction. |
| `IsPrime()` | Determines whether a number is prime using the **6k ± 1** optimization. |
| `FindPrimesInRange()` | Collects all prime numbers in the specified range. |
| `PrintPrimes()` | Prints the generated prime numbers. |

---

## Prime Checking Algorithm

The solution uses the **6k ± 1 optimization**.

Instead of testing every integer up to √n, it skips numbers that cannot be prime.

The algorithm works as follows:

1. Reject numbers less than or equal to 1.
2. Accept 2 and 3.
3. Reject multiples of 2 or 3.
4. Test only numbers of the form **6k − 1** and **6k + 1** up to √n.

This significantly reduces the number of divisibility checks while maintaining the same asymptotic complexity.

---

## Complexity

### IsPrime()

- **Time:** `O(√n)`
- **Space:** `O(1)`

### FindPrimesInRange()

For a range containing **N** numbers:

- **Time:** `O(N × √M)`

Where **M** is the largest number in the range.

- **Space:** `O(P)`

Where **P** is the number of prime numbers found.

---

## Engineering Notes

- Followed the **Single Responsibility Principle (SRP)** by separating validation, prime checking, searching, and printing.
- Used named tuples to improve readability.
- Returned a `List<int>` to make the result reusable by future features.
- Accepted `IEnumerable<int>` in `PrintPrimes()` to reduce coupling.
- Improved the prime-checking algorithm using the **6k ± 1** optimization.

---

## Possible Improvements

- Allow multiple searches without restarting the application.
- Export prime numbers to a file.
- Add console colors for better readability.
- Compare the performance of different prime-checking algorithms.
- Implement the **Sieve of Eratosthenes** for generating all primes up to a large upper bound.