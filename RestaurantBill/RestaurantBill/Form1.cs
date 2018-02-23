using System;
using System.Windows.Forms;

namespace RestaurantBill
{
    public partial class RestaurantBill : Form
    {
        // partial declarations
        private decimal subtotal;
        private const decimal TAX_RATE = .045M;

        // partial properties
        private Decimal Subtotal
        {
            get => subtotal;
            set => subtotal = value;
        }

        private Decimal Tax
        {
            get => (Subtotal * TAX_RATE);
        }

        private Decimal Total
        {
            get => (Subtotal + Tax);
        }

        // constructor
        public RestaurantBill()
        {
            InitializeComponent();
            Subtotal = 0.0M;
            beverageComboBox.Items.Add(new MenuItem.Beverage("Soda", 1.95M));
            beverageComboBox.Items.Add(new MenuItem.Beverage("Tea", 1.50M));
            beverageComboBox.Items.Add(new MenuItem.Beverage("Coffee", 1.25M));
            beverageComboBox.Items.Add(new MenuItem.Beverage("Mineral Water", 2.95M));
            beverageComboBox.Items.Add(new MenuItem.Beverage("Juice", 2.50M));
            beverageComboBox.Items.Add(new MenuItem.Beverage("Milk", 1.50M));
            appetizerComboBox.Items.Add(new MenuItem.Appetizer("Buffalo Wings", 5.95M));
            appetizerComboBox.Items.Add(new MenuItem.Appetizer("Chicken Fingers", 6.95M));
            appetizerComboBox.Items.Add(new MenuItem.Appetizer("Potato Skins", 8.95M));
            appetizerComboBox.Items.Add(new MenuItem.Appetizer("Nachos", 8.95M));
            appetizerComboBox.Items.Add(new MenuItem.Appetizer("Mushroom Caps", 10.95M));
            appetizerComboBox.Items.Add(new MenuItem.Appetizer("Shrimp Cocktail", 12.95M));
            appetizerComboBox.Items.Add(new MenuItem.Appetizer("Chips and Salsa", 6.95M));
            mainCourseComboBox.Items.Add(new MenuItem.MainCourse("Seafood Alfredo", 15.95M));
            mainCourseComboBox.Items.Add(new MenuItem.MainCourse("Chicken Alfredo", 13.95M));
            mainCourseComboBox.Items.Add(new MenuItem.MainCourse("Chicken Picatta", 13.95M));
            mainCourseComboBox.Items.Add(new MenuItem.MainCourse("Turkey Club", 11.95M));
            mainCourseComboBox.Items.Add(new MenuItem.MainCourse("Lobster Pie", 19.95M));
            mainCourseComboBox.Items.Add(new MenuItem.MainCourse("Prime Rib", 20.95M));
            mainCourseComboBox.Items.Add(new MenuItem.MainCourse("Shrimp Scampi", 18.95M));
            mainCourseComboBox.Items.Add(new MenuItem.MainCourse("Turkey Dinner", 13.95M));
            mainCourseComboBox.Items.Add(new MenuItem.MainCourse("Stuffed Chicken", 14.95M));
            dessertsComboBox.Items.Add(new MenuItem.Dessert("Apple Pie", 5.95M));
            dessertsComboBox.Items.Add(new MenuItem.Dessert("Sundae", 3.95M));
            dessertsComboBox.Items.Add(new MenuItem.Dessert("Carrot Cake", 5.95M));
            dessertsComboBox.Items.Add(new MenuItem.Dessert("Mud Pie", 4.95M));
            dessertsComboBox.Items.Add(new MenuItem.Dessert("Apple Crisp", 5.95M));
            dessertsComboBox.Items.Add(new MenuItem.Dessert("Chocolate Lava Cake", 5.95M));
        }

        // increment order total
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            MenuItem senderMenuItem = (MenuItem)senderComboBox.SelectedItem;

            Subtotal += senderMenuItem.ItemPrice;
        }

        // display totals
        private void completeButton_Click(object sender, EventArgs e)
        {
            subtotalLabel.Text = string.Format("{0:C}", Subtotal);
            taxLabel.Text = string.Format("{0:C}", Tax);
            totalLabel.Text = string.Format("{0:C}", Total);
        }

        // reset comboboxes and labels
        private void resetButton_Click(object sender, EventArgs e)
        {
            Subtotal = 0.0M;
            subtotalLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";
            beverageComboBox.ResetText();
            appetizerComboBox.ResetText();
            mainCourseComboBox.ResetText();
            dessertsComboBox.ResetText();
        }
    }
}
