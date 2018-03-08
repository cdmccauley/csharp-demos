using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubShop
{
    public partial class SubShop : Form
    {
        private static SubShopSystem ShopSystem { get; set; }

        public SubShop()
        {
            InitializeComponent();
            ShopSystem = new SubShopSystem();
        }

        private void ReflectInventory()
        {
            string[] outOfStock = SubShopSystem.SystemInventory.GetOutOfStock();

            if (!(outOfStock.Length == 0))
                foreach (GroupBox group in orderPanel.Controls)
                    foreach (Control control in group.Controls)
                        if (control is Button)
                            foreach (String item in outOfStock)
                                if (item.Equals(control.Text))
                                    control.Enabled = false;
        }

        private void ToggleButtonColor(Button sender)
        {
            Button senderButton = sender;

            senderButton.BackColor = (senderButton.BackColor == SystemColors.ControlLight)
                ? senderButton.BackColor = Color.Green
                : senderButton.BackColor = SystemColors.ControlLight;
        }

        private void ResetButtonColor(Panel targetPanel)
        {
            foreach (GroupBox group in targetPanel.Controls)
                foreach (Control control in group.Controls)
                    if (control is Button)
                        control.BackColor = SystemColors.ControlLight;
        }

        private void UpdateSandwichTextBox()
        {
            sandwichTextBox.Lines = ShopSystem.CurrentOrder.CurrentSub.ToStringArray();
        }

        private void UpdateOrderTextBox()
        {
            int sandwichCounter = 0;
            StringBuilder orderString = new StringBuilder();

            if (ShopSystem.CurrentOrder.CustomerSubs.Count > 0)
            {
                foreach (CustomerOrder.Sandwich sandwich in ShopSystem.CurrentOrder.CustomerSubs)
                {
                    ++sandwichCounter;
                    orderString.Append("Sandwich " + sandwichCounter + ",");
                }
                orderTextBox.Lines = orderString.ToString().Trim().Split(',');
            }
        }

        private void BreadButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            foreach (Button button in breadGroupBox.Controls)
                if (button.Name == senderButton.Name)
                {
                    if (button.BackColor == SystemColors.ControlLight)
                        button.BackColor = Color.Green;
                    else
                        button.BackColor = SystemColors.ControlLight;
                }
                else
                    button.BackColor = SystemColors.ControlLight;

            ShopSystem.CurrentOrder.CurrentSub.BuildSub(senderButton.Text);
            UpdateSandwichTextBox();
        }

        private void MeatButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            ToggleButtonColor((Button)sender);
            ShopSystem.CurrentOrder.CurrentSub.BuildSub(senderButton.Text);
            UpdateSandwichTextBox();
        }

        private void CheeseButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            ToggleButtonColor((Button)sender);
            ShopSystem.CurrentOrder.CurrentSub.BuildSub(senderButton.Text);
            UpdateSandwichTextBox();
        }

        private void ToppingButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            ToggleButtonColor((Button)sender);
            ShopSystem.CurrentOrder.CurrentSub.BuildSub(senderButton.Text);
            UpdateSandwichTextBox();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            if (senderButton.Text == "Cancel Sandwich")
            {
                ResetButtonColor((Panel)senderButton.Parent.Parent);
                sandwichTextBox.Clear();
                ShopSystem.CurrentOrder.StartSandwich();
            }
            else if (senderButton.Text == "Add Sandwich")
            {
                ShopSystem.CurrentOrder.EndSandwich();
                ReflectInventory();
                ResetButtonColor((Panel)senderButton.Parent.Parent);
                sandwichTextBox.Clear();
                UpdateOrderTextBox();
                ShopSystem.CurrentOrder.StartSandwich();
            }
        }

        private void orderPanel_VisibleChanged(object sender, EventArgs e)
        {
            Panel senderPanel = (Panel)sender;

            if (ShopSystem != null)
            {
                if (senderPanel.Visible)
                {
                    ShopSystem.GetCustomerOrder();
                    ReflectInventory();
                }
                else
                {
                    ResetButtonColor(senderPanel);
                    ShopSystem.EndCustomerOrder();
                }
            }
        }
    }
}
