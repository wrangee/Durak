namespace Durak
{
    partial class FormRegister
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addPlayer = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeletePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 22);
            this.textBox1.TabIndex = 1;
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(16, 121);
            this.addPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(123, 28);
            this.addPlayer.TabIndex = 1;
            this.addPlayer.Text = "Добавить еще";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(253, 121);
            this.startGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(100, 28);
            this.startGame.TabIndex = 2;
            this.startGame.Text = "Начать";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 46);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 22);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите имена игроков";
            // 
            // DeletePlayer
            // 
            this.DeletePlayer.Location = new System.Drawing.Point(147, 121);
            this.DeletePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeletePlayer.Name = "DeletePlayer";
            this.DeletePlayer.Size = new System.Drawing.Size(100, 28);
            this.DeletePlayer.TabIndex = 5;
            this.DeletePlayer.Text = "Удалить";
            this.DeletePlayer.UseVisualStyleBackColor = true;
            this.DeletePlayer.Click += new System.EventHandler(this.DeletePlayer_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 178);
            this.Controls.Add(this.DeletePlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация участников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeletePlayer;
    }
}

