using SmartEnterprise_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Models
{
    public class Client : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? CompanyName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Relationship
        public List<string> Projects { get; set; } = new List<string>();

        // Assigned Employee (Account Manager)
        public int? AccountManagerId { get; set; }

        // Business Feature
        public decimal TotalRevenue { get; set; }
    }
}
