using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfModels
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            foreach (SuitType suit in (SuitType[])Enum.GetValues(typeof(SuitType)))
            {
                var unicodeSymbol = "";
                var suitId = "";
                switch (suit)
                {
                    case SuitType.Clubs:
                        unicodeSymbol = "\u2663";
                        suitId = "C";
                        break;
                    case SuitType.Diamonds:
                        unicodeSymbol = "\u2666";
                        suitId = "D";
                        break;
                    case SuitType.Hearts:
                        unicodeSymbol = "\u2665";
                        suitId = "H";
                        break;
                    case SuitType.Spades:
                        unicodeSymbol = "\u2660";
                        suitId = "S";
                        break;
                    default:
                        break;

                }

                Card ace = new Card
                {
                    Id = $"A{suitId}",
                    Suit = suit,
                    CardType = CardType.Ace,
                    Value = 1,
                    FullName = $"Ace of {suit.ToString()}",
                    Symbol = $@"A{unicodeSymbol}"
                };
                Card two = new Card
                {
                    Id = $"2{suitId}",
                    Suit = suit,
                    CardType = CardType.Number,
                    Value = 2,
                    FullName = $"Two of {suit.ToString()}",
                    Symbol = $@"2{unicodeSymbol}"
                };
                Card three = new Card
                {
                    Id = $"3{suitId}",
                    Suit = suit,
                    CardType = CardType.Number,
                    Value = 3,
                    FullName = $"Three of {suit.ToString()}",
                    Symbol = $@"3{unicodeSymbol}"
                };
                Card four = new Card
                {
                    Id = $"4{suitId}",
                    Suit = suit,
                    CardType = CardType.Number,
                    Value = 4,
                    FullName = $"Four of {suit.ToString()}",
                    Symbol = $@"4{unicodeSymbol}"
                };
                Card five = new Card
                {
                    Id = $"5{suitId}",
                    Suit = suit,
                    CardType = CardType.Number,
                    Value = 5,
                    FullName = $"Five of {suit.ToString()}",
                    Symbol = $@"5{unicodeSymbol}"
                };
                Card six = new Card
                {
                    Id = $"6{suitId}",
                    Suit = suit,
                    CardType = CardType.Number,
                    Value = 6,
                    FullName = $"Six of {suit.ToString()}",
                    Symbol = $@"6{unicodeSymbol}"
                };
                Card seven = new Card
                {
                    Id = $"7{suitId}",
                    Suit = suit,
                    CardType = CardType.Number,
                    Value = 7,
                    FullName = $"Seven of {suit.ToString()}",
                    Symbol = $@"7{unicodeSymbol}"
                };
                Card eight = new Card
                {
                    Id = $"8{suitId}",
                    Suit = suit,
                    CardType = CardType.Number,
                    Value = 8,
                    FullName = $"Eight of {suit.ToString()}",
                    Symbol = $@"8{unicodeSymbol}"
                };
                Card nine = new Card
                {
                    Id = $"9{suitId}",
                    Suit = suit,
                    CardType = CardType.Number,
                    Value = 9,
                    FullName = $"Nine of {suit.ToString()}",
                    Symbol = $@"9{unicodeSymbol}"
                };
                Card ten = new Card
                {
                    Id = $"10{suitId}",
                    Suit = suit,
                    CardType = CardType.Number,
                    Value = 10,
                    FullName = $"Ten of {suit.ToString()}",
                    Symbol = $@"10{unicodeSymbol}"
                };
                Card jack = new Card
                {
                    Id = $"J{suitId}",
                    Suit = suit,
                    CardType = CardType.Jack,
                    Value = 10,
                    FullName = $"Jack of {suit.ToString()}",
                    Symbol = $@"J{unicodeSymbol}"
                };
                Card queen = new Card
                {
                    Id = $"Q{suitId}",
                    Suit = suit,
                    CardType = CardType.Queen,
                    Value = 10,
                    FullName = $"Queen of {suit.ToString()}",
                    Symbol = $"Q{unicodeSymbol}"
                };
                Card king = new Card
                {
                    Id = $"K{suitId}",
                    Suit = suit,
                    CardType = CardType.King,
                    Value = 10,
                    FullName = $"King of {suit.ToString()}",
                    Symbol = $"K{unicodeSymbol}"
                };

                Cards.Add(ace);
                Cards.Add(two);
                Cards.Add(three);
                Cards.Add(four);
                Cards.Add(five);
                Cards.Add(six);
                Cards.Add(seven);
                Cards.Add(eight);
                Cards.Add(nine);
                Cards.Add(ten);
                Cards.Add(jack);
                Cards.Add(queen);
                Cards.Add(king);
            }
        }
    }
}
