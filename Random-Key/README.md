# Random Key Generator

## Problem

Write a C# console application that generates one or more random keys based on the user's input.

The user chooses:
- The number of keys to generate.
- The type of characters used in the keys:
  - Numeric
  - Lowercase letters
  - Uppercase letters

Each generated key consists of **4 parts**, each containing **4 random characters**, separated by a hyphen (`-`).

---

## Example

### Input

```text
Enter the number of keys to generate:
3

Enter the key type (Numeric, AlphaSmall, AlphaCapital):
AlphaCapital
```

### Output

```text
--- Generated Keys ---

ABCD-EFGH-IJKL-MNOP
QWER-ASDF-ZXCV-TYUI
ZXCV-BNMQ-ASDF-QWER
```

---

## Features

- Validates user input.
- Generates one or multiple random keys.
- Supports multiple key types:
  - Numeric
  - Lowercase alphabetic
  - Uppercase alphabetic
- Uses `StringBuilder` for efficient string construction.
- Separates input, processing, and output into independent methods.

---

## Concepts Used

- Methods
- Enums
- Tuples
- StringBuilder
- Random
- Input Validation
- Loops
- Clean Code
- Separation of Concerns

---

## Solution Structure

| Method | Responsibility |
|---------|----------------|
| `GetBounds()` | Returns the valid character range for the selected key type. |
| `MakeWord()` | Generates a random sequence of characters. |
| `MakeKey()` | Creates a single formatted key. |
| `MakeKeys()` | Generates multiple keys. |
| `AskForNumOfKeys()` | Reads and validates the number of keys. |
| `AskForKeyType()` | Reads and validates the selected key type. |
| `WelcomeMessage()` | Displays the welcome message. |
| `ShowGeneratedKeys()` | Displays the generated keys. |

---

## Key Generation Algorithm

The application generates keys using the following steps:

1. Read and validate the user's input.
2. Determine the valid character range based on the selected `KeyType`.
3. Generate random characters to create each word.
4. Combine four words using the `-` separator to create a complete key.
5. Repeat the process until the requested number of keys has been generated.

---

## Complexity

### MakeWord()

**Time:** `O(L)`

**Space:** `O(L)`

Where **L** is the length of each word.

---

### MakeKey()

For a key containing **P** parts:

**Time:** `O(P × L)`

**Space:** `O(P × L)`

---

### MakeKeys()

For generating **N** keys:

**Time:** `O(N × P × L)`

**Space:** `O(N × P × L)`

Where:

- **N** = Number of keys
- **P** = Number of parts per key
- **L** = Length of each part

---

## Engineering Notes

- Followed the **Single Responsibility Principle (SRP)** by separating validation, key generation, and presentation.
- Used an **enum** to represent supported key types instead of magic values.
- Used **named tuples** to improve the readability of character bounds.
- Used **StringBuilder** to reduce unnecessary string allocations.
- Structured the application into reusable methods to improve readability and maintainability.