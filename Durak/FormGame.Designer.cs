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
            this.cardTable = new System.Windows.Forms.DataGridView();
            this.first = new System.Windows.Forms.DataGridViewImageColumn();
            this.sec = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cardTable
            // 
            this.cardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.first,
            this.sec});
            this.cardTable.Location = new System.Drawing.Point(339, 147);
            this.cardTable.Name = "cardTable";
            this.cardTable.Size = new System.Drawing.Size(472, 150);
            this.cardTable.TabIndex = 0;
            // 
            // first
            // 
            this.first.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first.HeaderText = "first";
            this.first.Name = "first";
            this.first.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.first.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sec
            // 
            this.sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sec.HeaderText = "sec";
            this.sec.Name = "sec";
            this.sec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "переход хода общий";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(858, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "переход хода между двумя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardTable);
            this.Name = "FormGame";
            this.Text = "Дурак";
            ((System.ComponentModel.ISupportInitialize)(this.cardTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cardTable;
        private System.Windows.Forms.DataGridViewImageColumn first;
        private System.Windows.Forms.DataGridViewImageColumn sec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}