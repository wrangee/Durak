using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public Player(string name)
        {
            this.Name = name;
            this.Hand = new List<Card>();
        }

        public void AddCardToHand(Card card)
        {
            Hand.Add(card);
        }

        public void RemoveCardFromHand(Card card)
        {
            Hand.Remove(card);
        }

        public Card Hit(Card defensecard) // Отбить карту
        {
            RemoveCardFromHand(defensecard);
            return defensecard;
        }

        public Card Toss(Card attackcard) // Подкинуть карту
        {
            RemoveCardFromHand(attackcard);
            return attackcard;
        }

        public Card MakeMove(Card attackcard)
        {
            RemoveCardFromHand(attackcard);
            return attackcard;
        }
    }
}
