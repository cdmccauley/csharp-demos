namespace GuessingGame
{
    partial class GuessingGame
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
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Location = new System.Drawing.Point(42, 48);
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.Size = new System.Drawing.Size(200, 20);
            this.instructionTextBox.TabIndex = 5;
            this.instructionTextBox.Text = "Guess the number between 1 and 1000";
            this.instructionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(127, 83);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(58, 86);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(63, 13);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Your guess:";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(105, 119);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "My Guess";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(42, 162);
            this.outputLabel.MinimumSize = new System.Drawing.Size(200, 13);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(200, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(105, 190);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.instructionTextBox);
            this.Name = "GuessingGame";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox instructionTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

