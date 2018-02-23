namespace HighLow
{
    partial class HighLow
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
            this.dealerLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.wagerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lowButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dealerLabel
            // 
            this.dealerLabel.Location = new System.Drawing.Point(17, 35);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(250, 13);
            this.dealerLabel.TabIndex = 0;
            this.dealerLabel.Text = "Welcome to High-Low!";
            this.dealerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(17, 212);
            this.pointsLabel.MinimumSize = new System.Drawing.Size(250, 13);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(250, 13);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = "You have been granted 1000 points!";
            this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(140, 75);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 2;
            // 
            // wagerLabel
            // 
            this.wagerLabel.AutoSize = true;
            this.wagerLabel.Location = new System.Drawing.Point(44, 78);
            this.wagerLabel.Name = "wagerLabel";
            this.wagerLabel.Size = new System.Drawing.Size(90, 13);
            this.wagerLabel.TabIndex = 3;
            this.wagerLabel.Text = "Enter your wager:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Will the number be higher or lower than 7?";
            // 
            // lowButton
            // 
            this.lowButton.Location = new System.Drawing.Point(64, 162);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(75, 23);
            this.lowButton.TabIndex = 5;
            this.lowButton.Text = "Lower";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.Click += new System.EventHandler(this.ButtonClickListener);
            // 
            // highButton
            // 
            this.highButton.Location = new System.Drawing.Point(145, 162);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(75, 23);
            this.highButton.TabIndex = 6;
            this.highButton.Text = "Higher";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.Click += new System.EventHandler(this.ButtonClickListener);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(105, 162);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.ButtonClickListener);
            // 
            // HighLow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wagerLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.dealerLabel);
            this.Name = "HighLow";
            this.Text = "High-Low";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label wagerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lowButton;
        private System.Windows.Forms.Button highButton;
        private System.Windows.Forms.Button resetButton;
    }
}

