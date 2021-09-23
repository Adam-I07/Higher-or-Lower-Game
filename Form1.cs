using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace higherANDlowerGame
{
    public partial class Form1 : Form
    {

        private int _guess;
        private int _random;
        private int _count = 0;


        public Form1()
        {
            InitializeComponent();
            Random randomNumber = new Random();
            _random = randomNumber.Next(0, 101);
        }

        private void inputGuessBox_TextChanged(object sender, EventArgs e)
        {
   

        }

        private void askGuessLabel_Click(object sender, EventArgs e)
        {

        }

        private void introMessage_Click(object sender, EventArgs e)
        {

        }

        private void guessNumberButton_Click(object sender, EventArgs e)
        {
            _guess = Convert.ToInt32(inputGuessBox.Text);
            _count++;
            amountGuessed.Text = _count + " guesses so far";

            if (_guess == _random)
            {
                labelHint.Text = "Correct";
                guessNumberButton.Enabled = false;
                labelHint.ForeColor = Color.Green;
            }
            else if (_guess > _random)
            {
                labelHint.Text = "Too high!";
                labelHint.ForeColor = Color.Red;
            }
            else
            {
                labelHint.Text = "Too low!";
                labelHint.ForeColor = Color.Blue;
            }

            if (_count == 10)
            {
                gameFinish.Text = "Game Over you have used up your 10 guesses!!";
                finishOptions.Text = "Press 'New Game' to start again or 'Exit' to leave the application";
            }    
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void amountGuessed_Click(object sender, EventArgs e)
        {
        }

        private void gameFinish_Click(object sender, EventArgs e)
        {

        }

        private void finishOptions_Click(object sender, EventArgs e)
        {

        }
    }
}
