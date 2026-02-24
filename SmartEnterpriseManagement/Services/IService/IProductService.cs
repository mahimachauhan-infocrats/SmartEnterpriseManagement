using SmartEnterpriseManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Services.IService
{
    public interface IProductService
    {
        void AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();
        void DeleteProduct(int id);
    }
}
