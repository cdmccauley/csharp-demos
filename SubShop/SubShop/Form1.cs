using System;
using System.Drawing;
using System.Text;
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
            orderTextBox.Lines = ShopSystem.CurrentOrder.ToStringArray();
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
                ShopSystem.CurrentOrder.StartSandwich();
            }
            else if (senderButton.Text == "Add Sandwich" && ShopSystem.CurrentOrder.CurrentSub.SubPrice > 0.00M)
            {
                ShopSystem.CurrentOrder.EndSandwich();
                ReflectInventory();
                ResetButtonColor((Panel)senderButton.Parent.Parent);
                sandwichTextBox.Clear();
                sandwichTotalTextBox.Clear();
                UpdateOrderTextBox();
                ShopSystem.CurrentOrder.StartSandwich();
            }
            else if (senderButton.Text == "Cancel Order")
            {
                ShopSystem.CurrentOrder.CancelOrder();
                ReflectInventory();
                orderPanel.Visible = false;
                ShopSystem.EndCustomerOrder();
                mainPanel.Visible = true;
            }
            else if (senderButton.Text == "Payment" && orderTotalTextBox.Text != "")
            {
                ReflectInventory();
                paymentDetailsTextBox.Lines = orderTextBox.Lines;
                paymentTaxTextBox.Text = orderTaxTextBox.Text;
                paymentTotalTextBox.Text = orderTotalTextBox.Text;
                ShopSystem.CurrentOrder.Payment.TextBoxClicked(cardNumberTextBox);
                ShopSystem.CurrentOrder.Payment.SetMessageLabel(paymentMessageLabel);
                ShopSystem.CurrentOrder.Payment.GuiRefs.Add(cardNumberTextBox.Name, cardNumberTextBox);
                ShopSystem.CurrentOrder.Payment.GuiRefs.Add(cardExpirationTextBox.Name, cardExpirationTextBox);
                ShopSystem.CurrentOrder.Payment.GuiRefs.Add(cardCvvTextBox.Name, cardCvvTextBox);
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
            ShopSystem.CurrentOrder.CurrentSub.BuildSub(senderButton.Text);
            UpdateSandwichTextBox();
        }

        private void UpdateSandwichTextBox()
        {
            sandwichTextBox.Lines = ShopSystem.CurrentOrder.CurrentSub.ToStringArray();
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

            ShopSystem.CurrentOrder.CurrentSub.BuildSub(senderButton.Text);
            UpdateSandwichTextBox();
        }

        private void ReflectInventory()
        {
            string[] outOfStock = SubShopSystem.SystemInventory.GetOutOfStock();

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
                }
            }
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            paymentFailLabel.Visible = false;
            mainPanel.Visible = false;
            switch (senderButton.Text)
            {
                case "Begin Order":
                    orderPanel.Visible = true;
                    break;
                case "View Inventory":
                    inventoryPanel.Visible = true;
                    break;
            }
        }

        private void PaymentNumPad_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            switch (senderButton.Text)
            {
                case "Del":
                    if (ShopSystem.CurrentOrder.Payment.LastTextBox.Text.Length > 0)
                        ShopSystem.CurrentOrder.Payment.LastTextBox.Text =
                            ShopSystem.CurrentOrder.Payment.LastTextBox.Text.Substring(0,
                                ShopSystem.CurrentOrder.Payment.LastTextBox.Text.Length - 1);
                    break;
                default:
                    if (ShopSystem.CurrentOrder.Payment.LastTextBox.Text.Length < ShopSystem.CurrentOrder.Payment.LastTextBox.MaxLength)
                        ShopSystem.CurrentOrder.Payment.LastTextBox.AppendText(senderButton.Text);
                    break;
            }
        }

        private void finalizePayment_Click(object sender, EventArgs e)
        {
            ShopSystem.CurrentOrder.Payment.ValidateCardInfo();
        }

        private void PaymentTextBox_Enter(object sender, EventArgs e)
        {
            ShopSystem.CurrentOrder.Payment.TextBoxClicked((TextBox)sender);
        }

        private void inventoryPanel_VisibleChanged(object sender, EventArgs e)
        {
            StringBuilder inventoryString = new StringBuilder();

            if (inventoryPanel.Visible)
            {
                foreach (ShopInventory.InventoryItem item in SubShopSystem.SystemInventory.Inventory["Bread"].Values)
                    inventoryString.Append(string.Format("{0,-17}", item.ItemName) + string.Format("{0,8},", item.ItemQty));
                breadInvTextBox.Lines = inventoryString.ToString().Remove(0, 27).Trim(',').Split(',');
                inventoryString.Clear();
                foreach (ShopInventory.InventoryItem item in SubShopSystem.SystemInventory.Inventory["Meat"].Values)
                    inventoryString.Append(string.Format("{0,-17}", item.ItemName) + string.Format("{0,8},", item.ItemQty));
                meatInvTextBox.Lines = inventoryString.ToString().Remove(0, 27).Trim(',').Split(',');
                inventoryString.Clear();
                foreach (ShopInventory.InventoryItem item in SubShopSystem.SystemInventory.Inventory["Cheese"].Values)
                    inventoryString.Append(string.Format("{0,-17}", item.ItemName) + string.Format("{0,8},", item.ItemQty));
                cheeseInvTextBox.Lines = inventoryString.ToString().Remove(0, 27).Trim(',').Split(',');
                inventoryString.Clear();
                foreach (ShopInventory.InventoryItem item in SubShopSystem.SystemInventory.Inventory["Topping"].Values)
                    inventoryString.Append(string.Format("{0,-17}", item.ItemName) + string.Format("{0,8},", item.ItemQty));
                toppingInvTextBox.Lines = inventoryString.ToString().Remove(0, 27).Trim(',').Split(',');
                inventoryString.Clear();
            }
            else
            {
                foreach (Control group in inventoryPanel.Controls)
                    if (group is GroupBox)
                        foreach (TextBox inventory in group.Controls)
                            inventory.Clear();
                paymentSuccessLabel.Visible = false;
            }
        }

        private void inventoryMainButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            paymentSuccessLabel.Visible = false;
            inventoryPanel.Visible = false;
        }
    }
}
