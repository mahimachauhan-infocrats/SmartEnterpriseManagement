using SmartEnterpriseManagement.Models;
using SmartEnterpriseManagement.Repository.Repo;
using SmartEnterpriseManagement.Services.IService;
using SmartEnterpriseManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Services.Service
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public void AddProduct(ProductModel product)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(product.ProductName))
                    throw new Exception("Product name cannot be empty.");

                _productRepository.Add(product);
                ProductLogger.Log("Product added successfully.");
            }
            catch (Exception ex)
            {
                ProductLogger.Log($"Error: {ex.Message}");
            }
        }

        public List<ProductModel> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
            ProductLogger.Log("Product deleted successfully.");
        }
    }
}
