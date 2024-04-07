using DemoListOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListOrders.Logics.IServices
{
    public interface ICustomerService
    {
        public List<Customer> GetCustomers();
    }
}
