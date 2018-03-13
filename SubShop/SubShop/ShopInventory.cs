using System;
using System.Collections.Generic;
using System.Text;

namespace SubShop
{
    public class ShopInventory
    {
        // inner class
        public class InventoryItem
        {
            // properties
            public string ItemName { get; private set; }

            public decimal ItemPrice { get; private set; }

            public int ItemQty { get; private set; }

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

        // declarations
        private const decimal BREAD_PRICE = 1.00M;

        private const decimal MEAT_PRICE = 1.50M;

        private const decimal CHEESE_PRICE = 0.75M;

        private const decimal TOPPING_PRICE = 0.10M;

        private const int INVENTORY_QTY = 1;

        // properties
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
            Inventory["Bread"].Add("Italian", new InventoryItem("Italian", BREAD_PRICE, INVENTORY_QTY));
            Inventory["Bread"].Add("Italian Herb", new InventoryItem("Italian Herb", BREAD_PRICE, INVENTORY_QTY));
            Inventory["Bread"].Add("Whole Wheat", new InventoryItem("Whole Wheat", BREAD_PRICE, INVENTORY_QTY));
            Inventory["Bread"].Add("Marble Rye", new InventoryItem("Marble Rye", BREAD_PRICE, INVENTORY_QTY));
            Inventory["Bread"].Add("Sourdough", new InventoryItem("Sourdough", BREAD_PRICE, INVENTORY_QTY));
            Inventory["Bread"].Add("Focaccia", new InventoryItem("Focaccia", BREAD_PRICE, INVENTORY_QTY));
            Inventory["Bread"].Add("Flatbread", new InventoryItem("Flatbread", BREAD_PRICE, INVENTORY_QTY));
            Inventory["Bread"].Add("Gluten-Free", new InventoryItem("Gluten-Free", BREAD_PRICE, INVENTORY_QTY));

            Inventory["Meat"].Add("None", new InventoryItem("None", 0.00M, int.MaxValue));
            Inventory["Meat"].Add("Roast Beef", new InventoryItem("Roast Beef", MEAT_PRICE, INVENTORY_QTY));
            Inventory["Meat"].Add("Ham", new InventoryItem("Ham", MEAT_PRICE, INVENTORY_QTY));
            Inventory["Meat"].Add("Chicken", new InventoryItem("Chicken", MEAT_PRICE, INVENTORY_QTY));
            Inventory["Meat"].Add("Turkey", new InventoryItem("Turkey", MEAT_PRICE, INVENTORY_QTY));
            Inventory["Meat"].Add("Salami", new InventoryItem("Salami", MEAT_PRICE, INVENTORY_QTY));
            Inventory["Meat"].Add("Pepperoni", new InventoryItem("Pepperoni", MEAT_PRICE, INVENTORY_QTY));
            Inventory["Meat"].Add("Meatball", new InventoryItem("Meatball", MEAT_PRICE, INVENTORY_QTY));
            Inventory["Meat"].Add("Tuna", new InventoryItem("Tuna", MEAT_PRICE, INVENTORY_QTY));

            Inventory["Cheese"].Add("None", new InventoryItem("None", 0.00M, int.MaxValue));
            Inventory["Cheese"].Add("American", new InventoryItem("American", CHEESE_PRICE, INVENTORY_QTY));
            Inventory["Cheese"].Add("Swiss", new InventoryItem("Swiss", CHEESE_PRICE, INVENTORY_QTY));
            Inventory["Cheese"].Add("Cheddar", new InventoryItem("Cheddar", CHEESE_PRICE, INVENTORY_QTY));
            Inventory["Cheese"].Add("Monterey Cheddar", new InventoryItem("Monterey Cheddar", CHEESE_PRICE, INVENTORY_QTY));
            Inventory["Cheese"].Add("Provolone", new InventoryItem("Provolone", CHEESE_PRICE, INVENTORY_QTY));
            Inventory["Cheese"].Add("Mozzarella", new InventoryItem("Mozzarella", CHEESE_PRICE, INVENTORY_QTY));
            Inventory["Cheese"].Add("Pepperjack", new InventoryItem("Pepperjack", CHEESE_PRICE, INVENTORY_QTY));
            Inventory["Cheese"].Add("Feta", new InventoryItem("Feta", CHEESE_PRICE, INVENTORY_QTY));

            Inventory["Topping"].Add("None", new InventoryItem("None", 0.00M, int.MaxValue));
            Inventory["Topping"].Add("Lettuce", new InventoryItem("Lettuce", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Tomato", new InventoryItem("Tomato", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Onion", new InventoryItem("Onion", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Spinach", new InventoryItem("Spinach", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Cucumber", new InventoryItem("Cucumber", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Carrot", new InventoryItem("Carrot", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Green Pepper", new InventoryItem("Green Pepper", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Banana Pepper", new InventoryItem("Banana Pepper", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Jalapeno", new InventoryItem("Jalapeno", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Olive", new InventoryItem("Olive", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Pickle", new InventoryItem("Pickle", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Avocado", new InventoryItem("Avocado", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Oil", new InventoryItem("Oil", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Vinegar", new InventoryItem("Vinegar", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Vinaigrette", new InventoryItem("Vinaigrette", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Mayonnaise", new InventoryItem("Mayonnaise", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Mustard", new InventoryItem("Mustard", TOPPING_PRICE, INVENTORY_QTY));
            Inventory["Topping"].Add("Honey Mustard", new InventoryItem("Honey Mustard", TOPPING_PRICE, INVENTORY_QTY));
        }

        // methods
        // return out of stock items
        public string[] GetOutOfStock()
        {
            StringBuilder outOfStockItems = new StringBuilder();

            foreach (Dictionary<String, InventoryItem> inventory in Inventory.Values)
                foreach (InventoryItem item in inventory.Values)
                    if (item.ItemQty < 1)
                        outOfStockItems.Append(item.ItemName + ",");

            if (!(outOfStockItems.ToString() == string.Empty))
            {
                return outOfStockItems.ToString().Trim(',').Split(',');
            }
            else
                return new string[0];
        }
    }
}
