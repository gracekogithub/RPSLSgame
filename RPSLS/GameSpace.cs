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


        HumanPlayers player;
       

        //constructor
        public GameSpace()
        {
            //player = new HumanPlayers();
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
                string[] player = {"John","Tom","Bob" };
                string user = Console.ReadLine();
                if (user == "rock")
                {
                    if (player[0] == "rock")
                    {
                        Console.WriteLine("tie, try again!");

                    }
                    else if (player[0] == "paper" || player[0] == "spock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[0] == "sicessors" || player[0] == "lizard")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "paper")
                {
                    if (player[0] == "paper")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player[0] == "scissors" || player[0] == "lizard")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[0] == "rock" || player[0] == "spock")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }

                if (user == "scissor")
                {
                    if (player[0] == "scissor")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player[0] == "spock" || player[0] == "rock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[0] == "lizard" || player[0] == "paper")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "lizard")
                {
                    if (player[0] == "lizard")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player[0] == "scissor" || player[0] == "rock")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[0] == "spock" || player[0] == "paper")
                    {
                        Console.WriteLine("you win");
                        userScore++;
                    }
                }
                if (user == "spock")
                {
                    if (player[0] == "spock")
                    {
                        Console.WriteLine("tie, try again!");
                    }
                    else if (player[0] == "paper" || player[0] == "lizard")
                    {
                        Console.WriteLine("you loose");
                        playerScore++;
                    }
                    else if (player[0] == "sicessors" || player[0] == "rock")
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
