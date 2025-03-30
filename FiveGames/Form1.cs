using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveGames
{
    public partial class Game_Menu : Form
    {
        public int game_decider;
        public Game_Menu()
        {
            InitializeComponent();
        }

        private void Sudoku_Btn_Click(object sender, EventArgs e)
        {
            var window1 = new Sudoku();
            window1.Show();
        }

        private void twenty_btn_Click(object sender, EventArgs e)
        {
            var window2 = new _2048();
            window2.Show();
        }

        private void Tictactoe_btn_Click(object sender, EventArgs e)
        {
            var window3 = new Tic_Tac_Toe();
            window3.Show();
        }

        private void Hangman_btn_Click(object sender, EventArgs e)
        {
            var window4 = new Hangman();
            window4.Show();
        }

        private void Crossword_btn_Click(object sender, EventArgs e)
        {
            var window5 = new Crossword();
            window5.Show();
        }
    }
}
