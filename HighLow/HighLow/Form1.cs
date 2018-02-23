using System;
using System.Windows.Forms;

namespace HighLow
{
    public partial class HighLow : Form
    {
        // declarations
        HighLowDealer gameRunner;

        // constructor
        public HighLow()
        {
            InitializeComponent();
            gameRunner = new HighLowDealer(inputTextBox, dealerLabel, pointsLabel, lowButton, highButton, resetButton);
        }

        // listen for any button click
        private void ButtonClickListener(object sender, EventArgs e)
        {
            Button buttonContainer = (Button)sender;

            if (buttonContainer.Name == "resetButton")
                gameRunner.ResetGame();
            else
                gameRunner.PlayRound(buttonContainer);
        }
    }
}
