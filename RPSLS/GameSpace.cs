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
        //constructor
        public GameSpace()
        {
            
        }   
        //method
        public void Simulation()
        {
            Welcome();
            bool repeat = true;
            while (repeat == true)
            {
                GameInstruction();
                PlayGame();
                PlayAgain();
            }
        }
        public void PlayAgain()
        {
            Console.WriteLine("If you want to play again, press yes or no to exit.");
            string userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                GameInstruction();
                PlayGame();
            }
            else
            {
                Console.WriteLine("Game over!");
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
            Console.WriteLine("rock, paper, scissors, lizard, spock... ");

            int userScore = 0, playerScore = 0;
            //bool playAgain = true;
            while (playerScore < 3 || userScore < 3)
            {
                int i = 0;
                
                string user = Console.ReadLine();
             
                if (user == "rock")
                {
                    if (humanName.name == "rock")
                    {
                        Console.WriteLine($"tie, try again!");

                    }
                    else if (humanName.name == "paper" || humanName.name == "spock")
                    {
                        Console.WriteLine($"{humanName.name} win, you loose");
                        playerScore++;
                    }
                    else if (humanName.name == "sicessors" || humanName.name == "lizard")
                    {
                        Console.WriteLine($"{humanName.name[i]} win, you win");
                        userScore++;
                    }
                }
                if (user == "paper")
                {
                    if (humanName.name == "paper")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (humanName.name == "scissors" || humanName.name == "lizard")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (humanName.name == "rock" || humanName.name == "spock")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }

                if (user == "scissor")
                {
                    if (humanName.name == "scissor")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (humanName.name == "spock" || humanName.name == "rock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (humanName.name == "lizard" || humanName.name == "paper")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "lizard")
                {
                    if (humanName.name == "lizard")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (humanName.name == "scissor" || humanName.name == "rock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (humanName.name == "spock" || humanName.name == "paper")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "spock")
                {
                    if (humanName.name == "spock")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (humanName.name == "paper" || humanName.name == "lizard")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (humanName.name == "sicessors" || humanName.name == "rock")
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
