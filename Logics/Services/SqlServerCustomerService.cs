using DemoListOrders.Logics.IServices;
using DemoListOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListOrders.Logics.Services
{
    internal class SqlServerCustomerService : ICustomerService
    {
        NorthwindContext _context = new NorthwindContext();
        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
