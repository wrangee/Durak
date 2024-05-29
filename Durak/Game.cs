using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Durak
{
    internal class Game
    {
        public Deck deck;
        public List<Player> players;
        public List<Round> rounds;
        public Card trump;
        public Game()
        {
            this.deck = new Deck();
            this.players = new List<Player>();
            this.rounds = new List<Round>();
            this.trump = deck.Cards[deck.Cards.Count - 1];
        }

        public void AddPlayer(string name)
        {
            var player = new Player(name);
            players.Add(player);
        }

        public void DealCards() // раздача карт
        {
            int numCardsToDeal = 6;
            Card trump = deck.Cards[deck.Cards.Count - 1];
            foreach (var player in players)
            {
                for (int i = 0; i < numCardsToDeal; i++)
                {
                    Card card = deck.Deal();
                    player.AddCardToHand(card);
                }
            }
            //deck.Cards.Add(trump);
        }

        public Player DetermineWinner()
        {
            Player winner = null;
            foreach (Player player in players)
            {
                if (player.Hand.Count == 0)
                {
                    winner = player;
                    break;
                }
            }
            return winner;
        }

        public void StartGame()
        {
            // Определение козыря
            Random random = new Random();
            int randomIndex = random.Next(players.Count);
            var round = new Round(players[randomIndex], players[(randomIndex + 1) % players.Count], trump);
            rounds.Add(round);
        }


        public void EndGame()
        {
            // Определение победителя
        }
    }
}
