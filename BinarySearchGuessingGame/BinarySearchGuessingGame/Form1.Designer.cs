namespace BinarySearchGuessingGame
{
    partial class BinarySearchGuessingGameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.lowerButton = new System.Windows.Forms.Button();
            this.higherButton = new System.Windows.Forms.Button();
            this.correctButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Think of a number betwen 1 and 1000...";
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(12, 74);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(260, 23);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowerButton
            // 
            this.lowerButton.Location = new System.Drawing.Point(12, 149);
            this.lowerButton.Name = "lowerButton";
            this.lowerButton.Size = new System.Drawing.Size(75, 23);
            this.lowerButton.TabIndex = 2;
            this.lowerButton.Text = "Lower";
            this.lowerButton.UseVisualStyleBackColor = true;
            this.lowerButton.Click += new System.EventHandler(this.lowerButton_Click);
            // 
            // higherButton
            // 
            this.higherButton.Location = new System.Drawing.Point(197, 149);
            this.higherButton.Name = "higherButton";
            this.higherButton.Size = new System.Drawing.Size(75, 23);
            this.higherButton.TabIndex = 3;
            this.higherButton.Text = "Higher";
            this.higherButton.UseVisualStyleBackColor = true;
            this.higherButton.Click += new System.EventHandler(this.higherButton_Click);
            // 
            // correctButton
            // 
            this.correctButton.Location = new System.Drawing.Point(107, 224);
            this.correctButton.Name = "correctButton";
            this.correctButton.Size = new System.Drawing.Size(75, 23);
            this.correctButton.TabIndex = 4;
            this.correctButton.Text = "Correct!";
            this.correctButton.UseVisualStyleBackColor = true;
            this.correctButton.Click += new System.EventHandler(this.correctButton_Click);
            // 
            // BinarySearchGuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.correctButton);
            this.Controls.Add(this.higherButton);
            this.Controls.Add(this.lowerButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Name = "BinarySearchGuessingGameForm";
            this.Text = "Binary Search Guessing Game";
            this.Load += new System.EventHandler(this.BinarySearchGuessingGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button lowerButton;
        private System.Windows.Forms.Button higherButton;
        private System.Windows.Forms.Button correctButton;
    }
}

