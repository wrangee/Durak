﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    internal class Round
    {
        public Player attacker;
        public Player defender;
        public bool isBitten;
        public Dictionary<Card, Card> CardsPairs;

        public Round(Player attacker, Player defender, Card trump)
        {
            this.attacker = attacker;
            this.defender = defender;
            this.isBitten = false;
            this.CardsPairs = new Dictionary<Card, Card>();
        }

        public void AddCardPair(Card attackCard, Card defenseCard)
        {
            CardsPairs.Add(attackCard, defenseCard);
        }

        public bool CheckHit(Card attackCard, Card defenseCard, Card trump)
        {
            if ((attackCard.GetCardValue(attackCard.Rank) < defenseCard.GetCardValue(attackCard.Rank) && attackCard.Suit == defenseCard.Suit) || (defenseCard.Suit == trump.Suit && attackCard.Suit != trump.Suit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckToss(Card attackCard)
        {
            bool matchingСards = false;
            foreach (var pair in CardsPairs)
            {
                if (attackCard.GetCardValue(attackCard.Rank) == pair.Key.GetCardValue(attackCard.Rank) || attackCard.GetCardValue(attackCard.Rank) == pair.Value.GetCardValue(attackCard.Rank))
                {
                    matchingСards |= true;              
                }
            }
            return matchingСards;
        }

        public void MoveAttacker(Player attacker, Card attackCard)
        {
            if (CheckToss(attackCard))
            {
                AddCardPair(attacker.Toss(attackCard), null);
            }
        }

        public void MoveDefender(Card attackCard, Card defenseCard, Card trump)
        {
            if (CheckHit(attackCard, defenseCard, trump))
            {
                AddCardPair(attackCard, attacker.Hit(defenseCard));
            }
        }

        public void Play()
        {
            // описание
        }

        public void DrawCardsAfterRound(List<Player> players, Deck deck)
        {
            int cardsToDraw = 6;
            foreach (Player player in players)
            {
                // Проверяем, нужно ли игроку добирать карты
                if (player.Hand.Count < cardsToDraw)
                {
                    int cardsNeeded = cardsToDraw - player.Hand.Count;
                    for (int i = 0; i < cardsNeeded; i++)
                    {
                        Card drawnCard = deck.Deal();
                        player.AddCardToHand(drawnCard);
                    }
                }
            }
        }

        public Player PassTurn(List<Player> players, int currentPlayer)
        {
            // Передаем ход следующему игроку
            currentPlayer = (currentPlayer + 1) % players.Count;
            return players[currentPlayer];
        }

        public Player DetermineAttacker(List<Player> players, Player lastAttacker)
        {
            if (lastAttacker == null)
            {
                // Если последнего атакующего нет (например, в начале игры), то первый игрок начинает атаку
                return players[0];
            }
            else
            {
                // Находим индекс последнего атакующего игрока
                int lastIndex = players.IndexOf(lastAttacker);

                // Определяем следующего игрока, который должен атаковать
                int nextIndex = (lastIndex + 1) % players.Count;
                return players[nextIndex];
            }
        }

        public Player DetermineWinner()
        {
            if (isBitten)
            {
                return defender;
            }
            else
            {
                return attacker;
            }
        }
    }
}
