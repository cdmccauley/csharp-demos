using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        // declarations
        GameController guessingGameController;

        // constructor
        public GuessingGame()
        {
            InitializeComponent();
            guessingGameController = new GameController();
        }

        // guess button event handler
        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                guessingGameController.CountGuess();
                if (guessingGameController.GameNumber > Int16.Parse(inputTextBox.Text)) // guess was too low
                {
                    BackColor = Color.Blue;
                    inputLabel.ForeColor = Color.White;
                    outputLabel.ForeColor = Color.White;
                    outputLabel.Text = "too low";
                }
                else if (guessingGameController.GameNumber < Int16.Parse(inputTextBox.Text)) // guess was too high
                {
                    BackColor = Color.Red;
                    inputLabel.ForeColor = Color.White;
                    outputLabel.ForeColor = Color.White;
                    outputLabel.Text = "too high";
                }
                else // guessed the number
                {
                    BackColor = Color.Green;
                    outputLabel.Text = string.Format("You guessed it in {0} guesses!", guessingGameController.GuessCounter);
                    playButton.Enabled = false;
                    resetButton.Visible = true;
                }
            }
            catch (FormatException inputError)
            {
                outputLabel.Text = inputError.Message;
            }
        }

        // reset button event handler
        private void resetButton_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            outputLabel.Text = "";
            inputLabel.ForeColor = Color.Black;
            outputLabel.ForeColor = Color.Black;
            playButton.Enabled = true;
            resetButton.Visible = false;
            guessingGameController.ResetGame();
        }
    }
}
