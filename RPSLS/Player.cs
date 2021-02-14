using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        protected string player;
        public List<string> gesture = new List<string>();
       

        public Player(string player) 
        {
            this.player = player;
            
          
            gesture.Add("rock");
            gesture.Add("paper");
            gesture.Add("scissors");
            gesture.Add("lizard");
            gesture.Add("spock");
        }

        public virtual void Play(HumanPlayers players)
        {
            Console.WriteLine("Please choose 1-rock,2-paper,3-scissors,4-lizard,5-spock: ");
            string user = Console.ReadLine();
            bool playAgain = true;
            int userScore = 0, playerScore = 0;
            while (playAgain == true)
            while (playerScore < 3 || userScore < 3)
            {
                
                switch (user)
                {
                    case "rock":
                        if (player=="rock")
                        {
                            Console.WriteLine("tie, try again!");
                        }
                        else if (player=="paper"||player=="spock")
                        {
                            Console.WriteLine("you loose");
                            playerScore++;
                        }
                        else if (player == "sicessors"||player =="lizard")
                        {
                            Console.WriteLine("you win");
                            userScore++;
                        }
                        break;

                    case "paper":
                        if (player == "paper")
                        {
                            Console.WriteLine("tie, try again!");
                        }
                        else if (player == "scissors" || player == "lizard")
                        {
                            Console.WriteLine("you loose");
                            playerScore++;
                        }
                        else if (player == "rock" || player == "spock")
                        {
                            Console.WriteLine("you win");
                            userScore++;
                        }

                        break;
                    case "scissor":
                        if (player == "scissor")
                        {
                            Console.WriteLine("tie, try again!");
                        }
                        else if (player == "rock" || player == "spock")
                        {
                            Console.WriteLine("loose");
                            playerScore++;
                        }
                        else if (player == "paper" || player == "lizard")
                        {
                            Console.WriteLine("win");
                            userScore++;
                        }
                        break;
                    case "lizard":
                        if (player == "lizard")
                        {
                            Console.WriteLine("tie, try again!");
                        }
                        else if (player == "scissor" || player == "rock")
                        {
                            Console.WriteLine("loose");
                            playerScore++;
                        }
                        else if (player == "spock" || player == "paper")
                        {
                            Console.WriteLine("win");
                            userScore++;
                        }
                        break;
                    case "spock":
                        if (player == "spock")
                        {
                            Console.WriteLine("tie, try again!");
                        }
                        else if (player == "paper" || player == "lizard")
                        {
                            Console.WriteLine("loose");
                            playerScore++;
                        }
                        else if (player == "sicessors" || player == "rock")
                        {
                            Console.WriteLine("win");
                            userScore++;
                        }
                        break;
                    default:
                        Console.WriteLine("Your input is invalid. Please try again");
                        break;
                }
                    if (playerScore==3)
                    {
                        Console.WriteLine("player won the game");
                    }
                    else if (userScore == 3)
                    {
                        Console.WriteLine("user won the game");
                    }
                    else
                    {

                    }
            }
            Console.WriteLine("If you want to play again, plese answer with yes or no. ");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                playAgain = true;
            }
            else if (answer == "no")
            {
                playAgain = false;
            }
            else
            {
                Console.WriteLine("try again");
            }
        }
    }
}
