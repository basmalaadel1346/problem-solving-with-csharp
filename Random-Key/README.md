# Random Key Generator

A C# console application that generates random keys in customizable formats.

## Features

- Generate one or more keys
- Numeric keys
- Lowercase alphabetic keys
- Uppercase alphabetic keys
- Configurable number of parts
- Configurable part length
- Efficient string generation using StringBuilder

## Example

ABCD-EFGH-IJKL-MNOP

5821-9044-1132-8765

abcd-qwer-zxcv-asdf

## Complexity

| Method | Time | Space |
|--------|------|-------|
| MakeWord | O(length) | O(length) |
| MakeKey | O(parts × length) | O(parts × length) |
| MakeKeys | O(count × parts × length) | O(count × parts × length) |