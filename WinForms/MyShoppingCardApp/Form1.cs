namespace MyShoppingCardApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Sample list of available products
            List<string> availableProducts = new List<string> { "Product 1", "Product 2", "Product 3", "Product 4" };

            // Populate the available products listbox
            listBoxAvailableProducts.Items.AddRange(availableProducts.ToArray());
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableProducts.SelectedItem != null)
            {
                // Add selected item to the shopping cart
                listBoxShoppingCart.Items.Add(listBoxAvailableProducts.SelectedItem);

                // Remove the selected item from the available products
                listBoxAvailableProducts.Items.Remove(listBoxAvailableProducts.SelectedItem);
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listBoxShoppingCart.SelectedItem != null)
            {
                // Add selected item back to available products
                listBoxAvailableProducts.Items.Add(listBoxShoppingCart.SelectedItem);

                // Remove the selected item from the shopping cart
                listBoxShoppingCart.Items.Remove(listBoxShoppingCart.SelectedItem);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (listBoxShoppingCart.Items.Count > 0)
            {
                // Create a message with the ordered items
                string orderMessage = "Order placed with the following items:\n";
                foreach (var item in listBoxShoppingCart.Items)
                {
                    orderMessage += "- " + item.ToString() + "\n";
                }

                // Show the order message
                MessageBox.Show(orderMessage, "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the shopping cart
                listBoxShoppingCart.Items.Clear();
            }
            else
            {
                MessageBox.Show("Shopping cart is empty. Add items to the cart before placing an order.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}