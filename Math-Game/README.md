# 🧮 Math Game (C# Console Application)

A simple console-based Math Quiz Game built with **C#** to practice problem-solving, OOP fundamentals, enums, collections, input validation, and clean code organization.

Players can choose the number of questions, difficulty level, and mathematical operation, then receive a detailed summary at the end of each round.

---

## Features

- Multiple difficulty levels
  - Easy
  - Medium
  - Hard
  - Mixed

- Mathematical operations
  - Addition
  - Subtraction
  - Multiplication
  - Division
  - Mixed operations

- Robust input validation
  - Integer validation
  - Positive number validation
  - Enum validation

- Automatic question generation

- Division questions always produce integer answers for a better gameplay experience.

- End-of-round summary including:
  - Total questions
  - Correct answers
  - Wrong answers
  - Pass/Fail result
  - Detailed review of every question

- Unlimited rounds until the player exits.

---

## Project Structure

```
MathGame
│
├── DifficultyLevel
├── MathOperation
├── QuizQuestion
├── QuizRound
├── InputHelper
└── Program
```

### Main Components

#### QuizQuestion

Represents a single math question.

Stores:

- Operands
- Operation
- Correct Answer
- Player Answer
- Result

---

#### QuizRound

Represents one complete game round.

Tracks:

- Round number
- Total questions
- Correct answers
- Wrong answers
- Question history
- Pass/Fail status

---

#### InputHelper

Handles all console input validation.

Responsibilities:

- Reading integers
- Reading positive integers
- Reading enum values
- Displaying validation messages

---

#### Program

Contains the game logic:

- Random question generation
- Answer calculation
- Game loop
- Round summary
- User interaction

---

## Concepts Practiced

- Object-Oriented Programming (OOP)
- Enums
- Classes
- Properties
- Collections (`List<T>`)
- Tuples
- Switch Expressions
- Input Validation
- Clean Code
- Separation of Responsibilities
- Random Number Generation
- Console Applications

---

## Example

```
*** Starting Round 1 ***

How many questions would you like to answer?
5

Choose difficulty:
1. Easy
2. Medium
3. Hard
4. Mix

Choose operation:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Mix

Question 1

15 + 8 = 23

Correct!
```

---

## Round Summary

```
Round 1 Summary

Total Questions : 5
Right Answers   : 4
Wrong Answers   : 1

Questions Detail:

Question 1 ✔
Question 2 ✔
Question 3 ✘
Question 4 ✔
Question 5 ✔

Result:
You Passed!
```

---

## Technologies

- C#
- .NET
- Console Application

---

## Learning Objectives

This project focuses on writing clean, maintainable code without introducing unnecessary architectural complexity.

It demonstrates how to organize a small console application using basic OOP principles while keeping the implementation simple and readable.

---
