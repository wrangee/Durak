using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Durak
{
    public partial class FormGame : Form
    {
        private Dictionary<string, Bitmap> cards = new Dictionary<string, Bitmap>()
        {
            ["Clubs_6"] = Properties.Resources.Clubs_6,
            ["Clubs_7"] = Properties.Resources.Clubs_7,
            ["Clubs_8"] = Properties.Resources.Clubs_8,
            ["Clubs_9"] = Properties.Resources.Clubs_9,
            ["Clubs_10"] = Properties.Resources.Clubs_10,
            ["Clubs_J"] = Properties.Resources.Clubs_J,
            ["Clubs_Q"] = Properties.Resources.Clubs_Q,
            ["Clubs_K"] = Properties.Resources.Clubs_K,
            ["Clubs_A"] = Properties.Resources.Clubs_A,
            ["Diamonds_6"] = Properties.Resources.Diamonds_6,
            ["Diamonds_7"] = Properties.Resources.Diamonds_7,
            ["Diamonds_8"] = Properties.Resources.Diamonds_8,
            ["Diamonds_9"] = Properties.Resources.Diamonds_9,
            ["Diamonds_10"] = Properties.Resources.Diamonds_10,
            ["Diamonds_J"] = Properties.Resources.Diamonds_J,
            ["Diamonds_Q"] = Properties.Resources.Diamonds_Q,
            ["Diamonds_K"] = Properties.Resources.Diamonds_K,
            ["Diamonds_A"] = Properties.Resources.Diamonds_A,
            ["Hearts_6"] = Properties.Resources.Hearts_6,
            ["Hearts_7"] = Properties.Resources.Hearts_7,
            ["Hearts_8"] = Properties.Resources.Hearts_8,
            ["Hearts_9"] = Properties.Resources.Hearts_9,
            ["Hearts_10"] = Properties.Resources.Hearts_10,
            ["Hearts_J"] = Properties.Resources.Hearts_J,
            ["Hearts_Q"] = Properties.Resources.Hearts_Q,
            ["Hearts_K"] = Properties.Resources.Hearts_K,
            ["Hearts_A"] = Properties.Resources.Hearts_A,
            ["Spades_6"] = Properties.Resources.Spades_6,
            ["Spades_7"] = Properties.Resources.Spades_7,
            ["Spades_8"] = Properties.Resources.Spades_8,
            ["Spades_9"] = Properties.Resources.Spades_9,
            ["Spades_10"] = Properties.Resources.Spades_10,
            ["Spades_J"] = Properties.Resources.Spades_J,
            ["Spades_Q"] = Properties.Resources.Spades_Q,
            ["Spades_K"] = Properties.Resources.Spades_K,
            ["Spades_A"] = Properties.Resources.Spades_A,
            ["back"] = Properties.Resources.back,
            ["Clubs"] = Properties.Resources.Clubs,
            ["Diamonds"] = Properties.Resources.Diamonds,
            ["Hearts"] = Properties.Resources.Hearts,
            ["Spides"] = Properties.Resources.Spides,
            ["Empty"] = Properties.Resources.Empty,
        };
        Game game = new Game();
        List<Player> players;
        List<Round> rounds;
        Player currentPlayer;
        Round currentRound;
        Deck deck;
        int bitoCounter = 0;
        PictureBox trump = new PictureBox();
        PictureBox backCard = new PictureBox();
        Label deckCount = new Label();
        Player winner;
        Player durak;
        public FormGame(List<TextBox> names)
        {    
            foreach (var name in names)
            {
                game.AddPlayer(name.Text);
            }
            InitializeComponent();
            game.DealCards();
            this.players = game.players;
            game.StartGame();
            this.rounds = game.rounds;
            this.currentPlayer = rounds[0].attacker;
            this.currentRound = rounds[0];
            this.deck = game.deck;
            for (int i = 0; i < players.Count; i++)
            {
                if (i >= 2)
                {
                    Height += 115;
                    cardTable.Location = new Point(cardTable.Location.X, cardTable.Location.Y + 60);
                    turnInRound.Location = new Point(turnInRound.Location.X, turnInRound.Location.Y + 60);
                    bitoButton.Location = new Point(bitoButton.Location.X, bitoButton.Location.Y + 60);
                    takeAllCards.Location = new Point(takeAllCards.Location.X, takeAllCards.Location.Y + 60);
                }
            }

            RefreshHands();
            RefreshTable();

            backCard.Name = "backCard";
            backCard.Height = 56;
            backCard.Width = 80;
            backCard.Location = new Point(787, 30);
            backCard.SizeMode = PictureBoxSizeMode.StretchImage;
            backCard.Image = cards["back"];
            backCard.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Controls.Add(backCard);
            Controls.SetChildIndex(backCard, 1);

            // вывод козыря
            var trumpCard = game.trump;
            var trumpCardName = trumpCard.Suit + '_' + trumpCard.Rank;
            trump.Name = "trump";
            trump.Height = 80;
            trump.Width = 56;
            trump.Location = new Point(800, 35);
            trump.SizeMode = PictureBoxSizeMode.StretchImage;
            trump.Tag = trumpCard.Suit + "_" + trumpCard.Rank;
            trump.Image = cards[trumpCardName];
            Controls.Add(trump);

            deckCount.Name = "deckCount";
            deckCount.Location = new Point(780, 5);
            Controls.Add(deckCount);
            Controls.SetChildIndex(deckCount, 0);
        }
        private void Card_Click(object sender, EventArgs e)
        {
            string pickedCard = (string)((PictureBox)sender).Tag;
            Bitmap cardPicture = cards[pickedCard];
            foreach (Card card in currentPlayer.Hand)
            {
                var cardName = card.Suit + '_' + card.Rank;
                if (pickedCard == cardName) // Проверка на экземпляр карты
                {                   
                    if (currentPlayer == currentRound.attacker)
                    {
                        if (currentRound.CardsPairs.Count == 0)
                        {
                            currentRound.Play(currentPlayer, card);                            
                            RefreshTable();
                            break;
                        }
                        else
                        {
                            if (currentRound.defender.Hand.Count != 0)
                            {
                                currentRound.MoveAttacker(currentPlayer, card);
                                if (currentRound.CheckToss(card))
                                {
                                    RefreshTable();
                                }
                                break;
                            }
                        }
                    }
                    else if (currentPlayer == currentRound.defender)
                    {
                        var attackCard = currentRound.CardsPairs.Last().Key;
                        foreach (var pair in currentRound.CardsPairs)
                        {
                            if (pair.Value == null)
                            {
                                attackCard = pair.Key;
                                break;
                            }
                        }
                        currentRound.MoveDefender(attackCard, card, game.trump);
                        if (currentRound.CheckHit(attackCard, card, game.trump))
                        {
                            RefreshTable();
                        }
                        break;
                    }
                }
            }

            if (currentPlayer.Hand.Count == 0)
            {
                players.Remove(currentPlayer);
                if (winner == null)
                {
                    winner = currentPlayer;
                }
                if (currentPlayer == currentRound.defender)
                {
                    currentPlayer = players[(players.IndexOf(currentPlayer) + 1) % players.Count];

                    var round = new Round(currentPlayer, players[(players.IndexOf(currentPlayer) + 1) % players.Count], game.trump);
                    game.rounds.Add(round);
                    currentRound = round;
                    if (deck.Cards.Count > 0)
                    {
                        currentRound.DrawCardsAfterRound(players, deck);
                    }
                    RefreshHands();
                    RefreshTable();
                    bitoCounter = 0;
                }
                if (currentPlayer == currentRound.attacker)
                {
                    currentPlayer = currentRound.defender;
                    currentRound.attacker = players[(players.IndexOf(currentPlayer) + 1) % players.Count];
                    RefreshHands();
                    RefreshTable();
                    bitoButton.Enabled = false;
                    takeAllCards.Enabled = true;
                }
            } 
            if (players.Count == 1)
            {
                durak = players[0];
                MessageBox.Show("Победа присуждается игроку: " + winner.Name + "\n" + "Дураком становистя: " + durak.Name);
            }

            RefreshHands();
        }

        private void turnInRound_Click(object sender, EventArgs e)
        {
            if (currentPlayer == currentRound.attacker)
            {
                currentPlayer = currentRound.defender;
            }
            else
            {
                currentPlayer = currentRound.attacker;
            }
            RefreshHands();
            RefreshTable();
            if (currentPlayer == currentRound.attacker)
            {
                bitoButton.Enabled = true;
                takeAllCards.Enabled = false;
            }
            else
            {
                bitoButton.Enabled = false;
                takeAllCards.Enabled = true;
            }
            bitoCounter = 0;
        }

        private void RefreshTable()
        {
            if (currentPlayer == currentRound.attacker)
            {
                if (currentRound.CardsPairs.Count == 0)
                {
                    turnInRound.Enabled = false;
                    bitoButton.Enabled = false;
                }
                else
                {
                    foreach (var pair in currentRound.CardsPairs)
                    {
                        if (pair.Value == null)
                        {
                            turnInRound.Enabled = true;
                            bitoButton.Enabled = false; // <-
                        }
                        else
                        {
                            turnInRound.Enabled = false;
                            bitoButton.Enabled = true; // <-
                        }
                    }
                }
                takeAllCards.Enabled = false;
            }
            else
            {
                foreach (var pair in currentRound.CardsPairs)
                {
                    if (pair.Value == null)
                    {
                        turnInRound.Enabled = false;
                    }
                    else
                    {
                        turnInRound.Enabled = true;
                    }
                }
                takeAllCards.Enabled = true;
            }

            cardTable.Rows.Clear();

            while (cardTable.RowCount < 2)
            {
                cardTable.Rows.Add(cards["Empty"], cards["Empty"], cards["Empty"], cards["Empty"], cards["Empty"], cards["Empty"]);
            }

            var cardNameKey = "";
            var cardNameValue = "";

            for (int i = 0; i < currentRound.CardsPairs.Count; i++)
            {
                var card = currentRound.CardsPairs.ElementAt(i);
                cardNameKey = card.Key.Suit + '_' + card.Key.Rank;
                if (card.Value != null)
                {
                    cardNameValue = card.Value.Suit + '_' + card.Value.Rank;
                }
                else
                {
                    cardNameValue = "Empty";
                }
                cardTable.Rows[0].Cells[i].Value = cards[cardNameKey];
                cardTable.Rows[1].Cells[i].Value = cards[cardNameValue];                
            }

            var deckC = deck.Cards.Count;
            deckCount.Text = "Карт осталось: " + deckC.ToString();

            UpdateLenElements();
        }

        private void RefreshHands()
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix].Name != "trump" &&  this.Controls[ix].Name != "backCard")
                {
                    if (this.Controls[ix] is PictureBox) this.Controls[ix].Dispose();
                }
            }

            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix].Name != "deckCount")
                {
                    if (this.Controls[ix] is Label) this.Controls[ix].Dispose();
                }
            }

            // Вывод рук игроков
            var cardDistanseY = 0;
            for (int i = 0; i < players.Count; i++)
            {
                var label = new Label();
                var cardDistanseX = 0;
                label.Text = players[i].Name;
                label.Location = new Point(10, 5 + cardDistanseY);
                Controls.Add(label);
                foreach (Card card in players[i].Hand)
                {
                    if (players[i] == currentPlayer)
                    {
                        card.Visible = true;
                    }
                    else
                    {
                        card.Visible = false;
                    }
                    var cardName = card.Suit + '_' + card.Rank;
                    PictureBox imageCard = new PictureBox();
                    imageCard.Height = 80;
                    imageCard.Width = 56;
                    imageCard.Location = new Point(15 + cardDistanseX, 30 + cardDistanseY);
                    imageCard.SizeMode = PictureBoxSizeMode.StretchImage;
                    imageCard.Tag = card.Suit + "_" + card.Rank;
                    if (card.Visible)
                    {
                        imageCard.Image = cards[cardName];
                    }
                    else
                    {
                        imageCard.Image = cards["back"];
                    }
                    Controls.Add(imageCard);
                    cardDistanseX += 60;
                }
                cardDistanseY += 120;                
            }

            foreach (PictureBox PictureCard in Controls.OfType<PictureBox>())
            {
                foreach (Card card in currentPlayer.Hand)
                {
                    var cardName = card.Suit + '_' + card.Rank;
                    if ((string)PictureCard.Tag == cardName) // Проверка на экземпляр карты
                    {
                        if (PictureCard.Name != "trump" && card.Visible)
                        {
                            PictureCard.Click += Card_Click;
                        }
                    }
                }
            }
        }

        private void bitoButton_Click(object sender, EventArgs e)
        {
            bitoCounter++;
            if (bitoCounter < players.Count - 1)
            {
                currentPlayer = players[(players.IndexOf(currentPlayer) + 1) % players.Count];
                if (currentPlayer != currentRound.defender)
                {
                    currentRound.attacker = currentPlayer;
                }
                else
                {
                    currentPlayer = players[(players.IndexOf(currentPlayer) + 1) % players.Count];
                    currentRound.attacker = currentPlayer;
                }
                RefreshHands();
                RefreshTable();
            }
            else
            {
                currentPlayer = currentRound.defender;

                var round = new Round(currentPlayer, players[(players.IndexOf(currentPlayer) + 1) % players.Count], game.trump);
                game.rounds.Add(round);
                currentRound = round;
                if (deck.Cards.Count > 0)
                {
                    currentRound.DrawCardsAfterRound(players, deck);
                }
                RefreshHands();
                RefreshTable();
                bitoCounter = 0;
            }
        }

        private void takeAllCards_Click(object sender, EventArgs e)
        {
            foreach (var card in currentRound.CardsPairs)
            {
                currentPlayer.AddCardToHand(card.Key);               
                if (card.Value != null)
                {
                    currentPlayer.AddCardToHand(card.Value);
                }
            }

            currentPlayer = currentRound.PassTurn(players, players.IndexOf(currentPlayer));

            var round = new Round(currentPlayer, players[(players.IndexOf(currentPlayer) + 1) % players.Count], game.trump);
            game.rounds.Add(round);
            currentRound = round;
            if (deck.Cards.Count > 0)
            {
                currentRound.DrawCardsAfterRound(players, deck);
            }
            RefreshHands();
            RefreshTable();
            bitoCounter = 0;
        }

        private void UpdateLenElements()
        {
            var maxCardsPlayers = 6;
            foreach (var player in players)
            {
                if (player.Hand.Count > maxCardsPlayers && player.Hand.Count >= 6)
                {
                    maxCardsPlayers = player.Hand.Count;
                }
            }
            Console.WriteLine(maxCardsPlayers);
            if (maxCardsPlayers > 5)
            {
                cardTable.Location = new Point(413 + (maxCardsPlayers - 6) * 56, cardTable.Location.Y);
                Width = 937 + (maxCardsPlayers - 6) * 56;
                turnInRound.Location = new Point(413 + (maxCardsPlayers - 6) * 56, turnInRound.Location.Y);
                bitoButton.Location = new Point(585 + (maxCardsPlayers - 6) * 56, bitoButton.Location.Y);
                takeAllCards.Location = new Point(684 + (maxCardsPlayers - 6) * 56, takeAllCards.Location.Y);
                trump.Location = new Point(800 + (maxCardsPlayers - 6) * 56, trump.Location.Y);
                backCard.Location = new Point(787 + (maxCardsPlayers - 6) * 56, backCard.Location.Y);
                deckCount.Location = new Point(780 + (maxCardsPlayers - 6) * 56, deckCount.Location.Y);
            }
        }

        private Player NextPlayer(List<Player> players, Player player)
        {
            return players[(players.IndexOf(currentPlayer) + 1) % players.Count];
        }
    }
}
