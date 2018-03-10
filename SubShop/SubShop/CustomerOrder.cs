using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubShop
{
    class CustomerOrder
    {
        // declarations
        public class Sandwich
        {
            // properties
            private ShopInventory.InventoryItem Bread { get; set; }

            private List<ShopInventory.InventoryItem> Meat { get; set; }

            private List<ShopInventory.InventoryItem> Cheese { get; set; }

            private List<ShopInventory.InventoryItem> Toppings { get; set; }

            private ShopInventory IngredientSource { get; set; }

            public decimal SubPrice
            {
                get
                {
                    return GetSubPrice();
                }
            }

            // constructor
            public Sandwich(ShopInventory inventoryRef)
            {
                IngredientSource = inventoryRef;
                Meat = new List<ShopInventory.InventoryItem>();
                Cheese = new List<ShopInventory.InventoryItem>();
                Toppings = new List<ShopInventory.InventoryItem>();

                Bread = IngredientSource.Inventory["Bread"]["None"];
                Meat.Add(IngredientSource.Inventory["Meat"]["None"]);
                Cheese.Add(IngredientSource.Inventory["Cheese"]["None"]);
                Toppings.Add(IngredientSource.Inventory["Topping"]["None"]);
            }

            // methods
            public void BuildSub(string ingredient)
            {
                if (IngredientSource.Inventory["Bread"].ContainsKey(ingredient))
                {
                    if (Bread.ItemName == ingredient)
                        Bread = IngredientSource.Inventory["Bread"]["None"];
                    else
                        Bread = IngredientSource.Inventory["Bread"][ingredient];
                }
                else if (IngredientSource.Inventory["Meat"].ContainsKey(ingredient))
                {
                    if (!Meat.Contains(IngredientSource.Inventory["Meat"][ingredient]))
                        Meat.Add(IngredientSource.Inventory["Meat"][ingredient]);
                    else
                        Meat.Remove(IngredientSource.Inventory["Meat"][ingredient]);

                    if (Meat.Count < 1)
                        Meat.Add(IngredientSource.Inventory["Meat"]["None"]);
                    else if (Meat[0].ItemName == "None" && Meat.Count > 1)
                        Meat.Remove(IngredientSource.Inventory["Meat"]["None"]);
                }
                else if (IngredientSource.Inventory["Cheese"].ContainsKey(ingredient))
                {
                    if (!Cheese.Contains(IngredientSource.Inventory["Cheese"][ingredient]))
                        Cheese.Add(IngredientSource.Inventory["Cheese"][ingredient]);
                    else
                        Cheese.Remove(IngredientSource.Inventory["Cheese"][ingredient]);

                    if (Cheese.Count < 1)
                        Cheese.Add(IngredientSource.Inventory["Cheese"]["None"]);
                    else if (Cheese[0].ItemName == "None" && Cheese.Count > 1)
                        Cheese.Remove(IngredientSource.Inventory["Cheese"]["None"]);
                }
                else if (IngredientSource.Inventory["Topping"].ContainsKey(ingredient))
                {
                    if (!Toppings.Contains(IngredientSource.Inventory["Topping"][ingredient]))
                        Toppings.Add(IngredientSource.Inventory["Topping"][ingredient]);
                    else
                        Toppings.Remove(IngredientSource.Inventory["Topping"][ingredient]);

                    if (Toppings.Count < 1)
                        Toppings.Add(IngredientSource.Inventory["Topping"]["None"]);
                    else if (Toppings[0].ItemName == "None" && Toppings.Count > 1)
                        Toppings.Remove(IngredientSource.Inventory["Topping"]["None"]);
                }
            }

            public void UseIngredients()
            {
                Bread.UseItem();
                foreach (ShopInventory.InventoryItem ingredient in Meat)
                    ingredient.UseItem();
                foreach (ShopInventory.InventoryItem ingredient in Cheese)
                    ingredient.UseItem();
                foreach (ShopInventory.InventoryItem ingredient in Toppings)
                    ingredient.UseItem();
            }

            public void UndoUseIngredients()
            {
                Bread.UndoUseItem();
                foreach (ShopInventory.InventoryItem ingredient in Meat)
                    ingredient.UndoUseItem();
                foreach (ShopInventory.InventoryItem ingredient in Cheese)
                    ingredient.UndoUseItem();
                foreach (ShopInventory.InventoryItem ingredient in Toppings)
                    ingredient.UndoUseItem();
            }

            private decimal GetSubPrice()
            {
                decimal sandwichPrice = 0.00M;

                sandwichPrice += Bread.ItemPrice;
                foreach (ShopInventory.InventoryItem ingredient in Meat)
                    sandwichPrice += ingredient.ItemPrice;
                foreach (ShopInventory.InventoryItem ingredient in Cheese)
                    sandwichPrice += ingredient.ItemPrice;
                foreach (ShopInventory.InventoryItem ingredient in Toppings)
                    sandwichPrice += ingredient.ItemPrice;

                return sandwichPrice;
            }

            public string[] ToStringArray()
            {
                StringBuilder sandwichString = new StringBuilder();

                //sandwichString.Append(String.Format("{0,-30}", "Toppings:") + ",");
                sandwichString.Append("Bread:,");
                sandwichString.Append(String.Format("  {0,-25}{1},", Bread.ItemName, Bread.ItemPrice));

                //sandwichString.Append(String.Format("{0,-30}", "Meat:") + ",");
                sandwichString.Append("Meat:,");
                foreach (ShopInventory.InventoryItem meatIngredient in Meat)
                    sandwichString.Append(String.Format("  {0,-25}{1},", meatIngredient.ItemName, meatIngredient.ItemPrice));

                //sandwichString.Append(String.Format("{0,-30}", "Cheese:") + ",");
                sandwichString.Append("Cheese:,");
                foreach (ShopInventory.InventoryItem cheeseIngredient in Cheese)
                    sandwichString.Append(String.Format("  {0,-25}{1},", cheeseIngredient.ItemName, cheeseIngredient.ItemPrice));

                //sandwichString.Append(String.Format("{0,-30}", "Toppings:") + ",");
                sandwichString.Append("Toppings:,");
                foreach (ShopInventory.InventoryItem toppingsIngredient in Toppings)
                    sandwichString.Append(String.Format("  {0,-25}{1},", toppingsIngredient.ItemName, toppingsIngredient.ItemPrice));

                return sandwichString.ToString().Trim().Split(',');
            }
        }

        // properties
        private ShopInventory InventorySource { get; set; }

        public List<Sandwich> CustomerSubs { get; private set; }

        public Sandwich CurrentSub { get; private set; }

        // constructor
        public CustomerOrder(ShopInventory inventoryRef)
        {
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

        public void GetPayment()
        {

        }

        public string[] ToStringArray()
        {
            int sandwichCounter = 0;
            StringBuilder orderString = new StringBuilder();

            if (CustomerSubs.Count > 0)
            {
                foreach (Sandwich sandwich in CustomerSubs)
                {
                    ++sandwichCounter;
                    //orderString.Append("Sandwich " + sandwichCounter + ",");
                    //
                    //sandwichString.Append("Bread:,");
                    orderString.Append(String.Format("Sandwich {0,-18}{1},", sandwichCounter, sandwich.SubPrice));
                    //
                }
                return (orderString.ToString().Trim().Split(','));
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
