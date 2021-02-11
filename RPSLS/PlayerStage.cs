using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class PlayerStage
    {
        //variables
        public List<HumanPlayers> person;
        public string ai;
        
        //constructor
        public PlayerStage()
        {
            person = new List<HumanPlayers>();
            HumanPlayers person1 = new HumanPlayers("John", "");
            HumanPlayers person2 = new HumanPlayers("Tom", "");
            HumanPlayers person3 = new HumanPlayers("Bob", "");
            person.Add(person1);
            person.Add(person2);
            person.Add(person3);

            

        }
        //method

    }
}
