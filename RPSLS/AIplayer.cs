﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AiPlayer : Player
    {
        public string aiName;
        public AiPlayer(string player): base (player)
        {
            aiName = player;
        }

        // Override and implement the ChooseGesture method
        // We need to automatically select a random gesture out of the list of gestures
        // Generate a random number between zero and the max index number of our gestures list
        // Set the choice variable eqaul to our gestures list at the index of our randomly generated number

        public override void ChooseGesture()
        {
            var random = new Random();
            var gesturesAi = new List<string> { "rock","paper","scissors","lizard","spock" };
            int index = random.Next(gesturesAi.Count);
            Console.WriteLine(gesturesAi[index]);

        }

    }
}
