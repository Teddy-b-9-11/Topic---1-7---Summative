using System;
using System.Reflection.Emit;

namespace Topic___1_7___Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerMove, playAgain;
            Random generator = new Random();
            int bank = 10, bet, computerMove, rock = 0, paper = 1, scissors = 2;
            bool done = false;
            
            Console.WriteLine("Welcome to my Casino");
            Console.WriteLine("You have " + bank + " dollars to bet if you choose to but if you ran out of money...YOU'RE OUT. Have fun");
            Console.WriteLine("Press Enter to start");
            Console.ReadLine();

            while (!done)
            {

                Console.WriteLine("You have " + bank + " dollars to bet.");
              

                Console.WriteLine("Enter how much you wanna bet");
                int.TryParse(Console.ReadLine(), out bet);
                if (bank < bet)
                {
                    Console.WriteLine("YOU TRY TO CHEAT ME GET OUT");
                    done = true;
                    break;
                }
                else
                {
                    Console.WriteLine("OOO a gambler I like, I'll rise you the same");
                }

                
                computerMove = generator.Next(3);

                Console.WriteLine("Type below what move you choose:");
                Console.WriteLine("Rock \t Paper \t Scissors");
                playerMove = Console.ReadLine();
                //Rock
                if (playerMove == "Rock" && computerMove == paper)
                {
                    Console.WriteLine("Awww man you bet me");
                    bank = bank + bet;
                    Console.WriteLine("You have " + bank + "$");
                }
                else if (playerMove == "Rock" && computerMove == scissors)
                {
                    Console.WriteLine("Haha I win no money for you");
                    bank = bank - bet;
                    Console.WriteLine("You have " + bank + "$");
                }
                else if (playerMove == "Rock" && computerMove == rock)
                {
                    Console.WriteLine("Guess you get to keep your money");
                    Console.WriteLine("You have " + bank + "$");
                }
                
                //Paper
                if (playerMove == "Paper" && computerMove == rock)
                {
                    Console.WriteLine("Awww man you bet me");
                    bank = bank + bet;
                    Console.WriteLine("You have " + bank + "$");
                }
                else if (playerMove == "Paper" && computerMove == scissors)
                {
                    Console.WriteLine("Haha I win no money for you");
                    bank = bank - bet;
                    Console.WriteLine("You have " + bank + "$");
                }
                else if (playerMove == "Paper" && computerMove == paper)
                {
                    Console.WriteLine("Guess you get to keep your money");
                    Console.WriteLine("You have " + bank + "$");
                }
                
                //Scissors
                if (playerMove == "Scissors" && computerMove == paper)
                {
                    Console.WriteLine("Awww man you bet me");
                    bank = bank + bet;
                    Console.WriteLine("You have " + bank + "$");
                }
                else if (playerMove == "Scissors" && computerMove == rock)
                {
                    Console.WriteLine("Haha I win no money for you");
                    bank = bank - bet;
                    Console.WriteLine("You have " + bank + "$");
                }
                else if (playerMove == "Scissors" && computerMove == scissors)
                {
                    Console.WriteLine("Guess you get to keep your money");
                    Console.WriteLine("You have " + bank + "$");
                }

                Console.WriteLine("Do you want to play again or cash out?");
                Console.WriteLine("Yes \t or \t No");
                playAgain = Console.ReadLine();
                if (playAgain == "No")
                {
                    Console.WriteLine("Ok bye");
                    break;
                }

            }

        }
    }
}
