using System;

class Program
{
    static void Main(string[] args)
    {
        int player1RandomNum;
        int player2RandomNum;

        int player1Points = 0;
        int player2Points = 0;

        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Player 1: press any key to roll the dice.");
            Console.ReadKey();
            player1RandomNum = random.Next(1, 7);
            Console.WriteLine("Player 1 rolled a " + player1RandomNum);

            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Player 2: press any key to roll the dice.");
            Console.ReadKey();
            player2RandomNum = random.Next(1, 7);
            Console.WriteLine("Player 2 rolled a " + player2RandomNum);

            if (player1RandomNum > player2RandomNum)
            {
                player1Points++;
                Console.WriteLine("Player 1 wins this round!");
            }
            else if (player1RandomNum < player2RandomNum)
            {
                player2Points++;
                Console.WriteLine("Player 2 wins this round!");
            }
            else
            {
                Console.WriteLine("Draw");
            }

            Console.WriteLine("Scores - Player 1: " + player1Points + ". Player 2: " + player2Points + ".");
            Console.WriteLine();
        }

        if (player1Points > player2Points)
        {
            Console.WriteLine("Player 1 wins the game!");
        }
        else if (player1Points < player2Points)
        {
            Console.WriteLine("Player 2 wins the game!");
        }
        else
        {
            Console.WriteLine("The game concludes in a draw.");
        }

        Console.ReadKey();
    }
}
