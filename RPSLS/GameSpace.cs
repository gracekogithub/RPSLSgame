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


      
       

        //constructor
        public GameSpace()
        {
      
        }   
        //method
        public void Simulation()
        {
            Welcome();
            GameInstruction();
            PlayGame();
            PlayAgain();
           
        }
        public void PlayAgain()
        {
            Console.WriteLine("If you want to play again, press yes or exit for no");
            string userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                PlayGame();
            }
            else
            {
                Console.WriteLine("Game over! Good Bye!");
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
                string[] player = {"John","Tom","Bob" };
                string user = Console.ReadLine();
                if (user == "rock")
                {
                    if (player[i] == "rock")
                    {
                        Console.WriteLine("tie, try again!");

                    }
                    else if (player[i] == "paper" || player[i] == "spock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[i] == "sicessors" || player[i] == "lizard")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "paper")
                {
                    if (player[i] == "paper")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player[i] == "scissors" || player[i] == "lizard")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[i] == "rock" || player[i] == "spock")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }

                if (user == "scissor")
                {
                    if (player[i] == "scissor")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player[i] == "spock" || player[i] == "rock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[i] == "lizard" || player[i] == "paper")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "lizard")
                {
                    if (player[i] == "lizard")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player[i] == "scissor" || player[i] == "rock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[i] == "spock" || player[i] == "paper")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "spock")
                {
                    if (player[i] == "spock")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player[i] == "paper" || player[i] == "lizard")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[i] == "sicessors" || player[i] == "rock")
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
