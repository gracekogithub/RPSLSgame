using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayers : Player
    {



        public HumanPlayers(string humanName) : base(humanName)
        {
            Console.WriteLine($"player {humanName} is next to play");
           
        }
        public override void Play()
        {
            base.Play();
           
        }


    }
}
