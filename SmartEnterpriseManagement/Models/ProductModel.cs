using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Models
{
    // ENCAPSULATION
    public class ProductModel
    {
        private int _quantity;

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductCategory Category { get; set; }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative.");
                _quantity = value;
            }
        }

        // POLYMORPHISM (Method Overriding)
        public override string ToString()
        {
            return $"{ProductId} - {ProductName} - {Category} - Qty: {Quantity}";
        }
    }
}
