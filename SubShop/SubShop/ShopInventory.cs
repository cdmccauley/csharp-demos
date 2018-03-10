﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubShop
{
    public class ShopInventory
    {
        public class InventoryItem
        {
            private string itemName;
            private decimal itemPrice;
            private int itemQty;

            public string ItemName
            {
                get => itemName;
                private set => itemName = value;
            }

            public decimal ItemPrice
            {
                get => itemPrice;
                private set => itemPrice = value;
            }

            public int ItemQty
            {
                get => itemQty;
                private set => itemQty = value;
            }

            // constructor
            public InventoryItem(string name, decimal price, int quantity)
            {
                ItemName = name;
                ItemPrice = price;
                ItemQty = quantity;
            }

            // methods
            public void UseItem()
            {
                --ItemQty;
            }

            public void UndoUseItem()
            {
                ++ItemQty;
            }

            // overrides
            public override string ToString()
            {
                return ItemName;
            }
        }

        private const decimal BREAD_PRICE = 1.00M;
        private const decimal MEAT_PRICE = 1.00M;
        private const decimal CHEESE_PRICE = 1.00M;
        private const decimal TOPPING_PRICE = 0.25M;

        public Dictionary<String, Dictionary<String, InventoryItem>> Inventory { get; private set; }

        // constructor
        public ShopInventory()
        {
            Inventory = new Dictionary<String, Dictionary<String, InventoryItem>>();
            Inventory.Add("Bread", new Dictionary<String, InventoryItem>());
            Inventory.Add("Meat", new Dictionary<String, InventoryItem>());
            Inventory.Add("Cheese", new Dictionary<String, InventoryItem>());
            Inventory.Add("Topping", new Dictionary<String, InventoryItem>());

            Inventory["Bread"].Add("None", new InventoryItem("None", 0.00M, int.MaxValue));
            Inventory["Bread"].Add("Italian", new InventoryItem("Italian", BREAD_PRICE, 1));
            Inventory["Bread"].Add("Italian Herb", new InventoryItem("Italian Herb", BREAD_PRICE, 1));
            Inventory["Bread"].Add("Whole Wheat", new InventoryItem("Whole Wheat", BREAD_PRICE, 1));
            Inventory["Bread"].Add("Marble Rye", new InventoryItem("Marble Rye", BREAD_PRICE, 1));
            Inventory["Bread"].Add("Sourdough", new InventoryItem("Sourdough", BREAD_PRICE, 1));
            Inventory["Bread"].Add("Foccacia", new InventoryItem("Focaccia", BREAD_PRICE, 1));
            Inventory["Bread"].Add("Flatbread", new InventoryItem("Flatbread", BREAD_PRICE, 1));
            Inventory["Bread"].Add("Gluten-Free", new InventoryItem("Gluten-Free", BREAD_PRICE, 1));

            Inventory["Meat"].Add("None", new InventoryItem("None", 0.00M, int.MaxValue));
            Inventory["Meat"].Add("Roast Beef", new InventoryItem("Roast Beef", MEAT_PRICE, 25));
            Inventory["Meat"].Add("Ham", new InventoryItem("Ham", MEAT_PRICE, 25));
            Inventory["Meat"].Add("Chicken", new InventoryItem("Chicken", MEAT_PRICE, 25));
            Inventory["Meat"].Add("Turkey", new InventoryItem("Turkey", MEAT_PRICE, 25));
            Inventory["Meat"].Add("Salami", new InventoryItem("Salami", MEAT_PRICE, 25));
            Inventory["Meat"].Add("Pepperoni", new InventoryItem("Pepperoni", MEAT_PRICE, 25));
            Inventory["Meat"].Add("Meatball", new InventoryItem("Meatball", MEAT_PRICE, 25));
            Inventory["Meat"].Add("Tuna", new InventoryItem("Tuna", MEAT_PRICE, 25));

            Inventory["Cheese"].Add("None", new InventoryItem("None", 0.00M, int.MaxValue));
            Inventory["Cheese"].Add("American", new InventoryItem("American", CHEESE_PRICE, 25));
            Inventory["Cheese"].Add("Swiss", new InventoryItem("Swiss", CHEESE_PRICE, 25));
            Inventory["Cheese"].Add("Cheddar", new InventoryItem("Cheddar", CHEESE_PRICE, 25));
            Inventory["Cheese"].Add("Monterey Cheddar", new InventoryItem("Monterey Cheddar", CHEESE_PRICE, 25));
            Inventory["Cheese"].Add("Provolone", new InventoryItem("Provolone", CHEESE_PRICE, 25));
            Inventory["Cheese"].Add("Mozzarella", new InventoryItem("Mozzarella", CHEESE_PRICE, 25));
            Inventory["Cheese"].Add("Pepperjack", new InventoryItem("Pepperjack", CHEESE_PRICE, 25));
            Inventory["Cheese"].Add("Feta", new InventoryItem("Feta", CHEESE_PRICE, 25));

            Inventory["Topping"].Add("None", new InventoryItem("None", 0.00M, int.MaxValue));
            Inventory["Topping"].Add("Lettuce", new InventoryItem("Lettuce", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Tomato", new InventoryItem("Tomato", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Onion", new InventoryItem("Onion", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Spinach", new InventoryItem("Spinach", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Cucumber", new InventoryItem("Cucumber", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Carrot", new InventoryItem("Carrot", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Green Pepper", new InventoryItem("Green Pepper", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Banana Pepper", new InventoryItem("Banana Pepper", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Jalapeno", new InventoryItem("Jalapeno", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Olive", new InventoryItem("Olive", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Pickle", new InventoryItem("Pickle", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Avocado", new InventoryItem("Avocado", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Oil", new InventoryItem("Oil", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Vinegar", new InventoryItem("Vinegar", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Vinaigrette", new InventoryItem("Vinaigrette", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Mayonnaise", new InventoryItem("Mayonnaise", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Mustard", new InventoryItem("Mustard", TOPPING_PRICE, 25));
            Inventory["Topping"].Add("Honey Mustard", new InventoryItem("Honey Mustard", TOPPING_PRICE, 25));
        }

        public string[] GetOutOfStock()
        {
            StringBuilder outOfStockItems = new StringBuilder();

            foreach (Dictionary<String, InventoryItem> inventory in Inventory.Values)
                foreach (InventoryItem item in inventory.Values)
                    if (item.ItemQty < 1)
                        outOfStockItems.Append(item.ItemName + ",");

            if (!(outOfStockItems.ToString() == string.Empty))
                return outOfStockItems.ToString().Trim(',').Split(',');
            else
                return new string[0];
        }

        public void UseItem(InventoryItem item) // break validation into another method
        {
            //if (Inventory["Bread"].ContainsKey(item) && Inventory["Bread"][item] > 0)
            //    Inventory["Bread"][item] -= 1;
            //else if (Inventory["Meat"].ContainsKey(item) && Inventory["Meat"][item] > 0)
            //    Inventory["Meat"][item] -= 1;
            //else if (Inventory["Cheese"].ContainsKey(item) && Inventory["Cheese"][item] > 0)
            //    Inventory["Cheese"][item] -= 1;
            //else if (Inventory["Topping"].ContainsKey(item) && Inventory["Topping"][item] > 0)
            //    Inventory["Topping"][item] -= 1;
            //else
            //    Console.WriteLine("Out of stock"); // PLACEHOLDER
        }

        public void RestockInventory(int stockQty) // untested
        {
            //foreach (string category in Inventory.Keys)
            //    foreach (InventoryItem inventoryItem in Inventory[category].Keys)
            //        Inventory[category][inventoryItem] += stockQty;
        }
    }
}