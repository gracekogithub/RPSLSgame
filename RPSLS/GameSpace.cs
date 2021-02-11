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
        public PlayerStage player;
        public List<Gesture> option;
        //constructor
        public GameSpace()
        {
            player = new PlayerStage();
            option = new List<Gesture>();

            Gesture gestureOption1 = new Gesture("Rock");
            Gesture gesturOption2 = new Gesture("Paper");
            Gesture gestureOption3 = new Gesture("Scissors");
            Gesture gestureOption4 = new Gesture("Lizard");
            Gesture gestureOption5 = new Gesture("Spock");
            option.Add(gestureOption1);
            option.Add(gesturOption2);
            option.Add(gestureOption3);
            option.Add(gestureOption4);
            option.Add(gestureOption5);

        }
        //players: 3 people and 1 Ai
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





    }
}
