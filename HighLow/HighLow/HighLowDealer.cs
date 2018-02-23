using System;
using System.Windows.Forms;

namespace HighLow
{
    class HighLowDealer
    {
        // declarations
        private Random cardSource;
        private TextBox playerWagerRef;
        private Label dealerLabelRef, pointsLabelRef;
        private Button lowButtonRef, highButtonRef, resetButtonRef;
        private int cardNumber, playerScore, playerWager;

        // properties
        private int CardNumber
        {
            get => cardNumber;
            set => cardNumber = value;
        }

        private int PlayerScore
        {
            get => playerScore;
            set => playerScore = value;
        }

        private int PlayerWager
        {
            get => playerWager;
            set => playerWager = value;
        }

        // constructor
        public HighLowDealer(TextBox playerWager, Label dealerLabel, Label pointsLabel, 
            Button lowButton, Button highButton, Button resetButton)
        {
            cardSource = new Random();
            PlayerScore = 1000;
            playerWagerRef = playerWager;
            dealerLabelRef = dealerLabel;
            pointsLabelRef = pointsLabel;
            lowButtonRef = lowButton;
            highButtonRef = highButton;
            resetButtonRef = resetButton;
            DealCard();
        }

        // get a new card
        private void DealCard()
        {
            CardNumber = cardSource.Next(1, 14);
        }

        // play a round of high-low
        public void PlayRound(Button playerGuess)
        {
            try
            {
                PlayerWager = Int16.Parse(playerWagerRef.Text);

                if (ValidateWager(PlayerWager))
                    if (CardNumber < 7 && playerGuess.Name == "lowButton")
                        GrantPoints(PlayerWager);
                    else if (CardNumber > 7 && playerGuess.Name == "highButton")
                        GrantPoints(PlayerWager);
                    else
                        DeductPoints(PlayerWager);
                else
                    dealerLabelRef.Text = string.Format("Wager must be 1-{0}", PlayerScore);
            }
            catch (FormatException)
            {
                dealerLabelRef.Text = "Wager must be a whole number.";
            }
            finally
            {
                DealCard();
            }
        }

        // validate users desired wager
        private bool ValidateWager(int requestedWager)
        {
            return (requestedWager <= PlayerScore && requestedWager > 0) ? true : false;
        }

        // add points
        private void GrantPoints(int pointsToGrant)
        {
            PlayerScore += pointsToGrant;
            dealerLabelRef.Text = string.Format("The number is {0}, you won this round!", CardNumber);
            UpdatePoints();
        }

        // deduct points
        private void DeductPoints(int pointsToDeduct)
        {
            PlayerScore -= pointsToDeduct;
            UpdatePoints();
            if (PlayerScore <= 0)
                EndGame();
            else
                dealerLabelRef.Text = string.Format("The number is {0}, try again...", CardNumber);
        }

        // refresh points label
        private void UpdatePoints()
        {
            pointsLabelRef.Text = string.Format("You now have {0} points.", PlayerScore);
        }

        // end the game
        private void EndGame()
        {
            dealerLabelRef.Text = "Game Over.";
            lowButtonRef.Visible = false;
            highButtonRef.Visible = false;
            resetButtonRef.Visible = true;
        }

        // reset the game
        public void ResetGame()
        {
            dealerLabelRef.Text = "Welcome back to High-Low!";
            PlayerScore = 1000;
            UpdatePoints();
            resetButtonRef.Visible = false;
            lowButtonRef.Visible = true;
            highButtonRef.Visible = true;
        }
    }
}
