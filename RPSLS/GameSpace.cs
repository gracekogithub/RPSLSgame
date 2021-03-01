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
        public bool repeat;
        public Player playerOne;
        public Player playerTwo;
        public int playerOneScore;
        public int playerTwoScore;
        //constructor
        public GameSpace()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            //playerOne = new AiPlayer("CS1");
            playerOne = new HumanPlayers("Bob");
        }   
        //method
        public void Simulation()
        {
            Welcome();
            GameInstruction();
            ChooseGameType();
            PlayGame();
            WinnerIs();
            WantToPlayAgain();
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome! This is the rule how to play.");
        }
        public void GameInstruction()
        {
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\n" +
                              "Lizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\n" +
                              "Paper disproves Spock\nSpock vaporizes Rock\n" +
                              "Now, please choose your gesture option\'Rock,Paper,Scissors,Lizard, or Spock\': ");
        }
        public void ChooseGameType()
        {
            Console.WriteLine("Please choose gametype. Press 1 for Ai player or 2 for human player");
            string input = Console.ReadLine();
            if (input == "1")
            {
                playerTwo = new AiPlayer("CS1");
            }
            else if (input == "2")
            {
               
                playerTwo = new HumanPlayers("Player's name is: ");
            }
            else
            {
                ChooseGameType();
            }
        }
        public void PlayGame()
        {
            while (playerOneScore < 3 || playerTwoScore < 3)
            {
                Console.WriteLine("rock, paper, scissors, lizard, spock... ");

                //string user = Console.ReadLine().ToLower();
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                if (playerOne.choice == playerTwo.choice)
                {
                    playerTwo.ChooseGesture();
                    Console.WriteLine($"tie, try again!");
                }
                if ((playerOne.choice == "paper" && playerTwo.choice == "rock") || (playerOne.choice == "spock" && playerTwo.choice == "rock" ))
                {
                    playerTwo.ChooseGesture();
                    Console.WriteLine($"you loose");
                    playerTwoScore++;
                }
                if ((playerOne.choice == "scissors" && playerTwo.choice == "rock") || (playerOne.choice == "lizard" && playerTwo.choice == "rock"))
                {
                    Console.WriteLine($"you win");
                    playerOneScore++;
                }
                else if ((playerOne.choice == "paper" && playerTwo.choice == "scissors") || (playerOne.choice == "paper" && playerTwo.choice == "lizard"))
                {
                    Console.WriteLine("you loose");
                    playerTwoScore++;
                }
                else if ((playerOne.choice == "paper" && playerTwo.choice == "rock") || (playerOne.choice == "paper" && playerTwo.choice == "spock"))
                {
                    Console.WriteLine("you win");
                    playerTwoScore++;
                }
                else if ((playerOne.choice == "scissor" && playerTwo.choice == "spock") || (playerOne.choice == "scissor" && playerTwo.choice == "rock"))
                {
                    Console.WriteLine("you loose");
                    playerTwoScore++;
                }
                if ((playerOne.choice == "scissor" && playerTwo.choice == "lizard") || (playerOne.choice == "scissor" && playerTwo.choice == "paper"))
                {
                    Console.WriteLine("you win");
                    playerOneScore++;
                }
                if ((playerOne.choice == "lizard" && playerTwo.choice == "scissor") || (playerOne.choice == "lizard" && playerTwo.choice == "rock"))
                {
                    Console.WriteLine("you loose");
                    playerTwoScore++;
                }
                if ((playerOne.choice == "lizard" && playerTwo.choice == "spock") || (playerOne.choice == "lizard" && playerTwo.choice == "paper"))
                {
                    Console.WriteLine("you win");
                    playerOneScore++;
                }
                if ((playerOne.choice == "spock" && playerTwo.choice == "paper") || (playerOne.choice == "spock" && playerTwo.choice == "lizard"))
                {
                    Console.WriteLine("you loose");
                    playerTwoScore++;
                }
                if ((playerOne.choice == "spock" && playerTwo.choice == "sicessors") || (playerOne.choice == "spock" && playerTwo.choice == "rock"))
                {
                    Console.WriteLine("you win");
                    playerOneScore++;
                }
                else
                {
                    Console.WriteLine("Your input is invalid. Please try again");
                }
            }
            Console.ReadLine();
        }
        public void WinnerIs()
        {
            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                if (playerOneScore == 3 && playerTwoScore < 3)
                {
                    Console.WriteLine("player1 won the game");
                }
                else if (playerTwoScore == 3 && playerOneScore < 3)
                {
                    Console.WriteLine("player2 won the game");
                }
            }
        }
        public void WantToPlayAgain()
        {
            Console.WriteLine("Do you want to play again? Please type yes or no: ");
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
            {
                GameInstruction();
            }
            else if (input == "no")
            {
                Console.WriteLine("Thank you for playing! Bye");
                System.Environment.Exit(0);
            }
            else
            {
                WantToPlayAgain();
            }
        }
    }
}
