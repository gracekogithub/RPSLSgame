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
        public bool turn;
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
        //game rule
        //players: 3 people and 1 Ai
        //choose 2 players(human vs human)
        //play 3 times to select a winner
        //the losing memebers will be removed from game
        //the first winner will choose last person
        //the winner will play with Ai
        //claim winner

        //method
        public void SetRule()
        {
            for (int i=1; ; i++)
            {
                
            }
          

        }
        
            
            //Rock crushes Scissors
            //Scissors cuts Paper
            //Paper covers Rock
            //Rock crushes Lizard
            //Lizard poisons Spock
            //Spock smashes Scissors
            //Scissors decapitates Lizard
            //Lizard eats Paper
            //Paper disproves Spock
            //Spock vaporizes Rock
        

    }
}
