using System;
using System.Reflection.Emit;

namespace Topic___1_7___Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerMove;
            Random generator = new Random();
            int bank = 10, bet, computerMove, rock = 0, paper = 1, scissors = 2, betAttempt, computerChoice;
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
                }
                else
                {
                    Console.WriteLine("OOO a gambler I like, I'll rise you the same");
                }


                Console.WriteLine("Type below what move you choose:");
                Console.WriteLine("Rock \t Paper \t Scissors");
                playerMove = Console.ReadLine();
                if (playerMove = )
                {

                }
                computerMove = generator.Next(3);


            }



        }
    }
}
