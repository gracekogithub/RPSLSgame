using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayers
    {
        //variables
        public string personName;
        public Gesture gestureOption;



        //constructor
        public HumanPlayers(string personName, string gestureOption)
        {
            this.personName = personName;
            this.gestureOption = new Gesture(gestureOption);
        }

        //method

    }
}
