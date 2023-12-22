using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyShoppingCardApp
{
    public partial class Form1 : Form
    {
        private List<string> availableProducts = new List<string> { "Product 1", "Product 2", "Product 3", "Product 4" };

        public Form1()
        {
            InitializeComponent();

            listBoxAvailableProducts.Items.AddRange(availableProducts.ToArray());
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableProducts.SelectedItem != null)
            {
                listBoxShoppingCart.Items.Add(listBoxAvailableProducts.SelectedItem);

                listBoxAvailableProducts.Items.Remove(listBoxAvailableProducts.SelectedItem);
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listBoxShoppingCart.SelectedItem != null)
            {
                listBoxAvailableProducts.Items.Add(listBoxShoppingCart.SelectedItem);

                listBoxShoppingCart.Items.Remove(listBoxShoppingCart.SelectedItem);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (listBoxShoppingCart.Items.Count > 0)
            {
                string orderMessage = "Order placed with the following items:\n";
                foreach (var item in listBoxShoppingCart.Items)
                {
                    orderMessage += "- " + item.ToString() + "\n";
                }

                MessageBox.Show(orderMessage, "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listBoxShoppingCart.Items.Clear();
            }
            else
            {
                MessageBox.Show("Shopping cart is empty. Add items to the cart before placing an order.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string newProduct = txtNewProduct.Text;

            if (!string.IsNullOrWhiteSpace(newProduct))
            {
                availableProducts.Add(newProduct);

                listBoxAvailableProducts.Items.Add(newProduct);

                txtNewProduct.Clear();
            }
        }
    }
}
