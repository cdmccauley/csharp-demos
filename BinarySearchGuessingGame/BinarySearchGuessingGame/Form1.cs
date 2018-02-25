using System;
using System.Windows.Forms;

namespace BinarySearchGuessingGame
{
    public partial class BinarySearchGuessingGameForm : Form
    {
        // properties
        private int StartOfRange { get; set; }

        private int EndOfRange { get; set; }

        private int HalfRangeDifference
        {
            get => (EndOfRange - StartOfRange) / 2;
        }

        private int CurrentGuess { get; set; }

        private int GuessCounter { get; set; }

        // constructor
        public BinarySearchGuessingGameForm()
        {
            InitializeComponent();
            StartOfRange = 0;
            EndOfRange = 1001;
            GuessCounter = 1;
        }

        // load event handler, begins game
        private void BinarySearchGuessingGameForm_Load(object sender, EventArgs e)
        {
            CurrentGuess = HalfRangeDifference;
            outputLabel.Text = string.Format("Is your number {0}?", CurrentGuess);
        }

        // higher button click event handler, makes a guess that is higher
        private void higherButton_Click(object sender, EventArgs e)
        {
            StartOfRange = CurrentGuess;
            CurrentGuess += HalfRangeDifference;
            UpdateOutput();
        }

        // lower button click event handler, makes a guess that is lower
        private void lowerButton_Click(object sender, EventArgs e)
        {
            EndOfRange = CurrentGuess;
            CurrentGuess -= HalfRangeDifference;
            UpdateOutput();
        }

        // correct button click event handler, user indicates the guess was correct
        private void correctButton_Click(object sender, EventArgs e)
        {
            if (lowerButton.Enabled)
                lowerButton.Enabled = false;
            if (higherButton.Enabled)
                higherButton.Enabled = false;
            if (correctButton.Enabled)
                correctButton.Enabled = false;
            outputLabel.Text = string.Format("I guessed your number in {0} attempts!", GuessCounter);
        }

        // updates outputLabel to message user
        private void UpdateOutput()
        {
            if (++GuessCounter == 10)
            {
                outputLabel.Text = string.Format("Your number is {0}!", CurrentGuess);
                lowerButton.Enabled = false;
                higherButton.Enabled = false;
            }
            else
                outputLabel.Text = string.Format("Is your number {0}?", CurrentGuess);
        }
    }
}
