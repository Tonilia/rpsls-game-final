using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew
{
    class Game
    {
        Player PlayerOne;
        Player PlayerTwo;

        public void RunGame()
        {
            WelcomePage();
            DisplayRules();
            ChoosePlayers();
            StartGame();
            EndGame();
            
        }
        public void WelcomePage()
        {
            Console.WriteLine("Welcome to RPSLS. Have fun.");
            Console.ReadLine();
        }
        public void DisplayRules()
        {
            Console.WriteLine("First the rules of the game.");
            Console.WriteLine("Lizard poisons Spock. Spock smashes Scissors.");
            Console.WriteLine("Scissors decapitates Lizard. Lizard eats Paper.");
            Console.WriteLine("Paper disproves Spock. Spock vaporizes Rock.");
            Console.ReadLine();
        }
        public void ChoosePlayers()
        {
            Console.WriteLine("How many players? 1 player or 2 players");
            string NumberPlayer = Console.ReadLine();

            if (NumberPlayer == "1")
            {
                PlayerOne = new Human();
                PlayerTwo = new Computer();
            }
            else if (NumberPlayer == "2")
            {
                PlayerOne = new Human();
                PlayerTwo = new Human();
            }
        }
            
        public void StartGame()
        {
            while (PlayerOne.AddPoint <= 3 && PlayerTwo.AddPoint <= 3)
            {
                PlayerOne.MakeChoice();
                PlayerTwo.MakeChoice();
                CalculateWinner();
                DisplayScore();
            }

           EndGame();
        }

        public void EndGame()
        {
            Console.ReadLine();
            Console.WriteLine("Would you like to play again? yes or no");
            string loop = Console.ReadLine().ToLower();
            if (loop == "yes")
            {
                ChoosePlayers();
            }
            else if (loop == "no")
            {
                Console.WriteLine("Thanks for playing. Goodbye.");
            }

        }

        public void CalculateWinner()
        {
            if (PlayerOne.Choice == "scissors" && PlayerTwo.Choice == "scissors")
            {
                Console.WriteLine("A draw! Neither player gets points");
            }
            else if (PlayerOne.Choice == "scissors" && PlayerTwo.Choice == "rock" || PlayerTwo.Choice == "spock")
            {
                Console.WriteLine(" Player 2 wins.");
                PlayerTwo.AddPoint++;
            }
            else if (PlayerOne.Choice == "scissors" && PlayerTwo.Choice == "paper" || PlayerTwo.Choice == "lizard")
            {
                Console.WriteLine(" Player 1 wins");
                PlayerOne.AddPoint++;
            }

            else if (PlayerOne.Choice == "rock" && PlayerTwo.Choice == "rock")
            {
                Console.WriteLine("A draw! Neither player gets points");
            }
            else if (PlayerOne.Choice == "rock" && PlayerTwo.Choice == "paper" || PlayerTwo.Choice == "spock")
            {
                Console.WriteLine(" Player 2 wins.");
                PlayerTwo.AddPoint++;
            }
            else if (PlayerOne.Choice == "rock" && PlayerTwo.Choice == "scissors" || PlayerTwo.Choice == "lizard")
            {
                Console.WriteLine(" Player 1 wins");
                PlayerOne.AddPoint++;
            }

            else if (PlayerOne.Choice == "paper" && PlayerTwo.Choice == "paper")
            {
                Console.WriteLine("A draw! Neither player gets points");
            }
            else if (PlayerOne.Choice == "paper" && PlayerTwo.Choice == "rock" || PlayerTwo.Choice == "spock")
            {
                Console.WriteLine(" Player 1 wins");
                PlayerOne.AddPoint++;
            }
            else if (PlayerOne.Choice == "paper" && PlayerTwo.Choice == "scissors" || PlayerTwo.Choice == "lizard")
            {
                Console.WriteLine(" Player 2 wins.");
                PlayerTwo.AddPoint++;
            }

            else if (PlayerOne.Choice == "lizard" && PlayerTwo.Choice == "lizard")
            {
                Console.WriteLine("A draw! Neither player gets points");
            }
            else if (PlayerOne.Choice == "lizard" && PlayerTwo.Choice == "paper" || PlayerTwo.Choice == "spock")
            {
                Console.WriteLine(" Player 1 wins");
                PlayerOne.AddPoint++;
            }
            else if (PlayerOne.Choice == "lizard" && PlayerTwo.Choice == "rock" || PlayerTwo.Choice == "scissors")
            {
                Console.WriteLine(" Player 2 wins.");
                PlayerTwo.AddPoint++;
            }

            else if (PlayerOne.Choice == "spock" && PlayerTwo.Choice == "spock")
            {
                Console.WriteLine("A draw! Neither player gets points");
            }
            else if (PlayerOne.Choice == "spock" && PlayerTwo.Choice == "lizard" || PlayerTwo.Choice == "paper")
            {
                Console.WriteLine(" Player 2 wins.");
                PlayerTwo.AddPoint++;
            }
            else if (PlayerOne.Choice == "spock" && PlayerTwo.Choice == "rock" || PlayerTwo.Choice == "scissors")
            {
                Console.WriteLine(" Player 1 wins");
                PlayerOne.AddPoint++;
            }

        }
        public void DisplayScore()
        {
            Console.WriteLine("Player One's score is {0} and Player Two's score is {1}", PlayerOne.AddPoint, PlayerTwo.AddPoint);
            Console.ReadLine();

            if (PlayerOne.AddPoint == 3)
                {
                Console.ReadLine();
                Console.WriteLine("Player 1, you won. Congrats!");
                }
            else if (PlayerTwo.AddPoint == 3)
                {
                Console.ReadLine();
                Console.WriteLine("Player 2, you won. Congrats!");
                }
        }
        //public void EndGame()
        //{
        //    Console.ReadLine();
        //    Console.WriteLine("Would you like to play again? yes or no");
        //    string loop = Console.ReadLine().ToLower();
        //    if(loop == "yes")
        //        {
        //        ChoosePlayers();
        //        }
        //    else if (loop == "no")
        //    {
        //        Console.WriteLine("Thanks for playing. Goodbye.");
        //    }

        //}
    }
 }


            
            
        
    

