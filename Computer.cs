using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew
{
    class Computer : Player
    {
        
        public override void MakeChoice()
        {
            Random r = new Random();
            var randomInt = r.Next(0, 4);

            switch (randomInt)
            {
                case 0:
                    Console.WriteLine("rock");
                    Choice = "rock";
                break;
                case 1:
                    Console.WriteLine("paper");
                    Choice = "paper";
                    break;
                case 2:
                    Console.WriteLine("scissors");
                    Choice = "scissors";
                    break;
                case 3:
                    Console.WriteLine("spock");
                    Choice = "spock";
                    break;
                case 4:
                    Console.WriteLine("lizard");
                    Choice = "lizard";
                    break;
            }            
        }

    }
}
