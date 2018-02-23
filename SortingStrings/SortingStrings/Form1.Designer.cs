namespace SortingStrings
{
    partial class SortingStrings
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
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.userListListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(12, 12);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(179, 20);
            this.userInputTextBox.TabIndex = 0;
            // 
            // userListListBox
            // 
            this.userListListBox.FormattingEnabled = true;
            this.userListListBox.Location = new System.Drawing.Point(12, 38);
            this.userListListBox.Name = "userListListBox";
            this.userListListBox.Size = new System.Drawing.Size(260, 212);
            this.userListListBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(197, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 20);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // SortingStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.userListListBox);
            this.Controls.Add(this.userInputTextBox);
            this.Name = "SortingStrings";
            this.Text = "Sorting Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.ListBox userListListBox;
        private System.Windows.Forms.Button addButton;
    }
}

