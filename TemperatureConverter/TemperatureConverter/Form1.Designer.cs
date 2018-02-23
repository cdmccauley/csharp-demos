namespace TemperatureConverter
{
    partial class TemperatureConverter
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.fahrenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.celsiusRadioButton = new System.Windows.Forms.RadioButton();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(92, 85);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // fahrenheitRadioButton
            // 
            this.fahrenheitRadioButton.AutoSize = true;
            this.fahrenheitRadioButton.Location = new System.Drawing.Point(77, 113);
            this.fahrenheitRadioButton.Name = "fahrenheitRadioButton";
            this.fahrenheitRadioButton.Size = new System.Drawing.Size(131, 17);
            this.fahrenheitRadioButton.TabIndex = 1;
            this.fahrenheitRadioButton.TabStop = true;
            this.fahrenheitRadioButton.Text = "Convert To Fahrenheit";
            this.fahrenheitRadioButton.UseVisualStyleBackColor = true;
            this.fahrenheitRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // celsiusRadioButton
            // 
            this.celsiusRadioButton.AutoSize = true;
            this.celsiusRadioButton.Location = new System.Drawing.Point(85, 138);
            this.celsiusRadioButton.Name = "celsiusRadioButton";
            this.celsiusRadioButton.Size = new System.Drawing.Size(114, 17);
            this.celsiusRadioButton.TabIndex = 2;
            this.celsiusRadioButton.TabStop = true;
            this.celsiusRadioButton.Text = "Convert To Celsius";
            this.celsiusRadioButton.UseVisualStyleBackColor = true;
            this.celsiusRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(77, 163);
            this.outputLabel.MinimumSize = new System.Drawing.Size(131, 13);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(131, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.celsiusRadioButton);
            this.Controls.Add(this.fahrenheitRadioButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "TemperatureConverter";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.RadioButton fahrenheitRadioButton;
        private System.Windows.Forms.RadioButton celsiusRadioButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

