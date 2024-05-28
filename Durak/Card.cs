using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    internal class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public bool Visible { get; set; }

        public Card(string suit, string rank, bool visible)
        {
            this.Suit = suit;
            this.Rank = rank;
            this.Visible = visible;
        }

        public int GetCardValue(string rank)
        {
            Console.WriteLine(rank);
            if (int.TryParse(rank, out int value))
            {
                return value;  // для числовых рангов, например "6", "7", "8"
            }
            else
            {
                // Присваиваем числовое значение для буквенных рангов
                switch (rank)
                {
                    case "J":
                        return 11;
                    case "Q":
                        return 12;
                    case "K":
                        return 13;
                    case "A":
                        return 14;
                    default:
                        return -1;  // если ранг не распознан
                }
            }
        }
    }
}
