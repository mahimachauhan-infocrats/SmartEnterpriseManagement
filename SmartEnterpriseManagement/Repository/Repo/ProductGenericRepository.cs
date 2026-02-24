using SmartEnterpriseManagement.Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Repository.Repo
{
    // GENERICS + ABSTRACTION
    public class ProductGenericRepository<T> : IProductRepository<T> where T : class
    {
        protected readonly List<T> _data = new List<T>();

        public virtual void Add(T entity)
        {
            _data.Add(entity);
        }

        public virtual List<T> GetAll()
        {
            return _data;
        }

        public virtual T GetById(int id)
        {
            return _data.FirstOrDefault();
        }

        public virtual void Delete(int id)
        {
            var item = _data.FirstOrDefault();

            if (item == null)
                throw new Exception("Item not found.");

            _data.Remove(item);
        }
    }
}
