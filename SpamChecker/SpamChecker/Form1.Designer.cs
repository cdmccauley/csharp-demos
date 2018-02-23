namespace SpamChecker
{
    partial class SpamCheckerForm
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
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(484, 197);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(157, 226);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(75, 23);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(238, 226);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(12, 200);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(460, 23);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpamCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.inputRichTextBox);
            this.Name = "SpamCheckerForm";
            this.Text = "Spam Checker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

