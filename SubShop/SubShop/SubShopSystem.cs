namespace SubShop
{
    class SubShopSystem
    {
        // properties
        public static ShopInventory SystemInventory { get; set; }

        public CustomerOrder CurrentOrder { get; set; }

        // constructor
        public SubShopSystem()
        {
            SystemInventory = new ShopInventory();
        }

        // methods
        public void GetCustomerOrder()
        {
            CurrentOrder = new CustomerOrder(SystemInventory);
            CurrentOrder.StartSandwich();
        }

        public void EndCustomerOrder()
        {
            CurrentOrder = null;
        }
    }
}
