using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        protected string player;
        protected string chosenGesture;
        protected List<string> gesture = new List<string>();

        public Player(string player, string chosenGesture) 
        {
            this.player = player;
            this.chosenGesture = chosenGesture;
            gesture.Add("rock");
            gesture.Add("paper");
            gesture.Add("scissors");
            gesture.Add("lizard");
            gesture.Add("spock");
        }

        public void Play()
        {
            Console.WriteLine("player one chose: ");
            string user = Console.ReadLine();
            int userScore = 0, playerScore = 0;
            for (int i = 0; i < 6; i++)
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

                }

            }
        }
    }
}
