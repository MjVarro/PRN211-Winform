using DemoListOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoListOrders.Logics.IServices;
using Microsoft.EntityFrameworkCore;

namespace DemoListOrders.Logics.Services
{
    internal class SqlServerProductService : IProductServices
    {

        NorthwindContext _context = new NorthwindContext();

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public List<decimal?> GetUnitPrice(int productId)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                return new List<decimal?> { product.UnitPrice };
            }
            else
            {
                return new List<decimal?>();
            }
        }
    }
}
