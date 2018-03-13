using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SubShop
{
    class CustomerPayment
    {
        // properties
        public string CardNumber { get; private set; }

        public string CardExpiration { get; private set; }

        public string CardCVV { get; private set; }

        public Dictionary<String, TextBox> GuiRefs { get; private set; }

        public Label MessageLabel { get; private set; }

        public TextBox LastTextBox { get; set; }

        private List<String> ValidCardStarts { get; set; }

        private Int16 AttemptCounter { get; set; }

        // constructor
        public CustomerPayment()
        {
            GuiRefs = new Dictionary<string, TextBox>();
            ValidCardStarts = new List<String>();
            ValidCardStarts.Add("1298");
            ValidCardStarts.Add("1267");
            ValidCardStarts.Add("4512");
            ValidCardStarts.Add("4567");
            ValidCardStarts.Add("8901");
            ValidCardStarts.Add("8933");
        }

        // methods
        public void ValidateCardInfo()
        {
            // method declarations
            int errorCounter = 0;

            // ready method components
            ++AttemptCounter;
            MessageLabel.Text = "";

            // if card number valid, get card number, else message
            if (GuiRefs["cardNumberTextBox"].Text.Length == 16 && ValidCardStarts.Contains(GuiRefs["cardNumberTextBox"].Text.Substring(0, 4)))
                CardNumber = GuiRefs["cardNumberTextBox"].Text;
            else
            {
                MessageLabel.Text = "Invalid Card Number.";
                ++errorCounter;
            }

            // if card expiry valid, get card expiry, else message
            if (GuiRefs["cardExpirationTextBox"].Text.Length == 6)
            {
                if (Int16.Parse(GuiRefs["cardExpirationTextBox"].Text.Substring(0, 2)) >= 1 &&
                    Int16.Parse(GuiRefs["cardExpirationTextBox"].Text.Substring(0, 2)) <= 12)
                {
                    if (Int16.Parse(GuiRefs["cardExpirationTextBox"].Text.Substring(2, 2)) > 19)
                    {
                        if (Int16.Parse(GuiRefs["cardExpirationTextBox"].Text.Substring(2, 4)) > 2017 && 
                            Int16.Parse(GuiRefs["cardExpirationTextBox"].Text.Substring(2, 4)) < 2024)
                            CardExpiration = GuiRefs["cardExpirationTextBox"].Text;
                        else
                        {
                            MessageLabel.Text = "Invalid Expiration Year.";
                            ++errorCounter;
                        }
                    }
                    else
                    {
                        MessageLabel.Text = "Invalid Expiration Year.";
                        ++errorCounter;
                    }
                }
                else
                {
                    MessageLabel.Text = "Invalid Expiration Month";
                    ++errorCounter;
                }
            }
            else
            {
                MessageLabel.Text = "Invalid Expiration Length.";
                ++errorCounter;
            }

            // if card cvv valid, get card cvv, else message
            if (GuiRefs["cardCvvTextBox"].Text.Length == 3)
                CardCVV = GuiRefs["cardCvvTextBox"].Text;
            else
            {
                MessageLabel.Text = "Invalid CVV Length.";
                ++errorCounter;
            }

            // if max attempts reached or no errors, end order
            if (AttemptCounter == 3)
            {
                EndPayment();
                MessageLabel.Parent.Parent.Parent.Controls["mainPanel"].Controls["paymentFailLabel"].Visible = true;
                MessageLabel.Parent.Parent.Parent.Controls["mainPanel"].Visible = true;
                MessageLabel.Parent.Parent.Visible = false;
            }
            else if (errorCounter == 0)
            {
                EndPayment();
                MessageLabel.Parent.Parent.Parent.Controls["inventoryPanel"].Visible = true;
                MessageLabel.Parent.Parent.Parent.Controls["inventoryPanel"].Controls["paymentSuccessLabel"].Visible = true;
                MessageLabel.Parent.Parent.Visible = false;
            }
        }

        // set reference for messages to user
        public void SetMessageLabel(Label messageLabel)
        {
            MessageLabel = messageLabel;
        }

        // hold reference to the last textbox that was used for gui numpad entry
        public void TextBoxClicked(TextBox senderTextBox)
        {
            LastTextBox = senderTextBox;
        }

        // go back to main menu
        private void EndPayment()
        {
            foreach (GroupBox group in MessageLabel.Parent.Parent.Controls)
                foreach (Control control in group.Controls)
                    if (control is TextBox)
                    {
                        TextBox clearing = (TextBox)control;
                        clearing.Clear();
                    }
        }
    }
}
