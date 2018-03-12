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
        // properties
        private static SubShopSystem ShopSystem { get; set; }

        // constructor
        public SubShop()
        {
            InitializeComponent();
            ShopSystem = new SubShopSystem();
        }

        // methods
        private void UpdateOrderTextBox()
        {
            orderTextBox.Lines = ShopSystem
                .CurrentOrder
                .ToStringArray();
            orderTaxTextBox.Text = ShopSystem.CurrentOrder.GetOrderTax();
            orderTotalTextBox.Text = ShopSystem.CurrentOrder.GetOrderTotal();
        }

        private void ResetButtonColor(Panel targetPanel)
        {
            foreach (GroupBox group in targetPanel.Controls)
                foreach (Control control in group.Controls)
                    if (control is Button)
                        control.BackColor = SystemColors.ControlLight;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            if (senderButton.Text == "Cancel Sandwich")
            {
                ResetButtonColor((Panel)senderButton.Parent.Parent);
                sandwichTextBox.Clear();
                ShopSystem
                    .CurrentOrder
                    .StartSandwich();
            }
            else if (senderButton.Text == "Add Sandwich" && ShopSystem.CurrentOrder.CurrentSub.SubPrice > 0.00M)
            {
                ShopSystem.CurrentOrder.EndSandwich();
                ReflectInventory();
                ResetButtonColor((Panel)senderButton.Parent.Parent);
                sandwichTextBox.Clear();
                sandwichTotalTextBox.Clear();
                UpdateOrderTextBox();
                ShopSystem
                    .CurrentOrder
                    .StartSandwich();
            }
            else if (senderButton.Text == "Cancel Order")
            {
                ShopSystem.CurrentOrder.CancelOrder();
                ReflectInventory();
                orderPanel.Visible = false;
                mainPanel.Visible = true;
            }
            else if (senderButton.Text == "Payment" && orderTotalTextBox.Text != "")
            {
                ReflectInventory();
                paymentDetailsTextBox.Lines = orderTextBox.Lines;
                paymentTaxTextBox.Text = orderTaxTextBox.Text;
                paymentTotalTextBox.Text = orderTotalTextBox.Text;
                orderPanel.Visible = false;
                paymentPanel.Visible = true;
            }
        }
        
        private void ToggleButtonColor(Button sender)
        {
            Button senderButton = sender;

            senderButton.BackColor = (senderButton.BackColor == SystemColors.ControlLight)
                ? senderButton.BackColor = Color.Green
                : senderButton.BackColor = SystemColors.ControlLight;
        }

        private void IngredientButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            ToggleButtonColor((Button)sender);
            ShopSystem
                .CurrentOrder
                .CurrentSub
                .BuildSub(senderButton.Text);
            UpdateSandwichTextBox();
        }

        private void UpdateSandwichTextBox()
        {
            sandwichTextBox.Lines = ShopSystem
                .CurrentOrder
                .CurrentSub
                .ToStringArray();
            sandwichTotalTextBox.Text = string.Format("  {0:C}", ShopSystem.CurrentOrder.CurrentSub.SubPrice);
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

            ShopSystem
                .CurrentOrder
                .CurrentSub
                .BuildSub(senderButton.Text);
            UpdateSandwichTextBox();
        }

        private void ReflectInventory()
        {
            string[] outOfStock = SubShopSystem
                .SystemInventory
                .GetOutOfStock();

            if (!(outOfStock.Length == 0))
            {
                foreach (GroupBox group in orderPanel.Controls)
                    foreach (Control control in group.Controls)
                        if (control is Button)
                            foreach (String item in outOfStock)
                                if (item.Equals(control.Text))
                                    control.Enabled = false;
            }
            else
            {
                foreach (GroupBox group in orderPanel.Controls)
                    foreach (Control control in group.Controls)
                        if (control is Button && !control.Enabled)
                            control.Enabled = true;
            }
        }

        private void orderPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (ShopSystem != null)
            {
                if (orderPanel.Visible)
                {
                    ShopSystem.GetCustomerOrder();
                    ReflectInventory();
                    sandwichTextBox.Clear();
                    orderTextBox.Clear();
                    orderTaxTextBox.Clear();
                    orderTotalTextBox.Clear();
                }
                else
                {
                    ResetButtonColor(orderPanel);
                    ShopSystem.EndCustomerOrder();
                }
            }
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            switch (senderButton.Text)
            {
                case "Begin Order":
                    mainPanel.Visible = false;
                    orderPanel.Visible = true;
                    break;
                case "View Inventory":
                    Console.WriteLine("View Inventory");
                    break;
            }
        }

        private void paymentTextBox_Click(object sender, EventArgs e)
        {
            TextBox senderTextBox = (TextBox)sender;
            String senderTextBoxName = senderTextBox.Name;

            if (!ShopSystem.CurrentOrder.Payment.GuiRefs.ContainsKey(senderTextBoxName))
                ShopSystem.CurrentOrder.Payment.GuiRefs.Add(senderTextBoxName, senderTextBox);
        }
    }
}
