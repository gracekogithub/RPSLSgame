using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   
    public abstract class Player
    {
        public HumanPlayers name;
        public string player;//{get; set; }
        public List<string> gesture; 

        public Player(string player) 
        {
            this.player = player;
            name = new HumanPlayers("");
            
            gesture = new List<string>();
            gesture.Add("rock");
            gesture.Add("paper");
            gesture.Add("scissors");
            gesture.Add("lizard");
            gesture.Add("spock");
        }

        public virtual void Play()
        {
            Console.WriteLine("Please choose rock, paper, scissors, lizard, spock: ");
            int userScore = 0, playerScore = 0;
            //bool playAgain = true;
            while (playerScore < 3 || userScore < 3)
            {
                string user = Console.ReadLine();
                if (user == "rock")
                {
                    if (player == "rock")
                    {
                        Console.WriteLine("tie, try again!");

                    }
                    else if (player == "paper" || player == "spock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player == "sicessors" || player == "lizard")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "paper")
                {
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
                }

                if (user == "scissor")
                {
                    if (player == "scissor")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player == "spock" || player == "rock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player == "lizard" || player == "paper")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "lizard")
                {
                    if (player == "lizard")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player == "scissor" || player == "rock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player == "spock" || player == "paper")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "spock")
                {
                    if (player == "spock")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player == "paper" || player == "lizard")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player == "sicessors" || player == "rock")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                else
                {
                    Console.WriteLine("Your input is invalid. Please try again");
                }
            }
            if (playerScore == 3)
            {
                Console.WriteLine("player won the game");
            }
            else if (userScore == 3)
            {
                Console.WriteLine("user won the game");
            }
            Console.ReadLine();
        }
        

    }
    
}
