using System.IO.Compression;

namespace GameOfWar
{
    public class Card
    {

        // Create a string property Suit with a private setter
        public string Suit {get ; private set;}

        // Create an int property Rank with a private setter - values should range from 0 for a face value of 2 to 12 for an Ace
        public int Rank {get; private set;}

        // Create a public constructor that takes suit and rank as arguments and assigns them to Suit and Rank
        public Card(string suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }

        // Overload the > operator to compare two cards by rank
        public static bool operator >(Card a, Card b)
        {
            return a.Rank > b.Rank;
        }

        // Overload the < operator to compare two cards by rank
        public static bool operator <(Card a, Card b)
        {
            return a.Rank < b.Rank;
        }

        // Create a public string method RankString that returns a string representation of this card's rank, 2-10 and Jack, Queen, King, Ace
        public string RankString()
        {
            if (Rank >= 2 && Rank <= 10)
            {
                return $"{Rank}";
            }
            switch (Rank)
            {
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13: 
                    return "King";
                case 14:
                    return "Ace";
            }

            return "Invalid";
        }
    }
}