namespace Topic___1_7___Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerMove;
            int bet = 10, computerMove, rock, paper, scissors, betAttempt;

            Console.WriteLine("Welcome to my Casino");
            Console.WriteLine("You have 10 dollars to bet if you choose to but if you ran out of money...YOU'RE OUT. Have fun");
            Console.WriteLine("Press Enter to start");
            Console.ReadLine();

            Console.WriteLine("Enter how much you wanna bet");
            int.TryParse(Console.ReadLine(), out betAttempt);
            if (bet < betAttempt)
            {
                Console.WriteLine("YOU TRY TO CHEAT ME GET OUT");
            }
            else
            {
                Console.WriteLine("OOO a gambler I like, I'll rise you the same");
            }



        }
    }
}
