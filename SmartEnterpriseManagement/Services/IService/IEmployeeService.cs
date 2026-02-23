using SmartEnterprise.Models;
using SmartEnterprise.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterprise.Services.IService
{
    public interface IEmployeeService : IBaseService<EmployeeModel>
    {
        List<EmployeeModel> GetByDepartment(string department);
        void PromoteEmployee(int id);
    }
}
