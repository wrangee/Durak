using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        // сделать удаление поля
        private void addPlayer_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Count() < 6)
            {
                int newTextBoxY = 10; // начальная позиция верхнего TextBox

                foreach (Control control in Controls)
                {
                    if (control is TextBox textbox)
                    {
                        int bottomPos = textbox.Location.Y + textbox.Size.Height;
                        if (bottomPos > newTextBoxY)
                        {
                            newTextBoxY = bottomPos + 10;
                        }
                    }
                }

                // Создаем новый экземпляр TextBox
                TextBox newTextBox = new TextBox();
                // Устанавливаем размер и позицию нового TextBox
                newTextBox.Location = new System.Drawing.Point(12, newTextBoxY);
                newTextBox.Size = new System.Drawing.Size(173, 20);
                // Добавляем новый TextBox на форму
                Controls.Add(newTextBox);

                // Увеличиваем высоту формы на высоту нового TextBox плюс небольшой отступ
                Height += newTextBox.Size.Height + 10;

                // Размещаем кнопку addPlayer под последним добавленным TextBox
                startGame.Location = new System.Drawing.Point(110, newTextBoxY + newTextBox.Size.Height + 10);
                addPlayer.Location = new System.Drawing.Point(12, newTextBoxY + newTextBox.Size.Height + 10);
            }
            else
            {
                MessageBox.Show("Нельзя добавить больше 6 TextBox.");
            }
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            var textBoxes = Controls.OfType<TextBox>().Where(tb => string.IsNullOrEmpty(tb.Text)).ToList();
            if (textBoxes.Any())
            {
                MessageBox.Show("Заполните необходимое(-ые) поле(-я)");
                return;
            }
            var players = Controls.OfType<TextBox>().ToList();
            // Создаем новую форму FormGame
            FormGame formGame = new FormGame(players);

            // Передаем значения из TextBox в FormGame

            this.Hide();
            // Открываем новую форму FormGame
            formGame.ShowDialog();

            // Скрываем текущую
        }
    }
}
