namespace RPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string? playerChoice;
            string? computerChoice;
            string? playerAnswer;

            while (playAgain)
            {
                playerChoice = "";
                computerChoice = "";
                playerAnswer = "";

                while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
                {
                    Console.Write("Input your choice! Rock, Paper, or Scissors: ");
                    playerChoice = Console.ReadLine();
                    playerChoice = playerChoice?.ToUpper();
                   
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computerChoice = "ROCK";
                        break;
                    case 2:
                        computerChoice = "PAPER";
                        break;
                    case 3:
                        computerChoice = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + playerChoice);
                Console.WriteLine("Computer: " + computerChoice);

                switch(playerChoice) 
                {
                    case "ROCK":
                        if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("DRAW!");
                        }
                        else if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("You LOSE!");
                        }
                        else if (computerChoice == "SCISSORS")
                        {
                            Console.WriteLine("You WIN!");
                        }
                        break;
                    case "PAPER":
                        if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("You WIN!");
                        }
                        else if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("DRAW!");
                        }
                        else if (computerChoice == "SCISSORS")
                        {
                            Console.WriteLine("You LOSE!");
                        }
                        break;
                    case "SCISSORS":
                        if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("You LOSE!");
                        }
                        else if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("You WIN!");
                        }
                        else if (computerChoice == "SCISSORS")
                        {
                            Console.WriteLine("DRAW");
                        }
                        break;
                }

                Console.Write("Play again? (Y/N): ");
                playerAnswer = Console.ReadLine();
                playerAnswer = playerAnswer?.ToUpper();

                if (playerAnswer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}