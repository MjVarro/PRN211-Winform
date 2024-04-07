using DemoListOrders.Logics.IServices;
using DemoListOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListOrders.Logics.Services
{
    internal class SqlServerEmployeeService : IEmployeeService
    {
        NorthwindContext _context = new NorthwindContext();

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
