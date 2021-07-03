using System;
using System.Collections.Generic;

namespace Program
{
    public class DeckOfCards
    {
        private string[] SuitCard = new string[4] { "Буби", "Крести", "Черви", "Пики" };
        private string[] ValueCard = new string[9] { "Шесть", "Семь", "Восемь", "Девять", "Десять", "Валет", "Дама", "Король", "Туз" };
        public List<string> Deck = new List<string>();
        public Dictionary<string, int> PointForValue = new Dictionary<string, int>();
        
        private void CreateDeck()
        {
            foreach (string Suit in SuitCard)
            {
                foreach (string Value in ValueCard)
                {
                    Deck.Add($"{Value} {Suit}");
                }
            }
        }
        private void CreatePointForValue()
        {
            foreach(string Card in Deck)
            {
                if (Card.Contains("Шесть"))
                {
                    PointForValue.Add(Card, 6);
                    continue;
                }
                if (Card.Contains("Семь"))
                {
                    PointForValue.Add(Card, 7);
                    continue;
                }
                if (Card.Contains("Восемь"))
                {
                    PointForValue.Add(Card, 8);
                    continue;
                }
                if (Card.Contains("Девять"))
                {
                    PointForValue.Add(Card, 9);
                    continue;
                }
                if (Card.Contains("Десять"))
                {
                    PointForValue.Add(Card, 10);
                    continue;
                }
                if (Card.Contains("Валет"))
                {
                    PointForValue.Add(Card, 2);
                    continue;
                }
                if (Card.Contains("Дама"))
                {
                    PointForValue.Add(Card, 3);
                    continue;
                }
                if (Card.Contains("Король"))
                {
                    PointForValue.Add(Card, 4);
                    continue;
                }
                if (Card.Contains("Туз"))
                {
                    PointForValue.Add(Card, 11);
                    continue;
                }


            }
        }

        public int getPlusPoint(string ValueCard)
        {
            return PointForValue[ValueCard];
        }

        public string getCard()
        {
            var rnd = new Random();
            string Card = Deck[rnd.Next(0, Deck.Count-1)];
            Deck.Remove(Card);
            return Card;
        }

        public DeckOfCards()
        {
            CreateDeck();
            CreatePointForValue();

        }
    }
}



