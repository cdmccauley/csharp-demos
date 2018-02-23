namespace RestaurantBill
{
    partial class RestaurantBill
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
            this.beverageComboBox = new System.Windows.Forms.ComboBox();
            this.appetizerComboBox = new System.Windows.Forms.ComboBox();
            this.mainCourseComboBox = new System.Windows.Forms.ComboBox();
            this.dessertsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.completeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beverageComboBox
            // 
            this.beverageComboBox.FormattingEnabled = true;
            this.beverageComboBox.Location = new System.Drawing.Point(92, 14);
            this.beverageComboBox.Name = "beverageComboBox";
            this.beverageComboBox.Size = new System.Drawing.Size(180, 21);
            this.beverageComboBox.TabIndex = 0;
            this.beverageComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // appetizerComboBox
            // 
            this.appetizerComboBox.FormattingEnabled = true;
            this.appetizerComboBox.Location = new System.Drawing.Point(92, 41);
            this.appetizerComboBox.Name = "appetizerComboBox";
            this.appetizerComboBox.Size = new System.Drawing.Size(180, 21);
            this.appetizerComboBox.TabIndex = 1;
            this.appetizerComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // mainCourseComboBox
            // 
            this.mainCourseComboBox.FormattingEnabled = true;
            this.mainCourseComboBox.Location = new System.Drawing.Point(92, 68);
            this.mainCourseComboBox.Name = "mainCourseComboBox";
            this.mainCourseComboBox.Size = new System.Drawing.Size(180, 21);
            this.mainCourseComboBox.TabIndex = 2;
            this.mainCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // dessertsComboBox
            // 
            this.dessertsComboBox.FormattingEnabled = true;
            this.dessertsComboBox.Location = new System.Drawing.Point(92, 95);
            this.dessertsComboBox.Name = "dessertsComboBox";
            this.dessertsComboBox.Size = new System.Drawing.Size(180, 21);
            this.dessertsComboBox.TabIndex = 3;
            this.dessertsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beverages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appetizers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Main Courses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Desserts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subtotal:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Location = new System.Drawing.Point(219, 175);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(53, 23);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tax:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxLabel
            // 
            this.taxLabel.Location = new System.Drawing.Point(219, 202);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(53, 23);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(219, 229);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(53, 23);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(15, 190);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(75, 23);
            this.completeButton.TabIndex = 14;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(15, 219);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // RestaurantBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dessertsComboBox);
            this.Controls.Add(this.mainCourseComboBox);
            this.Controls.Add(this.appetizerComboBox);
            this.Controls.Add(this.beverageComboBox);
            this.Name = "RestaurantBill";
            this.Text = "Restaurant Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox beverageComboBox;
        private System.Windows.Forms.ComboBox appetizerComboBox;
        private System.Windows.Forms.ComboBox mainCourseComboBox;
        private System.Windows.Forms.ComboBox dessertsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button resetButton;
    }
}

