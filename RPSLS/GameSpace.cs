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
        public HumanPlayers person;
        public AIplayer computer;
        public string[] gesture;
        //constructor
        public GameSpace()
        {
            person = new HumanPlayers("");
            computer = new AIplayer("");
            string[] gesture = new string[] { "Rock","Paper","Scissors","Lizard","Spock" };
            this.gesture = gesture;

        }
        //choose 2 players(human vs human)
        //play 3 times to select a winner
        //the losing memebers will be removed from game
        //the first winner will choose last person
        //the winner will play with Ai
        //claim winner

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
                              "Spock vaporizes Rock");
        }
        public void ChooseGesture()
        {
            Console.WriteLine($"Please, choose your gesture option: \n{person.personName[0]} chose {gesture[0]}");
            
        }




    }
}
