# Caesar Cipher

## Problem

Write a C# console application that encrypts and decrypts text using the **Caesar Cipher** algorithm.

The application reads a text from the user, encrypts it using a fixed shift key, then decrypts it back to its original form.

---

## Example

### Input

```text
Enter the text to encrypt:
Hello World
```

### Output

```text
Encrypted text: Khoor#Zruog
Decrypted text: Hello World
```

> **Note:** The Caesar Cipher shifts every character, including spaces and symbols.

---

## Features

- Reads text from the user.
- Encrypts text using a fixed shift key.
- Decrypts the encrypted text back to the original.
- Separates encryption logic from user interaction.
- Reuses the same shifting algorithm for both encryption and decryption.

---

## Concepts Used

- Methods
- Character Arrays
- Strings
- Type Casting
- Loops
- Caesar Cipher
- Code Reusability
- Clean Code
- Separation of Concerns

---

## Solution Structure

| Method | Responsibility |
|---------|----------------|
| `ReadText()` | Reads the input text from the user. |
| `ShiftText()` | Shifts each character by a specified value. |
| `EncryptText()` | Encrypts the text using a positive shift. |
| `DecryptText()` | Decrypts the text using a negative shift. |

---

## Caesar Cipher Algorithm

The Caesar Cipher encrypts text by shifting every character by a fixed number of positions.

The algorithm works as follows:

1. Read the input text.
2. Convert the string into a character array.
3. Shift each character by the encryption key.
4. Convert the modified character array back into a string.
5. To decrypt, apply the same algorithm using the negative shift value.

---

## Complexity

### ShiftText()

**Time:** `O(n)`

**Space:** `O(n)`

Where **n** is the length of the input text.

### EncryptText()

**Time:** `O(n)`

**Space:** `O(n)`

### DecryptText()

**Time:** `O(n)`

**Space:** `O(n)`

---

## Engineering Notes

- Followed the **Single Responsibility Principle (SRP)** by separating input handling, encryption, and decryption.
- Eliminated duplicated logic by implementing a reusable `ShiftText()` method.
- Used a `char[]` to efficiently modify characters before creating the final string.
- Kept `ShiftText()` private since it is an internal implementation detail.
- Used a constant encryption key to simplify the demonstration of the Caesar Cipher algorithm.