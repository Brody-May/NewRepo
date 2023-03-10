using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_and_Dapper
{
    internal class DapperProductRepository : IProductRepository
    {
        public void CreateProduct(string name, double price, int categoryID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
