using SmartEnterpriseManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Services.IService
{
    public interface ITask_module
    {
        void Add(WorkTask task);
        List<WorkTask> GetAll();
        WorkTask GetById(int id);
        void CompleteTask(int id);
    }
}
