namespace Durak
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cardTable = new System.Windows.Forms.DataGridView();
            this.first = new System.Windows.Forms.DataGridViewImageColumn();
            this.sec = new System.Windows.Forms.DataGridViewImageColumn();
            this.thried = new System.Windows.Forms.DataGridViewImageColumn();
            this.four = new System.Windows.Forms.DataGridViewImageColumn();
            this.five = new System.Windows.Forms.DataGridViewImageColumn();
            this.six = new System.Windows.Forms.DataGridViewImageColumn();
            this.newRoundButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.turnInRound = new System.Windows.Forms.Button();
            this.bitoButton = new System.Windows.Forms.Button();
            this.takeAllCards = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cardTable
            // 
            this.cardTable.AllowUserToAddRows = false;
            this.cardTable.AllowUserToDeleteRows = false;
            this.cardTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.cardTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cardTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.first,
            this.sec,
            this.thried,
            this.four,
            this.five,
            this.six});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cardTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.cardTable.EnableHeadersVisualStyles = false;
            this.cardTable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.cardTable.Location = new System.Drawing.Point(143, 112);
            this.cardTable.Name = "cardTable";
            this.cardTable.ReadOnly = true;
            this.cardTable.RowHeadersVisible = false;
            this.cardTable.RowTemplate.Height = 80;
            this.cardTable.Size = new System.Drawing.Size(434, 185);
            this.cardTable.TabIndex = 0;
            // 
            // first
            // 
            this.first.FillWeight = 54.20502F;
            this.first.HeaderText = "first";
            this.first.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.first.Name = "first";
            this.first.ReadOnly = true;
            this.first.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.first.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.first.Width = 56;
            // 
            // sec
            // 
            this.sec.FillWeight = 64.89226F;
            this.sec.HeaderText = "sec";
            this.sec.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.sec.Name = "sec";
            this.sec.ReadOnly = true;
            this.sec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sec.Width = 56;
            // 
            // thried
            // 
            this.thried.FillWeight = 79.82404F;
            this.thried.HeaderText = "thried";
            this.thried.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.thried.Name = "thried";
            this.thried.ReadOnly = true;
            this.thried.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thried.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.thried.Width = 56;
            // 
            // four
            // 
            this.four.FillWeight = 100.6862F;
            this.four.HeaderText = "four";
            this.four.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.four.Name = "four";
            this.four.ReadOnly = true;
            this.four.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.four.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.four.Width = 56;
            // 
            // five
            // 
            this.five.FillWeight = 129.8341F;
            this.five.HeaderText = "five";
            this.five.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.five.Name = "five";
            this.five.ReadOnly = true;
            this.five.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.five.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.five.Width = 56;
            // 
            // six
            // 
            this.six.FillWeight = 170.5583F;
            this.six.HeaderText = "six";
            this.six.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.six.Name = "six";
            this.six.ReadOnly = true;
            this.six.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.six.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.six.Width = 56;
            // 
            // newRoundButton
            // 
            this.newRoundButton.Location = new System.Drawing.Point(774, 112);
            this.newRoundButton.Name = "newRoundButton";
            this.newRoundButton.Size = new System.Drawing.Size(130, 23);
            this.newRoundButton.TabIndex = 1;
            this.newRoundButton.Text = "переход хода общий";
            this.newRoundButton.UseVisualStyleBackColor = true;
            this.newRoundButton.Click += new System.EventHandler(this.newRoundButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // turnInRound
            // 
            this.turnInRound.Location = new System.Drawing.Point(583, 112);
            this.turnInRound.Name = "turnInRound";
            this.turnInRound.Size = new System.Drawing.Size(185, 23);
            this.turnInRound.TabIndex = 4;
            this.turnInRound.Text = "переход хода между двумя";
            this.turnInRound.UseVisualStyleBackColor = true;
            this.turnInRound.Click += new System.EventHandler(this.turnInRound_Click);
            // 
            // bitoButton
            // 
            this.bitoButton.Location = new System.Drawing.Point(584, 153);
            this.bitoButton.Name = "bitoButton";
            this.bitoButton.Size = new System.Drawing.Size(75, 23);
            this.bitoButton.TabIndex = 5;
            this.bitoButton.Text = "Бито";
            this.bitoButton.UseVisualStyleBackColor = true;
            this.bitoButton.Click += new System.EventHandler(this.bitoButton_Click);
            // 
            // takeAllCards
            // 
            this.takeAllCards.Location = new System.Drawing.Point(709, 153);
            this.takeAllCards.Name = "takeAllCards";
            this.takeAllCards.Size = new System.Drawing.Size(75, 23);
            this.takeAllCards.TabIndex = 6;
            this.takeAllCards.Text = "Взять";
            this.takeAllCards.UseVisualStyleBackColor = true;
            this.takeAllCards.Click += new System.EventHandler(this.takeAllCards_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 450);
            this.Controls.Add(this.takeAllCards);
            this.Controls.Add(this.bitoButton);
            this.Controls.Add(this.turnInRound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newRoundButton);
            this.Controls.Add(this.cardTable);
            this.Name = "FormGame";
            this.Text = "Дурак";
            ((System.ComponentModel.ISupportInitialize)(this.cardTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cardTable;
        private System.Windows.Forms.Button newRoundButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button turnInRound;
        private System.Windows.Forms.DataGridViewImageColumn first;
        private System.Windows.Forms.DataGridViewImageColumn sec;
        private System.Windows.Forms.DataGridViewImageColumn thried;
        private System.Windows.Forms.DataGridViewImageColumn four;
        private System.Windows.Forms.DataGridViewImageColumn five;
        private System.Windows.Forms.DataGridViewImageColumn six;
        private System.Windows.Forms.Button bitoButton;
        private System.Windows.Forms.Button takeAllCards;
    }
}