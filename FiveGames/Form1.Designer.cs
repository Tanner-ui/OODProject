namespace FiveGames
{
    partial class Game_Menu
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
            this.Sudoku_Btn = new System.Windows.Forms.Button();
            this.twenty_btn = new System.Windows.Forms.Button();
            this.Tictactoe_btn = new System.Windows.Forms.Button();
            this.Hangman_btn = new System.Windows.Forms.Button();
            this.Crossword_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sudoku_Btn
            // 
            this.Sudoku_Btn.Location = new System.Drawing.Point(45, 67);
            this.Sudoku_Btn.Name = "Sudoku_Btn";
            this.Sudoku_Btn.Size = new System.Drawing.Size(197, 102);
            this.Sudoku_Btn.TabIndex = 0;
            this.Sudoku_Btn.Text = "Sudoku";
            this.Sudoku_Btn.UseVisualStyleBackColor = true;
            this.Sudoku_Btn.Click += new System.EventHandler(this.Sudoku_Btn_Click);
            // 
            // twenty_btn
            // 
            this.twenty_btn.Location = new System.Drawing.Point(42, 309);
            this.twenty_btn.Name = "twenty_btn";
            this.twenty_btn.Size = new System.Drawing.Size(200, 104);
            this.twenty_btn.TabIndex = 1;
            this.twenty_btn.Text = "2048";
            this.twenty_btn.UseVisualStyleBackColor = true;
            this.twenty_btn.Click += new System.EventHandler(this.twenty_btn_Click);
            // 
            // Tictactoe_btn
            // 
            this.Tictactoe_btn.Location = new System.Drawing.Point(523, 67);
            this.Tictactoe_btn.Name = "Tictactoe_btn";
            this.Tictactoe_btn.Size = new System.Drawing.Size(200, 102);
            this.Tictactoe_btn.TabIndex = 2;
            this.Tictactoe_btn.Text = "Tic-Tac-Toe";
            this.Tictactoe_btn.UseVisualStyleBackColor = true;
            this.Tictactoe_btn.Click += new System.EventHandler(this.Tictactoe_btn_Click);
            // 
            // Hangman_btn
            // 
            this.Hangman_btn.Location = new System.Drawing.Point(519, 311);
            this.Hangman_btn.Name = "Hangman_btn";
            this.Hangman_btn.Size = new System.Drawing.Size(204, 102);
            this.Hangman_btn.TabIndex = 3;
            this.Hangman_btn.Text = "Hangman";
            this.Hangman_btn.UseVisualStyleBackColor = true;
            this.Hangman_btn.Click += new System.EventHandler(this.Hangman_btn_Click);
            // 
            // Crossword_btn
            // 
            this.Crossword_btn.Location = new System.Drawing.Point(276, 192);
            this.Crossword_btn.Name = "Crossword_btn";
            this.Crossword_btn.Size = new System.Drawing.Size(204, 102);
            this.Crossword_btn.TabIndex = 4;
            this.Crossword_btn.Text = "Crossword";
            this.Crossword_btn.UseVisualStyleBackColor = true;
            this.Crossword_btn.Click += new System.EventHandler(this.Crossword_btn_Click);
            // 
            // Game_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Crossword_btn);
            this.Controls.Add(this.Hangman_btn);
            this.Controls.Add(this.Tictactoe_btn);
            this.Controls.Add(this.twenty_btn);
            this.Controls.Add(this.Sudoku_Btn);
            this.Name = "Game_Menu";
            this.Text = "Game Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sudoku_Btn;
        private System.Windows.Forms.Button twenty_btn;
        private System.Windows.Forms.Button Tictactoe_btn;
        private System.Windows.Forms.Button Hangman_btn;
        private System.Windows.Forms.Button Crossword_btn;
    }
}

