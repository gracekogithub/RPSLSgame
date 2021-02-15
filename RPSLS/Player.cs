using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   
    public abstract class Player
    {
        public string name;
        public List<string> gestures;
        public string choice;
        public Player(string name) 
        {
            this.name = name;
           
            
            gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
        }

        public virtual void ChooseGesture()
        {
            Console.WriteLine("Please choose rock, paper, scissors, lizard, spock: ");
            choice = Console.ReadLine();
            
           // choose a gesture
           // return the gesture that is chosen
        }
        

    }
    
}
