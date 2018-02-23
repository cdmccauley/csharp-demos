namespace MdiTextEditor
{
    partial class MdiTextEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleBoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleItalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleUnderlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.styleToolStripMenuItem});
            this.formatToolStripMenuItem.Enabled = false;
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.size8ToolStripMenuItem,
            this.size10ToolStripMenuItem,
            this.size12ToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sizeToolStripMenuItem.Text = "Font Size";
            // 
            // size8ToolStripMenuItem
            // 
            this.size8ToolStripMenuItem.Checked = true;
            this.size8ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.size8ToolStripMenuItem.Name = "size8ToolStripMenuItem";
            this.size8ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.size8ToolStripMenuItem.Text = "8 pt";
            this.size8ToolStripMenuItem.Click += new System.EventHandler(this.size8ToolStripMenuItem_Click);
            // 
            // size10ToolStripMenuItem
            // 
            this.size10ToolStripMenuItem.Name = "size10ToolStripMenuItem";
            this.size10ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.size10ToolStripMenuItem.Text = "10 pt";
            this.size10ToolStripMenuItem.Click += new System.EventHandler(this.size10ToolStripMenuItem_Click);
            // 
            // size12ToolStripMenuItem
            // 
            this.size12ToolStripMenuItem.Name = "size12ToolStripMenuItem";
            this.size12ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.size12ToolStripMenuItem.Text = "12 pt";
            this.size12ToolStripMenuItem.Click += new System.EventHandler(this.size12ToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorBlackToolStripMenuItem,
            this.colorRedToolStripMenuItem,
            this.colorBlueToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Font Color";
            // 
            // colorBlackToolStripMenuItem
            // 
            this.colorBlackToolStripMenuItem.Checked = true;
            this.colorBlackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colorBlackToolStripMenuItem.Name = "colorBlackToolStripMenuItem";
            this.colorBlackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorBlackToolStripMenuItem.Text = "Black";
            this.colorBlackToolStripMenuItem.Click += new System.EventHandler(this.colorBlackToolStripMenuItem_Click);
            // 
            // colorRedToolStripMenuItem
            // 
            this.colorRedToolStripMenuItem.Name = "colorRedToolStripMenuItem";
            this.colorRedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorRedToolStripMenuItem.Text = "Red";
            this.colorRedToolStripMenuItem.Click += new System.EventHandler(this.colorRedToolStripMenuItem_Click);
            // 
            // colorBlueToolStripMenuItem
            // 
            this.colorBlueToolStripMenuItem.Name = "colorBlueToolStripMenuItem";
            this.colorBlueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorBlueToolStripMenuItem.Text = "Blue";
            this.colorBlueToolStripMenuItem.Click += new System.EventHandler(this.colorBlueToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleBoldToolStripMenuItem,
            this.styleItalicToolStripMenuItem,
            this.styleUnderlineToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.styleToolStripMenuItem.Text = "Font Style";
            // 
            // styleBoldToolStripMenuItem
            // 
            this.styleBoldToolStripMenuItem.Name = "styleBoldToolStripMenuItem";
            this.styleBoldToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.styleBoldToolStripMenuItem.Text = "Bold";
            this.styleBoldToolStripMenuItem.Click += new System.EventHandler(this.styleBoldToolStripMenuItem_Click);
            // 
            // styleItalicToolStripMenuItem
            // 
            this.styleItalicToolStripMenuItem.Name = "styleItalicToolStripMenuItem";
            this.styleItalicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.styleItalicToolStripMenuItem.Text = "Italic";
            this.styleItalicToolStripMenuItem.Click += new System.EventHandler(this.styleItalicToolStripMenuItem_Click);
            // 
            // styleUnderlineToolStripMenuItem
            // 
            this.styleUnderlineToolStripMenuItem.Name = "styleUnderlineToolStripMenuItem";
            this.styleUnderlineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.styleUnderlineToolStripMenuItem.Text = "Underline";
            this.styleUnderlineToolStripMenuItem.Click += new System.EventHandler(this.styleUnderlineToolStripMenuItem_Click);
            // 
            // MdiTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiTextEditor";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleBoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleItalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleUnderlineToolStripMenuItem;
    }
}

