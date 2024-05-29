using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak
{
    internal class Deck
    {
        public List<Card> Cards;

        public Deck()
        {
            Cards = new List<Card>();
            InitializeDeck();
            Shuffle();
        }

        private void InitializeDeck()
        {
            this.Cards = new List<Card>();

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    Card card = new Card(suits[i], ranks[j], false);
                    this.Cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int randomIndex = random.Next(i, Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[randomIndex];
                Cards[randomIndex] = temp;
            }
        }

        public Card Deal()
        {
            if (Cards.Count == 0)
            {
                MessageBox.Show("Карты закончились!");
            }

            Card dealtCard = Cards[0];
            Cards.RemoveAt(0);
            return dealtCard;
        }
    }
}
