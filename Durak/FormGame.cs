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
        public FormGame(List<TextBox> names)
        {    
            foreach (var name in names)
            {
                Console.WriteLine(name);
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
            RefreshHands();
            RefreshTable();

            // вывод козыря
            var trumpCard = game.trump;
            var trumpCardName = trumpCard.Suit + '_' + trumpCard.Rank;
            PictureBox trump = new PictureBox();
            trump.Name = "trump";
            trump.Height = 80;
            trump.Width = 56;
            trump.Location = new Point(850, 120);
            trump.SizeMode = PictureBoxSizeMode.StretchImage;
            trump.Tag = trumpCard.Suit + "_" + trumpCard.Rank;
            trump.Image = cards[trumpCardName];
            Controls.Add(trump);



        }
        private void Card_Click(object sender, EventArgs e)
        {
            Console.WriteLine("клик");
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
                            currentRound.MoveAttacker(currentPlayer, card);
                            if (currentRound.CheckToss(card))
                            {
                                RefreshTable();
                            }
                            break;
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
        }

        private void newRoundButton_Click(object sender, EventArgs e)
        {
            currentPlayer = game.rounds[0].PassTurn(players, players.IndexOf(currentPlayer));
            var round = new Round(currentPlayer, players[(players.IndexOf(currentPlayer) + 1) % players.Count], game.trump);
            game.rounds.Add(round);
            currentRound = round;           
            currentRound.DrawCardsAfterRound(players, deck);
            RefreshHands();
            RefreshTable();
        }

        private void turnInRound_Click(object sender, EventArgs e)
        {
            // переход хода между аттакером и дефендером
            if (currentPlayer == game.rounds[0].attacker)
            {
                currentPlayer = players[(players.IndexOf(currentPlayer) + 1) % players.Count];
            }
            else
            {
                if (((players.IndexOf(currentPlayer) - 1) < 0)) currentPlayer = players[players.Count - 1];
                else currentPlayer = players[(players.IndexOf(currentPlayer) - 1) % players.Count];
            }
            RefreshHands();

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
        }

        private void RefreshTable()
        {
            if (currentPlayer == currentRound.attacker)
            {
                takeAllCards.Enabled = false;
            }
            else
            {
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
        }

        private void RefreshHands()
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix].Name != "trump")
                {
                    if (this.Controls[ix] is PictureBox) this.Controls[ix].Dispose();
                }
            }

            // Вывод рук игроков
            var cardDistanseX = 0;
            for (int i = 0; i < players.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        label1.Text = players[i].Name;
                        break;
                    case 1:
                        label2.Text = players[i].Name;
                        break;
                }
                if (i != 0 && i != 3)
                {
                    cardDistanseX += 30;
                }
                if (i == 3)
                {
                    cardDistanseX = 0;
                }
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
                    if (i < 3)
                    {
                        imageCard.Location = new Point(15 + cardDistanseX, 15);
                    }
                    else
                    {
                        imageCard.Location = new Point(15 + cardDistanseX, 15 + 300);
                    }
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
            }

            foreach (PictureBox PictureCard in Controls.OfType<PictureBox>())
            {
                foreach (Card card in currentPlayer.Hand)
                {
                    var cardName = card.Suit + '_' + card.Rank;
                    if ((string)PictureCard.Tag == cardName) // Проверка на экземпляр карты
                    {
                        if (card != game.trump && card.Visible)
                        {
                            PictureCard.Click += Card_Click;
                        }
                    }
                }
            }
        }

        private void bitoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void takeAllCards_Click(object sender, EventArgs e)
        {

        }
    }
}
