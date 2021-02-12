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
        Player playerOne;
        Player playerTwo;

        //public List<string> gesture;

        
        //constructor
        public GameSpace()
        {
           
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
           
      
            

        }
        //method
        public void PlayGame()
        {
            Console.WriteLine("Welcome! This is the rule how to play.");
            SetRule();
           
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
                              "Now, please choose your gesture option\'Rock,Paper,Scissors,Lizard, or Spock\': ");
        }
      




    }
}
