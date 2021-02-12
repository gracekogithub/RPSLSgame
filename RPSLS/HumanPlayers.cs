using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayers : Player
    {
        //variables
        public int winningScore;
        public int loosingScore;
        public int tie;
        public bool playingAgain;


        //constructor
        public HumanPlayers()//string name)
        {
           /* this.name = name*/;
            //person = personName;
            //person = new List<string>{ "john", "Tom", "Bob" };
            //person = new List<string>();
            //personName.Add("John");
            //personName.Add("Tom");
            //personName.Add("Bob");
            winningScore = 0;
            loosingScore = 0;
            tie = 0;
            playingAgain = true;
        }
        //method
        public void CapareGesture()
        {
            
        }
       
        public void ChooseGesture()
        {
            //ask for input
            //capture input
            //assign chosenGesture from input
            Console.WriteLine("");
            
            while (playingAgain)
            {
                //personN = "chose Rock";
                Console.WriteLine("John chose Rock");


                //if (true)//rock
                //{
                //    Console.WriteLine("tie! try again!");

                //}
                //else if ( == "Paper")
                //{
                //    Console.WriteLine("You win");
                //    winningScore++;
                //}
                //else if ( == "Scissors")
                //{
                //    Console.WriteLine("You lose");
                //    loosingScore++;
                //}
                //else if ( == "Lizard")
                //{
                //    Console.WriteLine("You win");
                //    winningScore++;
                //}
                //else if ( == "Spock")
                //{
                //    Console.WriteLine("You lose");
                //    loosingScore++;
                //}
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
