using CMP1903M_A01_2223;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Testing
{
    public static Pack pack = new Pack();

    public void bringing_cards_to_this_class()
    {
        List<Card> cards = Pack.cards;

        // Do something with the cards list
    }

    public static void RunMenu()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("\nWelcome to the card shuffler.\nPlease enter a number:\n1: Deal a card\n2: Deal multiple cards\n3: No shuffle\n4: Riffle Shuffle\n5: Fisher-Yates Shuffle\n6: End program\n");
            string userSelection = Console.ReadLine();
            switch (userSelection)
            {
                case "1":
                    Card card1 = pack.deal();
                    Console.WriteLine(card1.Value + " Of " + card1.Suit);
                    break;
                case "2":
                    Console.WriteLine("Number of cards:");
                    int amount = int.Parse(Console.ReadLine());
                    string[] dealtCards = pack.dealCard(amount);
                    foreach (string card in dealtCards)
                    {
                        Console.WriteLine(card);
                    }
                    break;
                case "3":
                    // No shuffle
                    break;
                case "4":
                    pack.riffleShuffle();
                    break;
                case "5":
                    pack.fisherYatesShuffle();
                    break;
                case "6":
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}