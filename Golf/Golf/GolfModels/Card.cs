using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfModels
{
    public class Card
    {
        public string Id { get; set; }
        public SuitType Suit { get; set; }
        public CardType CardType { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; } 
        public string Symbol { get; set; }

        public Card(){}

        public Card(int value, SuitType suit, CardType cardType)
        {
            Value = value;
            Suit = suit;
            CardType = cardType;
        }
    }
}
