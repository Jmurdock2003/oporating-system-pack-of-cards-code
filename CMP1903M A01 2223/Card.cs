using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        public string Suit { get; }
        public string Value { get; }

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation


    }
}
