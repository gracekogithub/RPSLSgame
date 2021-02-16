using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class GameSpace
    {
        //variables

        bool repeat;
        HumanPlayers humanName;
        AiPlayer aiName;
        int userScore;
        int playerScore;
        //constructor
        public GameSpace()
        {
            userScore = 0;
            playerScore = 0;
        }   
        //method
        public void Simulation()
        {
            Welcome();
            GameInstruction();
            PlayGame();
            WinnerIs();
        }
        
        
        public void WinnerIs()
        {
            if (playerScore == 3 && userScore <3)
            {
                Console.WriteLine("player won the game");
            }
            else if (userScore == 3 && playerScore <3)
            {
                Console.WriteLine("user won the game");
            }
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome! This is the rule how to play.");
        }
        public void GameInstruction()
        {
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\n"+
                              "Lizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\n"+
                              "Paper disproves Spock\nSpock vaporizes Rock\n" +
                              "Now, please choose your gesture option\'Rock,Paper,Scissors,Lizard, or Spock\': ");      
        }
        public void PlayGame()
        {
            
            
            while (playerScore < 3 || userScore < 3)
            {
                Console.WriteLine("rock, paper, scissors, lizard, spock... ");
                string user = Console.ReadLine();
                
                string player = Console.ReadLine();
             
                if (user == "rock")
                {
                    if (player == "rock")
                    {
                        Console.WriteLine($"tie, try again!");

                    }
                    else if (player == "paper" || player == "spock")
                    {
                        Console.WriteLine($"{player} win, you loose");
                        playerScore++;
                    }
                    else if (player == "sicessors" || player == "lizard")
                    {
                        Console.WriteLine($"{player} win, you win");
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
            
            Console.ReadLine();
        }
    }
}
