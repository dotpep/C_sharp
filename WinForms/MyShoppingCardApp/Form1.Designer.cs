namespace MyShoppingCardApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxAvailableProducts = new ListBox();
            listBoxShoppingCart = new ListBox();
            btnAddToCart = new Button();
            btnRemoveFromCart = new Button();
            btnOrder = new Button();
            txtNewProduct = new TextBox();
            btnAddProduct = new Button();
            SuspendLayout();
            // 
            // listBoxAvailableProducts
            // 
            listBoxAvailableProducts.BackColor = Color.LightYellow;
            listBoxAvailableProducts.FormattingEnabled = true;
            listBoxAvailableProducts.ItemHeight = 20;
            listBoxAvailableProducts.Location = new Point(298, 27);
            listBoxAvailableProducts.Name = "listBoxAvailableProducts";
            listBoxAvailableProducts.Size = new Size(225, 204);
            listBoxAvailableProducts.TabIndex = 0;
            // 
            // listBoxShoppingCart
            // 
            listBoxShoppingCart.BackColor = Color.Aquamarine;
            listBoxShoppingCart.FormattingEnabled = true;
            listBoxShoppingCart.ItemHeight = 20;
            listBoxShoppingCart.Location = new Point(529, 27);
            listBoxShoppingCart.Name = "listBoxShoppingCart";
            listBoxShoppingCart.Size = new Size(225, 204);
            listBoxShoppingCart.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.LightGreen;
            btnAddToCart.Location = new Point(67, 250);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(225, 161);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.BackColor = Color.LightCoral;
            btnRemoveFromCart.Location = new Point(298, 250);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(225, 161);
            btnRemoveFromCart.TabIndex = 3;
            btnRemoveFromCart.Text = "Remove from Cart";
            btnRemoveFromCart.UseVisualStyleBackColor = false;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Cyan;
            btnOrder.Location = new Point(529, 250);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(225, 161);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // txtNewProduct
            // 
            txtNewProduct.Location = new Point(67, 69);
            txtNewProduct.Name = "txtNewProduct";
            txtNewProduct.Size = new Size(125, 27);
            txtNewProduct.TabIndex = 5;
            txtNewProduct.Text = " ";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(67, 118);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Add Products";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddProduct);
            Controls.Add(txtNewProduct);
            Controls.Add(btnOrder);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnAddToCart);
            Controls.Add(listBoxShoppingCart);
            Controls.Add(listBoxAvailableProducts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAvailableProducts;
        private ListBox listBoxShoppingCart;
        private Button btnAddToCart;
        private Button btnRemoveFromCart;
        private Button btnOrder;
        private TextBox txtNewProduct;
        private Button btnAddProduct;
    }
}