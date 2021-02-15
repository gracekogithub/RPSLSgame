using System;
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
        public override void Play()
        {
            base.Play();
            Console.WriteLine("child");
        }
    }
}
