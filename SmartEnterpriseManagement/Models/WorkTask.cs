using SmartEnterprise_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Models
{
    public class WorkTask : BaseEntity
    {
        public string Description { get; set; }
        public string Status { get; set; }

    }
}
