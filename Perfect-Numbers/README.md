# Perfect Number Checker

## Problem

Build a C# console application that checks whether a number is a **Perfect Number** or finds all perfect numbers within a specified range.

A **Perfect Number** is a positive integer equal to the sum of its proper divisors (excluding the number itself).

---

## Features

- Check whether a single number is perfect.
- Find all perfect numbers within a user-defined range.
- Interactive console menu.
- Robust input validation.
- Efficient divisor search using the square root optimization (`O(√n)`).
- Clean separation between input, business logic, and presentation.

---

## Menu

```text
1. Check if a number is perfect
2. Find all perfect numbers in a range
3. Exit
```

---

## Example

### Single Number

```text
Choose an option:
1

Enter a positive integer: 28

Is 28 a Perfect number? : True
```

### Range

```text
Choose an option:
2

Start: 1
End: 1000

Perfect numbers:
6
28
496
```

---

## Solution Structure

| Method | Responsibility |
|---------|----------------|
| `ShowMenu()` | Displays the application menu. |
| `HandleMenuChoice()` | Executes the selected menu option. |
| `AskUserForNumber()` | Reads and validates a positive integer. |
| `AskUserForRange()` | Reads and validates a numeric range. |
| `IsDivisor()` | Checks whether a number divides another exactly. |
| `FindAllDivisors()` | Finds all proper divisors using √n optimization. |
| `SumOfDivisors()` | Calculates the sum of all divisors. |
| `IsPerfectNumber()` | Determines whether a number is perfect. |
| `FindAllPerfectNumbersInRange()` | Finds all perfect numbers within a range. |
| `PrintPerfectNumberCheck()` | Displays the result for a single number. |
| `PrintPerfectNumbersInRange()` | Displays all perfect numbers in the range. |

---

## Algorithm

### Checking a Perfect Number

1. Find all proper divisors.
2. Sum the divisors.
3. Compare the sum with the original number.

To improve performance, divisor searching iterates only up to **√n**. Whenever a divisor is found, its paired divisor (`n / i`) is also considered.

---

## Complexity

### FindAllDivisors()

- **Time:** `O(√n)`
- **Space:** `O(d)`

Where `d` is the number of proper divisors.

### IsPerfectNumber()

- **Time:** `O(√n)`
- **Space:** `O(d)`

### FindAllPerfectNumbersInRange()

If the range contains **N** numbers:

- **Time:** `O(N × √M)`

Where `M` is the largest number in the range.

- **Space:** `O(d)`

---

## Concepts Used

- Methods
- Enums
- Lists
- IEnumerable
- LINQ (`Sum`)
- Tuples
- Input Validation
- Square Root Optimization
- Clean Code
- Separation of Concerns

---

## Future Improvements

- Sort divisors before displaying them.
- Display the divisors of each perfect number.
- Support repeated execution without restarting the application.
- Export results to a text file.
- Add unit tests.