# Password Brute Force

A C# console application that demonstrates a brute-force password search algorithm.

The program generates every possible three-letter uppercase password (`AAA` to `ZZZ`) using lazy evaluation (`yield return`) and compares each generated password with the user's input until a match is found.

## Features

- Brute-force password generation
- Lazy enumeration with `yield return`
- Input validation
- Attempt counter
- Memory-efficient implementation

## Technologies

- C#
- .NET
- IEnumerable
- yield return
- LINQ

## Example

Enter a password (exactly 3 English letters):

ABC

Password found successfully!

Password : ABC

Attempts : 29

## Complexity

| Operation | Complexity |
|-----------|------------|
| Time | O(26³) |
| Space | O(1) |

## Concepts Practiced

- Nested loops
- Lazy evaluation
- IEnumerable
- yield return
- Brute-force algorithms
- Input validation