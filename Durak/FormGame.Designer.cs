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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cardTable = new System.Windows.Forms.DataGridView();
            this.first = new System.Windows.Forms.DataGridViewImageColumn();
            this.sec = new System.Windows.Forms.DataGridViewImageColumn();
            this.thried = new System.Windows.Forms.DataGridViewImageColumn();
            this.four = new System.Windows.Forms.DataGridViewImageColumn();
            this.five = new System.Windows.Forms.DataGridViewImageColumn();
            this.six = new System.Windows.Forms.DataGridViewImageColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cardTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardTable.ColumnHeadersVisible = false;
            this.cardTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.first,
            this.sec,
            this.thried,
            this.four,
            this.five,
            this.six});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cardTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.cardTable.EnableHeadersVisualStyles = false;
            this.cardTable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.cardTable.Location = new System.Drawing.Point(413, 33);
            this.cardTable.Name = "cardTable";
            this.cardTable.ReadOnly = true;
            this.cardTable.RowHeadersVisible = false;
            this.cardTable.RowHeadersWidth = 51;
            this.cardTable.RowTemplate.Height = 80;
            this.cardTable.Size = new System.Drawing.Size(360, 185);
            this.cardTable.TabIndex = 0;
            // 
            // first
            // 
            this.first.FillWeight = 54.20502F;
            this.first.HeaderText = "first";
            this.first.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.first.MinimumWidth = 6;
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
            this.sec.MinimumWidth = 6;
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
            this.thried.MinimumWidth = 6;
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
            this.four.MinimumWidth = 6;
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
            this.five.MinimumWidth = 6;
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
            this.six.MinimumWidth = 6;
            this.six.Name = "six";
            this.six.ReadOnly = true;
            this.six.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.six.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.six.Width = 56;
            // 
            // turnInRound
            // 
            this.turnInRound.Location = new System.Drawing.Point(413, 224);
            this.turnInRound.Name = "turnInRound";
            this.turnInRound.Size = new System.Drawing.Size(147, 23);
            this.turnInRound.TabIndex = 4;
            this.turnInRound.Text = "Передать ход оппоненту";
            this.turnInRound.UseVisualStyleBackColor = true;
            this.turnInRound.Click += new System.EventHandler(this.turnInRound_Click);
            // 
            // bitoButton
            // 
            this.bitoButton.Location = new System.Drawing.Point(585, 224);
            this.bitoButton.Name = "bitoButton";
            this.bitoButton.Size = new System.Drawing.Size(75, 23);
            this.bitoButton.TabIndex = 5;
            this.bitoButton.Text = "Бито";
            this.bitoButton.UseVisualStyleBackColor = true;
            this.bitoButton.Click += new System.EventHandler(this.bitoButton_Click);
            // 
            // takeAllCards
            // 
            this.takeAllCards.Location = new System.Drawing.Point(684, 224);
            this.takeAllCards.Name = "takeAllCards";
            this.takeAllCards.Size = new System.Drawing.Size(69, 23);
            this.takeAllCards.TabIndex = 6;
            this.takeAllCards.Text = "Взять";
            this.takeAllCards.UseVisualStyleBackColor = true;
            this.takeAllCards.Click += new System.EventHandler(this.takeAllCards_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 268);
            this.Controls.Add(this.takeAllCards);
            this.Controls.Add(this.bitoButton);
            this.Controls.Add(this.turnInRound);
            this.Controls.Add(this.cardTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дурак";
            ((System.ComponentModel.ISupportInitialize)(this.cardTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cardTable;
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