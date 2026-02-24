using SmartEnterpriseManagement.Models;
using SmartEnterpriseManagement.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Services.Service
{
    public class Task_module : ITask_module
    {
        private List<WorkTask> _tasks = new List<WorkTask>();
        private int _currentId = 1;

        public void Add(WorkTask task)
        {
            task.Id = _currentId++;
            task.Status = "Pending";
            _tasks.Add(task);
        }

        public List<WorkTask> GetAll()
        {
            return _tasks;
        }

        public WorkTask GetById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        public void CompleteTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.Status = "Completed";
            }
        }
    }
}
