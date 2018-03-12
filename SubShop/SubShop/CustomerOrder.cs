using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubShop
{
    class CustomerOrder
    {
        // properties
        private ShopInventory InventorySource { get; set; }

        public List<Sandwich> CustomerSubs { get; private set; }

        public Sandwich CurrentSub { get; private set; }

        public CustomerPayment Payment { get; private set; }

        // constructor
        public CustomerOrder(ShopInventory inventoryRef)
        {
            Payment = new CustomerPayment();
            CustomerSubs = new List<Sandwich>();
            InventorySource = inventoryRef;
        }

        // methods
        public void StartSandwich()
        {
            CurrentSub = new Sandwich(InventorySource);
        }

        public void EndSandwich()
        {
            CurrentSub.UseIngredients();
            CustomerSubs.Add(CurrentSub);
        }

        public void CancelOrder()
        {
            foreach (Sandwich sub in CustomerSubs)
                sub.UndoUseIngredients();
        }

        public string GetOrderTax()
        {
            const decimal TAX_RATE = .045M;
            decimal taxTotal = 0.00M;

            foreach (Sandwich customerSub in CustomerSubs)
                taxTotal += customerSub.SubPrice * TAX_RATE;

            return string.Format("  {0:C}", taxTotal);
        }

        public string GetOrderTotal()
        {
            decimal orderTotal = 0.00M;

            foreach (Sandwich customerSub in CustomerSubs)
                orderTotal += customerSub.SubPrice;
            orderTotal += Decimal.Parse(GetOrderTax().TrimStart().TrimStart('$'));

            return string.Format("  {0:C}", orderTotal);
        }

        public void GetPayment()
        {
            // ???
        }

        public string[] ToStringArray()
        {
            int sandwichCounter = 0;
            StringBuilder orderString = new StringBuilder();

            if (CustomerSubs.Count > 0)
            {
                foreach (Sandwich orderSandwich in CustomerSubs)
                {
                    ++sandwichCounter;
                    orderString.Append(String.Format("Sandwich {0,-18}{1},", 
                        sandwichCounter, 
                        orderSandwich.SubPrice));
                    orderString.Append(orderSandwich.OrderTextBoxHelper());
                }
                return (orderString
                    .ToString()
                    .Trim()
                    .Split(','));
            }
            return new string[0];
        }

        // overrides
        public override string ToString()
        {
            StringBuilder orderString = new StringBuilder();

            foreach (Sandwich sub in CustomerSubs)
                orderString.Append(sub.ToString() + "\n");

            return orderString.ToString();
        }
    }
}
