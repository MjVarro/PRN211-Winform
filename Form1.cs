using DemoListOrders.Logics.IServices;
using DemoListOrders.Logics.Services;
using DemoListOrders.Models;

namespace DemoListOrders
{
    public partial class Form1 : Form
    {
        IOrderService orderService;
        IEmployeeService employeeService;
        ICustomerService customerService;
        IProductServices productService;
        public Form1(IOrderService _orderService, IEmployeeService _empService,
            ICustomerService _cusService, IProductServices _productServices)
        {
            orderService = _orderService;
            employeeService = _empService;
            customerService = _cusService;
            productService = _productServices;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*cbCustomers.DisplayMember = "CompanyName";
            cbCustomers.ValueMember = "CustomerId";
            List<Customer> customers = customerService.GetCustomers();
            customers.Insert(0, new Customer
            {
                CustomerId = String.Empty,
                CompanyName = "All customers"
            });
            cbCustomers.DataSource = customers;

            cbEmployees.DisplayMember = "FirstName";
            cbEmployees.ValueMember = "EmployeeId";
            List<Employee> employees = employeeService.GetEmployees();
            employees.Insert(0, new Employee
            {
                EmployeeId = 0,
                FirstName = "All employees"
            });
            cbEmployees.DataSource = employees;
            dtpFrom.Value = new DateTime(1990, 1, 1);
            dtpTo.Value = DateTime.Now;
            LoadDataForDGV();*/
        }

        public void LoadDataForDGV()
        {
            string CustomerId = cbCustomers.SelectedValue.ToString();
            int EmployeeId = Convert.ToInt32(cbEmployees.SelectedValue);
            DateTime FromDate = dtpFrom.Value;
            DateTime ToDate = dtpTo.Value;
            var orders = orderService
                .GetOrders(EmployeeId, CustomerId, FromDate, ToDate, "OrderId")
                .Select(x => new
                {
                    OrderId = x.OrderId,
                    Employee = (x.Employee is null) ? String.Empty : x.Employee.FirstName,
                    Customer = (x.Customer is null) ? String.Empty : x.Customer.CompanyName,
                    OrderDate = x.OrderDate,
                    Freight = x.Freight
                })
                .ToList();
            dataGridView1.DataSource = orders;
        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        private void btAddOrder_Click(object sender, EventArgs e)
        {
            AddAnOrderForm form2 = new AddAnOrderForm(orderService, employeeService, customerService, productService);
            form2.ShowDialog();
        }
    }
}