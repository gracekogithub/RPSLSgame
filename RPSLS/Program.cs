using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameSpace space = new GameSpace();
            space.Simulation();
            HumanPlayers name = new HumanPlayers("John");
            name.Play();
            //AiPlayer aiName = new AiPlayer("C101");
            //aiName.Play();
           

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
