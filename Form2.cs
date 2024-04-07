using DemoListOrders.Logics.IServices;
using DemoListOrders.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoListOrders
{
    public partial class AddAnOrderForm : Form
    {
        IOrderService orderService;
        IEmployeeService employeeService;
        ICustomerService customerService;
        IProductServices productService;
        public AddAnOrderForm(IOrderService _orderService, IEmployeeService _empService,
             ICustomerService _cusService, IProductServices _productService)
        {
            orderService = _orderService;
            employeeService = _empService;
            customerService = _cusService;
            productService = _productService;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbCustomers.DisplayMember = "CompanyName";
            cbCustomers.ValueMember = "CustomerId";
            List<Customer> customers = customerService.GetCustomers();
            cbCustomers.DataSource = customers;

            cbEmployees.DisplayMember = "FirstName";
            cbEmployees.ValueMember = "EmployeeId";
            List<Employee> employees = employeeService.GetEmployees();
            cbEmployees.DataSource = employees;

            dtpReqDate.Value = DateTime.Now;
            LoadDataForProductDGV();

            btAddToCart.Click += dgvProducts_SelectionChanged;
            tbTotal.ReadOnly = true;

        }


        public void LoadDataForProductDGV()
        {
            var products = productService.GetProducts().Select(p => new
            {
                ProductId = p.ProductId,
                ProductName = (p.ProductName is null) ? String.Empty : p.ProductName,
                Price = p.UnitPrice
            }).ToList();
            dgvProducts.DataSource = products;
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private List<ProductPrice> selectedProducts = new List<ProductPrice>();

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgvProducts.SelectedRows;

            foreach (DataGridViewRow row in selectedRows)
            {
                string productId = row.Cells["ProductId"].Value.ToString();
                string productName = row.Cells["ProductName"].Value.ToString();

                TextBox tBProductId = new TextBox();
                tBProductId.Text = productId;
                tBProductId.ReadOnly = true;
                tBProductId.AutoSize = true;

                TextBox tBProductName = new TextBox();
                tBProductName.Text = productName;
                tBProductName.ReadOnly = true;
                tBProductName.Size = new Size(220, 100);

                NumericUpDown numQuantity = new NumericUpDown();
                numQuantity.Minimum = 0;
                numQuantity.Tag = productId;
                numQuantity.ValueChanged += numQuantity_ValueChanged;

                flowLayoutPanel1.Controls.Add(tBProductId);
                flowLayoutPanel1.Controls.Add(tBProductName);
                flowLayoutPanel1.Controls.Add(numQuantity);

                int selectedProductId = int.Parse(productId);
                var productUnitPrices = productService.GetUnitPrice(selectedProductId);
                if (productUnitPrices.Count > 0)
                {
                    selectedProducts.Add(new ProductPrice
                    {
                        ProductId = selectedProductId,
                        UnitPrice = productUnitPrices[0],
                        Quantity = 0
                    });
                }
            }
        }

        private void btDeleteCart_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            selectedProducts.Clear();
        }

        public class ProductPrice
        {
            public int ProductId { get; set; }
            public decimal? UnitPrice { get; set; }
            public int Quantity { get; set; }
            public decimal Total => (decimal)(UnitPrice * Quantity);
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown changedNumQuantity = (NumericUpDown)sender;

            int productId = Convert.ToInt32(changedNumQuantity.Tag);

            ProductPrice productPrice = selectedProducts
                .FirstOrDefault(p => p.ProductId == productId);

            if (productPrice != null)
            {
                productPrice.Quantity = (int)changedNumQuantity.Value;
                decimal total = selectedProducts.Sum(p => p.Total);
                tbTotal.Text = total.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btAddToCart_Click(object sender, EventArgs e)
        {

        }

        

        private void btProcessOrder_Click(object sender, EventArgs e)
        {
            /*//Add order
            Order newOrder = new Order();
            newOrder.RequiredDate = dtpReqDate.Value;
            newOrder.EmployeeId = (int)cbEmployees.SelectedValue;
            newOrder.CustomerId = cbCustomers.SelectedValue.ToString();
            newOrder.ShipAddress = tbAddress.Text;
            newOrder.OrderDate = DateTime.Now;

            Order addAnOrder = orderService.AddOrder(newOrder);
            //Add order detail
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                //check if the control is the product Id textbox or not
                if (i % 3 == 0)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    int productId = Convert.ToInt32(flowLayoutPanel1.Controls[i].Text);
                    Product product = productService.GetProductById(productId);
                    int quantity = Convert.ToInt32(flowLayoutPanel1.Controls[i + 2].Text);
                    orderDetail.ProductId = productId;
                    orderDetail.Quantity = Convert.ToInt16(quantity);
                    orderDetail.OrderId = addAnOrder.OrderId;
                    orderDetailService.AddOrderDetails(orderDetail);
                }
            }*/
            MessageBox.Show("Co Chi xinh dep tuyet voi!");
        }
    }
}
