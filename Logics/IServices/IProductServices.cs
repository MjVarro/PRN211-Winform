using DemoListOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoListOrders.Models;

namespace DemoListOrders.Logics.IServices
{
    public interface IProductServices
    {
        public List<Product> GetProducts();

        public List<decimal?> GetUnitPrice(int selectedProductId);
    }
}
