namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public Image ProductImage { get; set; }

            public Product(string name, decimal price, int quantity, Image productImage)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                ProductImage = productImage;
            }
        }
        public class ShoppingCart
        {
            public List<Product> CartItems { get; private set; }

            public ShoppingCart()
            {
                CartItems = new List<Product>();
            }

            public void AddProduct(Product product)
            {
                CartItems.Add(product);
            }

            public void RemoveProduct(Product product)
            {
                CartItems.Remove(product);
            }

            public decimal CalculateTotalPrice()
            {
                return CartItems.Sum(item => item.Price * item.Quantity);
            }

            public int CalculateTotalQuantity()
            {
                return CartItems.Sum(item => item.Quantity);
            }

            public void ClearCart()
            {
                CartItems.Clear();
            }
        }
        private List<Product> products = new List<Product>(); // Danh sách sản phẩm
        private ShoppingCart cart = new ShoppingCart();       // Đối tượng giỏ hàng
        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo sản phẩm mẫu
            products.Add(new Product("Sản phẩm A", 100000, 1, null));
            products.Add(new Product("Sản phẩm B", 200000, 1, null));
            products.Add(new Product("Sản phẩm C", 300000, 1, null));

            // Cập nhật DataGridView sản phẩm
            UpdateProductList();
        }
        private void UpdateProductList()
        {
            dataGridViewProducts.Rows.Clear();
            foreach (var product in products)
            {
                dataGridViewProducts.Rows.Add(product.ProductImage, product.Name, product.Price, product.Quantity);
            }
        }
        private void UpdateCart()
        {
            dataGridViewCart.Rows.Clear();
            foreach (var product in cart.CartItems)
            {
                dataGridViewCart.Rows.Add(product.Name, product.Price, product.Quantity);
            }

            lblTotalPrice.Text = $"Tổng giá trị: {cart.CalculateTotalPrice():C}";
            lblTotalQuantity.Text = $"Tổng số lượng: {cart.CalculateTotalQuantity()}";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var rowIndex = dataGridViewProducts.SelectedRows[0].Index;
                var selectedProduct = products[rowIndex];

                cart.AddProduct(selectedProduct);
                UpdateCart();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm vào giỏ hàng.");
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count > 0)
            {
                var rowIndex = dataGridViewCart.SelectedRows[0].Index;
                var selectedProduct = cart.CartItems[rowIndex];

                cart.RemoveProduct(selectedProduct);
                UpdateCart();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa khỏi giỏ hàng.");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thanh toán?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cart.ClearCart();
                UpdateCart();
                MessageBox.Show("Đơn hàng của bạn đã được thanh toán!");
            }
        }
    }
}
