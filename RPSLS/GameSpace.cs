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
        public void Welcome()
        {
            Console.WriteLine("Welcome! This is the rule how to play.");
        }
        public void PlayGame()
        {
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\n"+
                              "Lizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\n"+
                              "Paper disproves Spock\nSpock vaporizes Rock\n" +
                              "Now, please choose your gesture option\'Rock,Paper,Scissors,Lizard, or Spock\': ");      
        }
        public void SelectPlayer()
        {
            Console.WriteLine("John and Tom will play first");
        }
    }
}
