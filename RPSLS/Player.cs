using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public string name;
        public List<string> gestures = new List<string>();
        public string chosenGesture;
       
        public Player() 
        {
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");

        }

        public void ComparingGesture()
        {
            Console.WriteLine("You win");
            string input = Console.ReadLine();
               
            switch (Player)
            {
            
                
            }

        }
        
    }
}
