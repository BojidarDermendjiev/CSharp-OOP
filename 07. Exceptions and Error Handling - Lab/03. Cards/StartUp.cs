namespace _03._Cards
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    internal class StartUp
    {
        static void Main()
        {
            List<Card> card = new List<Card>();
            string[] drawnCards = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int currentHand = 0; currentHand < drawnCards.Length; currentHand++)
            {
                string face = drawnCards[currentHand].Split().First();
                string suit = drawnCards[currentHand].Split().Last();
                try
                {
                    card.Add(CreateCard(face, suit));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine(String.Join(" ", card));
        }

        private static Card CreateCard(string face, string suit)
        {
            string[] validFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] validSuit = new string[] { "S", "H", "D", "C" };
            if (!validFaces.Contains(face) || !validSuit.Contains(suit))
                throw new ArgumentException("Invalid card!");
            string utfSuit = string.Empty;
            switch (suit)
            {
                case "S":
                    utfSuit = "\u2660"; 
                    break;
                case "H": 
                    utfSuit = "\u2665";
                    break;
                case "D": 
                    utfSuit = "\u2666";
                    break;
                case "C": 
                    utfSuit = "\u2663"; 
                    break;
            }
            return new Card(face, utfSuit);
        }
    }
    public class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }
        public override string ToString() => $"[{Face}{Suit}]";
    }
}