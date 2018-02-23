namespace RestaurantBill
{
    abstract class MenuItem
    {
        // beverage classification
        public class Beverage : MenuItem
        {
            public Beverage(string name, decimal price) : base(name, price) { }
        }

        // appetizer classification
        public class Appetizer : MenuItem
        {
            public Appetizer(string name, decimal price) : base(name, price) { }
        }

        // main course classification
        public class MainCourse : MenuItem
        {
            public MainCourse(string name, decimal price) : base(name, price) { }
        }

        // dessert classification
        public class Dessert : MenuItem
        {
            public Dessert(string name, decimal price) : base(name, price) { }
        }

        // declarations
        private string itemName;
        private decimal itemPrice;

        // properties
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

        public MenuItem(string name, decimal price)
        {
            ItemName = name;
            ItemPrice = price;
        }

        // ToString() override
        public override string ToString()
        {
            return string.Format("{0}{1:C}", ItemName.PadRight(25, '.'), ItemPrice);
        }
    }
}
