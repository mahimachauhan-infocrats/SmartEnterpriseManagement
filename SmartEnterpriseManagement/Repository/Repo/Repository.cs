using SmartEnterprise.Repository.IRepo;
using SmartEnterprise_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterprise.Repository.Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T entity)
        {
            _items.Add(entity);
        }

        public List<T> GetAll()
        {
            return _items;
        }

        public T GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void Update(T entity)
        {
            var existing = GetById(entity.Id);
            if (existing != null)
            {
                _items.Remove(existing);
                _items.Add(entity);
            }
        }

        public void Remove(int id)
        {
            var entity = GetById(id);
            if (entity != null)
                _items.Remove(entity);
        }
    }
}
