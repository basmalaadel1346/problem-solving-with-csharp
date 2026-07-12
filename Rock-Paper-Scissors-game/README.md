# 🪨 Rock Paper Scissors Game (C# Console Application)

A simple **Rock-Paper-Scissors** console game built with **C#** to practice fundamental programming concepts such as methods, enums, loops, input validation, and game logic.

## Features

- 🎮 Play against the computer
- 🔢 Choose the number of rounds
- 🎲 Random computer moves
- ✅ Input validation using `Enum.TryParse` and `int.TryParse`
- 🏆 Automatic score tracking
- 📊 Final match summary
- 🔄 Play multiple matches without restarting the application

## Game Rules

- **Rock** beats **Scissors**
- **Scissors** beats **Paper**
- **Paper** beats **Rock**
- Same choices result in a **Tie**

## Project Structure

| Method | Description |
|---------|-------------|
| `GetPlayerChoice()` | Reads and validates the player's choice. |
| `GetComputerChoice()` | Generates a random computer choice. |
| `DetermineWin()` | Determines the winner of a round. |
| `PlayRound()` | Plays a single round and returns the result. |
| `PlayMatch()` | Plays multiple rounds and keeps score. |
| `AskToPlayAgain()` | Asks whether the player wants another match. |
| `RunTheGame()` | Controls the overall game loop. |

## Concepts Practiced

- C#
- Console Applications
- Enums
- Methods
- Loops
- Conditional Statements
- Input Validation
- Random Number Generation
- Basic Game Design
- Separation of Responsibilities

## Sample Gameplay

```text
Welcome to Rock-Paper-Scissors!

How many rounds? 3

Round 1
Enter your choice (1: Rock, 2: Paper, 3: Scissors): 1
You chose Rock and the computer chose Scissors.
You win!

Round 2
...

Game Over
Final Score -> You: 2 | Computer: 1
Final Winner: Player (You)!

Play Again? Y/N:
```

## Learning Objectives

This project was created to practice:

- Designing small console applications
- Breaking problems into reusable methods
- Using enums instead of magic numbers
- Implementing game logic
- Building interactive console applications
- Writing clean and readable C# code
