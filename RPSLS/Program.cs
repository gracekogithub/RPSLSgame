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
          
            GameSpace gamespace = new GameSpace();
            gamespace.Simulation();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
