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
        };
        Game game = new Game();
        int u = 1;
        private Point mouseOffset;
        private bool isDragging = false;
        private PictureBox draggedCard;

        public FormGame(List<TextBox> names)
        {    
            foreach (var name in names)
            {
                game.AddPlayer(name.Text);
            }
            InitializeComponent();
            game.DealCards();
            List<Player> players = game.players;

            // Вывод рук игроков
            var cardDistanseX = 0;
            for (int i = 0; i < players.Count; i++)
            {
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
            // вывод козыря
            var trumpCard = game.trump;
            var trumpCardName = trumpCard.Suit + '_' + trumpCard.Rank;
            PictureBox trump = new PictureBox();
            trump.Height = 80;
            trump.Width = 56;
            trump.Location = new Point(850, 120);
            trump.SizeMode = PictureBoxSizeMode.StretchImage;
            trump.Tag = trumpCard.Suit + "_" + trumpCard.Rank;
            trump.Image = cards[trumpCardName];
            Controls.Add(trump);


            foreach (PictureBox card in Controls.OfType<PictureBox>())
            {
                if (card != trump &&  !card.Visible)
                {                    
                    card.MouseDown += Card_MouseDown;                   
                    card.MouseMove += Card_MouseMove;
                    card.AllowDrop = true;
                }
            }
        }
        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pictureBox = (PictureBox)sender;
                pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Move);
            }
        }

        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pictureBox = (PictureBox)sender;
                pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Move);
            }
        }


        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void tableLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            ((TableLayoutPanel)sender).Controls.Add(pictureBox);
        }
    }
}
