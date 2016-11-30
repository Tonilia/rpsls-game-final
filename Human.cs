using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew
{
    class Human : Player
    {
        public override void MakeChoice()
        {
            Console.WriteLine("Choose your weapon: rock, paper, scissors, spock, or lizard.");
            Choice = Console.ReadLine();
        }
    }
}
