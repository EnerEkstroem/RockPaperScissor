using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor {
    class Program {
        static void Main(string[] args) {
            Boolean playing = true;
            int games = 0;
            int wins = 0;
            int ties = 0;
            int losses = 0;
            Random random = new Random();
            Console.WriteLine("Welcome to rock, paper, scissor");
            while (playing) {
                int choice = random.Next(0,3);
                string AiChoice = "";
                switch (choice) {
                    case 0:
                        AiChoice = "Rock";
                        break;
                    case 1:
                        AiChoice = "Paper";
                        break;
                    case 2:
                        AiChoice = "Scissor";
                        break;
                }
                Console.WriteLine("type in your selection (rock, paper or scissor) to play or exit to quit the game");
                string PlayerChoice = Console.ReadLine();
                switch (PlayerChoice.ToLower()) {
                    case "rock":
                        games++;
                        switch (AiChoice.ToLower()) {
                            case "rock":
                                ties++;
                                Console.WriteLine("Tie, you both choose Rock");
                                break;
                            case "paper":
                                losses++;
                                Console.WriteLine("You choose Rock, Computer choose Paper.");
                                Console.WriteLine("You loose this round");
                                break;
                            case "scissor":
                                wins++;
                                Console.WriteLine("You choose Rock, Computer choose Scissor.");
                                Console.WriteLine("You win this round");
                                break;
                            default:
                                //TODO : Throw exception though this shouldn't happen.
                                break;
                        }
                        break;
                    case "paper":
                        games++;
                        switch (AiChoice.ToLower()) {
                            case "rock":
                                wins++;
                                Console.WriteLine("You choose Paper, Computer choose Rock.");
                                Console.WriteLine("You win this round");
                                break;
                            case "paper":
                                ties++;
                                Console.WriteLine("Tie, you both choose Paper");
                                break;
                            case "scissor":
                                losses++;
                                Console.WriteLine("You choose Paper, Computer choose Scissor.");
                                Console.WriteLine("You loose this round");
                                break;
                            default:
                                //TODO : Throw exception though this shouldn't happen.
                                break;
                        }
                        break;
                    case "scissor":
                        games++;
                        switch (AiChoice.ToLower()) {
                            case "rock":
                                losses++;
                                Console.WriteLine("You choose Scissor, Computer choose Rock.");
                                Console.WriteLine("You loose this round");
                                break;
                            case "paper":
                                wins++;
                                Console.WriteLine("You choose Scissor, Computer choose Paper.");
                                Console.WriteLine("You win this round");
                                break;
                            case "scissor":
                                ties++;
                                Console.WriteLine("Tie, you both choose Scissor");
                                break;
                            default:
                                //TODO : Throw exception though this shouldn't happen.
                                break;
                        }
                        break;
                    case "exit":
                        playing = false;
                        Console.WriteLine("Thanks for playing Rock, Paper, Scissor");
                        break;
                    default:
                        Console.WriteLine("Invalid input please try again");
                        break;
                }
                Console.WriteLine("You have played " + games + " times and had " + losses + " losses, "
                                    + ties + " ties and " + wins + " wins");
            }
        }
    }
}
