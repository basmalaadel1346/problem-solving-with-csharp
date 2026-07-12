using System;

namespace Rock_Paper_Scissors_game
{
    internal class Program
    {
        private static readonly Random random = new Random();

        public enum Choice
        {
            Rock = 1,
            Paper,
            Scissors
        }

        public enum Status
        {
            Win,
            Lose,
            Tie
        }

        public static Choice GetComputerChoice()
        {
            int choice = random.Next(1, 4);
            return (Choice)choice;
        }

        public static Choice GetPlayerChoice()
        {
            while (true)
            {
                Console.Write("Enter your choice (1: Rock, 2: Paper, 3: Scissors): ");
                string input = Console.ReadLine();
                if (Enum.TryParse(input, true, out Choice playerChoice) && Enum.IsDefined(typeof(Choice), playerChoice))
                {
                    return playerChoice;
                }
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        public static Status DetermineWin(Choice playerChoice, Choice computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                return Status.Tie;
            }
            else if ((playerChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
                     (playerChoice == Choice.Paper && computerChoice == Choice.Rock) ||
                     (playerChoice == Choice.Scissors && computerChoice == Choice.Paper))
            {
                return Status.Win;
            }
            else
            {
                return Status.Lose;
            }
        }

        public static void ShowResultOfRound(Choice playerChoice, Choice computerChoice, Status roundResult)
        {
            if (roundResult == Status.Tie)
                Console.WriteLine($"Both players chose {playerChoice}. It's a tie!");
            else if (roundResult == Status.Win)
                Console.WriteLine($"You chose {playerChoice} and the computer chose {computerChoice}. You win!");
            else
                Console.WriteLine($"You chose {playerChoice} and the computer chose {computerChoice}. You lose!");

            Console.WriteLine();
        }

        public static int GetNumberOfRounds()
        {
            while (true)
            {
                Console.Write("How many rounds? ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int rounds) && rounds > 0)
                {
                    return rounds;
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number.\n");
            }
        }

        public static Status PlayRound()
        {
            Choice playerChoice = GetPlayerChoice();
            Choice computerChoice = GetComputerChoice();
            Status roundResult = DetermineWin(playerChoice, computerChoice);
            ShowResultOfRound(playerChoice, computerChoice, roundResult);

            return roundResult; 
        }

        public static void PlayMatch()
        {
            int rounds = GetNumberOfRounds();
            int playerScore = 0;
            int computerScore = 0;

            Console.WriteLine("\n==============================");

            for (int i = 1; i <= rounds; i++)
            {
                Console.WriteLine($"\nRound {i}");
                Status result = PlayRound();

                if (result == Status.Win)
                    playerScore++;
                else if (result == Status.Lose)
                    computerScore++;
            }

            Console.WriteLine("Game Over");
            Console.WriteLine($"Final Score -> You: {playerScore} | Computer: {computerScore}");

            if (playerScore > computerScore)
                Console.WriteLine("Final Winner: Player (You)!");
            else if (computerScore > playerScore)
                Console.WriteLine("Final Winner: Computer!");
            else
                Console.WriteLine("Final Winner: It's a Tie!");

            Console.WriteLine("==============================\n");
        }

        public static bool AskToPlayAgain()
        {
            while (true)
            {
                Console.Write("Play Again? Y/N: ");
                string input = Console.ReadLine()?.Trim().ToUpper();

                if (input == "Y") return true;
                if (input == "N") return false;

                Console.WriteLine("Invalid choice. Please enter 'Y' or 'N'.");
            }
        }

        public static void RunTheGame()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors!");
            Console.WriteLine();

            do
            {
                PlayMatch();
            }
            while (AskToPlayAgain());

            Console.WriteLine("\nExiting the game. Goodbye!");
        }

        static void Main(string[] args)
        {
            RunTheGame();
        }
    }
}