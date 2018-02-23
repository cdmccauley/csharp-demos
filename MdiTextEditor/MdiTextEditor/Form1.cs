using System;
using System.Drawing;
using System.Windows.Forms;

namespace MdiTextEditor
{
    public partial class MdiTextEditor : Form
    {
        // declarations
        ToolStripMenuItem senderItem;
        private Form childContainer;

        // constructor
        public MdiTextEditor()
        {
            InitializeComponent();
        }

        // file menu event handling
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            senderItem = (ToolStripMenuItem)sender;
            
            if (senderItem.Name == newToolStripMenuItem.Name) // new
            {
                childContainer = new ChildForm();
                childContainer.MdiParent = this;
                childContainer.Show();
                if (closeToolStripMenuItem.Enabled == false)
                {
                    closeToolStripMenuItem.Enabled = true;
                    formatToolStripMenuItem.Enabled = true;
                }
            }
            else if (senderItem.Name == closeToolStripMenuItem.Name) // close
            {
                if (HasChildren)
                    ActiveMdiChild.Dispose();
                if (ActiveMdiChild == null)
                {
                    closeToolStripMenuItem.Enabled = false;
                    formatToolStripMenuItem.Enabled = false;
                }
            }
            else if (senderItem.Name == exitToolStripMenuItem.Name) // exit
            {
                Application.Exit();
            }
        }

        // resize active child richtextbox text to 8pt
        private void size8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSizeMenuChecks((ToolStripMenuItem)sender);
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Controls[0].Font.Name, 
                8, ActiveMdiChild.Controls[0].Font.Style);
        }

        // resize active child richtextbox text to 10pt
        private void size10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSizeMenuChecks((ToolStripMenuItem)sender);
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Controls[0].Font.Name, 
                10, ActiveMdiChild.Controls[0].Font.Style);
        }

        // resize active child richtextbox text to 12pt
        private void size12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSizeMenuChecks((ToolStripMenuItem)sender);
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Controls[0].Font.Name, 
                12, ActiveMdiChild.Controls[0].Font.Style);
        }

        // manages format>size menu check marks
        private void SetSizeMenuChecks(ToolStripMenuItem sender)
        {
            size8ToolStripMenuItem.Checked = false;
            size10ToolStripMenuItem.Checked = false;
            size12ToolStripMenuItem.Checked = false;
            sender.Checked = true;
        }

        // change active child richtextbox text color to black
        private void colorBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorMenuChecks((ToolStripMenuItem)sender);
            ActiveMdiChild.Controls[0].ForeColor = Color.Black;
        }

        // change active child richtextbox text color to red
        private void colorRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorMenuChecks((ToolStripMenuItem)sender);
            ActiveMdiChild.Controls[0].ForeColor = Color.Red;
        }

        // change active child richtextbox text color to blue
        private void colorBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorMenuChecks((ToolStripMenuItem)sender);
            ActiveMdiChild.Controls[0].ForeColor = Color.Blue;
        }

        // manages format>color menu check marks
        private void SetColorMenuChecks(ToolStripMenuItem sender)
        {
            colorBlackToolStripMenuItem.Checked = false;
            colorBlueToolStripMenuItem.Checked = false;
            colorRedToolStripMenuItem.Checked = false;
            sender.Checked = true;
        }

        // add or remove bold text style to active child richtextbox text
        private void styleBoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyleMenuChecks((ToolStripMenuItem)sender);
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Controls[0].Font, 
                ActiveMdiChild.Controls[0].Font.Style ^ FontStyle.Bold);
        }

        // add or remove italic text style to active child richtextbox text
        private void styleItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyleMenuChecks((ToolStripMenuItem)sender);
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Controls[0].Font, 
                ActiveMdiChild.Controls[0].Font.Style ^ FontStyle.Italic);
        }

        // add or remove underline text style to active child richtextbox text
        private void styleUnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyleMenuChecks((ToolStripMenuItem)sender);
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Controls[0].Font, 
                ActiveMdiChild.Controls[0].Font.Style ^ FontStyle.Underline);
        }

        // manages format>style menu check marks
        private void SetStyleMenuChecks(ToolStripMenuItem sender)
        {
            sender.Checked = !sender.Checked;
        }
    }
}
