using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dealerCards = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10 };
            Random rand = new Random();
            int dealerFirstCard = rand.Next(dealerCards.Length);
            int dealerSecondCard = rand.Next(dealerCards.Length);
            int dealerHand = dealerFirstCard + dealerSecondCard;

            int[] userCards = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10 };
            int userFirstCard = rand.Next(userCards.Length);
            int userSecondCard = rand.Next(userCards.Length);
            int userHand = userFirstCard + userSecondCard;
            Console.WriteLine("Your hand is: " + userHand);

            Console.WriteLine("Would you like to hit? Type y or n");
            string hit = Console.ReadLine();

            if (hit == "y")
            {
                int hitCard = userHand += userFirstCard;
                Console.WriteLine(userHand);
            }
            else
            {
                Console.WriteLine(userHand);
            }

            if (userHand > dealerHand)
            {
                Console.WriteLine("You Win!");
                Console.WriteLine("The dealer had: " + dealerHand);
            }
            else
            {
                Console.WriteLine("You lose");
                Console.WriteLine("The dealer had: " + dealerHand);
            }
        }
    }
}
