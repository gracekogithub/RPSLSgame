using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayers : Player
    {

        public string playerName;
      
        public HumanPlayers(string player) : base (player)
        {
            playerName = player;
           
        }
        
    }
}
