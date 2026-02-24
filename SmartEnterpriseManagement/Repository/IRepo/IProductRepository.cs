using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Repository.IRepo
{
    // Abstraction
    public interface IProductRepository<T>
    {
        void Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Delete(int id);
    }
}
