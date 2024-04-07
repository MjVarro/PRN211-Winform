namespace DemoListOrders
{
    partial class AddAnOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dtpReqDate = new DateTimePicker();
            tbAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbCustomers = new ComboBox();
            cbEmployees = new ComboBox();
            groupBox2 = new GroupBox();
            btDeleteCart = new Button();
            btAddToCart = new Button();
            dgvProducts = new DataGridView();
            groupBox3 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label8 = new Label();
            tbTotal = new TextBox();
            btProcessOrder = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpReqDate);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbCustomers);
            groupBox1.Controls.Add(cbEmployees);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delivery Information:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpReqDate
            // 
            dtpReqDate.Location = new Point(134, 24);
            dtpReqDate.Name = "dtpReqDate";
            dtpReqDate.Size = new Size(268, 27);
            dtpReqDate.TabIndex = 8;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(134, 180);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(268, 27);
            tbAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 180);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 129);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Customers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 78);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Employee:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "RequiredDate:";
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(134, 129);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(268, 28);
            cbCustomers.TabIndex = 1;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(134, 75);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(268, 28);
            cbEmployees.TabIndex = 0;
            cbEmployees.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btDeleteCart);
            groupBox2.Controls.Add(btAddToCart);
            groupBox2.Controls.Add(dgvProducts);
            groupBox2.Location = new Point(27, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(439, 193);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product List:";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btDeleteCart
            // 
            btDeleteCart.Location = new Point(370, 114);
            btDeleteCart.Name = "btDeleteCart";
            btDeleteCart.Size = new Size(63, 71);
            btDeleteCart.TabIndex = 5;
            btDeleteCart.Text = "Delete Cart";
            btDeleteCart.UseVisualStyleBackColor = true;
            btDeleteCart.Click += btDeleteCart_Click;
            // 
            // btAddToCart
            // 
            btAddToCart.BackgroundImageLayout = ImageLayout.Center;
            btAddToCart.Location = new Point(370, 26);
            btAddToCart.Name = "btAddToCart";
            btAddToCart.Size = new Size(63, 68);
            btAddToCart.TabIndex = 1;
            btAddToCart.Text = "Add To Cart";
            btAddToCart.UseVisualStyleBackColor = true;
            btAddToCart.Click += btAddToCart_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(15, 26);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(349, 161);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_SelectionChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel1);
            groupBox3.Location = new Point(488, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(472, 379);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cart:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(6, 29);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(460, 344);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(507, 413);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 3;
            label8.Text = "Total:";
            label8.Click += label8_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(578, 410);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(182, 27);
            tbTotal.TabIndex = 4;
            // 
            // btProcessOrder
            // 
            btProcessOrder.Location = new Point(803, 401);
            btProcessOrder.Name = "btProcessOrder";
            btProcessOrder.Size = new Size(139, 44);
            btProcessOrder.TabIndex = 5;
            btProcessOrder.Text = "Process Order";
            btProcessOrder.UseVisualStyleBackColor = true;
            btProcessOrder.Click += btProcessOrder_Click;
            // 
            // AddAnOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 450);
            Controls.Add(btProcessOrder);
            Controls.Add(tbTotal);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AddAnOrderForm";
            Text = "AddAnOrder";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbCustomers;
        private ComboBox cbEmployees;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox tbAddress;
        private GroupBox groupBox2;
        private DataGridView dgvProducts;
        private GroupBox groupBox3;
        private Button btAddToCart;
        private Label label8;
        private TextBox tbTotal;
        private DateTimePicker dtpReqDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btDeleteCart;
        private Button btProcessOrder;
    }
}