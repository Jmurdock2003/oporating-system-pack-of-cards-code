using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> cards = new List<Card>();

        public Pack()
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    cards.Add(new Card(suit, value));
                }
            } // Initialize the card pack here
        }

        public Card deal() // This deals the top card from the deck
        {
            Card topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }

        public string[] dealCard(int amount)
        {
            string[] card_list = new string[amount];

            for (int i = 0; i < amount; i++)
            {
                Card card = deal();
                card_list[i] = card.Value + " Of " + card.Suit;
            }

            return card_list;
        }

        public void riffleShuffle()
        {
            int half = cards.Count / 2;
            List<Card> leftDeck = cards.GetRange(0, half);
            List<Card> rightDeck = cards.GetRange(half, half);

            cards.Clear();
            Random rand = new Random();

            while (leftDeck.Count > 0 || rightDeck.Count > 0)
            {
                if (leftDeck.Count > 0)
                {
                    int cardIndex = rand.Next(0, leftDeck.Count);
                    cards.Add(leftDeck[cardIndex]);
                    leftDeck.RemoveAt(cardIndex);
                }

                if (rightDeck.Count > 0)
                {
                    int cardIndex = rand.Next(0, rightDeck.Count);
                    cards.Add(rightDeck[cardIndex]);
                    rightDeck.RemoveAt(cardIndex);
                }
            }
        }

        public void fisherYatesShuffle()
        {
            Random rand = new Random();
            int n = cards.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }


    }
}
// Deals the number of cards specified by 'amount'

