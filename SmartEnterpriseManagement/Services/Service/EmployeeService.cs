using SmartEnterprise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterprise.Services.Service
{
    public class EmployeeService : BaseService<EmployeeModel>
    {
        // Here you can add employee-specific logic

        public List<EmployeeModel> GetByDepartment(string department)
        {
            return GetAll()
                   .Where(e => e.Department.Equals(department,
                           StringComparison.OrdinalIgnoreCase))
                   .ToList();
        }

        public void PromoteEmployee(int id)
        {
            var employee = GetById(id);

            if (employee != null)
            {
                Console.WriteLine($"{employee.Name} has been promoted!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
