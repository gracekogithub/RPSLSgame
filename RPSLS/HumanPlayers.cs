using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayers : Player
    {

        List<string> name;

        public HumanPlayers(string humanName) : base(humanName)
        {
            name = new List<string>();
            name.Add("John");
            name.Add("Tom");
            name.Add("Bob");
        }
        public override void ChooseGesture()
        {
            DisplayGestures();
            choice = Console.ReadLine();
            if (choice != "rock" && choice != "paper")
            {
                ChooseGesture();
            }

        }


    }
}
