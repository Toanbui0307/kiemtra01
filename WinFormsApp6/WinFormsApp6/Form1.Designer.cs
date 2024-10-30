namespace WinFormsApp6
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
            btnAddToCart = new Button();
            btnRemoveFromCart = new Button();
            btnCheckout = new Button();
            dataGridViewProducts = new DataGridView();
            image = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dataGridViewCart = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            lblTotalQuantity = new Label();
            lblTotalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(12, 253);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(147, 29);
            btnAddToCart.TabIndex = 0;
            btnAddToCart.Text = "Thêm vào giỏ hàng";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(216, 253);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(160, 29);
            btnRemoveFromCart.TabIndex = 1;
            btnRemoveFromCart.Text = "Xóa khỏi giỏ hàng";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(12, 537);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 2;
            btnCheckout.Text = "Thanh toán";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { image, name, Column1, Column2 });
            dataGridViewProducts.Location = new Point(12, 12);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(764, 206);
            dataGridViewProducts.TabIndex = 5;
            // 
            // image
            // 
            image.HeaderText = "Hình ảnh";
            image.MinimumWidth = 6;
            image.Name = "image";
            image.ReadOnly = true;
            image.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "Tên";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Giá";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số lượng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.AllowUserToAddRows = false;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5 });
            dataGridViewCart.Location = new Point(11, 302);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCart.Size = new Size(765, 206);
            dataGridViewCart.TabIndex = 6;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Số lượng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Location = new Point(495, 546);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(120, 20);
            lblTotalQuantity.TabIndex = 7;
            lblTotalQuantity.Text = "Tổng số lượng: 0";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(187, 541);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(101, 20);
            lblTotalPrice.TabIndex = 8;
            lblTotalPrice.Text = "Tổng giá trị: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblTotalQuantity);
            Controls.Add(dataGridViewCart);
            Controls.Add(dataGridViewProducts);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnAddToCart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddToCart;
        private Button btnRemoveFromCart;
        private Button btnCheckout;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewCart;
        private DataGridViewTextBoxColumn image;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label lblTotalQuantity;
        private Label lblTotalPrice;
    }
}
