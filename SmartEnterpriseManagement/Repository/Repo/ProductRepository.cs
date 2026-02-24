using SmartEnterpriseManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Repository.Repo
{// INHERITANCE
    public class ProductRepository : ProductGenericRepository<ProductModel>
    {
        public ProductModel GetByName(string name)
        {
            return _data.FirstOrDefault(p => p.ProductName == name);
        }
    }
}
