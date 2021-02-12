using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameSpace
    {
        //variables
        public string inputUser;
        public List<HumanPlayers> personN;
        public AIplayer computer;
        //public string[] gesture;
        public List<GestureOption> gestureN;

        public int winningScore;
        public int loosingScore;
        public int tie;
        public bool playingAgain;
        //constructor
        public GameSpace()
        {
            inputUser = inputUser;
            personN = new List<HumanPlayers>();
            computer = new AIplayer("");
            gestureN = new List<GestureOption>();
      
            winningScore = 0;
            loosingScore = 0;
            tie = 0;
            playingAgain = true;

        }
        //method
        public void PlayGame()
        {
            Console.WriteLine("Welcome! This is the rule how to play.");
            SetRule();
            ChooseGesture();
        }
        public void SetRule()
        {
            Console.WriteLine("Rock crushes Scissors\n" +
                              "Scissors cuts Paper\n"+
                              "Paper covers Rock\n"+
                              "Rock crushes Lizard\n"+
                              "Lizard poisons Spock\n"+
                              "Spock smashes Scissors\n"+
                              "Scissors decapitates Lizard\n"+
                              "Lizard eats Paper\n"+
                              "Paper disproves Spock\n"+
                              "Spock vaporizes Rock\b" +
                              "Now, please choose your gestion option\'Rock,Paper,Scissors,Lizard, or Spock\'");
        }
        public void ChooseGesture()
        {
            //Console.WriteLine($"Please, {personN[0].person} chose {gestureN[0].gesture}");
            while (playingAgain)
            {
                //personN = "chose Rock";
                Console.WriteLine("John chose Rock");
                if (inputUser == "Rock")
                {
                    Console.WriteLine("tie");
                }
                else if (inputUser == "Paper")
                {
                    Console.WriteLine("You win");
                    winningScore++;
                }
                else if (inputUser == "Scissors")
                {
                    Console.WriteLine("You lose");
                    loosingScore++;
                }
                else if (inputUser == "Lizard")
                {
                    Console.WriteLine("You win");
                    winningScore++;
                }
                else if (inputUser == "Spock")
                {
                    Console.WriteLine("You lose");
                    loosingScore++;
                }
            }
           
           //if("rock" == "rock" || "sicssors" == "sicssor" ||"paper" == "paper" || "lizard" == "lizard "|| "spock" == "spock")
           // {
           //     Console.WriteLine("tie");
           //     tie = 0;
           //     playingAgain = true;
           // }
          
        }




    }
}
