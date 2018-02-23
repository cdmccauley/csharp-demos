namespace ReadStudentFiles
{
    partial class ReadStudentFilesForm
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
            this.openButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.classButton = new System.Windows.Forms.Button();
            this.gradeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Enabled = false;
            this.studentButton.Location = new System.Drawing.Point(140, 12);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(75, 23);
            this.studentButton.TabIndex = 1;
            this.studentButton.Text = "Student";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // classButton
            // 
            this.classButton.Enabled = false;
            this.classButton.Location = new System.Drawing.Point(268, 12);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(75, 23);
            this.classButton.TabIndex = 2;
            this.classButton.Text = "Class";
            this.classButton.UseVisualStyleBackColor = true;
            this.classButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // gradeButton
            // 
            this.gradeButton.Enabled = false;
            this.gradeButton.Location = new System.Drawing.Point(396, 12);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(75, 23);
            this.gradeButton.TabIndex = 3;
            this.gradeButton.Text = "Grade";
            this.gradeButton.UseVisualStyleBackColor = true;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(396, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(12, 41);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(459, 179);
            this.outputRichTextBox.TabIndex = 5;
            this.outputRichTextBox.Text = "";
            // 
            // ReadStudentFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.classButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.openButton);
            this.Name = "ReadStudentFilesForm";
            this.Text = "Read Student Files";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button classButton;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
    }
}

