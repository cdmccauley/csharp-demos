using System;
using System.Windows.Forms;

namespace SpamChecker
{
    public partial class SpamCheckerForm : Form
    {
        // declarations
        string[] spamKeywords = {
            "additional income",
            "natural",
            "free",
            "gift",
            "winner",
            "cure",
            "increase",
            "be your own boss",
            "home",
            "cash",
            "bonus",
            "check",
            "money order",
            "stock",
            "asset",
            "usd",
            "money",
            "bank",
            "urgent" };
        int spamScore;
        const int SPAM_THRESHOLD = 5;

        // constructor
        public SpamCheckerForm()
        {
            InitializeComponent();
        }

        // scan button click event handler
        private void scanButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            spamScore = 0;
            foreach (string keyword in spamKeywords)
                if (inputRichTextBox.Text.ToLower().Contains(keyword))
                {
                    ++spamScore;
                    if (spamScore == SPAM_THRESHOLD)
                        outputLabel.Text = "Sending message to spam folder...";
                }
        }

        // clear button click event handler
        private void clearButton_Click(object sender, EventArgs e)
        {
            inputRichTextBox.Text = "";
            outputLabel.Text = "";
        }
    }
}
