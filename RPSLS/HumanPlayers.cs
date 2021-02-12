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
       
        public List<string> person;

        //constructor
        public HumanPlayers(List<string> personName)
        {
            //person = personName;
            //person = new List<string>{ "john", "Tom", "Bob" };
            person = new List<string>();
            personName.Add("John");
            personName.Add("Tom");
            personName.Add("Bob");

        }

        //method

    }
}
