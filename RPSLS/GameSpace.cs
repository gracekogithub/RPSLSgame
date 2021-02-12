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
        public List<HumanPlayers> personN;
        public AIplayer computer;
        //public string[] gesture;
        public List<GestureOption> gestureN;

        public int winningScore;
        public int tie;
        public bool playingAgain;
        //constructor
        public GameSpace()
        {
            personN = new List<HumanPlayers>();
            computer = new AIplayer("");
            gestureN = new List<GestureOption>();
      
            winningScore = 0;
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
                              "Spock vaporizes Rock\bNow, please choose your gestion option\'Rock,Paper,Scissors,Lizard, or Spock\'");
        }
        public void ChooseGesture()
        {
            Console.WriteLine($"Please, {personN[0].person} chose {gestureN[0].gesture}");
            
            
            

            //if ("JohnPickGesture" == "Rock")
            //{
            //    if (userInput == "rock")
            //    {
            //        Console.WriteLine("tie");
            //    }
            //    if (userInput == "Paper")
            //    {
            //        Console.WriteLine("You lost");
            //        winningScore++;
            //    }
            //    Console.WriteLine();
                
            //}
            
        }




    }
}
