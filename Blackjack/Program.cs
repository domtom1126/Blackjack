using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("Welcome to Blackjack!");
            Console.WriteLine("1) Play");
            Console.WriteLine("2) Rules");
            Console.WriteLine("3) Exit");
            int menuSelect = Int32.Parse(Console.ReadLine());
            if (menuSelect == 1)
            {
                Game();
                MainMenu();
            }
            else if (menuSelect == 2)
            {
                Console.WriteLine("The game of blackjack is played where you try to get as close as possible to 21 without going over" +
                    "If you go over the dealer wins, if the dealer goes over you win, if the dealer gets closer to 21 you lose," +
                    "if you are closer to 21 than the dealer, you win.");
                MainMenu();
            }
            else
            {
                MainMenu();
            }
            
        }
        static void Game()
        {
            // Dealer Cards
            int[] dealerCards = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10 };
            Random rand = new Random();
            //Picks random first card
            int dealerFirstCard = rand.Next(dealerCards.Length);
            // Picks random second card
            int dealerSecondCard = rand.Next(dealerCards.Length);
            //Adds first and second card to make dealerHand
            int dealerHand = dealerFirstCard + dealerSecondCard;



            //Users Cards
            int[] userCards = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10 };
            int userFirstCard = rand.Next(userCards.Length);
            int userSecondCard = rand.Next(userCards.Length);
            int userHand = userFirstCard + userSecondCard;
            //Outputs your hand 
            Console.WriteLine("Your hand is: " + userHand);
            //Asks if you want to take another card to get as close to 21 as possible
            Console.WriteLine("Would you like to hit? Type y or n");

            string hit = Console.ReadLine().ToLower();
            // User answers "y" and outputs their hand plus the next card
            if (hit == "y")
            {
                int hitCard = userHand += userFirstCard;
                Console.WriteLine("Your new hand is:" + hitCard);
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
            else if (userHand < dealerHand)
            {
                Console.WriteLine("You Lose!");
                Console.WriteLine("The dealer had: " + dealerHand);
            }
            else if (dealerHand > 21)
            {
                Console.WriteLine("The dealer busts. You won!");
                Console.WriteLine("The dealer had: " + dealerHand);
            }
            else if (userHand == dealerHand)
            {
                Console.WriteLine("You tie with the dealer");
                Console.WriteLine("The dealer had: " + dealerHand);
            }
            else if (userHand > 21)
            {
                Console.WriteLine("You bust! You lose!");
            }
        }
    }
}
