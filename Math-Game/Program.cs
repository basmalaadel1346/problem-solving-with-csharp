using System;
using System.Collections.Generic;

namespace MathGame
{
    public enum DifficultyLevel
    {
        Easy = 1,
        Medium = 2,
        Hard = 3,
        Mix = 4
    }

    public enum MathOperation
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4,
        Mix = 5
    }

    public class QuizQuestion
    {
        public int FirstOperand { get; set; }
        public int SecondOperand { get; set; }
        public MathOperation OperationType { get; set; }
        public int CorrectAnswer { get; set; } // أصبحت int لأنه لم يعد هناك كسور
        public int PlayerAnswer { get; set; }  // أصبحت int
        public bool IsCorrect { get; set; }
    }

    public class QuizRound
    {
        public int RoundNumber { get; set; }
        public int TotalQuestionsCount { get; set; }
        public int CorrectAnswersCount { get; set; }
        public int WrongAnswersCount { get; set; }
        public List<QuizQuestion> QuestionsList { get; set; } = new List<QuizQuestion>();
        public bool IsPassed => CorrectAnswersCount >= WrongAnswersCount;
    }

    public static class InputHelper
    {
        public static void ShowInvalidInputError() => Console.WriteLine("Invalid input. Please try again.");

        public static int PromptForValidInteger(string promptMessage)
        {
            while (true)
            {
                Console.Write(promptMessage);
                if (int.TryParse(Console.ReadLine(), out int validNumber))
                    return validNumber;

                ShowInvalidInputError();
            }
        }

        public static int PromptForPositiveInteger(string promptMessage)
        {
            while (true)
            {
                int validNumber = PromptForValidInteger(promptMessage);
                if (validNumber > 0)
                    return validNumber;

                ShowInvalidInputError();
            }
        }

        public static T PromptForValidEnum<T>(string promptMessage) where T : struct, Enum
        {
            while (true)
            {
                Console.WriteLine(promptMessage);
                if (Enum.TryParse<T>(Console.ReadLine(), true, out T parsedEnum) && Enum.IsDefined(typeof(T), parsedEnum))
                {
                    return parsedEnum;
                }
                ShowInvalidInputError();
            }
        }
    }

    internal class Program
    {
        private readonly static Random _randomGenerator = new Random();

        public static int CalculateCorrectAnswer(MathOperation operation, int firstOperand, int secondOperand)
        {
            return operation switch
            {
                MathOperation.Add => firstOperand + secondOperand,
                MathOperation.Subtract => firstOperand - secondOperand,
                MathOperation.Multiply => firstOperand * secondOperand,
                MathOperation.Divide => firstOperand / secondOperand, 
                _ => throw new ArgumentException("Unsupported math operation.")
            };
        }

        public static (int firstOperand, int secondOperand) GenerateRandomOperands(DifficultyLevel level, MathOperation actualOperation)
        {
            int maxLimit = level switch
            {
                DifficultyLevel.Easy => 20, 
                DifficultyLevel.Medium => 50,
                DifficultyLevel.Hard => 100,
                _ => 100 // Mix
            };

            if (actualOperation == MathOperation.Divide)
            {
                int second = _randomGenerator.Next(1, maxLimit+1);
                int answer = _randomGenerator.Next(1, maxLimit+1);
                int first = second * answer;
                return (first, second);
            }

            return (_randomGenerator.Next(1, maxLimit + 1), _randomGenerator.Next(1, maxLimit + 1));
        }

        public static MathOperation GenerateRandomOperation() => (MathOperation)_randomGenerator.Next(1, 5);

        public static void DisplayWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("        Welcome to the Math Game!       ");
            Console.WriteLine("========================================");
        }

        public static string GetOperationSymbol(MathOperation operation)
        {
            return operation switch
            {
                MathOperation.Add => "+",
                MathOperation.Subtract => "-",
                MathOperation.Multiply => "*",
                MathOperation.Divide => "/",
                _ => "?"
            };
        }

        public static void DisplayRoundSummary(QuizRound completedRound)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine($"          Round {completedRound.RoundNumber} Summary");
            Console.WriteLine("========================================");
            Console.WriteLine($"Total Questions : {completedRound.TotalQuestionsCount}");
            Console.WriteLine($"Right Answers   : {completedRound.CorrectAnswersCount}");
            Console.WriteLine($"Wrong Answers   : {completedRound.WrongAnswersCount}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Questions Detail:");
            for (int i = 0; i < completedRound.QuestionsList.Count; i++)
            {
                var q = completedRound.QuestionsList[i];
                string symbol = GetOperationSymbol(q.OperationType);
                string mark = q.IsCorrect ? "✔" : "✘";

                Console.Write($"Question {i + 1}: {q.FirstOperand} {symbol} {q.SecondOperand} = {q.PlayerAnswer} {mark}");

                if (!q.IsCorrect)
                    Console.Write($" (Correct was: {q.CorrectAnswer})");

                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------");

            if (completedRound.IsPassed)
                Console.WriteLine("Result: You Passed! Great Job!");
            else
                Console.WriteLine("Result: You Failed! Better luck next time.");

            Console.WriteLine("========================================\n");
        }

        public static void PlaySingleRound(int roundNumber)
        {
            QuizRound currentRound = new QuizRound
            {
                RoundNumber = roundNumber,
                TotalQuestionsCount = InputHelper.PromptForPositiveInteger("How many questions would you like to answer? ")
            };

            DifficultyLevel selectedDifficulty = InputHelper.PromptForValidEnum<DifficultyLevel>("Choose difficulty (1: Easy, 2: Medium, 3: Hard, 4: Mix):");
            MathOperation selectedOperationType = InputHelper.PromptForValidEnum<MathOperation>("Choose operation (1: Add, 2: Subtract, 3: Multiply, 4: Divide, 5: Mix):");

            for (int questionIndex = 1; questionIndex <= currentRound.TotalQuestionsCount; questionIndex++)
            {
                Console.WriteLine($"\n--- Question {questionIndex}/{currentRound.TotalQuestionsCount} ---");

                MathOperation actualQuestionOperation = selectedOperationType == MathOperation.Mix
                    ? GenerateRandomOperation()
                    : selectedOperationType;

                var (firstOperand, secondOperand) = GenerateRandomOperands(selectedDifficulty, actualQuestionOperation);

                QuizQuestion currentQuestion = new QuizQuestion
                {
                    FirstOperand = firstOperand,
                    SecondOperand = secondOperand,
                    OperationType = actualQuestionOperation,
                    CorrectAnswer = CalculateCorrectAnswer(actualQuestionOperation, firstOperand, secondOperand)
                };

                string mathExpression = $"{currentQuestion.FirstOperand} {GetOperationSymbol(currentQuestion.OperationType)} {currentQuestion.SecondOperand}";

                currentQuestion.PlayerAnswer = InputHelper.PromptForValidInteger($"What is {mathExpression} = ");

                currentQuestion.IsCorrect = (currentQuestion.PlayerAnswer == currentQuestion.CorrectAnswer);

                if (currentQuestion.IsCorrect)
                {
                    Console.WriteLine("Correct!");
                    currentRound.CorrectAnswersCount++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is: {currentQuestion.CorrectAnswer}");
                    currentRound.WrongAnswersCount++;
                }

                currentRound.QuestionsList.Add(currentQuestion);
            }

            DisplayRoundSummary(currentRound);
        }

        public static void StartGameLoop()
        {
            DisplayWelcomeMessage();
            int currentRoundNumber = 1;

            while (true)
            {
                Console.WriteLine($"\n*** Starting Round {currentRoundNumber} ***");
                PlaySingleRound(currentRoundNumber);

                Console.WriteLine("Would you like to play another round? (Press 1 for Yes, any other key for No): ");
                string playerChoice = Console.ReadLine();

                if (playerChoice != "1")
                {
                    Console.WriteLine("Thanks for playing! Goodbye.");
                    break;
                }

                currentRoundNumber++;
                Console.Clear();
            }
        }

        public static void Main(string[] args)
        {
            StartGameLoop();
        }
    }
}